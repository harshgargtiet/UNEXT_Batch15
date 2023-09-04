using StudentDetails.Models;

namespace StudentDetails.Services.Interface
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentByRollNum(int rollno);
    }
}
