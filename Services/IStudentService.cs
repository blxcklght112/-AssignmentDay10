using Day10.DTO;
using Day10.Entities;

namespace Day10.Services
{
    public interface IStudentService
    {
        Task<Student> AddStudent(StudentDTO student);

        Task<Student> EditStudent(Student student);

        Task DeleteStudent(int id);

        Task<List<Student>> GetAllStudent();

        Task<Student> GetStudentById(int id);
    }
}