using ProjectManagerDLL.DataBase;
using ProjectManagerDLL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetctManagerBLL
{
    public class SearchBLL
    {
        Repository<Users> repo = new Repository<Users>();
        public List<Users> FindSearch(string username)
        {
             List<Users> usersmn = repo.List(x => x.Username == username);
             return usersmn;


        }
    }
}
