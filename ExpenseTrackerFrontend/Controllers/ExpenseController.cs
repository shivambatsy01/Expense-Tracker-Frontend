using ExpenseTrackerFrontend.Models.CreateModel;
using ExpenseTrackerFrontend.Models.Domain;
using ExpenseTrackerFrontend.Views;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerFrontend.Controllers
{
    [Route("expense")]
    public class ExpenseController : Controller  //one view foldeer per controller
    {
        //public IActionResult Index()
        //{
        //    //It doesnot have any view with name 'Index' in View\Expense
        //    //It will return error untill there is view with name 'Index'
        //    return View();

        //}

        [HttpGet]
        [Route("add")]
        public ViewResult AddExpense()  //name same as cshtml file (same name as view) -> one view folder per controller
        {
            ViewData["Title"] = "page from controller";
            return View();
        }


        [HttpPost]   //post on same route i.e. 'expense'
        [Route("add")]
        public async Task<IActionResult> AddExpense(CreateExpense expense)
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
            var Expenses = new List<Expense>
            {
                new Expense
                {
                    Name = "Expense1",
                    Amount = 20,
                    Remarks = "Remark1",
                },
                new Expense
                {
                    Name = "Expense2",
                    Amount = 20,
                    Remarks = "Remark2",
                },
                new Expense
                {
                    Name = "Expense3",
                    Amount = 20,
                    Remarks = "Remark3",
                },
                new Expense
                {
                    Name = "Expense4",
                    Amount = 20,
                    Remarks = "Remark4",
                },
                new Expense
                {
                    Name = "Expense5",
                    Amount = 20,
                    Remarks = "Remark5",
                }
            };

            ViewData["Expenses"] = Expenses; 
            return View();
        }
    }
}
