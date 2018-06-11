using Portafolio.Models;
using Portafolio.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portafolio.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        PortafolioEntities Entities = new PortafolioEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add() {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Add(ViewModelPerfil perfil)
        {
            if (!ModelState.IsValid)
            {
                return PartialView();
            }
            Perfil p = new Perfil();
            p.Extracto = perfil.Extracto;
            p.Titular = perfil.Titular;
            p.ImgExtracto = SaveUploadedFile(perfil.imgExtracto);
            p.ImgTitular = SaveUploadedFile(perfil.imgTitular);
            Entities.Perfil.Add(p);
            Entities.SaveChanges();
            return PartialView();
        }

        public ActionResult Details() {
            return PartialView();
        }

        private string SaveUploadedFile(HttpPostedFileBase file)
        {
            string ruta_virtual = "";
            if (file != null)
            {
                string ruta = Path.Combine(Server.MapPath("~/Images/"));
                ruta_virtual = "~/Images/"+ file.FileName + "";
               // string pathString = ruta;
                bool isExists = System.IO.Directory.Exists(ruta);

                if (!isExists)
                    System.IO.Directory.CreateDirectory(ruta);

                var path = string.Format("{0}\\{1}", ruta, file.FileName);
                file.SaveAs(path);
                return ruta_virtual;
            }
            return ruta_virtual;
        }
    }
}