using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class PartidoController : Controller
    {
        Sistema s = Sistema.Instancia;

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                return View(s.GetPartidos());
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ListarFinalizados()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Periodista")
            {
                return View(s.GetPartidosCerrados());
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult PartidosEntreFechas()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult PartidosEntreFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            return View(s.GetPartidosEntreFechas(fechaInicial, fechaFinal));
        }

        [HttpGet]
        public IActionResult FinalizarPartido(int id)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador" && !s.GetPartido(id).Finalizado)
            {
                ViewBag.get = true;
                ViewBag.confirmacion = false;
                return View(s.GetPartido(id));
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult FinalizarPartido(int id, bool confirmacion)
        {
            ViewBag.get = false;
            ViewBag.confirmacion = confirmacion;
            if (confirmacion)
            {
                s.FinalizarPartido(id);
                ViewBag.msg = "Partido finalizado con éxito!";
            }
            else
            {
                ViewBag.msg = "Debe confirmar la finalización";
            }
            return View(s.GetPartido(id));
        }
    }
}
