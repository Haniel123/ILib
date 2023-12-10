using DTO;
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
            var result = db.SaveChanges();
            return result;
        }
        public List<Author> getAuthor()
        {

            var result = from author in db.Authors where author.Status == 1 orderby author.Id descending select author;
 

            return result.ToList();
        }
        
        public string GetAuthorNameById(int authorId)
        {
            var result = (from author in db.Authors
                          where author.Id == authorId
                          select author.Name).FirstOrDefault();

            return result ?? "Unknown Author";
        }

        public bool updateAuthor(string id, Author item)
        {
            int.Parse(id);
            var items = db.Authors.Find(item.Id);
            if (items != null)
            {
                items.Name = item.Name;
                db.SaveChanges();
                return true;
            }
            else { return false; }

        }

        public bool deleteAuthor(string id, Author item)
        {
            int.Parse(id);
            var items = db.Authors.Find(item.Id);
            if (items != null)
            {
                items.Status = 0;
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }

    }

}
