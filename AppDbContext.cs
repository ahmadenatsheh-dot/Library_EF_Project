using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Laibrary_EF.Models;
namespace Laibrary_EF
{
    internal class AppDbContext : DbContext
    {
        string connect = "server = localhost; database = laybrary_project; user = root; password = ;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseMySql(connect, new MySqlServerVersion(new Version(8, 2, 12)));

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
    }
}
