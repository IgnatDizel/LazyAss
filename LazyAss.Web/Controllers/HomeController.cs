using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LazyAss.BLL.Managers;
using LazyAss.Web.Models;

namespace LazyAss.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
 
            return View(v);
        }
    }
}