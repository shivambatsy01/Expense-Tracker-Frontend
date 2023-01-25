using ExpenseTrackerFrontend.Models.APIModels;
using ExpenseTrackerFrontend.Models.Domain;

namespace ExpenseTrackerFrontend.DataProviders.ExpenseDataProvider
{
    public interface IExpenseDataProvider
    {
        //public Task<Expense> GetExpenseByIdAsync(Guid expenseId);
        public Task<IEnumerable<Expense>> GetUserAllExpensesAsync(Guid userId);
        public Task<Expense> AddExpenseAsync(Guid userId, ExpenseApiModel expense);
        public Task<Expense> UpdateExpenseAsync(Guid expenseId, ExpenseApiModel expense);
        public Task<Expense> DeleteExpenseAsync(Guid expenseId);

        //public Task<IEnumerable<Expense>> GetUserExpensesByDateAsync(Guid userId, DateTime date);
        //public Task<IEnumerable<Expense>> GetUserExpensesBeetweenDatesAsync(Guid usierId, DateTime startDate, DateTime endDate);
        //public Task<IEnumerable<Expense>> GetUserExpensesByCategoryAsync(Guid userId, int categoryId);
    }
}
