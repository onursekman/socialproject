using ProjectManagerDLL.DataBase;
using ProjectManagerDLL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetctManagerBLL
{
    public class UsersManagerBll
    {
        Repository<Users> repo = new Repository<Users>();

        public int Update(Users users)
        {
            

            return repo.Update(users);
           
        }
    }
}
