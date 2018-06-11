using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portafolio.ViewModel
{
    public class ViewModelPerfil
    {
        [Required(ErrorMessage = "El campo {0} no puede quedar vacio")]
        public string Titular { get; set; }

        [Required(ErrorMessage = "El campo {0} no puede quedar vacio")]
        public string Extracto { get; set; }

        public HttpPostedFileBase imgTitular { get; set; }

        public HttpPostedFileBase imgExtracto { get; set; }
    }
}