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
    
    public partial class Usuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string correo { get; set; }
        public Nullable<int> id_Nivel { get; set; }
    
        public virtual NivelCeliaquismo NivelCeliaquismo { get; set; }
    }
}
