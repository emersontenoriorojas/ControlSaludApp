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
        //[ValidateAntiForgeryToken]
        public ActionResult Authorize(trabajador trabajadorModel)
        {
            using (DIRESAEntities db = new DIRESAEntities())
            {
                var userDetails = db.trabajadors.Where(x => x.usuario == trabajadorModel.usuario && x.contraseña == trabajadorModel.contraseña).FirstOrDefault();
                if (userDetails == null)
                {
                    trabajadorModel.LoginErrorMessagge = "Usuario o contraseña no valido";
                    return View("Index", trabajadorModel);
                }
                else
                {
                    Session["DNI"] = userDetails.DNI;
                    Session["usuario"] = userDetails.usuario;
                    Session["apellidos"] = userDetails.apellidos;
                    Session["nombre"] = userDetails.nombre;
                    Session["acceso"] = userDetails.acceso;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {
            //int dniUser = (int)Session["DNI"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}