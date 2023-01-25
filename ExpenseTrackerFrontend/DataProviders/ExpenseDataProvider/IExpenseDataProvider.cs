using ExpenseTrackerFrontend.Models.APIModels;
using ExpenseTrackerFrontend.Models.Domain;

namespace ExpenseTrackerFrontend.DataProviders.ExpenseDataProvider
{
    public interface IExpenseDataProvider
    {
        public Task<IEnumerable<Expense>> GetUserAllExpensesAsync(Guid userId);
        public Task<Expense> AddExpenseAsync(Guid userId, ExpenseApiModel expense);
        public Task<Expense> UpdateExpenseAsync(Guid expenseId, ExpenseApiModel expense);
        public Task<Expense> DeleteExpenseAsync(Guid expenseId);
    }
}
