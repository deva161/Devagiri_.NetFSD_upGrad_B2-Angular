using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [Route("feedback")]
    public class FeedbackController : Controller
    {
        // GET → Show form
        [HttpGet("form")]
        [Route("/")]
        public IActionResult Form()
        {
            return View();
        }

        // POST → Handle submission
        [HttpPost("submit")]
        public IActionResult Submit(string name, string comments, int rating)
        {
            // Logic based on rating
            if (rating >= 4)
            {
                ViewData["Message"] = "Thank You for your positive feedback!";
            }
            else
            {
                ViewData["Message"] = "We will improve based on your feedback.";
            }

            // Optional: pass name also
            ViewData["UserName"] = name;

            return View("Result");
        }
    }
}
