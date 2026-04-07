using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        // Static list to persist data
        private static List<dynamic> products = new List<dynamic>();

        // GET → Show page with form + table
        
        [HttpGet("AddProducts")]
        public IActionResult AddProducts()
        {
            ViewBag.Products = products;
            return View();
        }

        // POST → Add product
        [HttpPost("add")]
        public IActionResult Add(string productName, double price, int quantity)
        {
            // Add new product to list
            products.Add(new
            {
                Name = productName,
                Price = price,
                Quantity = quantity
            });

            // Send updated list using ViewBag
            ViewBag.Products = products;

            // Return SAME view (no redirect, no TempData)
            return View("AddProducts");
        }
    }
}

