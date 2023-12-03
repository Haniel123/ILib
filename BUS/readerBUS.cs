using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class readerBUS
    {
        readerDAO readerDAO = new readerDAO();
        public int insertReaderB(Reader item)
        {
            return readerDAO.insertReader(item);
        }

        public bool updateReaderB(string id, Reader item)
        {
            return readerDAO.updateReader(id, item);
        }

        public bool deleteReaderB(string id, Reader item)
        {
            return readerDAO.deleteReader(id, item);
        }


        public List<Reader> getReaderB()
        {
            return readerDAO.getReader();
        }



    }
}
