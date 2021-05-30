using ProjectManagerDLL.DataBase;
using ProjectManagerDLL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetctManagerBLL
{
   public    class LoginBLL
    {
       static Repository<Users> repo = new Repository<Users>();
        
        public int Register(Users users)
        {


            //users.Status = 1;

            //return repo.Insert(users);



            users.Status = 1;

            return repo.Insert(users);


        }


        public Users Login(Users users)
        {
            return repo.Find(x => x.Email == users.Email && x.Password == users.Password);
        }

        public int UserDelete(int id)
        {

            Users user = repo.Find(x => x.Id == id);
            
            return repo.Delete(user);

        }




    }
}
