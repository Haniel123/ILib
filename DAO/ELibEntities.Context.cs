﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ELibEntities : DbContext
    {
        public ELibEntities()
            : base("name=ELibEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookStatu> BookStatus { get; set; }
        public virtual DbSet<BookType> BookTypes { get; set; }
        public virtual DbSet<BorrowTicket> BorrowTickets { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }
        public virtual DbSet<Usert> Userts { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<BorrowBook> BorrowBooks { get; set; }
    }
}
