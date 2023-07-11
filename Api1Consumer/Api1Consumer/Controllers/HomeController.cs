using Api1Consumer.Models;
using ApiApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace Api1Consumer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        string baseUrl = "http://localhost:5130/";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            IList<Student> slist = new List<Student>();
            using (var client = new HttpClient()) { 
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync("Students");

                if (getData.IsSuccessStatusCode) { 
                    string res = getData.Content.ReadAsStringAsync().Result;
                    slist = JsonConvert.DeserializeObject<List<Student>>(res);
                   
                }
                else
                {
                    Console.WriteLine("Error");
                }
            };

                ViewData.Model= slist;
                return View();
        }

        public async Task<Student> GetById(int id)
        {
            Student s = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl+"Students/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync(id+"");

                if (getData.IsSuccessStatusCode)
                {
                    string res = getData.Content.ReadAsStringAsync().Result;
                    s = JsonConvert.DeserializeObject<Student>(res);

                }
                else
                {
                    Console.WriteLine("Error");
                }
            };

            return s;
        }

        public async Task<ActionResult> AddStudent(Student student) {
            Student s = new Student() { 
                ID=student.ID,
                namefirst=student.namefirst,
                namelast=student.namelast,
                DOB=student.DOB,
                emailID=student.emailID
            };
            if (student.namefirst != null) {
                using (var client= new HttpClient()) { 
                    client.BaseAddress = new Uri(baseUrl+"Students/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage getData = await client.PostAsJsonAsync<Student>(student.ID+"",s);
                    if (getData.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else { 
                        Console.WriteLine("Error");
                        return RedirectToAction("Index");
                    }
                };
            }
            return View();
        }
        [HttpGet("DeleteStudent")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            Console.WriteLine(id);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl + "Students/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage getData = await client.DeleteAsync(id+"");
                    if (getData.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                };
            
            return RedirectToAction("Index");
        }

        [HttpGet("EditStudent")]
        public async Task<ActionResult> EditStudent(Student student, int id)
        {
            Student s = new Student()
            {
                ID = student.ID,
                namefirst = student.namefirst,
                namelast = student.namelast,
                DOB = student.DOB,
                emailID = student.emailID
            };
            if (student.namefirst != null)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl + "Students/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage getData = await client.PutAsJsonAsync<Student>(student.ID + "", s);
                    if (getData.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        return RedirectToAction("Index");
                    }
                };
            }
            s = GetById(id).Result;
            ViewData.Model = s;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}