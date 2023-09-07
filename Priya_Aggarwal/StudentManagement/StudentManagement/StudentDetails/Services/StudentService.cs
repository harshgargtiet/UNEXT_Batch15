using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interface;
using StudentDetails.GlobalExceptions;
namespace StudentDetails.Services
{
    public class StudentService : IStudent
    {
        public StudentMgmtContext? _context; //_ read only

        public StudentService(StudentMgmtContext? context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var students = await _context.Students.ToListAsync();
            return students;
        }

        // returning only one student that is why no List
        public async Task<Student> GetStudentByRollno(int rollno)
        {
            // finding on the basis of id
            var student = await _context.Students.FindAsync(rollno);
            if (student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionMessages[0]);
            }
            else
            {
                return student;
            }
        }

        public async Task<List<Student>> AddNewStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> UpdateStudent(int rollno, Student student)
        {
            // finding on the basis of id
            var upstudent = await _context.Students.FindAsync(rollno);
            if (upstudent == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionMessages[0]);
            }
            else
            {
                upstudent.Name = student.Name;
                upstudent.City  = student.City;
                await _context.SaveChangesAsync();
                return upstudent = await _context.Students.FindAsync(rollno);
            }
        }

        public async Task<List<Student>> DeleteStudent(int rollno)
        {
            var delstudent = await _context.Students.FindAsync(rollno);
            if (delstudent == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionMessages[0]);
            }
            else
            {
                _context.Students.Remove(delstudent);
                await _context.SaveChangesAsync();
                return await _context.Students.ToListAsync();
            }
        }
    }
}
