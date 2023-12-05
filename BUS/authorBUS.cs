using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{

    public class authorBUS
    {
        authorDAO AuthorDAO = new authorDAO();
        public int insertAuthorB(Author item)
        {
            return AuthorDAO.insertAuthor(item);
        }

        public bool updateAuthorB(string id, Author item)
        {
            return AuthorDAO.updateAuthor(id, item);
        }

        public bool deleteAuthorB(string id, Author item)
        {
            return AuthorDAO.deleteAuthor(id, item);
        }


        public List<Author> getAuthorB()
        {
            return AuthorDAO.getAuthor();
        }


    }
}
