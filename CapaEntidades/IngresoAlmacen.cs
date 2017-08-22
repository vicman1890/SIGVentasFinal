using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class IngresoAlmacen
    {
        public IngresoAlmacen()
        {
            this.Lineas = new List<DetalleIngresoAlmacen>();
        }
        
        public int idIngresoAlmacen { get; set; }
        public int idTipoComprobante { get; set; }
        public String Serie { get; set; }
        public String NroDocumento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal subTotal { get; set; }
        public decimal igv { get; set; }
        public int idProveedor { get; set; }
        public decimal TotalPagado { get; set; }
        public decimal descripcion { get; set; }
        public List<DetalleIngresoAlmacen> Lineas { get; set; }
        public int idUsuario { get; set; }
        public bool Estado { get; set; }

    }
}
