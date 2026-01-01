using StudentManagement.Models;

namespace StudentManagement.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student? GetById(int id);
        Student Add(Student student);
        bool Update(int id, Student student);
        bool Delete(int id);
    }
}
