using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class DetalleIngresoNEG
    {
        public static DetalleIngresoNEG _Instancia;
        private DetalleIngresoNEG() { }
        public static DetalleIngresoNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new DetalleIngresoNEG();
            }
            return _Instancia;

        }

        public DetalleIngresoAlmacen obtenerPrecioVenta(int id)
        {
            return DetalleIngresoAlmacenDAO.Instancia().obtenerPrecioVenta(id);
        }

    }
}
