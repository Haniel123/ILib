using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class loginBUS
    {
        loginDAO login1DAO = new loginDAO();
        public bool checkUser(string userName,string passWord) {
            return login1DAO.checkUser(userName,passWord);
        }
    }
}
