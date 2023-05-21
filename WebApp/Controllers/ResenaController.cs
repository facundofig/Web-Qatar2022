using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ResenaController : Controller
    {
        Sistema s = Sistema.Instancia;

        [HttpGet]
        public IActionResult Create(int id)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Periodista" && s.GetPartido(id).Finalizado)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Create(Resena r, int id)
        {
            try
            {
                r.Periodista = s.GetPeriodista(HttpContext.Session.GetInt32("logueadoId"));
                r.Fecha = DateTime.Now;
                r.Partido = s.GetPartido(id);
                s.AltaResena(r);
                ViewBag.msg = "Reseña ingresada con éxito!";
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
            }
            return View();
        }
    }
}
