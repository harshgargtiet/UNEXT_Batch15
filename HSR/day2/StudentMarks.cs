using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSECustom
{
    internal class StudentMarks : StudentDetails
    {

        private int marks1, marks2, marks3;
        public StudentMarks(int rolno, string name, string address, long phno, int marks1, int marks2, int marks3)
            : base(rolno, name, address, phno)
        {
            Marks1 = marks1;
            Marks2 = marks2;
            Marks3 = marks3;
        }

        public int Marks1 { get => marks1; set => marks1 = value; }
        public int Marks2 { get => marks2; set => marks2 = value; }
        public int Marks3 { get => marks3; set => marks3 = value; }

        //Methods
        public int CalculateTotal()
        {
            int total = Marks1 + Marks2 + Marks3;
            return total;
        }
        public double CalculateAverage()
        {
            double avg = (Marks1 + Marks2 + Marks3)/3;
            return avg;
        }
    }
}
