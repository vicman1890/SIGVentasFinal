using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class VehiculoDAO
    {
        
        
        public static VehiculoDAO _Instancia;
        private VehiculoDAO() { }
        public static VehiculoDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new VehiculoDAO();
            }
            return _Instancia;

        }
        
        public Boolean Guardar(Vehiculo v)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("Vehiculo_Insertar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("Vehiculo", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("Placa", v.Placa);
            cmd.Parameters.AddWithValue("Color", v.Placa);
            cmd.Parameters.AddWithValue("idMarca", v.idMarca);
            cmd.Parameters.AddWithValue("idModelo", v.idModelo);
            cmd.Parameters.AddWithValue("idCliente", v.idCliente);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            v.idVehiculo = (Int32)paramId.Value;
            return true;
        }


        public List<Vehiculo> Listar(Vehiculo vehiculo)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("Vehiculo_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Vehiculo> lista = new List<Vehiculo>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Vehiculo objVehiculo = new Vehiculo();
                objVehiculo.idVehiculo = Convert.ToInt32(dr["Vehiculo"]);
                objVehiculo.Placa = dr["Placa"].ToString();
                objVehiculo.idMarca = Convert.ToInt32(dr["idMarca"]);
                objVehiculo.idModelo = Convert.ToInt32(dr["idModelo"]);
                objVehiculo.idCliente = Convert.ToInt32(dr["idCliente"]);
                
                lista.Add(objVehiculo);
            }
            cmd.Connection.Close();
            return lista;
        }

        public List<Vehiculo> Buscar(Vehiculo v)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Vehiculo_Buscar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("placa", v. Placa);
            con.Open();
            List<Vehiculo> coleccion = new List<Vehiculo>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Vehiculo obj = new Vehiculo();
                obj.idVehiculo = (Int32)dr["Vehiculo"];
                obj.Placa = dr["Placa"].ToString();
                obj.idMarca = (Int32)dr["idMarca"];
                obj.idModelo = (Int32)dr["idModelo"];


                coleccion.Add(obj);
            }

            con.Close();
            return coleccion;
        }

        public Vehiculo Verificar(String placa)
        {
            /*string sql = @"SELECT *
                      FROM Vehiculo
                      WHERE Placa = @placa";*/

            string sql = @" SELECT Vehiculo, Placa, idMarca, idModelo, idCliente
                            FROM Vehiculo
                            INNER JOIN ModeloMarca
                             ON ModeloMarca.ModeloMarca=Vehiculo.idModelo
                            WHERE Placa = @placa";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@placa", placa);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            
            con.Open();


            Vehiculo obj = new Vehiculo();
           
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                obj.idVehiculo = (Int32)dr["idVehiculo"];
                obj.Placa = dr["Placa"].ToString();
                //obj.objMarca.Descripcion = dr["TipoVehiculo"].ToString();
                ///obj.objModelo.idModeloMarca = (Int32)dr["idModelo"];
                obj.idMarca = (Int32)dr["idMarca"];
                obj.idModelo = (Int32)dr["idModelo"];

            }

            con.Close();
            return obj;




        }


    }
}
