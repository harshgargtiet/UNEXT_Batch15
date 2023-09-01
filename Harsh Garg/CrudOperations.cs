using DBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    internal class CrudOperations
    {
        public void InsertRecordsInStudentEntity()
        {
            using (var context = new StudentManagementContext())
            {
                var stud1 = new Student()
                {
                    Rollno = 10001,
                    Name = "Rahul",
                    City = "Bengaluru"
                };

                var stud2 = new Student()
                {
                    Rollno = 10002,
                    Name = "Simran",
                    City = "Paris"
                };

                context.Students.Add(stud1);
                context.Students.Add(stud2);
                context.SaveChanges();
            }
        }

        public void ReadRecordsInStudentEntity(string stname)
        {
            var context = new StudentManagementContext();
            var st = context.Students.Where(s => s.Name == stname);
            foreach (var s in st)
            {
                Console.WriteLine(s.Name+" "+s.Rollno+" "+s.City);
            }
        }

        public void UpdateRecordsInStudentEntity()
        {
            using (var context = new StudentManagementContext())
            {
                Student st = context.Students.First<Student>
                    (s => (s.Rollno == 10001));
                st.City = "Delhi";
                context.SaveChanges();
            }
        }

        public void DeleteRecordsInStudentEntity()
        {
            using (var context = new StudentManagementContext())
            {
                //context.Students.First<Student>());
                context.Students.Remove(context.Students.First<Student>(s => (s.Rollno == 10001)));
                context.SaveChanges();
            }
        }
    }
}
