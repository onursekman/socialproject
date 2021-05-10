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
        ProjectBLL projectBLL = new ProjectBLL();
        // GET: Logins
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Users users)
        {
            Users user = loginBLL.Login(users);
          
            
            if (user!=null)
            {
                List<Project> projects = projectBLL.Projects(user.Id);
                int projesayisi=0;
                foreach (var item in projects)
                {
                    projesayisi++;

                }
                Session["projesayisi"] = projesayisi;
                Session["user"] = user;
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
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("Index", "Login");

            }

        }

      
        public ActionResult LogOut()
        {
            Session["user"]=null;
            return RedirectToAction("Index", "Login");
        }
    }
}