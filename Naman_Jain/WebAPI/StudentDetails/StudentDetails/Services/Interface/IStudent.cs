using StudentDetails.Models;

namespace StudentDetails.Services.Interface
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentByRollNum(int rollno);
        Task<List<Student>> AddNewStudent(Student student);
        Task<Student> UpdateStudent(int rollno, Student student);
        Task<List<Student>> DeleteStudent(int rollno);
    }
}
