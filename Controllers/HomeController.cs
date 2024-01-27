using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using FLApiWeb.Models;
using System.Data.Entity;
using FLApiWeb.Service;
using System.Web.Mvc;

namespace FLApiWeb.Controllers
{
    public class HomeController : Controller
    {       
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
