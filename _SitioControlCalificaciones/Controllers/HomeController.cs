using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _SitioControlCalificaciones.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace _SitioControlCalificaciones.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (new Dlls.Login().inicioSesion(model))
                    {
                        var data = new Dlls.Login().datosJson(model);
                    }

                    //Validacion en la base de datos
                    /*
                     * if(inicio de sesion true)
                     * {
                     *  todo bonis
                     *  return View("NuevaVista", model);
                     * }
                     * else
                     *  return View(model)
                     * 
                     */
                    
                }
                catch (Exception ex)
                {
                    var ver = ex.Message;
                }
            }
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
