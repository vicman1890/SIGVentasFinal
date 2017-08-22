using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Transactions;
using CapaDatos;

namespace CapaNegocio
{
    public class IngresoAlmacenNEG
    {

        public static IngresoAlmacenNEG _Instancia;
        private IngresoAlmacenNEG() { }
        public static IngresoAlmacenNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new IngresoAlmacenNEG();
            }
            return _Instancia;

        }

        public static void RegistrarIngreso(IngresoAlmacen c)
        {
            //
            // inicializo la transacciones
            //
            using (TransactionScope scope = new TransactionScope())
            {
                //
                // Creo la factura y sus lineas
                //
                IngresoAlmacenDAO.Create(c);

                //
                // Actualizo el total
                //
                //InvoiceDAL.UpdateTotal(invoice.InvoiceId, invoice.Total);

                scope.Complete();
            }

        }

        public DetalleIngresoAlmacen ObtenerStockActual(int id)
        {
            return IngresoAlmacenDAO.Instancia().stockActual(id);
        }

        public DataTable listarIngresos()
        {
            return IngresoAlmacenDAO.Instancia().ListarIngresosAlmacen();
        }

        public DataTable reporteStockAlmacen()
        {
            return IngresoAlmacenDAO.Instancia().ReporteStockAlmacen();
        }
    }
}
