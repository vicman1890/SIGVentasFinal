using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ColorArticuloDAO
    {
        public static ColorArticuloDAO _Instancia;
        private ColorArticuloDAO() { }
        public static ColorArticuloDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ColorArticuloDAO();
            }
            return _Instancia;

        }

        public List<ColorArticulo> Listar(ColorArticulo color)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("SP_Color_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<ColorArticulo> lista = new List<ColorArticulo>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ColorArticulo objColor = new ColorArticulo();
                objColor.idColor = Convert.ToInt32(dr["idColor"]);
                objColor.Descripcion = dr["Nombre"].ToString();
                objColor.Estado = Convert.ToBoolean(dr["Estado"]);
                lista.Add(objColor);
            }
            cmd.Connection.Close();
            return lista;
        }

        public Boolean Guardar(ColorArticulo c)
        {

            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Color_Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idColor", SqlDbType.Int);
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
            c.idColor = (Int32)paramId.Value;
            return true;
        }

        public Boolean Modificar(ColorArticulo c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Color_Modificar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idColor", c.idColor);
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

        public List<ColorArticulo> Buscar(ColorArticulo c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            SqlCommand cmd = new SqlCommand("SP_Color_Buscar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre", c.Descripcion);
           
            con.Open();
            List<ColorArticulo> coleccion = new List<ColorArticulo>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ColorArticulo obj = new ColorArticulo();
                obj.idColor = (Int32)dr["idColor"];
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
