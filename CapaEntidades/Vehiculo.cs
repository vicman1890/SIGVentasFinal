using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidades
{
    public class Vehiculo
    {
        public int idVehiculo { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        //public virtual ICollection<MarcaVehiculo> Marca { get; set; }
        //public virtual ICollection<ModeloMarca> Modelo { get; set; }
        public int idMarca { get; set; }
        public int idModelo { get; set; }
        public int idCliente { get; set; }
        public Boolean Estado { get; set; }

    }
}
