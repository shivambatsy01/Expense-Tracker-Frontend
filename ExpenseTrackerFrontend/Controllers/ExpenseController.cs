using ExpenseTrackerFrontend.Global;
using ExpenseTrackerFrontend.Models.CreateModel;
using ExpenseTrackerFrontend.Models.Domain;
using ExpenseTrackerFrontend.Views;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

namespace ExpenseTrackerFrontend.Controllers
{
    [Route("expense")]
    public class ExpenseController : Controller  //one view foldeer per controller
    {
        private readonly ICustomSessionStore SessionStore;
        public ExpenseController(ICustomSessionStore SessionStore)
        {
            this.SessionStore = SessionStore;
        }

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
            //how to get userID from UI -> retrieve using session
            //implement session state

            //return  ViewExpenses();
            return null;
        }


        [HttpGet]
        public async Task<IActionResult> ViewExpenses([FromHeader] RequestHeaders requestHeaders)
        {
            var cookie = requestHeaders.Cookie;
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
            //ViewData["SessionUser"] = 
            return View();
        }
    }
}
