using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class ProfilesController : Controller
    {
     
        [HttpGet]
        public ActionResult GetProfiles()
        {


            return View();
        }
    }
}