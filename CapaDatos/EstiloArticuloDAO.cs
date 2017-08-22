using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class EstiloArticuloDAO
    {

        public static EstiloArticuloDAO _Instancia;
        private EstiloArticuloDAO() { }
        public static EstiloArticuloDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new EstiloArticuloDAO();
            }
            return _Instancia;

        }

        public List<EstiloArticulo> Listar(EstiloArticulo estilo)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("SP_Estilo_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<EstiloArticulo> lista = new List<EstiloArticulo>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EstiloArticulo objEstilo = new EstiloArticulo();
                objEstilo.idEstiloArticulo = Convert.ToInt32(dr["idEstilo"]);
                objEstilo.Descripcion = dr["Nombre"].ToString();
                objEstilo.Estado = Convert.ToBoolean(dr["Estado"]);
                lista.Add(objEstilo);
            }
            cmd.Connection.Close();
            return lista;
        }

        public Boolean Guardar(EstiloArticulo c)
        {

            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Estilo_Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idEstilo", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("Nombre", c.Descripcion);
            cmd.Parameters.AddWithValue("Estado", c.Estado);
            

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            c.idEstiloArticulo = (Int32)paramId.Value;
            return true;
        }

        public Boolean Modificar(EstiloArticulo c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("SP_Estilo_Modificar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idEstilo", c.idEstiloArticulo);
            cmd.Parameters.AddWithValue("Nombre", c.Descripcion);
            cmd.Parameters.AddWithValue("Estado", c.Estado);
            

            con.Open();
            Int32 i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1) return true;
            else return false;
        }

        public List<EstiloArticulo> Buscar(EstiloArticulo c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            SqlCommand cmd = new SqlCommand("SP_Estilo_Buscar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre", c.Descripcion);

            con.Open();
            List<EstiloArticulo> coleccion = new List<EstiloArticulo>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EstiloArticulo obj = new EstiloArticulo();
                obj.idEstiloArticulo = (Int32)dr["idEstilo"];
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
