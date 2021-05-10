using System;
using ProjectManagerDLL.DataBase;
using ProjetctManagerBLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project

        ProjectBLL projectBLL = new ProjectBLL();
        public ActionResult Index()
        {
            Users users = Session["user"] as Users;
            
            return View();
        }
    }
}