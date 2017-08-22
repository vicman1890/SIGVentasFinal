using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int idComprobante { get; set; }
        public int idArticulo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Cantidad { get; set; }
        public int idDetalleIngresoAlmacen { get; set; }

    }
}
