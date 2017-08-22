using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CapaDatos
{
    public class ModeloVehiculoDAO
    {

        public static ModeloVehiculoDAO _Instancia;
        private ModeloVehiculoDAO() { }
        public static ModeloVehiculoDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ModeloVehiculoDAO();
            }
            return _Instancia;

        }

        public List<ModeloVehiculo> ListarModeloMarca(int idMarcaVehiculo)
        {


            string sql = @"SELECT *
                      FROM ModeloVehiculo
                      WHERE idMarcaVehiculo = @idMarcaVehiculo order by Descripcion";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idMarcaVehiculo", idMarcaVehiculo);

      
            List<ModeloVehiculo> lista = new List<ModeloVehiculo>();
            con.Open();


            
            /*SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("MarcaVehiculo_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<ModeloMarca> lista = new List<ModeloMarca>();
            cmd.Connection.Open();*/
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ModeloVehiculo objModelo = new ModeloVehiculo();
                objModelo.idModeloVehiculo = Convert.ToInt32(dr["idModeloVehiculo"]);
                objModelo.idMarcaVehiculo = Convert.ToInt32(dr["idMarcaVehiculo"]);
                objModelo.Descripcion = dr["Descripcion"].ToString();
                objModelo.TipoVehiculo = Convert.ToInt32(dr["idTipoVehiculo"]);

                lista.Add(objModelo);
            }
            cmd.Connection.Close();
            return lista;
        }

    }
}
