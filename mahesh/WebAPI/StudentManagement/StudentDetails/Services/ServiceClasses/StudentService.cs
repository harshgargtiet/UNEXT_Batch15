using Microsoft.EntityFrameworkCore;
using StudentDetails.GlobalExceptions;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;

namespace StudentDetails.Services.ServiceClasses
{
    public class StudentService: IStudent
    {

        public StudentManagementContext? _context;

        public StudentService(StudentManagementContext? context)
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

        public async Task<Student?> AddNewStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            // Use await and ValueTask.Result to extract the Student object
            return await _context.Students.FindAsync(student.Rollno);
        }

        public async Task<Student?> UpdateStudent(Student student)
        {
            Student? studentFound = await _context.Students.FindAsync(student.Rollno);

            if(studentFound == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionStrings[0]);
            }
            else
            {
                studentFound.Name = student.Name;
                await _context.SaveChangesAsync();
            }

            return await _context.Students.FindAsync(student.Rollno);
        }

        public async Task<List<Student>> DeleteStudent(int rollNum)
        {
            Student? student = await _context.Students.FindAsync(rollNum);

            if(student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionStrings[0]);
            }
            else
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }

            return await _context.Students.ToListAsync();
        }

    }
}
