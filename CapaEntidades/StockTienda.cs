using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class StockTienda
    {
        public StockTienda()
        {
            this.Lineas = new List<DetalleStockTienda>();
        }

        public int idStockTienda { get; set; }
        public DateTime FechaIngresoTienda { get; set; }
        public int idUsuario { get; set; }
        public bool Estado { get; set; }
        public List<DetalleStockTienda> Lineas { get; set; }
    }
}
