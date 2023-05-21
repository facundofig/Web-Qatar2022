using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class OperadorController : Controller
    {
        Sistema s = Sistema.Instancia;

        [HttpGet]
        public IActionResult Estadisticas()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                ViewBag.selecciones = s.GetSeleccionesMasGoles();
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Estadisticas(string emailBuscado)
        {
            ViewBag.selecciones = s.GetSeleccionesMasGoles();
            return View(s.GetPartidosTarjetaRojaPeriodista(emailBuscado));
        }
    }
}
