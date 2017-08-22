using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ProveedorDAO
    {

        public static ProveedorDAO _Instancia;
        private ProveedorDAO() { }
        public static ProveedorDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ProveedorDAO();
            }
            return _Instancia;

        }

        public Boolean Guardar(Proveedor c)
        {

            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Proveedor_Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idProveedor", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("Nombres", c.Nombres);
            cmd.Parameters.AddWithValue("Direccion", c.Direccion);
            cmd.Parameters.AddWithValue("Ruc", c.Ruc);
            cmd.Parameters.AddWithValue("Telefono", c.Telefono);
            cmd.Parameters.AddWithValue("Email", c.Email);
            cmd.Parameters.AddWithValue("Estado", c.Estado);
            /*cmd.Parameters.AddWithValue("departamento", c.departamento);
            cmd.Parameters.AddWithValue("provincia", c.provincia);
            cmd.Parameters.AddWithValue("distrito", c.distrito);*/

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            c.idProveedor = (Int32)paramId.Value;
            return true;
        }

        public List<Proveedor> Buscar(Proveedor c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            SqlCommand cmd = new SqlCommand("SP_Proveedor_Buscar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", c.Nombres);
            cmd.Parameters.AddWithValue("ruc", c.Ruc);
            con.Open();
            List<Proveedor> coleccion = new List<Proveedor>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Proveedor obj = new Proveedor();
                obj.idProveedor = (Int32)dr["idProveedor"];
                obj.Nombres = dr["Nombres"].ToString();
                obj.Direccion = dr["Direccion"].ToString();
                obj.Ruc = dr["Ruc"].ToString();
                obj.Telefono = dr["Telefono"].ToString();
                obj.Email = dr["Email"].ToString();
                /*obj.departamento = dr["departamento"].ToString();
                obj.provincia = dr["provincia"].ToString();
                obj.distrito = dr["distrito"].ToString();*/
                obj.Estado = (Boolean)dr["Estado"];

                coleccion.Add(obj);
            }

            con.Close();
            return coleccion;
        }

        public List<Proveedor> Listar(Proveedor proveedor)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Proveedor_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Proveedor> lista = new List<Proveedor>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Proveedor objProveedor = new Proveedor();
                objProveedor.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                objProveedor.Nombres = dr["Nombres"].ToString();
                objProveedor.Direccion = dr["Direccion"].ToString();
                objProveedor.Ruc = dr["Ruc"].ToString();
                objProveedor.Telefono = dr["Telefono"].ToString();
                objProveedor.Email = dr["Email"].ToString();
                objProveedor.Estado = (Boolean)dr["Estado"];
                /*objCliente.Departamento = dr["departamento"].ToString();
                objCliente.Provincia = dr["provincia"].ToString();
                objCliente.Distrito = dr["distrito"].ToString();*/
                lista.Add(objProveedor);
            }
            cmd.Connection.Close();
            return lista;
        }

        public Boolean Modificar(Proveedor c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Proveedor_Modificar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("idProveedor", c.idProveedor);
            cmd.Parameters.AddWithValue("Nombres", c.Nombres);
            cmd.Parameters.AddWithValue("Direccion", c.Direccion);
            cmd.Parameters.AddWithValue("Ruc", c.Ruc);
            cmd.Parameters.AddWithValue("Telefono", c.Telefono);
            cmd.Parameters.AddWithValue("Email", c.Email);
            cmd.Parameters.AddWithValue("Estado", c.Estado);

            con.Open();
            Int32 i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1) return true;
            else return false;
        }
    }
}
