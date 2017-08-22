using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class EgresosCaja
    {
        public int id { get; set; }
        public decimal monto { get; set; }
        public String descripcion { get; set; }
        public DateTime fecha { get; set; }
    }
}
