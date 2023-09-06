using Microsoft.EntityFrameworkCore;
using Student_Management.Models;
using Student_Management.Services.Interface;
using Student_Management.GlobalExceptions;

namespace Student_Management.Services
{
    public class StudentService : iStudent
    {
        public StudentManagementContext? _context;

        public StudentService(StudentManagementContext? context)
        {
            _context = context;
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

        public async Task<List<Student>> AddNewStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return await _context.Students.ToListAsync();
        }

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

        public async Task<Student> GetStudentsByRollno(int rollno)
        {
            var student = await _context.Students.FindAsync(rollno);
            if(student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionmessages[0]);
            }
            else
            {
                return student;
            }
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
    }
}
