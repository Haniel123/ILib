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

        public int insertBook(Book item)
        {
            db.Books.Add(item);
            var result = db.SaveChanges();
            return result;
        }

        public List<Book> getBook()
        {
            var result = from book in db.Books select book;
            return result.ToList();
        }
    }
}
