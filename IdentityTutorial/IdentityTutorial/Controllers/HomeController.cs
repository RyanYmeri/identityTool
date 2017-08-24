using IdentityTutorial.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using IdentityTutorial.App_Start;

namespace IdentityTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public string AddUser()
        {
            ApplicationUser user;
            ApplicationUserStore Store = new ApplicationUserStore(new ApplicationDbContext());
            ApplicationUserManager userManager = new ApplicationUserManager(Store);
            user = new ApplicationUser
            {
                UserName = "TestUserTwo",
                Email = "TestUserTwo@test.com"
            };

            var result = userManager.Create(user);
            if (!result.Succeeded)
            {
                return result.Errors.First();
            }
            return "User Added";
        }
    }
}