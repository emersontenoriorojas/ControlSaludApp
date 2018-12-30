using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlSaludApp.Models;

namespace ControlSaludApp.Controllers
{
    public class SeguimientoController : Controller
    {
        spSeguimientoCred_Result spSeguimientoCred_Result = new spSeguimientoCred_Result();

        // GET: Seguimiento
        public ActionResult Index()
        {
            #region Lista de Redes
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "Red", Value = "0" });
            li.Add(new SelectListItem { Text = "Ica - Palpa - Nazca", Value = "1" });
            li.Add(new SelectListItem { Text = "Chincha - Pisco", Value = "2" });
            ViewData["red"] = li;
            return View();
            #endregion
            
        }

        public ActionResult GetRed()
        {
            return View();
        }

        public JsonResult GetMicrored(string id)
        {
            #region Lista de Microrredes
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
            #endregion

        }

        public JsonResult GetEstablecimiento(string id)
        {
            #region Lista de Establecimientos
            List<SelectListItem> establecimiento = new List<SelectListItem>();
            switch (id)
            {
                case "1":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Regional de Ica", Value = "Regional de Ica" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Maria del Socorro", Value = "Santa Maria del Socorro" });
                    establecimiento.Add(new SelectListItem { Text = "San Juan Bautista", Value = "San Juan Bautista" });
                    establecimiento.Add(new SelectListItem { Text = "Acomayo", Value = "Acomayo" });
                    establecimiento.Add(new SelectListItem { Text = "Fonavi IV", Value = "Fonavi IV" });
                    establecimiento.Add(new SelectListItem { Text = "San Martin de Porras", Value = "San Martin de Porras" });
                    establecimiento.Add(new SelectListItem { Text = "El Carmen - Olivo", Value = "El Carmen - Olivo" });
                    establecimiento.Add(new SelectListItem { Text = "Chanchajalla", Value = "Chanchajalla" });
                    establecimiento.Add(new SelectListItem { Text = "Pasaje Tinguiña Valle", Value = "Pasaje Tinguiña Valle" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Felix Torrealva", Value = "Essalud - Felix Torrealva" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Pnp - Ica", Value = "Sanidad Pnp - Ica" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Agusto Hernandez", Value = "Essalud - Agusto Hernandez" });
                    break;

                case "2":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "San Joaquin", Value = "San Joaquin" });
                    establecimiento.Add(new SelectListItem { Text = "Subtanjalla", Value = "Subtanjalla" });
                    establecimiento.Add(new SelectListItem { Text = "Guadalupe", Value = "Guadalupe" });
                    establecimiento.Add(new SelectListItem { Text = "Señor de Luren", Value = "Señor de Luren" });
                    establecimiento.Add(new SelectListItem { Text = "La Angostura", Value = "La Angostura" });
                    establecimiento.Add(new SelectListItem { Text = "Arrabales", Value = "Arrabales" });
                    establecimiento.Add(new SelectListItem { Text = "Yanquiza", Value = "Yanquiza" });
                    establecimiento.Add(new SelectListItem { Text = "Collazos", Value = "Collazos" });
                    establecimiento.Add(new SelectListItem { Text = "Cerro Prieto", Value = "Cerro Prieto" });
                    establecimiento.Add(new SelectListItem { Text = "Pampa de Villacuri", Value = "Pampa de Villacuri" });
                    establecimiento.Add(new SelectListItem { Text = "Camino de Reyes", Value = "Camino de Reyes" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Macacona", Value = "Essalud - Macacona" });
                    break;

                case "3":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Los Molinos", Value = "Los Molinos" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud-La Tinguiña", Value = "Essalud-La Tinguiña" });
                    establecimiento.Add(new SelectListItem { Text = "Parcona", Value = "Parcona" });
                    establecimiento.Add(new SelectListItem { Text = "Pampa de la Isla", Value = "Pampa de la Isla" });
                    establecimiento.Add(new SelectListItem { Text = "Huamani", Value = "Huamani" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Barbara", Value = "Santa Barbara" });
                    establecimiento.Add(new SelectListItem { Text = "Yaurilla", Value = "Yaurilla" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Chavalina", Value = "Essalud - Chavalina" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - La Tinguiña", Value = "Essalud - La Tinguiña" });
                    break;

                case "4":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "La Palma Grande", Value = "La Palma Grande" });
                    establecimiento.Add(new SelectListItem { Text = "Los Aquijes", Value = "Los Aquijes" });
                    establecimiento.Add(new SelectListItem { Text = "Cachiche", Value = "Cachiche" });
                    establecimiento.Add(new SelectListItem { Text = "El Huarango", Value = "El Huarango" });
                    establecimiento.Add(new SelectListItem { Text = "El Arenal", Value = "El Arenal" });
                    establecimiento.Add(new SelectListItem { Text = "Parina Chico", Value = "Parina Chico" });
                    establecimiento.Add(new SelectListItem { Text = "PP.JJ. El Rosario", Value = "PP.JJ. El Rosario" });
                    establecimiento.Add(new SelectListItem { Text = "Pampahuasi", Value = "Pampahuasi" });
                    establecimiento.Add(new SelectListItem { Text = "Cocharcas", Value = "Cocharcas" });
                    establecimiento.Add(new SelectListItem { Text = "San Jose de Curis", Value = "San Jose de Curis" });
                    establecimiento.Add(new SelectListItem { Text = "Huarangal", Value = "Huarangal" });
                    break;

                case "5":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Pueblo Nuevo", Value = "Pueblo Nuevo" });
                    establecimiento.Add(new SelectListItem { Text = "Tate", Value = "Tate" });
                    establecimiento.Add(new SelectListItem { Text = "Pachacutec", Value = "Pachacutec" });
                    establecimiento.Add(new SelectListItem { Text = "San Rafael", Value = "San Rafael" });
                    establecimiento.Add(new SelectListItem { Text = "Pariña Grande", Value = "Pariña Grande" });
                    establecimiento.Add(new SelectListItem { Text = "Callejon los Espinos", Value = "Callejon los Espinos" });
                    establecimiento.Add(new SelectListItem { Text = "Lujaraja", Value = "Lujaraja" });
                    establecimiento.Add(new SelectListItem { Text = "Puno", Value = "Puno" });
                    establecimiento.Add(new SelectListItem { Text = "Los Calderones", Value = "Los Calderones" });
                    establecimiento.Add(new SelectListItem { Text = "El Palto", Value = "El Palto" });
                    break;

                case "6":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Santiago", Value = "Santiago" });
                    establecimiento.Add(new SelectListItem { Text = "Ocucaje", Value = "Ocucaje" });
                    establecimiento.Add(new SelectListItem { Text = "La Venta", Value = "La Venta" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Dominguita", Value = "Santa Dominguita" });
                    establecimiento.Add(new SelectListItem { Text = "Aguada de Palos", Value = "Aguada de Palos" });
                    establecimiento.Add(new SelectListItem { Text = "Callango", Value = "Callango" });
                    establecimiento.Add(new SelectListItem { Text = "Cordova", Value = "Cordova" });
                    establecimiento.Add(new SelectListItem { Text = "Pampa Chacaltana", Value = "Pampa Chacaltana" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Santa Margarita", Value = "Essalud - Santa Margarita" });
                    break;


                case "7":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "De Apoyo de Palpa", Value = "De Apoyo de Palpa" });
                    establecimiento.Add(new SelectListItem { Text = "Rio Grande", Value = "Rio Grande" });
                    establecimiento.Add(new SelectListItem { Text = "Pueblo Nuevo", Value = "Pueblo Nuevo" });
                    establecimiento.Add(new SelectListItem { Text = "San Ignacio", Value = "San Ignacio" });
                    establecimiento.Add(new SelectListItem { Text = "Sacramento", Value = "Sacramento" });
                    establecimiento.Add(new SelectListItem { Text = "Saramarca", Value = "Saramarca" });
                    establecimiento.Add(new SelectListItem { Text = "Llipata", Value = "Llipata" });
                    establecimiento.Add(new SelectListItem { Text = "La Isla", Value = "La Isla" });
                    establecimiento.Add(new SelectListItem { Text = "Pampa Blanca", Value = "Pampa Blanca" });
                    establecimiento.Add(new SelectListItem { Text = "El Palmar", Value = "El Palmar" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Cruz", Value = "Santa Cruz" });
                    establecimiento.Add(new SelectListItem { Text = "San Francisco", Value = "San Francisco" });
                    establecimiento.Add(new SelectListItem { Text = "El Carmen", Value = "El Carmen" });
                    establecimiento.Add(new SelectListItem { Text = "Tibillos", Value = "Tibillos" });
                    establecimiento.Add(new SelectListItem { Text = "San Jacinto", Value = "San Jacinto" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Palpa", Value = "Essalud - Palpa" });
                    break;

                case "8":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "De Apoyo de Nazca", Value = "De Apoyo de Nazca" });
                    establecimiento.Add(new SelectListItem { Text = "Changuillo", Value = "Changuillo" });
                    establecimiento.Add(new SelectListItem { Text = "El Ingenio", Value = "El Ingenio" });
                    establecimiento.Add(new SelectListItem { Text = "Marcona", Value = "Marcona" });
                    establecimiento.Add(new SelectListItem { Text = "Vista Alegre", Value = "Vista Alegre" });
                    establecimiento.Add(new SelectListItem { Text = "San Luis de Pajonal", Value = "San Luis de Pajonal" });
                    establecimiento.Add(new SelectListItem { Text = "Cabildo", Value = "Cabildo" });
                    establecimiento.Add(new SelectListItem { Text = "La Isla", Value = "La Isla" });
                    establecimiento.Add(new SelectListItem { Text = "Coyungo", Value = "Coyungo" });
                    establecimiento.Add(new SelectListItem { Text = "San Javier", Value = "San Javier" });
                    establecimiento.Add(new SelectListItem { Text = "Tulin", Value = "Tulin" });
                    establecimiento.Add(new SelectListItem { Text = "Tupac Amaru", Value = "Tupac Amaru" });
                    establecimiento.Add(new SelectListItem { Text = "Copara", Value = "Copara" });
                    establecimiento.Add(new SelectListItem { Text = "Las Trancas", Value = "Las Trancas" });
                    establecimiento.Add(new SelectListItem { Text = "Taruga", Value = "Taruga" });
                    establecimiento.Add(new SelectListItem { Text = "Buena Fe", Value = "Buena Fe" });
                    establecimiento.Add(new SelectListItem { Text = "Las Cañas", Value = "Las Cañas" });
                    establecimiento.Add(new SelectListItem { Text = "San Miguel de la Pascana", Value = "San Miguel de la Pascana" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Maria Reiche Neuman", Value = "Essalud - Maria Reiche Neuman" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Nazca", Value = "Essalud - Nazca" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Pnp - Nazca", Value = "Sanidad Pnp - Nazca" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Naval - Combatuan", Value = "Sanidad Naval - Combatuan" });
                    break;

                case "9":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "San Jose de Chincha", Value = "San Jose de Chincha" });
                    establecimiento.Add(new SelectListItem { Text = "Grocio Prado", Value = "Grocio Prado" });
                    establecimiento.Add(new SelectListItem { Text = "Sunampe", Value = "Sunampe" });
                    establecimiento.Add(new SelectListItem { Text = "Condorillo Alto", Value = "Condorillo Alto" });
                    establecimiento.Add(new SelectListItem { Text = "Topara", Value = "Topara" });
                    establecimiento.Add(new SelectListItem { Text = "Balconcito", Value = "Balconcito" });
                    establecimiento.Add(new SelectListItem { Text = "Cruz Blanca", Value = "Cruz Blanca" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Rene Toche Groppo", Value = "Essalud - Rene Toche Groppo" });
                    break;

                case "10":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Chincha Baja", Value = "Chincha Baja" });
                    establecimiento.Add(new SelectListItem { Text = "El Carmen", Value = "El Carmen" });
                    establecimiento.Add(new SelectListItem { Text = "Tambo de Mora", Value = "Tambo de Mora" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Rosa", Value = "Santa Rosa" });
                    establecimiento.Add(new SelectListItem { Text = "Lurinchincha", Value = "Lurinchincha" });
                    establecimiento.Add(new SelectListItem { Text = "Hoja Redonda", Value = "Hoja Redonda" });
                    establecimiento.Add(new SelectListItem { Text = "Wiracocha", Value = "Wiracocha" });
                    establecimiento.Add(new SelectListItem { Text = "San Jose", Value = "San Jose" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Tambo de Mora", Value = "Essalud - Tambo de Mora" });
                    break;

                case "11":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Alto Laran", Value = "Alto Laran" });
                    establecimiento.Add(new SelectListItem { Text = "Pueblo Nuevo", Value = "Pueblo Nuevo" });
                    establecimiento.Add(new SelectListItem { Text = "Aylloque", Value = "Aylloque" });
                    establecimiento.Add(new SelectListItem { Text = "Huachinga", Value = "Huachinga" });
                    establecimiento.Add(new SelectListItem { Text = "Chavin", Value = "Chavin" });
                    establecimiento.Add(new SelectListItem { Text = "San Isidro", Value = "San Isidro" });
                    establecimiento.Add(new SelectListItem { Text = "Los Alamos", Value = "Los Alamos" });
                    establecimiento.Add(new SelectListItem { Text = "El Salvador", Value = "El Salvador" });
                    establecimiento.Add(new SelectListItem { Text = "San Juan de Yanac", Value = "San Juan de Yanac" });
                    establecimiento.Add(new SelectListItem { Text = "Huañupiza", Value = "Huañupiza" });
                    establecimiento.Add(new SelectListItem { Text = "San Pedro de Huacarpana", Value = "San Pedro de Huacarpana" });
                    establecimiento.Add(new SelectListItem { Text = "Liscay", Value = "Liscay" });
                    establecimiento.Add(new SelectListItem { Text = "Bellavista", Value = "Bellavista" });
                    establecimiento.Add(new SelectListItem { Text = "Vista Alegre", Value = "Vista Alegre" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Pueblo Nuevo", Value = "Essalud - Pueblo Nuevo" });
                    establecimiento.Add(new SelectListItem { Text = "San Agustin", Value = "San Agustin" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Pnp - Chincha", Value = "Sanidad Pnp - Chincha" });
                    break;

                case "12":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Humay", Value = "Humay" });
                    establecimiento.Add(new SelectListItem { Text = "Independencia", Value = "Independencia" });
                    establecimiento.Add(new SelectListItem { Text = "San Clemente", Value = "San Clemente" });
                    establecimiento.Add(new SelectListItem { Text = "Huancano", Value = "Huancano" });
                    establecimiento.Add(new SelectListItem { Text = "Pampano", Value = "Pampano" });
                    establecimiento.Add(new SelectListItem { Text = "Bernales", Value = "Bernales" });
                    establecimiento.Add(new SelectListItem { Text = "Los Paracas", Value = "Los Paracas" });
                    establecimiento.Add(new SelectListItem { Text = "Cabeza de Toro Lateral 4", Value = "Cabeza de Toro Lateral 4" });
                    establecimiento.Add(new SelectListItem { Text = "Dos Palmas", Value = "Dos Palmas" });
                    establecimiento.Add(new SelectListItem { Text = "Cabeza de Toro Lateral 5", Value = "Cabeza de Toro Lateral 5" });
                    establecimiento.Add(new SelectListItem { Text = "Toma de Leon", Value = "Toma de Leon" });
                    establecimiento.Add(new SelectListItem { Text = "San Jose de Condor", Value = "San Jose de Condor" });
                    establecimiento.Add(new SelectListItem { Text = "Camacho", Value = "Camacho" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - San Clemente", Value = "Essalud - San Clemente" });
                    break;

                case "13":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "Tupac Amaru", Value = "Tupac Amaru" });
                    establecimiento.Add(new SelectListItem { Text = "San Miguel", Value = "San Miguel" });
                    establecimiento.Add(new SelectListItem { Text = "Cuchilla Vieja", Value = "Cuchilla Vieja" });
                    establecimiento.Add(new SelectListItem { Text = "Santa Cruz", Value = "Santa Cruz" });
                    establecimiento.Add(new SelectListItem { Text = "Casalla", Value = "Casalla" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Tupac Amaru", Value = "Essalud - Tupac Amaru" });
                    break;

                case "14":
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "0" });
                    establecimiento.Add(new SelectListItem { Text = "San Juan de Dios", Value = "San Juan de Dios" });
                    establecimiento.Add(new SelectListItem { Text = "Paracas", Value = "Paracas" });
                    establecimiento.Add(new SelectListItem { Text = "San Andres", Value = "San Andres" });
                    establecimiento.Add(new SelectListItem { Text = "San Martin de Porres", Value = "San Martin de Porres" });
                    establecimiento.Add(new SelectListItem { Text = "Laguna Grande", Value = "Laguna Grande" });
                    establecimiento.Add(new SelectListItem { Text = "La Esperanza", Value = "La Esperanza" });
                    establecimiento.Add(new SelectListItem { Text = "San Juan de Dios", Value = "San Juan de Dios" });
                    establecimiento.Add(new SelectListItem { Text = "Essalud - Antonio Skrabonja Antoncich", Value = "ssalud - Antonio Skrabonja Antoncich" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Pnp - Pisco", Value = "Sanidad Pnp - Pisco" });
                    establecimiento.Add(new SelectListItem { Text = "Sanidad Fap - Pisco", Value = "Sanidad Fap - Pisco" });
                    break;
                default:
                    establecimiento.Add(new SelectListItem { Text = "Establecimiento", Value = "1" });
                    break;
            }
            return Json(new SelectList(establecimiento, "Value", "Text"));
            #endregion

        }

        DIRESAEntities1 DIRESAEntities1 = new DIRESAEntities1();


        public List<spSeguimientoCred_Result> GetSeguimiento(string Establecimiento)
        {
            //Establecimiento = spSeguimientoCred_Result.Establecimiento;
            var cadena = ConfigurationManager.ConnectionStrings["Cnn"].ConnectionString;
            List<spSeguimientoCred_Result> lista = new List<spSeguimientoCred_Result>();
            using (var cn = new SqlConnection(cadena))
            {
                try
                {
                    cn.Open();
                    using (var cmd = cn.CreateCommand())
                    {
                        cmd.CommandText = "spSeguimientoCred";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@textobuscar2", Establecimiento);
                        var drd = cmd.ExecuteReader();

                        while (drd.Read())
                        {
                            var atenciones = new spSeguimientoCred_Result();
                            atenciones.DNI = drd.GetString(drd.GetOrdinal("DNI"));
                            atenciones.APELLIDO_PATERNO = drd.GetString(drd.GetOrdinal("APELLIDO PATERNO"));
                            atenciones.APELLIDO_MATERNO = drd.GetString(drd.GetOrdinal("APELLIDO MATERNO"));
                            atenciones.NOMBRES_DEL_NIÑO = drd.GetString(drd.GetOrdinal("NOMBRES DEL NIÑO"));
                            atenciones.FECHA_DE_NACIMIENTO = drd.GetDateTime(drd.GetOrdinal("FECHA DE NACIMIENTO"));
                            atenciones.EDAD = drd.GetString(drd.GetOrdinal("EDAD"));
                            atenciones.TIPO_DE_SEGURO = drd.GetString(drd.GetOrdinal("TIPO DE SEGURO"));
                            atenciones.PROGRAMAS_SOCIALES = drd.GetString(drd.GetOrdinal("PROGRAMA SOCIAL"));
                            atenciones.CENTRO_POBLADO = drd.GetString(drd.GetOrdinal("NOMBRE DE CENTRO POBLADO"));
                            atenciones.Establecimiento_Ultimo_Control = drd.GetString(drd.GetOrdinal("ESTABLECIMIENTO"));
                            atenciones.UltimoControlCred = drd.GetString(drd.GetOrdinal("UltimoControlCred"));
                            atenciones.ProximoControlCred = drd.GetString(drd.GetOrdinal("ProximoControlCred"));
                            lista.Add(atenciones);
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    if (cn.State == ConnectionState.Open) cn.Close();
                }
            }

            return lista;
        }

        [HttpPost]
        public string Parametro(string Establecimiento)
        {
            return Establecimiento;
        }

        public JsonResult Seguimiento(string Establecimiento)
        {
            Establecimiento = "Santa Maria del Socorro";
            return Json(GetSeguimiento(Establecimiento).ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}