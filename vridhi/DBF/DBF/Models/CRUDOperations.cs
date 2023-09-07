using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBF.Models
{
    internal class CRUDOperations
    {

        public void InsertRecords()
        {
            using(var context = new StudentMgmtContext())
            {
                var stud1 = new Student()
                {
                    Rollno = 10001,
                    Name = "Rahul",
                    City ="BLR"
                };

                var stud2 = new Student()
                {
                    Rollno = 10002,
                    Name = "Vivek",
                    City = "BLR"
                };
                context.Students.Add(stud1);
                context.Students.Add(stud2);
                context.SaveChanges();
            }
        }
        public void ReadDataFromStudentEntity(string stname)
        {
            var context = new StudentMgmtContext();
            var st = context.Students.Where
                (s => s.Name == stname);
            foreach (var s in st)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
