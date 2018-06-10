using Portafolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        PortafolioEntities Entities = new PortafolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult inicio()
        {
            var inicio = Entities.Perfil.SingleOrDefault();
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