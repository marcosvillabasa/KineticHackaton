using FreeGlutenApp.Models;
using FreeGlutenApp.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FreeGlutenApp.Controllers
{
    [RoutePrefix("api/Menus")]
    public class MenusController : ApiController
    {
        [HttpGet]
        [Route("ObtenerMenus")]
        public IHttpActionResult ObtenerMenus()
        {
            var db = new FreeGlutenEntities();

            var res = db.Menus.Select(p => new MenusViewModel
            {
                id = p.id,
                descripcionMenu = p.Descripcion,
                precioMenu = p.Precio,
                nivelCeliaquismo = p.id_Nivel,

            }).ToList();

            return Ok(res);
        }

        

        public IHttpActionResult CrearMenu(MenusViewModel menu)
        {
            var db = new FreeGlutenEntities();

            var menuNuevo = new Menus
            {
                Descripcion = menu.descripcionMenu,

            };
            db.Menus.Add(menuNuevo);

            var res = db.SaveChanges();
            if (res > 0)
            {
                return Ok(menuNuevo);
            }
            return BadRequest("nada");
        }
    }
}
