using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class StockTiendaDAO
    {
        public static StockTiendaDAO _Instancia;
        private StockTiendaDAO() { }
        public static StockTiendaDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new StockTiendaDAO();
            }
            return _Instancia;

        }

        public static void Create(StockTienda c)
        {
            using (SqlConnection con = Conexion.Instancia().conectar())
            {
                con.Open();
              
                SqlCommand cmd = new SqlCommand("SP_IngresoTienda_Insertar", con);
                cmd.CommandType = CommandType.StoredProcedure; 
                {
                    cmd.Parameters.AddWithValue("FechaIngresoTienda", c.FechaIngresoTienda);
                    cmd.Parameters.AddWithValue("idUsuario", c.idUsuario);
                    cmd.Parameters.AddWithValue("Estado", c.Estado);
                    c.idStockTienda = Convert.ToInt32(cmd.ExecuteScalar());
                }


                //SqlCommand cmd2 = new SqlCommand("DetalleComprobante_Insertar_PA", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                string sqlLineaFactura = "INSERT INTO DetalleStockTienda(idStockTienda, idArticulo , idDetalleIngresoAlmacen, StockInicial, StockFinal) VALUES (@idStockTienda, @idArticulo , @idDetalleIngresoAlmacen, @StockInicial, @StockFinal) SELECT SCOPE_IDENTITY()";

                using (SqlCommand cmd2 = new SqlCommand(sqlLineaFactura, con))
                {

                    foreach (DetalleStockTienda d in c.Lineas)
                    {
                        //
                        // como se reutiliza el mismo objeto SqlCommand es necesario limpiar los parametros
                        // de la operacion previa, sino estos se iran agregando en la coleccion, generando un fallo
                        //
                        cmd2.Parameters.Clear();

                        cmd2.Parameters.AddWithValue("idStockTienda", c.idStockTienda);
                        cmd2.Parameters.AddWithValue("idArticulo", d.idArticulo);
                        cmd2.Parameters.AddWithValue("idDetalleIngresoAlmacen", d.idDetalleIngresoAlmacen);
                        cmd2.Parameters.AddWithValue("StockInicial", d.StockInicial);
                        cmd2.Parameters.AddWithValue("StockFinal", d.StockFinal);
                        

                        //
                        // Si bien obtenermos el id de linea de factura, este no es usado
                        // en la aplicacion
                        //
                        d.idDetalleStockTienda = Convert.ToInt32(cmd2.ExecuteScalar());

                    }

                }

            }
        }

        public DetalleStockTienda stockActual(int id)
        {
            string sql = @"SELECT TOP 1 StockFinal FROM DetalleStockTienda WHERE idArticulo like @id ORDER BY idDetalleStockTienda DESC;";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("id", id);
            con.Open();

            DetalleStockTienda obj = new DetalleStockTienda();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (dr["StockFinal"].ToString() == "")
                {
                    obj.StockFinal = 0;
                }
                else {
                    obj.StockFinal = (Int32)dr["StockFinal"];
                }
            }
            con.Close();
            return obj;
        }

        public String disminuirStock(int id, int cantidad)
        {
            //string sql = @"SELECT TOP 1 PrecioVenta FROM DetalleIngresoAlmacen WHERE idArticulo like @id ORDER BY idDetalleIngresoAlmacen DESC;";
            string rpta = "";

            SqlConnection con = Conexion.Instancia().conectar();

            SqlCommand cmd = new SqlCommand("SP_Disminuir_StockTienda", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);


            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("cantidad", cantidad);
            con.Open();


            rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizó el stock";
            return rpta;
        }

        public DataTable ListarIngresosTienda()
        {
            DataTable DtResultado = new DataTable("IngresosTienda");
            SqlConnection con = Conexion.Instancia().conectar();
            /*try
            {*/

            SqlCommand cmd = new SqlCommand("SELECT v.idStockTienda, v.FechaIngresoTienda, a.Codigo AS CodigoArticulo, a.Nombre AS NombreArticulo, di.StockInicial AS StockInicial, di.StockFinal AS StockFinal, v.Estado, u.Username FROM StockTienda AS v INNER JOIN Usuario AS u ON v.idUsuario = u.idUsuario INNER JOIN DetalleStockTienda as di ON v.idStockTienda = di.idStockTienda INNER JOIN Articulo AS a ON di.idArticulo = a.idArticulo", con);

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
