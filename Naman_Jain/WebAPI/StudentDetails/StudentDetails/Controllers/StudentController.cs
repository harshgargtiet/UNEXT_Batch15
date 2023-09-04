using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetails.Models;
using StudentDetails.Services.Interface;

namespace StudentDetails.Controllers
{
    [Route("[controller]")]
    [ApiController] // declarator or annotation
    public class StudentController : ControllerBase
    {
        public IStudent? _student;

        public StudentController(IStudent? student)
        {
            _student = student;
        }

        //[HttpGet("get-students")]
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var students = await _student.GetAllStudents();

            if (students == null)
            {
                return NotFound("Student List Empty");
            }
            return Ok(students);
        }

        [HttpGet("{rollno}")]
        public async Task<ActionResult<Student>> GetStudentByRollNum(int rollno)
        {
            try
            {
                var student = await _student.GetStudentByRollNum(rollno);
                return Ok(student);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
