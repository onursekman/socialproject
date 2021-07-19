using ProjectManagerDLL.DataBase;
using ProjetctManagerBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settings

        UsersManagerBll usersManagerBll = new UsersManagerBll();


        public ActionResult StatuHide( )
        {
            Users users = Session["user"] as Users;

           
            users.Status = 0;


            
            usersManagerBll.Update(users);

       
            return RedirectToAction("LogOut", "Login");






        }
        public ActionResult GetSettings()
        {
            
            
            return View();





        }
        

    }
}