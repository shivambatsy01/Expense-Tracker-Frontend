namespace ExpenseTrackerFrontend.Global
{
    public class SessionStore : ICustomSessionStore
    {
        public List<Session> Sessions = new List<Session>();

        public Session GetSession(Guid id)
        {
            return Sessions.FirstOrDefault(x => x.Id == id);
        }
        
        public Guid CreateSession(string userName)
        {
            var session = new Session
            {
                Id = new Guid(),
                UserName = userName
            };
            Sessions.Add(session);
            return session.Id;
        }

        public void DestroySession(Guid id)
        {
            var session = Sessions.FirstOrDefault(x => x.Id == id);
            Sessions.Remove(session);
        }
    }
}
