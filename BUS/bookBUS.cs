using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class bookBUS
    {
        bookDAO BookDAO = new bookDAO();

        public List<Book> getBookBUS()
        {
            return BookDAO.getBook();
        }

        public bool insertBookBUS(Book item)
        {
            return BookDAO.insertBook(item);
        }
        
        public bool updateBookBUS(int id, Book item)
        {
            return BookDAO.updateBook(id, item);
        }

        public bool deleteBookBUS(int id, Book item)
        {
            return BookDAO.deleteBook(id, item);
        }

        public List<Book> searchBUS(string name, int authorId, int typeId)
        {
            return BookDAO.search(name, authorId, typeId);
        }

        public bool isNameExists(string name)
        {
            return BookDAO.isNameExists(name);
        }
    }
}

