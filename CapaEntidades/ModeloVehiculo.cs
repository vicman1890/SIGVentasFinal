using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class ModeloVehiculo
    {

        public int idModeloVehiculo { get; set; }
        public int idMarcaVehiculo { get; set; }
        public String Descripcion { get; set; }
        public int TipoVehiculo { get; set; }
        public Boolean Estado { get; set; }
    }
}
