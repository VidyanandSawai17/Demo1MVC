using Microsoft.AspNetCore.Mvc;

namespace Demo1MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetails()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult StudentDetails(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Roll_No = form["rollno"];
            ViewBag.Percentage = form["percentage"];
            ViewBag.Stream = form["stream"];
            return View("Student");
        }
    }
}
