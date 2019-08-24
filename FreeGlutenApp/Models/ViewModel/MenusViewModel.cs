using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeGlutenApp.Models.ViewModel
{
    public class MenusViewModel
    {
        public int id { get; set; }
        public string descripcionMenu { get; set; }
        public double? precioMenu { get; set; }
        public int? nivelCeliaquismo { get; set; }
    }
}