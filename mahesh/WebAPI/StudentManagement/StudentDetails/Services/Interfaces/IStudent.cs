using StudentDetails.Models;

namespace StudentDetails.Services.Interfaces
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudent();
        Task<Student?> GetStudentByID(int rollNum);
        Task<Student?> AddNewStudent(Student student);
        Task<Student?> UpdateStudent(Student student);
        Task<List<Student>> DeleteStudent(int rollNum);
    }
}
