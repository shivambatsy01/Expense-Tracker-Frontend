using ExpenseTrackerFrontend.DataProviders.ExpenseDataProvider;
using ExpenseTrackerFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpenseTrackerFrontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExpenseDataProvider expenseDataProvider;

        public HomeController(ILogger<HomeController> logger, IExpenseDataProvider expenseDataProvider)
        {
            _logger = logger;
            this.expenseDataProvider = expenseDataProvider;
        }

        public IActionResult Index()
        {
            return View("Index");
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