using ApiApp1.Models;

namespace ApiApp1.Services.Interfaces
{
    public interface IStudentService
    {
        public List<Student> getAll();

        public Student getById(int id);
        public Student addStudent(Student student);
        public Student deleteStudent(int id);
        public Student updateStudent(Student student);
    }
}
