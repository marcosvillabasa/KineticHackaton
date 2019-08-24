using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeGlutenApp.Models.ViewModel
{
    public class LugaresViewModel
    {
        public int id { set; get; }
        public string direccionLugar { set; get; }
        public string nombreLugar { set; get; }
        public string nivelCeliaquismo { set; get; }
    }
}