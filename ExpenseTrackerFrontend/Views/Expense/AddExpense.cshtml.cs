using ExpenseTrackerFrontend.Models.AddData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExpenseTrackerFrontend.Views.Expense
{
    public class AddExpenseModel : PageModel
    {

        [BindProperty]
        public CreateExpense Expense { get; set; }
        public AddExpenseModel()  //ctor
        {
            Expense = new CreateExpense
            {
                Amount = 20,
                Name = "New Expense",
                Remarks = "Remarks",
                DateOfExpense = DateTime.Now,
            };
        }


        public void OnGet()
        {
            
        }

        public void OnPost()
        {

        }
    }
}
