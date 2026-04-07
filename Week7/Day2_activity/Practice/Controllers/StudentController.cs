using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [Route("student")]
    public class StudentController : Controller
    {
        // GET → Show Form
        
        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }

        // POST → Handle Submission
        [HttpPost("Register")]
        public IActionResult Register(string studentName, int age, string course)
        {
            // Store in ViewBag
            ViewBag.Name = studentName;
            ViewBag.Age = age;
            ViewBag.Course = course;

            // Directly return Display View (NO redirect)
            return View("Display");
        }
    }
}
