using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement1.Models;
using StudentManagement1.Services.interfaces;
using System.Security.Cryptography.X509Certificates;

namespace StudentManagement1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent? _student;

        public StudentController(IStudent? student) {

            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
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

        public async Task<ActionResult<Student>> GetStudentByRollNo(int rollno)
        {

            try
            {
                var student = await _student.GetStudentByRollNo(rollno);
                return Ok(student);
            }

            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddNewStudent(Student student)
        {
            return await _student.AddNewStudent(student);
        }

        [HttpPut]
        public async Task<ActionResult<Student>> UpdateStudent(int rollno , Student student)
        {
            try
            {
                var upstudent = await _student.UpdateStudent(rollno, student);
                return Ok(upstudent);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<Student>> DeleteStudent(int rollno, Student student)
        {
            try
            {
                var upstudent = await _student.UpdateStudent(rollno, student);
                return Ok(upstudent);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
