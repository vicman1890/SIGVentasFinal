using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ServicioDAO
    {
        
        
        public static ServicioDAO _Instancia;
        private ServicioDAO() { }
        public static ServicioDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ServicioDAO();
            }
            return _Instancia;

        }
        
        
        public Boolean Guardar(Servicio s)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Servicio_Insertar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idServicioVehiculo", SqlDbType.Int);
           
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("descripcion", s.descripcion);
            cmd.Parameters.AddWithValue("precio", s.precio);
            cmd.Parameters.AddWithValue("idTipoVehiculo", s.idCategoria);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            s.id = (Int32)paramId.Value;
            return true;
        }

        public List<Servicio> Listar(Servicio servicio)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Servicio_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Servicio> lista = new List<Servicio>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Servicio objServicio = new Servicio();
                objServicio.id = Convert.ToInt32(dr["idServicioVehiculo"]);
                objServicio.descripcion = dr["descripcion"].ToString();
                objServicio.precio = Convert.ToDecimal(dr["precio"]);
                objServicio.idCategoria = Convert.ToInt32(dr["idTipoVehiculo"]);
                lista.Add(objServicio);
            }
            cmd.Connection.Close();
            return lista;
        }

        
        public List<Servicio> Buscar(Servicio s)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Servicio_Buscar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("descripcion", s.descripcion);
            cmd.Parameters.AddWithValue("idTipoVehiculo", s.idCategoria);
            con.Open();
            List<Servicio> coleccion = new List<Servicio>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Servicio obj = new Servicio();
                obj.id = (Int32)dr["idServicioVehiculo"];
                obj.descripcion = dr["descripcion"].ToString();
                obj.idCategoria = (Int32)dr["idTipoVehiculo"];
                obj.precio = (decimal)dr["precio"];//dr["ruc"].ToString();
                

                coleccion.Add(obj);
            }

            con.Close();
            return coleccion;
        }

        public Boolean Modificar(Servicio s)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Servicio_Modificar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("id", s.id);
            cmd.Parameters.AddWithValue("descripcion", s.descripcion);
            cmd.Parameters.AddWithValue("idCategoria", s.idCategoria);
            cmd.Parameters.AddWithValue("precio", s.precio);
            
            con.Open();
            Int32 i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1) return true;
            else return false;
        }



        public List<Servicio> ServicioPorTipoVehiculo(Servicio servicio)
        {


            string sql = @" SELECT idServicioVehiculo, idTipoVehiculo, Descripción
                            FROM ServicioVehiculo
                            INNER JOIN ModeloMarca
                             ON ModeloMarca.TipoVehiculo=ServicioVehiculo.idTipoVehiculo
                            WHERE idModelo = @modelo";

            /*string sql = @" SELECT idServicioVehiculo, idTipoVehiculo, Descripción
                            FROM ServicioVehiculo
                            INNER JOIN ModeloMarca
                             ON ModeloMarca.TipoVehiculo=ServicioVehiculo.idTipoVehiculo
                            WHERE idModelo = @modelo";*/


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@placa", placa);


            List<Servicio> lista = new List<Servicio>();
            
          
            /*SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Servicio_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Servicio> lista = new List<Servicio>();
            cmd.Connection.Open();*/
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Servicio objServicio = new Servicio();
                objServicio.id = Convert.ToInt32(dr["id"]);
                objServicio.descripcion = dr["descripcion"].ToString();
                objServicio.precio = Convert.ToDecimal(dr["precio"]);
                objServicio.idCategoria = Convert.ToInt32(dr["idCategoria"]);
                lista.Add(objServicio);
            }
            cmd.Connection.Close();
            return lista;
        }


        public Servicio ServicioSeleccionadoTipoVehiculo(int ModeloMarca, String desc)
        {
            /*string sql = @"SELECT *
                      FROM ServicioVehiculo
                      WHERE idTipoVehiculo = @TipoVehiculo AND Descripcion = @desc";*/


            string sql = @"SELECT * FROM ServicioVehiculo INNER JOIN ModeloMarca
                             ON ModeloMarca.TipoVehiculo=ServicioVehiculo.idTipoVehiculo
                            WHERE ModeloMarca.ModeloMarca = @ModeloMarca AND ServicioVehiculo.Descripcion = @desc";

            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@ModeloMarca", ModeloMarca);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("@desc", desc);
            con.Open();


            Servicio obj = new Servicio();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                obj.id = (Int32)dr["idServicioVehiculo"];
                obj.descripcion = dr["Descripcion"].ToString();
                obj.idCategoria = (Int32)dr["idTipoVehiculo"];
                obj.precio = (decimal)dr["precio"];
             

            }

            con.Close();
            return obj;

        }
    }
}
