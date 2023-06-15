using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiShopTest.Responce
{
    public partial class ResponceUsers
    {
        public ResponceUsers(Users users)
        {
            Name = users.name;
            Login = users.login;
            Password = users.password;
        }
        public string Name;
        public string Login;
        public string Password;
    }
}