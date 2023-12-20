using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class bookDAO
    {
        public ELibEntities db = new ELibEntities();

        public List<Book> getBook()
        {
            var result = from book in db.Books
                         where book.Status == 1
                               && (from author in db.Authors
                                   where author.Id == book.IdAuthor && author.Status == 1
                                   select author).Any()
                               && (from type in db.BookTypes
                                   where type.id == book.IdType && type.Status == 1
                                   select type).Any()
                         orderby book.id descending
                         select book;
            return result.ToList();
        }

        public bool insertBook(Book item)
        {
            db.Books.Add(item);
            db.SaveChanges();
            return true;
        }

        public bool updateBook(int id, Book item)
        {
            var existingBook = db.Books.Find(id);

            if (existingBook != null)
            {
                existingBook.Name = item.Name;
                existingBook.IdAuthor = item.IdAuthor;
                existingBook.IdType = item.IdType;
                existingBook.Publisher = item.Publisher;
                existingBook.Price = item.Price;
                existingBook.Amount = item.Amount;
                existingBook.Status = item.Status;
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool deleteBook(int id, Book item)
        {
            var existingBook = db.Books.Find(id);

            if (existingBook != null)
            {
                existingBook.Status = 0;
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Book> search(string name, int authorId, int typeId)
        {
            var result = from book in db.Books
                         where (string.IsNullOrEmpty(name) || book.Name.Contains(name)) 
                               && (authorId == 0 || (from author in db.Authors where author.Id == book.IdAuthor && author.Status == 1 select author).Any())
                               && (typeId == 0 || (from type in db.BookTypes where type.id == book.IdType && type.Status == 1 select type).Any())
                               && book.Status == 1
                               && (authorId == 0 || book.IdAuthor == authorId)
                               && (typeId == 0 || book.IdType == typeId)
                               && (from author in db.Authors where author.Id == book.IdAuthor && author.Status == 1 select author).Any()
                               && (from type in db.BookTypes where type.id == book.IdType && type.Status == 1 select type).Any()
                         orderby book.id descending
                         select book;

            return result.ToList();
        }
        public bool isNameExists(string name)
        {
            return db.Books.Any(b => b.Name == name && b.Status == 1);
        }
    }
}
