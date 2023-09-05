using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetails.Services;
using StudentDetails.Models;
using StudentDetails.GlobalExceptions;

namespace StudentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent? _student;
        public ExceptionDetails exceptionDetails;

        public StudentController(IStudent? student)
        {
            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudent()
        {
            List<Student> students = await _student.GetAllStudent();
            if(students == null || students.Count == 0)
            {
                return NotFound("Not found!");
            }
            return Ok(students);
        }

        [HttpGet("{rollNum}")]
        public async Task<ActionResult<Student>> GetStudentByID(int rollNum)
        {
            try
            {
                Student student = await _student.GetStudentByID(rollNum);
                return Ok(student);
            }
            catch (Exception e) 
            {
                throw new ArgumentException(ExceptionDetails.exceptionString[0]);
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddNewStudent(Student student)
        {
            return await _student.AddNewStudent(student);
        }

        [HttpPut]
        public async Task<ActionResult<Student>> UpdateStudent(int rollno, Student student)
        {
            try
            {
                var upstudent = await _student.UpdateStudent(rollno, student);
                return Ok(upstudent);
            }
            catch (ArgumentException e) 
            { 
                return NotFound(e.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollno)
        {
            try
            {
                var students = await _student.DeleteStudent(rollno);
                return Ok(students);
            }
            catch (ArgumentException e) 
            {
                return NotFound(e.Message);
            }

        }
    }
}
