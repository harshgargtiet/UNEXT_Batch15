﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Management.Models;
using Student_Management.Services.Interface;

namespace Student_Management.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public iStudent? _student;

        public StudentController(iStudent? student)
        {
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
        public async Task<ActionResult<Student>> GetStudentByRollno(int rollno)
        {
            try
            {
                var student = await _student.GetStudentByRollno(rollno);
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
        public async Task<ActionResult<Student>> UpdateStudent(int rollno, Student student)
        {
            try
            {
                var upstudent = await _student.UpdateStudent(rollno, student);
                return Ok(upstudent);
            }
            catch (ArgumentException ex)
            { return NotFound(ex.Message); }
            
        }

        [HttpDelete]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollno)
        {
            try
            {
                var students = await _student.DeleteStudent(rollno);
                return Ok(students);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            
        }
    }
}
    
