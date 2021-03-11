﻿using ProjectManagerDLL.DataBase;
using ProjectManagerDLL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetctManagerBLL
{
  public  class PostBLL
    {
        Repository<Post> repo = new Repository<Post>();


        public List<Post> GetPost(int id)
        {
            return  repo.List(x=> x.PostUser == id);
        }

    }
}