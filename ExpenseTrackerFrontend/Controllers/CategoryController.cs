using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerFrontend.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
