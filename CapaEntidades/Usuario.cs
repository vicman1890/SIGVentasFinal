using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string Dni { get; set; }
        public Decimal Salario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int idTipoUsuario { get; set; }
        public Boolean Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string DiaPago { get; set; }
        public string DiaDescanso { get; set; }

    }
}
