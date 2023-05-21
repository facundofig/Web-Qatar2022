using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Sistema s = Sistema.Instancia;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string logueadoNombre = HttpContext.Session.GetString("logueadoNombre");
            if (logueadoNombre != null)
            {
                ViewBag.msg = $"Bienvenido al sistema {logueadoNombre}";
            }
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("logueadoId") == null)
            {
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Login(string email, string pass)
        {
            Usuario buscado = s.Login(email, pass);
            if (buscado != null)
            {
                HttpContext.Session.SetInt32("logueadoId", buscado.Id);
                HttpContext.Session.SetString("logueadoNombre", buscado.Nombre + " " + buscado.Apellido);
                HttpContext.Session.SetString("logueadoRol", buscado.GetTipo());

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.msg = "Credenciales incorrectas";
                return View();
            }
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetInt32("logueadoId") != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
