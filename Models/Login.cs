using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FLApiWeb.Models;

namespace FLApiWeb.Models
{
    public class Login
    {
        public string UserName { set; get; }
        public string Password { set; get; }
    }
    public class Registration : Utenti { }

}