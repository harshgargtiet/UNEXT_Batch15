using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class StudentDetails
    {
        // Instance data members
        private int rollno;
        private string? name, address; // nullable string
        private long phno;

        public StudentDetails(int rollno, string name, string address, long phno)
        {
            Rollno = rollno;
            Name = name;
            Address = address;
            Phno = phno;
        }

        public int Rollno { get => rollno; set => rollno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
        public long Phno { get => phno; set => phno = value; }
    }
}
