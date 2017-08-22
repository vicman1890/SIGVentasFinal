using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class TallaArticuloDAO
    {

        public static TallaArticuloDAO _Instancia;
        private TallaArticuloDAO() { }
        public static TallaArticuloDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new TallaArticuloDAO();
            }
            return _Instancia;

        }

        public List<TallaArticulo> Listar(TallaArticulo talla)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("SP_Talla_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<TallaArticulo> lista = new List<TallaArticulo>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TallaArticulo objTalla = new TallaArticulo();
                objTalla.idTallaArticulo = Convert.ToInt32(dr["idTalla"]);
                objTalla.Descripcion = dr["Nombre"].ToString();
                objTalla.Estado = Convert.ToBoolean(dr["Estado"]);
                lista.Add(objTalla);
            }
            cmd.Connection.Close();
            return lista;
        }

        public Boolean Guardar(TallaArticulo c)
        {

            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Talla_Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idTalla", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("Nombre", c.Descripcion);
            cmd.Parameters.AddWithValue("Estado", c.Estado);
            /*cmd.Parameters.AddWithValue("departamento", c.departamento);
            cmd.Parameters.AddWithValue("provincia", c.provincia);
            cmd.Parameters.AddWithValue("distrito", c.distrito);*/

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            c.idTallaArticulo = (Int32)paramId.Value;
            return true;
        }

        public Boolean Modificar(TallaArticulo c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Talla_Modificar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idTalla", c.idTallaArticulo);
            cmd.Parameters.AddWithValue("Nombre", c.Descripcion);
            cmd.Parameters.AddWithValue("Estado", c.Estado);
            /*cmd.Parameters.AddWithValue("departamento", c.departamento);
            cmd.Parameters.AddWithValue("provincia", c.provincia);
            cmd.Parameters.AddWithValue("distrito", c.distrito);*/

            con.Open();
            Int32 i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1) return true;
            else return false;
        }

        public List<TallaArticulo> Buscar(TallaArticulo c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            SqlCommand cmd = new SqlCommand("SP_Talla_Buscar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre", c.Descripcion);

            con.Open();
            List<TallaArticulo> coleccion = new List<TallaArticulo>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TallaArticulo obj = new TallaArticulo();
                obj.idTallaArticulo = (Int32)dr["idTalla"];
                obj.Descripcion = dr["Nombre"].ToString();

                /*obj.departamento = dr["departamento"].ToString();
                obj.provincia = dr["provincia"].ToString();
                obj.distrito = dr["distrito"].ToString();*/
                obj.Estado = (Boolean)dr["Estado"];

                coleccion.Add(obj);
            }

            con.Close();
            return coleccion;
        }

    }
}
