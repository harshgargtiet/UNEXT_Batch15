using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBFirst.Models
{
    internal class CRUDOperations
    {
        //create
        public void InsertRecords()
        {
            using (var context = new StudentMgmtContext())
            {
                var stud1 = new Student()
                {
                    Rollno = 1001,
                    Name = "HSR",
                    City = "BLR"
                };
                var stud2 = new Student()
                {
                    Rollno = 1002,
                    Name = "Rahul",
                    City = "Manipal"
                };

                context.Students.Add(stud1);
                context.Students.Add(stud2);
                context.SaveChanges();
            }
        }

        public void ReadData(string stname)
        {
            var context = new StudentMgmtContext();
            var st = context.Students.Where(s => s.Name == stname);
            foreach (var s in st)
            {
                Console.WriteLine(s.Name + " " + s.Rollno + " " + s.City);
            }
        }

        public void UpdateRecords() 
        {
            using (var context = new StudentMgmtContext())
            {
                Student st = context.Students.First<Student>
                    (s => (s.Rollno == 1001));
                st.City = "Kolkata";
                context.SaveChanges();
            }
        }

        public void DeleteRecords() 
        {
            using (var context = new StudentMgmtContext())
            {
                context.Students.Remove(context.Students.First<Student>
                    (s => (s.Rollno == 1002)));
                context.SaveChanges();
            }
        }
    }   
}
