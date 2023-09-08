using DBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBF
{
    internal class CRUDoperations
    {
        public void InsertRecordingsInStudentEntity()
        {
            using (var context = new StudentManagementContext())
            {
                var stud1 = new Student()
                {
                    Rollno = 10001,
                    Name = "MMMM",
                    City = "Blr"
                };

                var stud2 = new Student()
                {
                    Rollno = 10002,
                    Name = "SSSSS",
                    City = "Del"
                };
                context.Students.Add(stud1);
                context.Students.Add(stud2);
                context.SaveChanges();

            }
        }

        public void ReadDataFromStudentEntity(string stname)
        {
            var context = new StudentManagementContext();
            var st = context.Students.Where
                (s => s.Name == stname);
            foreach (var s in st)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
