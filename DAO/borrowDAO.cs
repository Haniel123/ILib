﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class borrowDAO
    {
        public ELibEntities db = new ELibEntities();
        public int insertBorrow(BorrowTicket item)
        {
            db.BorrowTickets.Add(item);
            var result = db.SaveChanges();
            return result;
        }

        public int insertBorrowBook(BorrowBook item)
        {
            db.BorrowBooks.Add(item);
            var result = db.SaveChanges();
            return result;
        }


        public bool updateBorrow(string id, BorrowTicket item)
        {
            int.Parse(id);
            var items = db.BorrowTickets.Find(item.Id);
            if (items != null)
            {
                items.IdBook = item.IdBook;
                items.DateStart = item.DateStart;
                items.DateEnd = item.DateEnd;
                items.IdReader = item.IdReader;
                items.Code = item.Code;

                db.SaveChanges();
                return true;
            }
            else { return false; }

        }

        public bool deleteBorrow(string id, BorrowTicket item)
        {
            int.Parse(id);
            var items = db.BorrowTickets.Find(item.Id);
            if (items != null)
            {
                items.Status = 0;
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }


        public bool deleteBorrowBook(string id, BorrowBook item)
        {
            int.Parse(id);
            var items = db.BorrowBooks.Find(item.Id);
            if (items != null)
            {
                items.Status = 0;
                db.SaveChanges();
                return true;
            }
            else { return false; }
        }


        public List<BorrowTicket> getBorrow()
        {
            var result = from borrow in db.BorrowTickets where borrow.Status != 0 orderby borrow.Id descending select borrow;
            return result.ToList();
        }

        public List<BorrowBook> getBookBorrow(int idReader)
        {
            var result = from borrbook in db.BorrowBooks where borrbook.IdReader == idReader where borrbook.Status == 1  orderby borrbook.Id descending select borrbook;
            return result.ToList();
        }

        public List<Book> getBook()
        {
            var result = from usertype in db.Books where usertype.Status == 1 orderby usertype.id descending select usertype;
            return result.ToList();
        }
        public List<Reader> getReader()
        {
            var result = from reader in db.Readers where reader.Status == 1 orderby reader.Id descending select reader ;    
            return result.ToList();
        }
    }
}
