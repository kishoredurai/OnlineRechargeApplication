using Microsoft.AspNetCore.Mvc;

namespace OnlineRechargeApplication.Controllers
{
    public class AuthController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp() 
        {
            return View();
        }
        public ActionResult SignIn() 
        {
            return View();
        }
    }
}
