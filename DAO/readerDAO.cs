    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class readerDAO
    {
        public ELibEntities db = new ELibEntities();
        public int insertReader(Reader item)
        {
            db.Readers.Add(item);
            var result = db.SaveChanges();
            return result;
        }

        public bool updateReader(string id, Reader item)
        {
            int.Parse(id);
            var items = db.Readers.Find(item.Id);
            if (items != null)
            {
                items.Fullname = item.Fullname;
                items.Address = item.Address;
                items.Phone = item.Phone;
              
                db.SaveChanges();
                return true;
            }
            else { return false; }

        }

        public bool deleteReader(string id, Reader item)
        {
            int.Parse(id);
            var items = db.Readers.Find(item.Id);
            if (items != null)
            {
                items.Status = 0;
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }



        public List<Reader> getReader()
        {
            var result = from reade in db.Readers where reade.Status == 1 orderby reade.Id descending select reade;
            return result.ToList();
        }
    }
}
