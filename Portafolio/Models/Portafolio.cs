//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portafolio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Portafolio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Portafolio()
        {
            this.MaestroEtiquetaPorta = new HashSet<MaestroEtiquetaPorta>();
        }
    
        public int IDPortafolio { get; set; }
        public string ImgPortafolio { get; set; }
        public string Resumen { get; set; }
        public string Link { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaestroEtiquetaPorta> MaestroEtiquetaPorta { get; set; }
    }
}