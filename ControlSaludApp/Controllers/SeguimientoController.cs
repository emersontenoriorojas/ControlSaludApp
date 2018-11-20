using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlSaludApp.Controllers
{
    public class SeguimientoController : Controller
    {
        // GET: Seguimiento
        public ActionResult Index()
        {

            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "Red", Value = "0" });
            li.Add(new SelectListItem { Text = "Ica - Palpa - Nazca", Value = "1" });
            li.Add(new SelectListItem { Text = "Chincha - Pisco", Value = "2" });
            ViewData["red"] = li;
            return View();
        }

        public ActionResult GetRed()
        {
            return View();
        }

        public JsonResult GetMicrored(string id)
        {
            List<SelectListItem> microred = new List<SelectListItem>();
            switch (id)
            {
                case "1":
                    microred.Add(new SelectListItem { Text = "Microred", Value = "0" });
                    microred.Add(new SelectListItem { Text = "Ica", Value = "1" });
                    microred.Add(new SelectListItem { Text = "San Joaquin", Value = "2" });
                    microred.Add(new SelectListItem { Text = "Tinguiña/Parcona", Value = "3" });
                    microred.Add(new SelectListItem { Text = "La Palma", Value = "4" });
                    microred.Add(new SelectListItem { Text = "Pueblo Nuevo", Value = "5" });
                    microred.Add(new SelectListItem { Text = "Santiago", Value = "6" });
                    microred.Add(new SelectListItem { Text = "Palpa", Value = "7" });
                    microred.Add(new SelectListItem { Text = "Nazca", Value = "8" });
                    
                    break;

                case "2":
                    microred.Add(new SelectListItem { Text = "Microred", Value = "9" });
                    microred.Add(new SelectListItem { Text = "Chincha", Value = "10" });
                    microred.Add(new SelectListItem { Text = "Chincha Baja", Value = "11" });
                    microred.Add(new SelectListItem { Text = "Pueblo Nuevo", Value = "12" });                    
                    microred.Add(new SelectListItem { Text = "San Clemente", Value = "13" });
                    microred.Add(new SelectListItem { Text = "Tupac Amaru Inca", Value = "14" });
                    microred.Add(new SelectListItem { Text = "Pisco", Value = "15" });
                    break;
                default:
                    microred.Add(new SelectListItem { Text = "Microred", Value = "0" });
                    break;
            }
            return Json(new SelectList(microred, "Value", "Text"));
        }

        public JsonResult GetEstablecimiento(string id)
        {
            List<SelectListItem> establecimiento = new List<SelectListItem>();
            switch (id)
            {
                case "1":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Regional de Ica", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Maria del Socorro", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "San Juan Bautista", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Acomayo", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Fonavi IV", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "San Martin de Porras", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "El Carmen - Olivo", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Chanchajalla", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Pasaje Tinguiña Valle", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Felix Torrealva", Value = "10" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Pnp - Ica", Value = "11" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Agusto Hernandez", Value = "12" });
                    break;

                case "2":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "San Joaquin", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Subtanjalla", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Guadalupe", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Señor de Luren", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "La Angostura", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Arrabales", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Yanquiza", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Collazos", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Cerro Prieto", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "Pampa de Villacuri", Value = "10" });
                    establecimiento.Add(new SelectListItem { Text = "Camino de Reyes", Value = "11" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Macacona", Value = "12" });
                    break;

                case "3":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Los Molinos", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud-La Tinguiña", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Parcona", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Pampa de la Isla", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Huamani", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Barbara", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Yaurilla", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Chavalina", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - La Tinguiña", Value = "9" });
                    break;

                case "4":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "La Palma Grande", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Los Aquijes", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Cachiche", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "El Huarango", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "El Arenal", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Parina Chico", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "PP.JJ. El Rosario", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Pampahuasi", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Cocharcas", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "San Jose de Curis", Value = "10" });
                    establecimiento.Add(new SelectListItem { Text = "Huarangal", Value = "11" });
                    break;

                case "5":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Pueblo Nuevo", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Tate", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Pachacutec", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "San Rafael", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Pariña Grande", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Callejon los Espinos", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Lujaraja", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Puno", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Los Calderones", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "El Palto", Value = "10" });
                    break;

                case "6":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Santiago", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Ocucaje", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "La Venta", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Dominguita", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Aguada de Palos", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Callango", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Cordova", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Pampa Chacaltana", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Santa Margarita", Value = "9" });
                    break;


                case "7":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "De Apoyo de Palpa", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Rio Grande", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Pueblo Nuevo", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "San Ignacio", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Sacramento", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Saramarca", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Llipata", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "La Isla", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Pampa Blanca", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "El Palmar", Value = "10" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Cruz", Value = "11" });
                    establecimiento.Add(new SelectListItem { Text = "San Francisco", Value = "12" });
                    establecimiento.Add(new SelectListItem { Text = "El Carmen", Value = "13" });
                    establecimiento.Add(new SelectListItem { Text = "Tibillos", Value = "14" });
                    establecimiento.Add(new SelectListItem { Text = "San Jacinto", Value = "15" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Palpa", Value = "16" });
                    break;

                case "8":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "De Apoyo de Nazca", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Changuillo", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "El Ingenio", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Marcona", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Vista Alegre", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "San Luis de Pajonal", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Cabildo", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "La Isla", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Coyungo", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "San Javier", Value = "10" });
                    establecimiento.Add(new SelectListItem { Text = "Tulin", Value = "11" });
                    establecimiento.Add(new SelectListItem { Text = "Tupac Amaru", Value = "12" });
                    establecimiento.Add(new SelectListItem { Text = "Copara", Value = "13" });
                    establecimiento.Add(new SelectListItem { Text = "Las Trancas", Value = "14" });
                    establecimiento.Add(new SelectListItem { Text = "Taruga", Value = "15" });
                    establecimiento.Add(new SelectListItem { Text = "Buena Fe", Value = "16" });
                    establecimiento.Add(new SelectListItem { Text = "Las Cañas", Value = "17" });
                    establecimiento.Add(new SelectListItem { Text = "San Miguel de la Pascana", Value = "18" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Maria Reiche Neuman", Value = "19" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Nazca", Value = "20" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Pnp - Nazca", Value = "21" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Naval - Combatuan", Value = "22" });
                    break;

                case "9":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "San Jose de Chincha", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Grocio Prado", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Sunampe", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Condorillo Alto", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Topara", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Balconcito", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Cruz Blanca", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Rene Toche Groppo", Value = "8" });
                    break;

                case "10":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Chincha Baja", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "El Carmen", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Tambo de Mora", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Rosa", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Lurinchincha", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Hoja Redonda", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Wiracocha", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "San Jose", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Tambo de Mora", Value = "9" });
                    break;

                case "11":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Alto Laran", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Pueblo Nuevo", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Aylloque", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Huachinga", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Chavin", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "San Isidro", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Los Alamos", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "El Salvador", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "San Juan de Yanac", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "Huañupiza", Value = "10" });
                    establecimiento.Add(new SelectListItem { Text = "San Pedro de Huacarpana", Value = "11" });
                    establecimiento.Add(new SelectListItem { Text = "Liscay", Value = "12" });
                    establecimiento.Add(new SelectListItem { Text = "Bellavista", Value = "13" });
                    establecimiento.Add(new SelectListItem { Text = "Vista Alegre", Value = "14" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Pueblo Nuevo", Value = "15" });
                    establecimiento.Add(new SelectListItem { Text = "San Agustin", Value = "16" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Pnp - Chincha", Value = "17" });
                    break;

                case "12":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Humay", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Independencia", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "San Clemente", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Huancano", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Pampano", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Bernales", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "Los Paracas", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Cabeza de Toro Lateral 4", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Dos Palmas", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "Cabeza de Toro Lateral 5", Value = "10" });
                    establecimiento.Add(new SelectListItem { Text = "Toma de Leon", Value = "11" });
                    establecimiento.Add(new SelectListItem { Text = "San Jose de Condor", Value = "12" });
                    establecimiento.Add(new SelectListItem { Text = "Camacho", Value = "13" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - San Clemente", Value = "14" });
                    break;

                case "13":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Tupac Amaru", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "San Miguel", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "Cuchilla Vieja", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Cruz", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Casalla", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Tupac Amaru", Value = "6" });
                    break;

                case "14":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "San Juan de Dios", Value = "1" });
                    establecimiento.Add(new SelectListItem { Text = "Paracas", Value = "2" });
                    establecimiento.Add(new SelectListItem { Text = "San Andres", Value = "3" });
                    establecimiento.Add(new SelectListItem { Text = "San Martin de Porres", Value = "4" });
                    establecimiento.Add(new SelectListItem { Text = "Laguna Grande", Value = "5" });
                    establecimiento.Add(new SelectListItem { Text = "La Esperanza", Value = "6" });
                    establecimiento.Add(new SelectListItem { Text = "San Juan de Dios", Value = "7" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Antonio Skrabonja Antoncich", Value = "8" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Pnp - Pisco", Value = "9" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Fap - Pisco", Value = "10" });
                    break;
                default:
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    break;
            }
            return Json(new SelectList(establecimiento, "Value", "Text"));
        }
    }
}