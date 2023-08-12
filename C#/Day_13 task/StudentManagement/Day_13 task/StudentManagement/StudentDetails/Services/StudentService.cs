using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Context;
using StudentDetails.GlobalException;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;

namespace StudentDetails.Services
{
    public class StudentService : IStudent
    {
        public StudentContext? _studentContext;

        public StudentService(StudentContext? studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<List<Student>> AddStudent(Student student)
        {
            _studentContext.Students.Add(student);
            var rstudent = await _studentContext.SaveChangesAsync();
            return await _studentContext.Students.ToListAsync();
        }

        public async Task<List<Student>> DeleteStudent(int rollno)
        {
            var student = await _studentContext.Students.FindAsync(rollno);
            if (student == null)
            {
                throw new Exception(StudentDetailsException.StudentDetailexception[0]);
            }
            else
            {
                _studentContext.Students.Remove(student);
                await _studentContext.SaveChangesAsync();
                var response = await _studentContext.Students.ToListAsync();
                return response;
            }
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var students = await _studentContext.Students.ToListAsync();
                return students;
        }

        public async Task<Student> GetStudentById(int id)
        {
            var response = await _studentContext.Students.FindAsync(id);
            if (response == null)
            {
                throw new Exception(StudentDetailsException.StudentDetailexception[0]);
            }
            return response;
        }

        public async Task<Student> UpdateStudent(int rollno, Student student)
        {
            Student? rstudent = await _studentContext.Students.FindAsync(rollno,student);

            if(rstudent == null)
            {
                throw new Exception(StudentDetailsException.StudentDetailexception[0]);
            }
            
            rstudent.Studentame = student.Studentame;
            rstudent.phno = student.phno;
            rstudent.Addr = student.Addr;
            await _studentContext.SaveChangesAsync();
             rstudent = await _studentContext.Students.FindAsync(rollno, student);

            return rstudent;
        }
    }
}
