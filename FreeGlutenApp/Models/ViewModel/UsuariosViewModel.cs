using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeGlutenApp.Models.ViewModel
{
    public class UsuariosViewModel
    {
        public int id { set; get; }
        public string nombreUsuario { set; get; }
        public string correo { set; get; }
        public string nivelCeliaquismo { set; get; }
    }
}