using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController] //Decorator
    public class StudentController : ControllerBase
    {
        public IStudent? _student;

        public StudentController(IStudent? student)
        {
            _student = student;
        }

        [HttpGet]

        public async Task<ActionResult> GetAllStudents()
        {
            var students = await _student.GetAllStudents();
            if (students == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(students);
            }

        }

        [HttpGet("{RollNo}")]

        public async Task<ActionResult> GetStudentByRollNo(int RollNo)
        {
            try
            {
                var student = await _student.GetStudentByRollNo(RollNo);
                return Ok(student);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpPost]

        public async Task<ActionResult<List<Student>>>
            AddNewStudent(Student student)
        {
            return await _student.AddNewStudent(student);
        }

        [HttpPut]

        public async Task<ActionResult<Student>>
            UpdateStudent(int RollNo, Student student)
        {
            try
            {
                var UpdateStudent = await _student.UpdateStudent(RollNo, student);
                return Ok(UpdateStudent);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        
        public async Task<ActionResult<List<Student>>>
            DeleteStudent(int RollNo)
        {
            try
            {
                var DeleteStudent = await _student.DeleteStudent(RollNo);
                return Ok(DeleteStudent);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
