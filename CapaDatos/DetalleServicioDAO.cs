using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    public class DetalleServicioDAO
    {

        public static DetalleServicioDAO _Instancia;
        private DetalleServicioDAO() { }
        public static DetalleServicioDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new DetalleServicioDAO();
            }
            return _Instancia;

        }

        public Boolean Guardar(int idVehiculo, int idServicio)
        {

            
            DetalleServicio d = new DetalleServicio();
            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Cliente_Insertar_PA", con);

            string sql = @" SELECT Lavado, Encerado, Motor, idDetalleServicio
                            FROM DetalleServicio
                            INNER JOIN Vehiculo
                             ON Vehiculo.Vehiculo=DetalleServicio.idVehiculo
                            WHERE Placa = @placa AND FechaServicio = @fecha";

            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idDetalleServicio", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("idVehiculo", d.idVehiculo);
            cmd.Parameters.AddWithValue("idServicio", d.idServicio);
            cmd.Parameters.AddWithValue("Lavado", d.Lavado);
            cmd.Parameters.AddWithValue("Encerado", d.Encerado);
            cmd.Parameters.AddWithValue("Motor", d.Motor);
            cmd.Parameters.AddWithValue("FechaServicio", d.FechaServicio);
            

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            d.idDetalleServicio = (Int32)paramId.Value;
            return true;
        }


        public DetalleServicio Guardar(String placa, DateTime fecha)
        {
            /*string sql = @"SELECT *
                      FROM DetalleServicio
                      WHERE idVehiculo = @vehiculo AND FechaServicio = @fecha";*/

            string sql = @" SELECT Lavado, Encerado, Motor, idDetalleServicio
                            FROM DetalleServicio
                            INNER JOIN Vehiculo
                             ON Vehiculo.Vehiculo=DetalleServicio.idVehiculo
                            WHERE Placa = @placa AND FechaServicio = @fecha";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@placa", placa);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("@fecha", fecha);
            con.Open();


            DetalleServicio obj = new DetalleServicio();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                obj.idDetalleServicio = (Int32)dr["idDetalleServicio"];
                obj.idVehiculo = (Int32)dr["idVehiculo"];
                obj.Lavado = (Boolean)dr["Lavado"];
                obj.Encerado = (Boolean)dr["Encerado"];
                obj.Motor = (Boolean)dr["Motor"];

            }

            con.Close();
            return obj;

        }



        public DetalleServicio Verificar(String placa, DateTime fecha)
        {
            /*string sql = @"SELECT *
                      FROM DetalleServicio
                      WHERE idVehiculo = @vehiculo AND FechaServicio = @fecha";*/

             string sql = @" SELECT Lavado, Encerado, Motor, idDetalleServicio
                            FROM DetalleServicio
                            INNER JOIN Vehiculo
                             ON Vehiculo.Vehiculo=DetalleServicio.idVehiculo
                            WHERE Placa = @placa AND FechaServicio = @fecha";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@placa", placa);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("@fecha", fecha);
            con.Open();


            DetalleServicio obj = new DetalleServicio();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                obj.idDetalleServicio = (Int32)dr["idDetalleServicio"];
                obj.idVehiculo = (Int32)dr["idVehiculo"];
                obj.Lavado = (Boolean)dr["Lavado"];
                obj.Encerado = (Boolean)dr["Encerado"];
                obj.Motor = (Boolean)dr["Motor"];

            }

            con.Close();
            return obj;

        }
    }
}
