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
    public class VentaNEG
    {

        public static VentaNEG _Instancia;
        private VentaNEG() { }
        public static VentaNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new VentaNEG();
            }
            return _Instancia;

        }

        //ComprobanteDAO dao = new ComprobanteDAO();
        //Comprobante ent = new Comprobante();


        /*public Boolean Guardar(Comprobante c)
        {
            ComprobanteDAO dao = new ComprobanteDAO();     
            
            return dao.Guardar(c);



        }*/

        public List<Venta> Buscar(Venta c)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(c);*/
            return VentaDAO.Instancia().Buscar(c);
        }

        public static void RegistrarFacturacion(Venta c)
        {
            //
            // inicializo la transacciones
            //
            using (TransactionScope scope = new TransactionScope())
            {
                //
                // Creo la factura y sus lineas
                //
                VentaDAO.Create(c);

                //
                // Actualizo el total
                //
                //InvoiceDAL.UpdateTotal(invoice.InvoiceId, invoice.Total);

                scope.Complete();
            }

        }

        //Metodo que se encarga de llamar al metodo ObtenerProducto 
        //por codigo de la clase Venta
        public static DataTable ObtenerVenta(String correlativo, String nroDoc, int idcom)
        {
            //return new ComprobanteDAO().ObtenerVenta(numero);
            return VentaDAO.Instancia().ObtenerVenta(correlativo,nroDoc, idcom);
        }

        /*public static DataTable ObtenerVenta(DateTime fechacomprobante)
        {
            //return new ComprobanteDAO().ObtenerVenta(fechacomprobante);
            return VentaDAO.Instancia().ObtenerVenta(fechacomprobante);
        }*/

       /* public static int ObtenerUltimaFactura()
        {
            return VentaDAO.Instancia().ultimaFactura();
        }*/

        public Venta obtenerUltimaVenta(int id)
        {
            return VentaDAO.Instancia().nroVentaActual(id);
        }

        public String reducirStock(int id, int cantidad)
        {
            return VentaDAO.Instancia().disminuirStock(id, cantidad);
        }

        public DataTable listarVentas()
        {
            return VentaDAO.Instancia().ListarVentas();
        }

        public DataTable reporteVentasxDias(String FecIn, String FecFin)
        {
            return VentaDAO.Instancia().ReporteVentasxDias(FecIn,FecFin);
        }
    }
}
