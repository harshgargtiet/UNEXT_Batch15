using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSECustom
{
    internal class Grades : StudentMarks
    {
        private string? grade;

        public Grades(int rolno, string name, string address, 
            long phno, int marks1, int marks2, int marks3, string grade) 
            : base(rolno, name, address, phno, marks1, marks2, marks3)
        {
            this.Grade = grade;
        }

        public string? Grade { get => grade; set => grade = value; }
        public string CalculateGrade()
        {
            double avg = CalculateAverage();
            if (avg > 90) {
                Grade = "A";
            } else if (avg >= 70 && avg <= 89)
            {
                Grade = "B";
            } else { Grade = "C"; }
            return Grade; 
        }
    }
}
