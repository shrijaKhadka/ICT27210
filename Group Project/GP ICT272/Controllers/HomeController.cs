using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using GP_ICT272.Data;
using GP_ICT272.Models;

namespace GP_ICT272.Controllers
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
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                GP_ICT272Context db = new GP_ICT272Context();
                bool ISValidUser = db.Users
                    .All(u => u.Name.ToLower() == user
                    .Name.ToLower() && user
                    .Password == user.Password);
                if (ISValidUser)
                {
                    FormsAuthentication.SetAuthCookie(user.Name, false);
                    return RedirectToAction("Index", "Employees");
                }
            }
            ModelState.AddModelError("", "invalid Username or Passsword");
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Register(User registerUser)
        {
            if(ModelState.IsValid)
            {
                GP_ICT272Context db = new GP_ICT272Context();
                db.Users.Add(registerUser);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }




    }

}