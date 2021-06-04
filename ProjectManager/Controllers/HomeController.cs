using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectManagerDLL.DataBase;
using ProjetctManagerBLL;

namespace ProjectManager.Controllers
{
    public class HomeController : Controller


    {//sdss

        PostBLL postBLL = new PostBLL();
        [HttpGet]
        public ActionResult Index()
        {

            Users users = Session["user"] as Users;
            if (users!=null)
            {
                //List<Post> GetPost = postBLL.GetPost(users.Id);
                List<Post> tümpost = postBLL.TümPost(users.Id);

                tümpost.Reverse();

                return View(tümpost);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

           
        }

       
    }
}