using ProjectManagerDLL.DataBase;
using ProjectManagerDLL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetctManagerBLL
{
   public class ProjectBLL
    {
        Repository<Project> repo = new Repository<Project>();

        public List<Project> Projects(int id)
        {
            return repo.List(x => x.UserPublishing == id);
        }


    }
}
