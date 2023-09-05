using StudentDetails.Models;
using System.Threading.Tasks;

namespace StudentDetails.Services.Interfaces
{
    public interface IStudent
    {
        Task<List<StudentDetail>> GetAllStudents();

        Task<StudentDetail> GetStudentByRollno(int rollno);

        Task<List<StudentDetail>> AddNewStudent(StudentDetail studentDetail);

        Task<StudentDetail> UpdateStudent(int rollno, StudentDetail studentDetail);

        Task<List<StudentDetail>>DeleteStudent(int rollno);


    }
}
