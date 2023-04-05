using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo1MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            List<String> options = new List<string>() { "Select Option", "Devlopment", "Testing", "HR" };
            ViewData["options"] = new SelectList(options);
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Emp_Id = form["empid"];
            ViewBag.Salary = form["salary"];
            ViewBag.Gender = form["gender"];
            return View("Employee");
        }
    }
}
