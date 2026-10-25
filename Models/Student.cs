using System;
using System.Collections.Generic;
using System.Text;

namespace Laibrary_EF.Models
{
    public class Student
    {

        public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
            
        private int id;
        private string name;
        private int universityId;
        private bool isActive;
        public Student (int id, string name, int universityId, bool isActive)
        {
           this.id = id;
            Name = name;
            this.universityId = universityId;
            IsActive = isActive;
        }
        public Student() { }

        public int Id
        {
            get { return id; }
            set;
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
       public int UniversityId
       {  
            get { return universityId; }
            set;
        }
        public bool IsActive
        {
            get { return isActive; }
            set
            {
                isActive = value;
            }
        }
        
    }
}
