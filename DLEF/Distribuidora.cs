//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Distribuidora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Distribuidora()
        {
            this.Discoes = new HashSet<Disco>();
        }
    
        public int IdDistribuidora { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> PorcentajeDistribucion { get; set; }
        public System.DateTime FechaNCreacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Disco> Discoes { get; set; }
    }
}
