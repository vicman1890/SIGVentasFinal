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
    public class StockTiendaNEG
    {

            public static StockTiendaNEG _Instancia;
            private StockTiendaNEG() { }
            public static StockTiendaNEG Instancia()
            {
                if (_Instancia == null)
                {
                    _Instancia = new StockTiendaNEG();
                }
                return _Instancia;


        }
        public static void RegistrarIngresoTienda(StockTienda c)
        {

            //
            // inicializo la transacciones
            //
            using (TransactionScope scope = new TransactionScope())
            {
                //
                // Creo la factura y sus lineas
                //
                StockTiendaDAO.Create(c);

                //
                // Actualizo el total
                //
                //InvoiceDAL.UpdateTotal(invoice.InvoiceId, invoice.Total);

                scope.Complete();
            }

        }

        public DetalleStockTienda ObtenerStockActual(int id)
        {
            return StockTiendaDAO.Instancia().stockActual(id);
        }

        public String reducirStock(int id, int cantidad)
        {
            return StockTiendaDAO.Instancia().disminuirStock(id, cantidad);
        }

        public DataTable listarIngresosStock()
        {
            return StockTiendaDAO.Instancia().ListarIngresosTienda();
        }
    }
}
