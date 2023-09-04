﻿using Microsoft.EntityFrameworkCore;
using StudentDetails.Models;
using StudentDetails.Services.Interface;
using StudentDetails.GlobalExceptions;

namespace StudentDetails.Services.ServiceClasses
{
    public class StudentService : IStudent
    {
        public StudentMgmtContext? _context;

        public StudentService(StudentMgmtContext? context)
        {
            _context = context;
        }

        // Task is added if we need asynchronous operation
        public async Task<List<Student>> GetAllStudents()
        {
            List<Student> students = await _context.Students.ToListAsync();
            return students;
        }

        public async Task<Student> GetStudentByRollNum(int rollno)
        {
            // FindAsync only for primary key
            var student = await _context.Students.FindAsync(rollno);

            if(student == null)
            {
                throw new ArgumentException(ExceptionDetails.exceptionMessages[0]);
            }

            return student;
        }
    }
}
