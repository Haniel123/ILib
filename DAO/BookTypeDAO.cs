﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class bookTypeDAO
    {
        public ELibEntities db = new ELibEntities();

        public int insertBookType(BookType item)
        {
            db.BookTypes.Add(item);
            var result = db.SaveChanges();
            return result;
        }

        public List<BookType> getBookTypes()
        {
            var result = from bookType in db.BookTypes
                         where bookType.Status == 1
                         orderby bookType.id descending
                         select bookType;
            return result.ToList();
        }

        public bool updateBookType(string id, BookType item)
        {
            int.TryParse(id, out var parsedId);

            var existingBookType = db.BookTypes.Find(parsedId);

            if (existingBookType != null)
            {
                existingBookType.Name = item.Name;
                existingBookType.Status = item.Status;
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool deleteBookType(string id, BookType item)
        {
            int.TryParse(id, out var parsedId);

            var existingBookType = db.BookTypes.Find(parsedId);

            if (existingBookType != null)
            {
                existingBookType.Status = 0;
                db.SaveChanges();
                return true;
            }

            return false;
        }
        public List<BookType> search(string name)
        {
            var result = from type in db.BookTypes
                         where (string.IsNullOrEmpty(name) || type.Name.Contains(name))  && type.Status == 1
                         orderby type.id descending
                         select type;

            return result.ToList();
        }
        public bool isNameExists(string name)
        {
            return db.BookTypes.Any(b => b.Name == name && b.Status == 1);
        }
    }
}
