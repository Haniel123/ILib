using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class bookTypeBUS
    {
        private bookTypeDAO BookTypeDAO = new bookTypeDAO();

        public List<BookType> getBookTypesBUS()
        {
            return BookTypeDAO.getBookTypes();
        }

        public int insertBookTypeBUS(BookType item)
        {
            return BookTypeDAO.insertBookType(item);
        }        

        public bool updateBookTypeBUS(string id, BookType item)
        {
            return BookTypeDAO.updateBookType(id, item);
        }

        public bool deleteBookTypeBUS(string id, BookType item)
        {
            return BookTypeDAO.deleteBookType(id, item);
        }
    }
}
