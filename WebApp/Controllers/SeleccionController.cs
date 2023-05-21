using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class SeleccionController : Controller
    {
        Sistema s = Sistema.Instancia;
        
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("logueadoId") == null || HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                return View(s.GetSelecciones());
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
