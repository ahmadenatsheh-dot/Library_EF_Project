using Laibrary_EF.Models;
using MySqlConnector;
using System.Security.Cryptography.X509Certificates;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Laibrary_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connect = "server = localhost; database = laybrary_project; user = root; password = ;";
            using var db = new AppDbContext();
            List<Book> books = new List<Book>
             {
                 new Book(1, "C Basics", 10, true),
                 new Book(2, "C++ Basics", 15, true),
                 new Book(3, "Java Basics", 22, true),
                 new Book(4, "python Basics", 18, true),
             };
            //Book book = new Book(1, "C# Basics", 25, true);

            db.Books.Add(books);
            db.SaveChanges();


        }
    }
}
