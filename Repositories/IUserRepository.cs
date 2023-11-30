using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyWeb.Models;

namespace MyWeb.Repositories
{
    public interface IUserRepository
    {
        // private List<UserModel> users = new List<UserModel>{
        //     new UserModel{Id=123,Name="natalia",Password="rahasia",
        //     FavoriteColor="blue",Role="admin",GoogleId="12345678"}
        // };

        public UserModel? GetByGoogleId(string googleId);

        public UserModel? GetByUsernameAndPassword(string username, string password);
    }
}