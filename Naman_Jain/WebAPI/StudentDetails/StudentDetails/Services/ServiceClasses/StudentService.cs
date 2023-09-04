using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interface;

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
    }
}
