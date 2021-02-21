using ProjectManagerDLL.DataBase;
using ProjetctManagerBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class LoginController : Controller
    {
        LoginBLL loginBLL = new LoginBLL();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Users users)
        {
            Users user = loginBLL.Login(users);

            if (user!=null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");

            }
        

          
        }
        [HttpPost]
        public ActionResult Register(Users users)
        {

          int i=  loginBLL.Register(users);
            if (i==1)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");

            }


        }
    }
}