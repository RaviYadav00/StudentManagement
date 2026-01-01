using StudentManagement.Models;
using System.Linq;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> _students = new();
        private static int _id = 1;

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student? GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public Student Add(Student student)
        {
            student.Id = _id++;
            _students.Add(student);
            return student;
        }

        public bool Update(int id, Student student)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Name = student.Name;
            existing.Email = student.Email;
            existing.Course = student.Course;

            return true;
        }

        public bool Delete(int id)
        {
            var student = GetById(id);
            if (student == null) return false;

            _students.Remove(student);
            return true;
        }
    }
}
