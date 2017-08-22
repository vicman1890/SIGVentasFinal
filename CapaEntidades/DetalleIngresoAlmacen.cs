using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class DetalleIngresoAlmacen
    {
        public int idDetalleIngresoAlmacen { get; set; }
        public int idIngresoAlmacen { get; set; }
        public int idArticulo { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public int CantidadFinal { get; set; }
    }
}
