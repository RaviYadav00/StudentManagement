using StudentManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Repositories
{
    public class StudentRepository
    {
        private readonly List<Student> _students = new();
        private int _id = 1;

        public List<Student> GetAll() => _students;

        public Student? GetById(int id) => _students.FirstOrDefault(s => s.Id == id);

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
            var existing = GetById(id);
            if (existing == null) return false;

            _students.Remove(existing);
            return true;
        }
    }
}
