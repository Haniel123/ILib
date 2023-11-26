using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class authorDAO
    {
        public ELibEntities db = new ELibEntities();
      public int insertAuthor(Author item)
        {
            db.Authors.Add(item);
            var result =  db.SaveChanges();
            return result;
        }

        public List<Author> getAuthor()
        {
   
            var result = from author in db.Authors  select author;
            return result.ToList();
        }
    }
}
