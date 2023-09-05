using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;
using StudentDetails.GlobalExceptions;

namespace StudentDetails.Services.Services_Classes
{
    public class StudentService : IStudent
    {
        //Create context to connect to database
        public StudentManagementContext? _context; // id the student table is empty the context will be null

        public StudentService(StudentManagementContext? context)
        {
            _context = context;
        }

        public async Task<List<StudentDetail>> GetAllStudents()
        {
            // wait for data to be fetched
            var students= await _context.StudentDetails.ToListAsync();
            return students;

        }

        public async Task<StudentDetail> GetStudentByRollno(int rollno)
        {
            var student = await _context.StudentDetails.FindAsync(rollno);
            if (student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionmessages[0]);
            }
            else
            {
                return student;
            }
        }

        public async Task<List<StudentDetail>> AddNewStudent(StudentDetail studentDetail)
        {
            _context.StudentDetails.Add(studentDetail);
            await _context.SaveChangesAsync();
            return  await _context.StudentDetails.ToListAsync();
             
        }

        public async Task<StudentDetail> UpdateStudent(int rollno,StudentDetail studentDetail)
        {
            var upstudent = await _context.StudentDetails.FindAsync(rollno);
            if (upstudent == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionmessages[0]);
            }
            else
            {
                upstudent.Name=studentDetail.Name;
                await _context.SaveChangesAsync();
                return await _context.StudentDetails.FindAsync(rollno);

                 ;
            }
        }
        public async Task<List<StudentDetail>> DeleteStudent(int rollno) 
        {
            var upstudent = await _context.StudentDetails.FindAsync(rollno);
            if (upstudent == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionmessages[0]);
            }
            else
            {
                _context.StudentDetails.Remove(upstudent);
                await _context.SaveChangesAsync();
                return await _context.StudentDetails.ToListAsync();

                ;
            }

        }
    }
}
