﻿using ProjectManagerDLL.DataBase;
using ProjetctManagerBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class PostController : Controller
    {
        PostBLL postBLL = new PostBLL();
        public ActionResult PostInsert(Post post)
        {

            Users users = Session["user"] as Users;

            post.PostUser = users.Id;
            postBLL.PostInsert(post);

            return View();
        }
    }
}