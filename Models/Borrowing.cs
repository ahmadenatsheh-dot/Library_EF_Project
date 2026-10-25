using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Laibrary_EF.Models
{
    public class Borrowing
    {
        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        private DateTime borrowDate;
        private int id;
        private DateTime? returnDate;
        private int bookId;
        private int studentId;
        public Borrowing() { }
        public Borrowing(DateTime borrowDate, int id, DateTime? returnDate, int bookId, int studentId) 
        {
            this.id = id;
            this.borrowDate = borrowDate;
            this.bookId = bookId;
            this.studentId = studentId;
            ReturnDate = returnDate;
        }
        public DateTime BorrowDate
        {
            get { return borrowDate; }
            set;
        }

       
        public int Id
        {
            get { return id; }
            set;
        }
        public DateTime? ReturnDate
        {
            get { return returnDate;}
            set
            { 
                    returnDate = value;
            }
        }
        public int BookId
        {
            get { return bookId; }
            set;
        }
        public int StudentId
        {
            get { return studentId; }
            set;
        }
    }
}
