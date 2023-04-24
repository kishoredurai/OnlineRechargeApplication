using Microsoft.AspNetCore.Mvc;
using OnlineRechargeApplication.Models;

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

        //[HttpPost]
        //public ActionResult SignUp(IFormCollection obj)
        //{
        //    CustomerModel model = new CustomerModel();
        //    model.CustomerName = obj["name"];
        //    model.CustomerEmail = obj["email"];
        //    model.CustomerAddress = obj["phonenumber"];
        //    model.CountryCode = int.Parse(obj["countrycode"]);
        //    model.ServiceProvider.ServiceProviderName = obj["serviceprovider"];


        //}
    }
}
