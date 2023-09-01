using DBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBF
{
    internal class CRUDOperations
    {
        public void InsertRecordInStudentEntity()
        {
            using (var context = new StudentMgmtContext())
            {
                var stud1 = new Student()
                {
                    Rollno = 000010,
                    Name = "Rajnikant",
                    City = "BLR"
                };
                var stud2 = new Student()
                {
                    Rollno = 000011,
                    Name = "Thalaiva",
                    City = "BLR"
                };

                context.Students.Add(stud1);
                context.Students.Add(stud2);    
                context.SaveChanges();
            }
        }

        public void UpdateRecordInStudentEntity()
        {
            using (var context = new StudentMgmtContext())
            {
                Student st = context.Students.First<Student>(s => (s.Rollno == 10));
                st.City = "Delhi";
                context.SaveChanges();
            }
        }

        public void DeleteRecordInStudentEntity()
        {
            using (var context= new StudentMgmtContext())
            {
                context.Students.Remove(context.Students.First<Student>(s => (s.Rollno == 11)));
                context.SaveChanges();
            }
        }

        public void ReadData(string stname)
        {
            var context = new StudentMgmtContext();
            var st = context.Students.Where(s => s.Name == stname);

            foreach(var s in st)
            {
                Console.WriteLine(s.Name + " " + s.Rollno + " " + s.City);
            }
        }
    }
}
