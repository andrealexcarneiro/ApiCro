using ApiCro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCro.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Ambiente = 1, Usuario = "andre", Senha = "andre", GuidTenant = "manager" });
            users.Add(new User { Ambiente = 2, Usuario = "robin", Senha = "robin", GuidTenant = "employee" });
            return users.Where(x => x.Usuario.ToLower() == username.ToLower() && x.Usuario == x.Usuario).FirstOrDefault();
        }
    }
}
