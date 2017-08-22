using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Venta
    {
        
        public Venta()
        {
            this.Lineas = new List<DetalleVenta>();
        }
        
        public int idVenta { get; set; }
        
        public DateTime FechaVenta { get; set; }
        public decimal SubTotalVenta { get; set; }
        public decimal IgvVenta { get; set; }
        public int idCliente { get; set; }
        public decimal TotalVenta { get; set; }
        public int idUsuario { get; set; }
        public Boolean Estado { get; set; }
        public List<DetalleVenta> Lineas { get; set; }
        public String Correlativo { get; set; }
        public String NroDocumento { get; set; }
        public int idTipoComprobante { get; set; }
    }
}
