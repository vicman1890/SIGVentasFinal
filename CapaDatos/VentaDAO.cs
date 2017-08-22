using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using System.Windows.Forms;


namespace CapaDatos
{
    public class VentaDAO
    {

        public static VentaDAO _Instancia;
        private VentaDAO() { }
        public static VentaDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new VentaDAO();
            }
            return _Instancia;

        }


        /*public Boolean Guardar(Comprobante c)
        {

            
            SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Comprobante_Insertar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("id", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            
            //cmd.Parameters.AddWithValue("numero", c.número);
            cmd.Parameters.AddWithValue("idCliente", c.idCliente);
            cmd.Parameters.AddWithValue("fecha", c.fecha);
            cmd.Parameters.AddWithValue("totalVenta", c.totalVenta);


            SqlCommand cmd2 = new SqlCommand("DetalleComprobante_Insertar_PA", con);


            foreach (DetalleComprobante d in c.Lineas)
            {
                //
                // como se reutiliza el mismo objeto SqlCommand es necesario limpiar los parametros
                // de la operacion previa, sino estos se iran agregando en la coleccion, generando un fallo
                //
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("id", c.id);
                cmd.Parameters.AddWithValue("idServicio", d.idServicio);
                cmd.Parameters.AddWithValue("precio", d.precio);
                cmd.Parameters.AddWithValue("cantidad", d.cantidad);

                //
                // Si bien obtenermos el id de linea de factura, este no es usado
                // en la aplicacion
                //
                d.id = 1;
                //d.id = Convert.ToInt32(cmd.ExecuteScalar());
            }



            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            c.id = (Int32)paramId.Value;
            return true;
        }*/


        public static void Create(Venta c)
        {
            using (SqlConnection con = Conexion.Instancia().conectar())
            {
                con.Open();
                //
                // Creacion de la Factura
                //
                //string sqlFactura = "INSERT INTO Comprobante(fecha, idCliente, totalVenta, igv, subTotal, numero)VALUES(GETDATE(), @idCliente, @totalVenta, @igv, @subTotal, @numero) SELECT SCOPE_IDENTITY()";

                SqlCommand cmd = new SqlCommand("SP_Venta_Insertar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //using (SqlCommand cmd = new SqlCommand(sqlFactura, con))
                {

                    
                    cmd.Parameters.AddWithValue("FechaVenta", c.FechaVenta);
                    cmd.Parameters.AddWithValue("idCliente", c.idCliente);
                    cmd.Parameters.AddWithValue("idUsuario", c.idUsuario);
                    cmd.Parameters.AddWithValue("TotalVenta", c.TotalVenta);
                    cmd.Parameters.AddWithValue("SubTotalVenta", c.SubTotalVenta);
                    cmd.Parameters.AddWithValue("IgvVenta", c.IgvVenta);
                    cmd.Parameters.AddWithValue("idTipoComprobante", c.idTipoComprobante);
                    cmd.Parameters.AddWithValue("Correlativo", c.Correlativo);
                    cmd.Parameters.AddWithValue("NroDocumento", c.NroDocumento);
                    cmd.Parameters.AddWithValue("Estado", c.Estado);
                    c.idVenta = Convert.ToInt32(cmd.ExecuteScalar());
                }


                //SqlCommand cmd2 = new SqlCommand("DetalleComprobante_Insertar_PA", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                
                string sqlLineaFactura = "INSERT INTO DetalleVenta(idVenta, idArticulo, PrecioVenta, Cantidad, idDetalleIngresoAlmacen) VALUES (@idVenta, @idArticulo, @PrecioVenta, @Cantidad, @idDetalleIngresoAlmacen) SELECT SCOPE_IDENTITY()";

                using (SqlCommand cmd2 = new SqlCommand(sqlLineaFactura, con))
                {

                    foreach (DetalleVenta d in c.Lineas)
                    {
                        //
                        // como se reutiliza el mismo objeto SqlCommand es necesario limpiar los parametros
                        // de la operacion previa, sino estos se iran agregando en la coleccion, generando un fallo
                        //
                        cmd2.Parameters.Clear();

                        cmd2.Parameters.AddWithValue("idVenta", c.idVenta);
                        cmd2.Parameters.AddWithValue("idArticulo", d.idArticulo);
                        cmd2.Parameters.AddWithValue("PrecioVenta", d.PrecioVenta);
                        cmd2.Parameters.AddWithValue("Cantidad", d.Cantidad);
                        cmd2.Parameters.AddWithValue("idDetalleIngresoAlmacen", d.idDetalleIngresoAlmacen);

                        //
                        // Si bien obtenermos el id de linea de factura, este no es usado
                        // en la aplicacion
                        //
                        d.idDetalleVenta = Convert.ToInt32(cmd2.ExecuteScalar());
                        
                    }

                }

            }
        }

        
        public DataTable ListarVentas()
        {
            DataTable DtResultado = new DataTable("Ventas");
            SqlConnection con = Conexion.Instancia().conectar();
            /*try
            {*/

                SqlCommand cmd = new SqlCommand("SP_Venta_Listar", con);

                SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
                SqlDat.Fill(DtResultado);

            /*}
            catch (Exception ex)
            {
                DtResultado = null;
            }*/
            return DtResultado;

        }

        public List<Venta> Buscar(Venta c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            SqlCommand cmd = new SqlCommand("SP_Venta_Buscar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("correlativo", c.Correlativo);
            cmd.Parameters.AddWithValue("nrodoc", c.NroDocumento);
            con.Open();
            List<Venta> coleccion = new List<Venta>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Venta obj = new Venta();
                obj.idVenta = (Int32)dr["idVenta"];
                obj.idCliente = (Int32)dr["idCliente"];
                obj.FechaVenta = (DateTime)dr["FechaVenta"];
                obj.SubTotalVenta =  (Decimal)dr["SubTotalVenta"];
                obj.IgvVenta = (Decimal)dr["IgvVenta"];
                obj.TotalVenta = (Decimal)dr["TotalVenta"];
                obj.Correlativo = dr["Correlativo"].ToString();
                obj.NroDocumento = dr["NroDocumento"].ToString();
                obj.idUsuario = (Int32)dr["idUsuario"];
                
              

                Usuario u = new Usuario();
                u.Username = dr["Username"].ToString();

                TipoComprobante tc = new TipoComprobante();
                tc.Nombre = dr["Nombre"].ToString();

                Cliente cl = new Cliente();
                cl.Nombres = dr["Nombres"].ToString();

                obj.Estado = (Boolean)dr["Estado"];
                obj.idTipoComprobante = (Int32)dr["idTipoComprobante"];

                coleccion.Add(obj);
            }

            con.Close();
            return coleccion;
        }

        public String disminuirStock(int id, int cantidad)
        {
            //string sql = @"SELECT TOP 1 PrecioVenta FROM DetalleIngresoAlmacen WHERE idArticulo like @id ORDER BY idDetalleIngresoAlmacen DESC;";
            string rpta = "";

            SqlConnection con = Conexion.Instancia().conectar();

            SqlCommand cmd = new SqlCommand("SP_Disminuir_Stock", con);
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

        /*public DetalleIngresoAlmacen disminuirStock(int id, int cantidad)
        {
            string sql = @"update DetalleIngresoAlmacen set CantidadFinal=CantidadFinal-@cantidad
SELECT TOP 1 CantidadFinal FROM DetalleIngresoAlmacen 
WHERE idArticulo like @id ORDER BY idDetalleIngresoAlmacen DESC;
";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("cantidad", cantidad);
            con.Open();

            DetalleIngresoAlmacen obj = new DetalleIngresoAlmacen();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (dr["CantidadFinal"].ToString() == "")
                {
                    obj.CantidadFinal = 0;
                }
                else {
                    obj.CantidadFinal = (Int32)dr["CantidadFinal"];
                }
            }
            con.Close();
            return obj;
        }*/

        public DataTable ObtenerVenta(String correlativo, String nroDoc, int idTipoComprobante)
        {
            DataTable dtVenta = new DataTable("Venta");
            SqlConnection con = Conexion.Instancia().conectar();
            try
            {
               
               
                //2. Establecer el comando
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = con;//La conexion que va a usar el comando
                sqlCmd.CommandText = "SP_Venta_Listar_";//El comando a ejecutar
                sqlCmd.CommandType = CommandType.StoredProcedure;//Decirle al comando que va a ejecutar una sentencia SQL

                //cmd.Parameters.AddWithValue("Codigo", a.Codigo);
                sqlCmd.Parameters.AddWithValue("nroCorrelativo", correlativo);
                sqlCmd.Parameters.AddWithValue("nroDocumento", nroDoc);
                sqlCmd.Parameters.AddWithValue("idtipoComprobante", idTipoComprobante);
                //con.Open();




                /*SqlParameter sqlParcodigoVenta2 = new SqlParameter();
                sqlParcodigoVenta2.ParameterName = "nroDocumento";
                sqlParcodigoVenta2.SqlDbType = SqlDbType.VarChar;
                sqlParcodigoVenta2.Value = nro;*/

                //sqlCmd.Parameters.Add(sqlParcodigoVenta); //Agregamos el parametro al comando

                //4. El DataAdapter que va a ejecutar el comando y es el encargado de llena el DataTable
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtVenta);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                dtVenta = null;
            }
            return dtVenta;
        }
       
        

        public Venta nroVentaActual(int id)
        {
            string sql = @"SELECT TOP 1 NroDocumento FROM Venta WHERE idTipoComprobante like @id ORDER BY idVenta DESC;";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("id", id);
            con.Open();

            Venta obj = new Venta();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                obj.NroDocumento = dr["NroDocumento"].ToString();

            }
            con.Close();         
            return obj;
                      
        }

        public DataTable ReporteVentasxDias(String FecInc, String FecFin)
        {
            DataTable DtResultado = new DataTable("ReporteVentasxDia");
            SqlConnection con = Conexion.Instancia().conectar();
            /*try
            {*/

            SqlCommand cmd = new SqlCommand("SP_VentasxDias_Reporte", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("FechaInicio", FecInc);
            cmd.Parameters.AddWithValue("FechaFin", FecFin);
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
