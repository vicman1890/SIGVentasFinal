using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class DetalleStockTienda
    {
        public int idDetalleStockTienda { get; set; }
        public int idStockTienda { get; set; }
        public int idArticulo { get; set; }
        public int idUsuario { get; set; }
        public int idDetalleIngresoAlmacen { get; set; }
        public int StockInicial { get; set; }
        public int StockFinal { get; set; }
    }
}
