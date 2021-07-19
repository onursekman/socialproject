using ProjectManagerDLL.DataBase;
using ProjetctManagerBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        

        SearchBLL searchBLL = new SearchBLL();
        
        public ActionResult Index(Users UserName)
        {
            searchBLL.FindSearch(UserName.UserName);
           

            return View(UserName);
        }


       
    }
}