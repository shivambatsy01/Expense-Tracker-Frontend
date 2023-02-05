using ExpenseTrackerFrontend.Models.CreateModel;
using ExpenseTrackerFrontend.Models.Domain;

namespace ExpenseTrackerFrontend.DataProviders.UserDataProvider
{
    public class UserDataProvider : IUserDataProvider
    {
        private readonly IConfiguration Configuration;
        private string urlRoute;
        public UserDataProvider(IConfiguration configuration)
        {
            this.Configuration = configuration;
            urlRoute = configuration["APIServer"] + "expenses/";  //check and modify
        }

        public UserLogin GetUserDetails(string username)
        {
            throw new NotImplementedException();
        }
    }
}
