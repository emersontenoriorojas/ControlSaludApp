using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlSaludApp.Models;

namespace ControlSaludApp.Controllers
{
    public class HomeController : Controller
    {
        DIRESAEntities db = new DIRESAEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Usuarios(trabajador trabajador)
        {
            // Metodo para obtener un trabajador e insertar en la base de datos
            return View();
        }

        

        public ActionResult Historial()
        {
            return View();
        }
        

        public ActionResult ObtenerRed()
        {
            return View();
        }
    }
}