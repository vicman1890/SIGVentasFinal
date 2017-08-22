using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Ruc { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Boolean Estado { get; set; }
    }
}
