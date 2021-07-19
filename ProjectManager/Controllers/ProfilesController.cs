using ProjectManagerDLL.DataBase;
using ProjetctManagerBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class ProfilesController : Controller
    {

        PostBLL postBLL = new PostBLL();
        [HttpGet]
        public ActionResult GetProfiles()
        {
            Users users = Session["user"] as Users;
             List<Post> GetPost= postBLL.GetPost(users.Id);
            GetPost.Reverse();
            
            return View(GetPost);
        }

    }
}