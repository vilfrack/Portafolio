using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult inicio()
        {
            return PartialView();
        }
        public PartialViewResult portafolio()
        {
            return PartialView();
        }
        public PartialViewResult skill()
        {
            return PartialView();
        }
        public PartialViewResult nosotros()
        {
            return PartialView();
        }
    }
}