//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlSaludApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class trabajador
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
        public System.DateTime fech_nac { get; set; }
        public string DNI { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string establecimiento { get; set; }
        public string acceso { get; set; }
        [Required(ErrorMessage = "Ingrese el usuario")]
        public string usuario { get; set; }
        [Required(ErrorMessage = "Ingrese la contraseña")]
        public string contraseña { get; set; }

        public string LoginErrorMessagge { get; set; }

        public static IEnumerable<SelectListItem> Sexo()
        {
            IList<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem {Text = "Sexo", Value= null},
                new SelectListItem {Text = "Maculino", Value= "M"},
                new SelectListItem {Text = "Femenino", Value= "F"}
            };
            return items;
        }
    }
}
