using Microsoft.EntityFrameworkCore;
using StudentDetails.GlobalExceptions;
using StudentDetails.Models;

namespace StudentDetails.Services
{
    public class StudentServices : IStudent
    {
        public StudentMgmtContext? _context;

        public StudentServices(StudentMgmtContext? context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllStudent()
        {
            List<Student> students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<Student?> GetStudentByID(int rollNum)
        {
            Student? student = await _context.Students.FindAsync(rollNum);
            return student ?? throw new ArgumentException();
        }

        public async Task<List<Student>> AddNewStudent(Student student) 
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> UpdateStudent(int rollno, Student student)
        {
            var upstudent = await _context.Students.FindAsync(rollno);
            if (upstudent == null) 
            {
                throw new ArgumentException(ExceptionDetails.exceptionString[0]);
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
                throw new ArgumentException(ExceptionDetails.exceptionString[0]);
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
