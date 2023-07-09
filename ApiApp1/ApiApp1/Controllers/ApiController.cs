using ApiApp1.Models;
using ApiApp1.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiApp1.Controllers
{
    [ApiController]
    [Route("/")]
    public class ApiController : Controller
    {
        private IStudentService studentService;

        public ApiController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        // GET: ApiController
        [HttpGet("Students")]
        public JsonResult Index()
        {
            List<Student> list = studentService.getAll();
            return new JsonResult(list);
        }

        // GET: ApiController/Details/5
        [HttpGet("Students/{id}")]
        public JsonResult Details(int id)
        {
            Student s = studentService.getById(id);
            return new JsonResult(s);
        }


        // POST: ApiController/Create
        [HttpPost("Students/{id}")]
        public JsonResult Create([FromBody] Student student)
        {
            Student s = studentService.addStudent(student);
            return new JsonResult(s);
        }

        //PUT : ApiController/Edit

        [HttpPut("Students/{id}")]
        public JsonResult Edit([FromBody] Student student, int id) {

            Student s = studentService.updateStudent(student);
            return new JsonResult(s);
        }

        //DELETE: ApiController/Delete
        [HttpDelete("Students/{id}")]
        public JsonResult Delete(int id)
        {
            Console.WriteLine(id);
            Student s = studentService.deleteStudent(id);
            return new JsonResult(s);
        }
        
    }
}
