using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerFrontend.Controllers
{
    [Route("expense")]
    public class ExpenseController : Controller
    {
        [Route("IndexMethodOfExpenseController-SearchViewNamedAsIndexIn-Views/Expense-folder")]
        public IActionResult Index()
        {
            return View();
        }

        //take care of naming conventions in .net
        public ViewResult AddExpense()  //name same as cshtml file (same name as view) -> one view folder per controller
        {
            return View();
        }
    }
}
