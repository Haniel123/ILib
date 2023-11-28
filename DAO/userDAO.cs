using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class userDAO
    {
        public ELibEntities db = new ELibEntities();
        public int insertUser(Usert item)
        {
            db.Userts.Add(item);
            var result = db.SaveChanges();
            return result;
        }
        public List<Usert> getUser()
        {
            var result = from user in db.Userts select user;
            return result.ToList();
        }
        public List<UserType> getUserType()
        {
            var result = from usertype in db.UserTypes select usertype;
            return result.ToList();
        }

    }
}
