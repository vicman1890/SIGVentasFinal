using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        public string Codigo { get; set; }
        public string BarCode { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public int idTallaArticulo { get; set; }
        public int idColorArticulo { get; set; }
        public int idEstiloArticulo { get; set; }
        public int idGeneroArticulo { get; set; }
    }
}
