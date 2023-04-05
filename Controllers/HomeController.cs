using Demo1MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo1MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            // using ViewData

            List<Student> StudentList = new List<Student>()
            {
                new Student{Name="Ram", City="Amrvati",Percentage=86},
                new Student{Name="Ram", City="Amrvati",Percentage=86},
                new Student{Name="Ram", City="Amrvati",Percentage=86},
                new Student{Name="Ram", City="Amrvati",Percentage=86},
            };

            ViewData["studlist"] = StudentList;

            // Using ViewBag

            List<Employee> emp = new List<Employee>()
            {
                new Employee{Name="Ram", City="Amravati", Salery=153450 },
                new Employee{Name="Ram", City="Amravati", Salery=153450 },
                new Employee{Name="Ram", City="Amravati", Salery=153450 },
                new Employee{Name="Ram", City="Amravati", Salery=153450 },
                new Employee{Name="Ram", City="Amravati", Salery=153450 },
            };

            ViewBag.List = emp;

            TempData["message"] = "This is my first MVC application";
            TempData.Keep("message");

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