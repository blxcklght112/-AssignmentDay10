using Microsoft.AspNetCore.Mvc;
using Day10.DTO;
using Day10.Services;
using Day10.Entities;

namespace Day10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("/add-student")]
        public async Task<Student> AddStudent(StudentDTO student)
        {
            return await _studentService.AddStudent(student);
        }

        [HttpPut("/edit-student")]
        public async Task<Student> EditStudent(Student student)
        {
            return await _studentService.EditStudent(student);
        }

        [HttpDelete("/delete-student")]
        public async Task DeleteStudent(int id)
        {
            await _studentService.DeleteStudent(id);
        }

        [HttpGet("/get-all-student")]
        public async Task<List<Student>> GetAllStudent()
        {
            return await _studentService.GetAllStudent();
        }

        [HttpGet("/get-student-by-id")]
        public async Task<Student> GetStudentById(int id)
        {
            return await _studentService.GetStudentById(id);
        }
    }
}