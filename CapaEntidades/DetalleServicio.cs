using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class DetalleServicio
    {
      
        public int idDetalleServicio { get; set; }
        public int idVehiculo { get; set; }
        public int idServicio { get; set; }
        public Boolean Lavado { get; set; }
        public Boolean Encerado { get; set; }
        public Boolean Motor { get; set; }
        public DateTime FechaServicio { get; set; }

    }
}
