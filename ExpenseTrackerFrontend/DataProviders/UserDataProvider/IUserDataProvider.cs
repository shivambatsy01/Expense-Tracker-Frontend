using ExpenseTrackerFrontend.Models.CreateModel;

namespace ExpenseTrackerFrontend.DataProviders.UserDataProvider
{
    public interface IUserDataProvider
    {
        public UserLogin GetUserDetails(string username);
    }
}
