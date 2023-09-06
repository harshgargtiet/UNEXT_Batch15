using Student_Management.Models;

namespace Student_Management.Services.Interface
{
    public interface iStudent
    {
        Task<List<Student>> GetAllStudents();

        Task<Student> GetStudentByRollno(int rollno);

        Task<List<Student>> AddNewStudent(Student student);

        Task<Student> UpdateStudent(int rollno, Student student);

        Task<List<Student>> DeleteStudent(int rollno);

    }
}
