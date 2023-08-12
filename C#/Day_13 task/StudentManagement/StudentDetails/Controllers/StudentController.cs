using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;

namespace StudentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
       
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
           var students = await _student.GetAllStudents();
            if(students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }

        [HttpGet ("{id}")]
        public async Task<ActionResult<List<Student>>> GetStudentById(int rollno)
        {
            Student student;
            try
            {
                student = await _student.GetStudentById(rollno);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(student);
        }

        [HttpPost("update")]
        public async Task<ActionResult<Student>> UpdateStudent(int rollno,Student student)
        {
            Student students;
            try
            {
                students = await _student.UpdateStudent(rollno,student);
                return Ok(students);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
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
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
