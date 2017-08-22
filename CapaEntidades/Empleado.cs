using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Empleado
    {

        public int idEmpleado { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string direccionDomicilio { get; set; }
        public string dni { get; set; }
        public string numeroCelular { get; set; }
        public string numeroFijo { get; set; }
        public string idSalario { get; set; }
        public string idFrecuenciaPago { get; set; }
        public Boolean estado { get; set; }
    }
}
