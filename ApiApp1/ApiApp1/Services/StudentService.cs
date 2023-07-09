using ApiApp1.Models;
using ApiApp1.Services.Interfaces;
using Happy_Marriage.Utilities;

namespace ApiApp1.Services
{
    public class StudentService:IStudentService
    {
        private readonly DBEntityContext dBEntityContext;

        public StudentService(DBEntityContext dBEntityContext) { 
            this.dBEntityContext = dBEntityContext;
        }

        public List<Student> getAll() {
            var list = from Student in dBEntityContext.Student select Student;
            return list.ToList<Student>();
        }

        public Student getById(int id)
        {
            var list = from Student in dBEntityContext.Student where (Student.ID==id) select Student;
            Student? s = list.FirstOrDefault(u => u.ID==id);
            return s;        
        }

        public Student addStudent(Student student)
        {
            dBEntityContext.Student.Add(student);
            dBEntityContext.SaveChanges();
            return student;
        }

        public Student deleteStudent(int id)
        {
            var s = getById(id);
            dBEntityContext.Student.Remove(s);
            dBEntityContext.SaveChanges();
            return s;
        }

        public Student updateStudent(Student student)
        {
            dBEntityContext.Student.Update(student);
            dBEntityContext.SaveChanges();
            return student;
        }
    }
}
