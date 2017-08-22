using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CapaDatos
{
   public class MarcaVehiculoDAO
    {

       public static MarcaVehiculoDAO _Instancia;
       private MarcaVehiculoDAO() { }
       public static MarcaVehiculoDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new MarcaVehiculoDAO();
            }
            return _Instancia;

        }


        public Boolean Guardar(MarcaVehiculo c)
        {

            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_MarcaVehiculo_Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idMarcaVehiculo", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("Descripcion", c.Descripcion);
            cmd.Parameters.AddWithValue("Estado", c.Estado);
            /*cmd.Parameters.AddWithValue("departamento", c.departamento);
            cmd.Parameters.AddWithValue("provincia", c.provincia);
            cmd.Parameters.AddWithValue("distrito", c.distrito);*/

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            c.idMarca = (Int32)paramId.Value;
            return true;
        }

        public List<MarcaVehiculo> ListarMarcas(MarcaVehiculo cliente)
       {
           SqlConnection con = Conexion.Instancia().conectar();
           //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
           SqlCommand cmd = new SqlCommand("MarcaVehiculo_Listar_PA", con);
           cmd.CommandType = CommandType.StoredProcedure;
           List<MarcaVehiculo> lista = new List<MarcaVehiculo>();
           cmd.Connection.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               MarcaVehiculo objMarca = new MarcaVehiculo();
               objMarca.idMarca = Convert.ToInt32(dr["MarcaVehiculo"]);
               objMarca.Descripcion = dr["Descripcion"].ToString();

               lista.Add(objMarca);
           }
           cmd.Connection.Close();
           return lista;
       }

    }
}
