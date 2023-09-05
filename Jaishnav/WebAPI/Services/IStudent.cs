using StudentDetails.Models;

namespace StudentDetails.Services
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudent();
        Task<Student> GetStudentByID(int rollNum);
        Task<List<Student>> AddNewStudent(Student student);
        Task<Student> UpdateStudent(int rollNum, Student student);
        Task<List<Student>> DeleteStudent(int rollNum);
    }
}
