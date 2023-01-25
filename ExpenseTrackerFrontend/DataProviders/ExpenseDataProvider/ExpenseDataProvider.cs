using ExpenseTrackerFrontend.Models.APIModels;
using ExpenseTrackerFrontend.Models.Domain;
using ExpenseTrackerFrontend.SessionDetails;
using RestSharp;

namespace ExpenseTrackerFrontend.DataProviders.ExpenseDataProvider
{
    public class ExpenseDataProvider : IExpenseDataProvider
    {
        private readonly IConfiguration configuration;
        private string urlRoute;
        public ExpenseDataProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
            urlRoute = configuration["APIServer"] + "expenses/";
        }

        public async Task<Expense> AddExpenseAsync(Guid userId, ExpenseApiModel expense)
        {
            string serverUrl = urlRoute + userId.ToString();

            var client = new RestClient(serverUrl);
            var request = new RestRequest();
            request.AddJsonBody(expense);
            var response = await client.PostAsync(request);

            var responseExpense = new Expense();
            return responseExpense;
        }

        public async Task<Expense> DeleteExpenseAsync(Guid expenseId)
        {
            string serverUrl = urlRoute + expenseId.ToString();

            var client = new RestClient(serverUrl);
            var request = new RestRequest();
            var response = await client.DeleteAsync(request);

            var responseExpense = new Expense();
            return responseExpense;
        }


        public async Task<IEnumerable<Expense>> GetUserAllExpensesAsync(Guid userId)
        {
            string serverUrl = urlRoute + "user-expenses" + userId.ToString();
            var client = new RestClient(serverUrl);
            var request = new RestRequest();
            var response = await client.GetAsync(request); //need to deserialise response

            var responseExpense = new List<Expense>();
            return responseExpense;
        }

        public async Task<Expense> UpdateExpenseAsync(Guid expenseId, ExpenseApiModel expense)
        {
            string serverUrl = urlRoute + expenseId.ToString();
            var client = new RestClient(serverUrl);
            var request = new RestRequest();
            var response = await client.PutAsync(request); //need to deserialise response

            var responseExpense = new Expense();
            return responseExpense;
        }
    }
}
