using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class IngresoAlmacenDAO
    {
        public static IngresoAlmacenDAO _Instancia;
        private IngresoAlmacenDAO() { }
        public static IngresoAlmacenDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new IngresoAlmacenDAO();
            }
            return _Instancia;

        }

        public static void Create(IngresoAlmacen c)
        {
            using (SqlConnection con = Conexion.Instancia().conectar())
            {
                con.Open();
                //
                // Creacion de la Factura
                //
                //string sqlFactura = "INSERT INTO Comprobante(fecha, idCliente, totalVenta, igv, subTotal, numero)VALUES(GETDATE(), @idCliente, @totalVenta, @igv, @subTotal, @numero) SELECT SCOPE_IDENTITY()";

                SqlCommand cmd = new SqlCommand("SP_IngresoAlmacen_Insertar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //using (SqlCommand cmd = new SqlCommand(sqlFactura, con))
                {


                    cmd.Parameters.AddWithValue("FechaIngreso", c.FechaIngreso);
                    cmd.Parameters.AddWithValue("idProveedor", c.idProveedor);
                    cmd.Parameters.AddWithValue("TotalPagado", c.TotalPagado);
                    cmd.Parameters.AddWithValue("idTipoComprobante", c.idTipoComprobante);
                    cmd.Parameters.AddWithValue("idUsuario", c.idUsuario);
                    cmd.Parameters.AddWithValue("Estado", c.Estado);
                    cmd.Parameters.AddWithValue("Serie", c.Serie);
                    cmd.Parameters.AddWithValue("Correlativo", c.NroDocumento);
                    //cmd.Parameters.AddWithValue("numero", c.numero);

                    c.idIngresoAlmacen = Convert.ToInt32(cmd.ExecuteScalar());
                }


                //SqlCommand cmd2 = new SqlCommand("DetalleComprobante_Insertar_PA", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                string sqlLineaFactura = "INSERT INTO DetalleIngresoAlmacen(idIngresoAlmacen, idArticulo, PrecioCompra, PrecioVenta , Cantidad, CantidadFinal) VALUES (@idIngresoAlmacen, @idArticulo, @PrecioCompra, @PrecioVenta, @Cantidad, @CantidadFinal) SELECT SCOPE_IDENTITY()";

                using (SqlCommand cmd2 = new SqlCommand(sqlLineaFactura, con))
                {

                    foreach (DetalleIngresoAlmacen d in c.Lineas)
                    {
                        //
                        // como se reutiliza el mismo objeto SqlCommand es necesario limpiar los parametros
                        // de la operacion previa, sino estos se iran agregando en la coleccion, generando un fallo
                        //
                        cmd2.Parameters.Clear();

                        cmd2.Parameters.AddWithValue("idIngresoAlmacen", c.idIngresoAlmacen);
                        cmd2.Parameters.AddWithValue("idArticulo", d.idArticulo);
                        cmd2.Parameters.AddWithValue("PrecioCompra", d.PrecioCompra);
                        cmd2.Parameters.AddWithValue("PrecioVenta", d.PrecioVenta);
                        cmd2.Parameters.AddWithValue("Cantidad", d.Cantidad);
                        cmd2.Parameters.AddWithValue("CantidadFinal", d.CantidadFinal);

                        //
                        // Si bien obtenermos el id de linea de factura, este no es usado
                        // en la aplicacion
                        //
                        d.idDetalleIngresoAlmacen = Convert.ToInt32(cmd2.ExecuteScalar());

                    }

                }

            }
        }

        public DetalleIngresoAlmacen stockActual(int id)
        {
            string sql = @"SELECT TOP 1 CantidadFinal FROM DetalleIngresoAlmacen WHERE idArticulo like @id ORDER BY idDetalleIngresoAlmacen DESC;";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("id", id);
            con.Open();

           DetalleIngresoAlmacen obj = new DetalleIngresoAlmacen();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if(dr["CantidadFinal"].ToString()== "")
                {
                    obj.CantidadFinal = 0;
                }else {
                    obj.CantidadFinal = (Int32)dr["CantidadFinal"];
                }
            }
            con.Close();
            return obj;        
        }

        public DataTable ListarIngresosAlmacen()
        {
            DataTable DtResultado = new DataTable("IngresosAlmacen");
            SqlConnection con = Conexion.Instancia().conectar();
            /*try
            {*/

            SqlCommand cmd = new SqlCommand("SELECT v.idIngresoAlmacen, v.FechaIngreso, a.Codigo AS CodigoArticulo, a.Nombre AS NombreArticulo, di.Cantidad AS CantidadIngreso, di.CantidadFinal AS CantidadStockAlmacen, v.idTipoComprobante, v.Estado,tc.Nombre AS NombreTipoComprobante, v.Serie, v.Correlativo, c.Nombres AS NombreProveedor, u.Username FROM IngresoAlmacen AS v INNER JOIN Usuario AS u ON v.idUsuario = u.idUsuario INNER JOIN TipoComprobante AS tc ON v.idTipoComprobante = tc.idTipoComprobante INNER JOIN Proveedor as c ON v.idProveedor = c.idProveedor INNER JOIN DetalleIngresoAlmacen as di ON v.idIngresoAlmacen = di.idIngresoAlmacen INNER JOIN Articulo AS a ON di.idArticulo = a.idArticulo", con);

            SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
            SqlDat.Fill(DtResultado);

            /*}
            catch (Exception ex)
            {
                DtResultado = null;
            }*/
            return DtResultado;

        }

        public DataTable ListarIngresosAlmacenStock()
        {
            DataTable DtResultado = new DataTable("IngresosAlmacen");
            SqlConnection con = Conexion.Instancia().conectar();
            /*try
            {*/

            SqlCommand cmd = new SqlCommand("SELECT TOP 1 CantidadFinal FROM DetalleIngresoAlmacen ORDER BY idDetalleIngresoAlmacen DESC;", con);

            SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
            SqlDat.Fill(DtResultado);

            /*}
            catch (Exception ex)
            {
                DtResultado = null;
            }*/
            return DtResultado;

        }

        public DataTable ReporteStockAlmacen()
        {
            DataTable DtResultado = new DataTable("ReporteStockAlmacen");
            SqlConnection con = Conexion.Instancia().conectar();
            /*try
            {*/

            SqlCommand cmd = new SqlCommand("SP_StockAlmacen_Reporte", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("FechaInicio", FecInc);
            //cmd.Parameters.AddWithValue("FechaFin", FecFin);
            SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
            SqlDat.Fill(DtResultado);

            /*}
            catch (Exception ex)
            {
                DtResultado = null;
            }*/
            return DtResultado;

        }

    }
}
