using StudentManagement1.Models;

namespace StudentManagement1.Services.interfaces
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudentByRollNo(int rollno);

        Task<List<Student>> AddNewStudent(Student student);

        Task<Student> UpdateStudent( int rollno, Student student );
        Task<List<Student> >DeleteStudent(int rollno);

    }
}
