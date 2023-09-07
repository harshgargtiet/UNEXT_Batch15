using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetails.GlobalExceptions;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace StudentDetails.Controllers
{
    [Route("[controller]")]
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
                return NotFound("I didnt find shit");
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
            } catch (Exception e)
            {
                throw new ArgumentException(ExceptionDetails.exceptionStrings[0]);
            }
            
            //if(student == null)
            //{
            //    return NotFound("No ID lol");
            //}
            //return Ok(student);
            //return student != null ? Ok(student) :
            //    throw new ArgumentException(ExceptionDetails.exceptionStrings[0]);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddNewStudent(Student student)
        {
            try
            {
                Student? student1 = await _student.AddNewStudent(student);
                return student1;
            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<Student?>> UpdateStudent(Student student)
        {
            try
            {
                Student? studentFound = await _student.UpdateStudent(student);
                return studentFound;
            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{rollNum}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollNum)
        {
            try
            {
                List<Student> studentList = await _student.DeleteStudent(rollNum);
                return Ok(studentList);
            } catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
