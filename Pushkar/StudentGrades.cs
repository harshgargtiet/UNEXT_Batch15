﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{

    internal class StudentGrades: StudentMarks
    {
        private string? grade;

        public StudentGrades(int rollno, string name, string address, long phno,
            int mark1, int mark2, int mark3, string grade) 
            : base(rollno, name, address, phno, mark1, mark2, mark3)
        {
            Grade = grade; 
        }

        public string? Grade { get => grade; set => grade = value; }

        public string CalculateGrade()
        {
            double avg = CalculateAverage();
            if (avg >= 90) 
            {
                Grade = "A";
            }
            else if (avg >=70 && avg <= 89)
            {
                Grade = "B";
            }
            else if (avg >=50 && avg <= 69)
            {
                Grade = "C";
            }
            else
            { 
                Grade = "D";
            }
            return Grade;
        }
    }


}
