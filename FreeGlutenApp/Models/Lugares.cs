//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeGlutenApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lugares
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lugares()
        {
            this.Menus = new HashSet<Menus>();
        }
    
        public int id { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> id_Nivel { get; set; }
    
        public virtual NivelCeliaquismo NivelCeliaquismo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menus> Menus { get; set; }
    }
}
