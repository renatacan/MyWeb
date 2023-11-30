using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWeb.Models;
using MyWeb.Repositories;

namespace MyWebApp.Repositories
{
    public class userRepository : IUserRepository
    {
        private List<UserModel> users = new List<UserModel>{
            new UserModel{Id=123,Name="natalia",Password="rahasia",
            FavoriteColor="blue",Role="admin",GoogleId="12345678"}
        };
        public UserModel? GetByGoogleId(string googleId)
        {
            throw new NotImplementedException();
        }

        public UserModel? GetByUsernameAndPassword(string username, string password)
        {
            var user = users.SingleOrDefault(u=>u.Name == username && password == "rahasia");
            return user;
        }
    }
}