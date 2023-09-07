using DBFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApproach
{
    internal class CRUDOperations
    {
        public void InsertRecords()
        {
            using (var context = new StudentManagementContext())
            {
                var stud1 = new Student()
                {
                    Rollno = 1,
                    Name = "King"
                };
                var stud2 = new Student()
                {
                    Rollno = 2,
                    Name = "Hitman"
                };

                context.Students.Add(stud1);
                context.Students.Add(stud2);
                context.SaveChanges();
            }
        }

        public void ReadData(string name)
        {
            var context = new StudentManagementContext();
            var st = context.Students.Where(s => s.Name == name).FirstOrDefault();

            Console.WriteLine(st.Name + "\t" + st.Rollno);
        }
    }
}
