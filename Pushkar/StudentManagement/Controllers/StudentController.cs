using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;

namespace StudentDetails.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent? _student;

        public StudentController(IStudent? student)
        {
            _student = student;
        }
        [HttpGet]
        public async Task<ActionResult<List<StudentDetail>>> GetAllStudents()
        {
            var students = await _student.GetAllStudents();
            if (students == null)
            {
                return NotFound("Student List Empty");
            }
            else
            {
                return Ok(students);
            }

        }

        [HttpGet("{rollno}")]
        public async Task<ActionResult<StudentDetail>> GetStudentByRollno(int rollno)
        {
            try
            {
                var student = await _student.GetStudentByRollno(rollno);
                return student;

            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }


        }

        [HttpPost]
        public async Task<ActionResult<List<StudentDetail>>>AddNewStudent(StudentDetail student)
        {
            return await _student.AddNewStudent(student);
        }

        [HttpPut]

        public async Task<ActionResult<StudentDetail>>UpdateStudent(int rollno,StudentDetail student)
 
        {
            try
            {
                var upstudent = await _student.UpdateStudent(rollno, student);
                return Ok(upstudent);
            }
            catch(ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            { 
            
            }
        }

        [HttpDelete]
        public async Task<ActionResult<List<StudentDetail>>> DeleteStudent(int rollno)//, StudentDetail student)

        {
            try
            {
                var upstudent = await _student.DeleteStudent(rollno);
                return Ok(upstudent);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            {

            }
        }
    }
}
