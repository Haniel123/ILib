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
            var result = from book in db.Books where book.Status == 1 select book;
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
    }
}
