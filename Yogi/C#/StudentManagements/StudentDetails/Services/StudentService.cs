using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interface;
using StudentDetails.Global_Exceptions;
using Microsoft.AspNetCore.Mvc;



namespace StudentDetails.Services
{
    public class StudentService : iStudent
    {
        public StudentManagementContext? _context; // underscore indicates read-only



        public StudentService(StudentManagementContext? context)
        {
            _context = context;
        }
        //using context class, data is read from database 
        //request moves from application server to database server 
        //asynchronous operations 
        public async Task<List<Student>> GetAllStudents()
        {
            var students = await _context.Students.ToListAsync();
            return students;



        }
        public async Task<Student> GetStudentByRollno(int rollno)
        {
            var student = await _context.Students.FindAsync(rollno);
            if (student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionmessages[0]);
            }
            else
            {
                return student;
            }
        }



        public async Task<List<Student>> AddNewStudent(Student student)
        {
            _context.Students.Add(student);  // from entity framework core 
            await _context.SaveChangesAsync();
            return await _context.Students.ToListAsync();
        }



        public async Task<Student> UpdateStudent(int rollno, Student student)
        {
            var upstudent = await _context.Students.FindAsync(rollno);
            if (upstudent == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionmessages[0]);
            }
            else
            {
                upstudent.Name = student.Name;
                upstudent.City = student.City;
                await _context.SaveChangesAsync();



                return await _context.Students.FindAsync(rollno);

            }
        }



        public async Task<List<Student>> DeleteStudent(int rollno)
        {
            var student = await _context.Students.FindAsync(rollno);
            if (student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionmessages[0]);
            }
            else
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return await _context.Students.ToListAsync();
            }
        }




    }
}
