using Microsoft.AspNetCore.Http;

namespace ExpenseTrackerFrontend.Global
{
    public interface ICustomSessionStore
    {
        public Session GetSession(Guid id);

        public Guid CreateSession(string userName);

        public void DestroySession(Guid id);
    }
}
