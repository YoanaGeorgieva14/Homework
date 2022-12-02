using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataAccess.Model
{
    internal class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public BookDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("@(localdb)\MSSQLLocalDB");
        }
    }
}
