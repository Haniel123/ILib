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

        public bool updateUser(string id, Usert item)
        {
            int.Parse(id);
            var items = db.Userts.Find(item.Id);
            if (items != null)
            {
                items.Username = item.Username;
                items.Address = item.Address;
                items.Fullname = item.Fullname;
                items.Phone = item.Phone;
                items.Username = item.Address;
                db.SaveChanges();
                return true;
            }
            else { return false; }

        }

        public bool deleteUser(string id, Usert item)
        {
            int.Parse(id);
            var items = db.Userts.Find(item.Id);
            if (items != null)
            {
                items.Status = 0;
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }



        public List<Usert> getUser()
        {
            var result = from user in db.Userts where user.Status == 1 orderby user.Id descending select user;
            return result.ToList();
        }
        public List<UserType> getUserType()
        {
            var result = from usertype in db.UserTypes select usertype;
            return result.ToList();
        }

    }
}
