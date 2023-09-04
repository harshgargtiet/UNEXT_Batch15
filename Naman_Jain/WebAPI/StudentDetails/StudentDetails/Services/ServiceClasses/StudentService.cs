using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interface;
using StudentDetails.GlobalExceptions;

namespace StudentDetails.Services.ServiceClasses
{
    public class StudentService : IStudent
    {
        public StudentMgmtContext? _context;

        public StudentService(StudentMgmtContext? context)
        {
            _context = context;
        }

        // Task is added if we need asynchronous operation
        public async Task<List<Student>> GetAllStudents()
        {
            List<Student> students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<Student> GetStudentByRollNum(int rollno)
        {
            // FindAsync only for primary key
            var student = await _context.Students.FindAsync(rollno);

            if(student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionMessages[0]);
            }

            return student;
        }

        public async Task<List<Student>> AddNewStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> UpdateStudent(int rollno, Student student)
        {
            var _student = await _context.Students.FindAsync(rollno);
            if(_student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionMessages[0]);
            } else
            {
                _student.Name = student.Name;
                _student.City = student.City;
                await _context.SaveChangesAsync();

                _student = await _context.Students.FindAsync(rollno);
                return _student;
            }
        }

        public async Task<List<Student>> DeleteStudent(int rollno)
        {
            var _student = await _context.Students.FindAsync(rollno);
            if (_student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionMessages[0]);
            }
            else
            {
                _context.Students.Remove(_student);
                await _context.SaveChangesAsync();

                var students = await _context.Students.ToListAsync();
                return students;
            }
        }
    }
}
