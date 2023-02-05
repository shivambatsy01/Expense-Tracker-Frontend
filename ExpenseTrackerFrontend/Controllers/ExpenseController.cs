using ExpenseTrackerFrontend.Models.Domain;
using ExpenseTrackerFrontend.Views;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerFrontend.Controllers
{
    [Route("expense")]
    public class ExpenseController : Controller  //one view foldeer per controller
    {
        public IActionResult Index()
        {
            //It doesnot have any view with name 'Index' in View\Expense
            //It will return error untill there is view with name 'Index'
            return View();

        }

        [HttpGet]
        public ViewResult AddExpense()  //name same as cshtml file (same name as view) -> one view folder per controller
        {
            ViewData["Title"] = "page from controller";
            return View();
        }


        [HttpPost]   //post on same route i.e. 'expense'
        public async Task<IActionResult> AddExpense(Expense expense)
        {
            //complete this function to backend call and redirect to ViewExpenses 
            //backend calls
            /* ------
              ----
             -----*/
            ///

            return await ViewExpenses();
        }


        public async Task<IActionResult> ViewExpenses()
        {
            return null;
        }
    }
}
