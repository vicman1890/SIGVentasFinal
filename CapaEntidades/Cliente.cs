using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Ruc { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        /*public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }*/
        public bool Estado { get; set; }

    }
}
