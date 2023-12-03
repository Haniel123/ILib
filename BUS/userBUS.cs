using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class userBUS
    {

        userDAO userDAO = new userDAO();
        public int insertUserB(Usert item)
        {
            return userDAO.insertUser(item);
        }

        public bool updateUserB (string id,Usert item)
        {
            return userDAO.updateUser(id ,item);
        }

        public bool deleteUserB(string id, Usert item)
        {
            return userDAO.deleteUser(id, item);
        }


        public List<Usert> getUserB()
        {
            return userDAO.getUser();
        }



        public List<UserType> getUserTypeB()
        {
            return userDAO.getUserType();
        }


    }
}
