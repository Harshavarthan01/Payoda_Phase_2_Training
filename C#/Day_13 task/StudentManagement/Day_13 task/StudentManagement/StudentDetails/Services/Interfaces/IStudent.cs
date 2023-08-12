using StudentDetails.Models;

namespace StudentDetails.Services.Interfaces
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudents();

        public Task<Student> GetStudentById(int id);

        public Task<List<Student>> AddStudent(Student student);

        public Task<Student> UpdateStudent(int rollno, Student student);

        public Task<List<Student>> DeleteStudent(int id);

    }
}
