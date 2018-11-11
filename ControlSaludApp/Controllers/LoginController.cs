using System.Linq;
using System.Web.Mvc;
using ControlSaludApp.Models;
using System.Web;

namespace ControlSaludApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(trabajador trabajadorModel)
        {
            using (DIRESAEntities db = new DIRESAEntities())
            {
                var userDetails = db.trabajadors.Where(x => x.usuario == trabajadorModel.usuario && x.contraseña == trabajadorModel.contraseña);
                if (userDetails == null)
                {
                    Session["nombre"] = trabajadorModel.nombre;
                    Session["apellidos"] = trabajadorModel.apellidos;
                    return RedirectToAction("Index", "Home");
                }
                else
                {              
                    trabajadorModel.LoginErrorMessagge = "Usuario o contraseña no valido";
                    return View("Index");
                }
            }
        }

    }
}