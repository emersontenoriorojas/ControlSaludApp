using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlSaludApp.Models
{
    public class CredViewModel
    {
        public string DNI { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELLIDO_MATERNO { get; set; }
        public string NOMBRES_DEL_NIÑO { get; set; }
        public Nullable<System.DateTime> FECHA_DE_NACIMIENTO { get; set; }
        public string EDAD { get; set; }
        public string TIPO_DE_SEGURO { get; set; }
        public string PROGRAMAS_SOCIALES { get; set; }
        public string CENTRO_POBLADO { get; set; }
        public string DIRECCION { get; set; }
        public string Establecimiento_Ultimo_Control { get; set; }
        public string UltimoControlCred { get; set; }
        public string ProximoControlCred { get; set; }
        public string Establecimiento { get; set; }
    }
}