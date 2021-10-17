using LABII.Dominio;
using LABII.Models;
using LABII.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LABII.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IPersona ipersona;

        public HomeController(ILogger<HomeController> logger,IPersona ipersona)
        {
            _logger = logger;
            this.ipersona = ipersona;
        }
        public IActionResult GetAll()
        {
            var FormatoJson = ipersona.Listar();
            return Json(new{data = FormatoJson});

        }
        public IActionResult save()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(persona psn)
        {
            if (!ModelState.IsValid)
            {

                return View("Save", psn);
            }
            else
            {
                persona persona = new persona();
                persona.NombrePersona = psn.NombrePersona;
                persona.EdadPersona = psn.EdadPersona;
                persona.DescripcionPersona = psn.DescripcionPersona;
                ipersona.Save(persona);
                return RedirectToAction("Index");

            }
            

        }

        public IActionResult Index()
        {
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
