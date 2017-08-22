using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;
using System.Data;
using System.Transactions;

namespace CapaNegocio
{
    public  class DetalleVentaNEG
    {

        public static DetalleVentaNEG _Instancia;
        private DetalleVentaNEG() { }
        public static DetalleVentaNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new DetalleVentaNEG();
            }
            return _Instancia;

        }

        //Metodo utilizado para obtener el descuento del detalle de la venta
        //si la venta supera los 50 soles, dolares, euros, etc
        //se le hace un descuento del 5% del detalle de la venta
        public static decimal ObtenerDescuento(decimal cantidad, decimal pu)
        {
            if ((cantidad * pu) > 50)
            {
                decimal porcentaje = Convert.ToDecimal(0.05);
                decimal descuento = ((cantidad * pu) * porcentaje);
                return descuento;
            }
            else
            {
                return 0;
            }
        }

        public DataTable listarDetalleVentas(int idVenta)
        {
            return DetalleVentaDAO.Instancia().ListarDetalleVenta(idVenta);
        }
    }
}
