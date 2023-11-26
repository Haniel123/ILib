using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class loginDAO
    {
        public ELibEntities db = new ELibEntities();
        public bool checkUser(string userName, string passWord)
        {
            if (db.Userts.Any(x => x.Username == userName) && db.Userts.Any(x => x.Password == passWord))
            {
                return true;
            }
            return false;
        }
    }
}
