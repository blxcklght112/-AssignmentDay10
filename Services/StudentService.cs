using Day10.DTO;
using Day10.DB;
using Day10.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day10.Services
{
    public class StudentService : IStudentService
    {
        private StudentContext _context;

        public StudentService(StudentContext context)
        {
            _context = context;
        }

        public async Task<Student> AddStudent(StudentDTO student)
        {
            var addStudent = await _context.Students.AddAsync(new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                City = student.City,
                State = student.State
            });

            await _context.SaveChangesAsync();

            return addStudent.Entity;
        }

        public async Task<Student> EditStudent(Student student)
        {
            var item = await _context.Students.FindAsync(student.StudentId);
            if (item != null)
            {
                item.FirstName = student.FirstName;
                item.LastName = student.LastName;
                item.City = student.City;
                item.State = student.State;
                await _context.SaveChangesAsync();
                return item;
            }

            return null;
        }

        public async Task DeleteStudent(int id)
        {
            var item = await _context.Students.FindAsync(id);
            if (item != null)
            {
                _context.Students.Remove(item);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Student>> GetAllStudent()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _context.Students.FindAsync(id);
        }
    }
}