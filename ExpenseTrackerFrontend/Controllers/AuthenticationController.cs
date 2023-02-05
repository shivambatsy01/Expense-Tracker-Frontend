using ExpenseTrackerFrontend.DataProviders.UserDataProvider;
using ExpenseTrackerFrontend.Global;
using ExpenseTrackerFrontend.Models.CreateModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExpenseTrackerFrontend.Controllers
{

    [Route("auth")]
    public class AuthenticationController : Controller
    {

        private readonly IUserDataProvider UserDataProvider;
        private readonly ICustomSessionStore SessionStore;

        public AuthenticationController(IUserDataProvider userDataProvider, ICustomSessionStore sessionStore)
        {
            this.UserDataProvider = userDataProvider;
            this.SessionStore = sessionStore;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLogin login)
        {
            //create session and redirect to homepage
            //store username in session
            //access username everywhere in the application -> 
            //request have cookie -> cookie has session ID -> session has username

            if(login.UserName == "user1" && login.Password == "pass1")  //authentication
            {
                var sessionId = SessionStore.CreateSession(login.UserName);
                Response.Cookies.Append("sessionID", sessionId.ToString());
                Response.Redirect("localhost:7225/expense");
            }
            else
            {
                return null;
            }
            return null;
            

        }

        [Route("logout")]
        public IActionResult Logout()
        {
            //destroy session
            //redirect to login page
            HttpContext.Session.Remove("User");

            return null;
        }
    }
}
