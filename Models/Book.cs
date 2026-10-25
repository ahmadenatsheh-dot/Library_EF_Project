using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Laibrary_EF.Models
{
    public class Book
    {
        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

        private int id;
        private string title;
        private decimal price;
        private bool isAvailable;
        public Book() { }
        public Book(int id, string title, decimal price, bool isAvailable)
        {
            Id = id;
            Title = title;
            Price = price;
            IsAvailable = isAvailable;
        }
        public int Id
        {
            get { return id;}
            set;

        }
        public string Title
        {
            get { return title;}
            set
            {
                title = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
            }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            set
            {
                isAvailable = value;
            }
        }
    }
}
