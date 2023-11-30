using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public String Name { get; set; } = string.Empty;

        public String Password { get; set; } = string.Empty;

        public String FavoriteColor { get; set; } = string.Empty;

        public String Role { get; set; } = string.Empty;

        public String GoogleId { get; set; } = string.Empty;
    }
}