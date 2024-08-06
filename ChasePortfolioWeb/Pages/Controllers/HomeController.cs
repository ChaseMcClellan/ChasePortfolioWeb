using Microsoft.AspNetCore.Mvc;

namespace ChasePortfolioWeb.Pages
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            // Handle the contact form submission
            // For now, just return a success response
            return Json(new { success = true });
        }
    }
}
