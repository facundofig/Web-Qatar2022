using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class PeriodistaController : Controller
    {
        Sistema s = Sistema.Instancia;

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                return View(s.GetPeriodistas());
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("logueadoId") == null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Create(Periodista p)
        {
            try
            {
                s.AltaUsuario(p);
                ViewBag.msg = "Alta realizada con éxito!";
            }
            catch (Exception e)
            {
                ViewBag.msg = e.Message;
            }
            return View();

        }

        public IActionResult MisResenas()
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Periodista")
            {
                return View(s.GetResenasDePeriodista(HttpContext.Session.GetInt32("logueadoId")));
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ListarResenas(int id)
        {
            if (HttpContext.Session.GetString("logueadoRol") == "Operador")
            {
                return View(s.GetResenasDePeriodista(id));
            }
            return RedirectToAction("Index");
        }
    }
}
