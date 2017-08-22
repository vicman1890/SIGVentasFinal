using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class ClienteDAO
    {

        public static ClienteDAO _Instancia;
        private ClienteDAO() { }
        public static ClienteDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ClienteDAO();
            }
            return _Instancia;

        }
        
        public Boolean Guardar(Cliente c)
        {

            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Cliente_Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idCliente", SqlDbType.Int);
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
            c.idCliente = (Int32)paramId.Value;
            return true;        
        }

        public Cliente VerificarPorRuc(String ruc)
        {



            string sql = @"SELECT *
                      FROM Cliente
                      WHERE Ruc = @ruc";
            
            
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            //SqlCommand cmd = new SqlCommand("Cliente_Buscar_PA", con);
            SqlCommand command = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("nombre", c.nombre);
            command.Parameters.AddWithValue("ruc", ruc);
            con.Open();

            Cliente obj = new Cliente();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                obj.idCliente = (Int32)dr["idCliente"];
                obj.Ruc = dr["Ruc"].ToString();
                obj.Nombres = dr["Nombres"].ToString();
                obj.Telefono = dr["Telefono"].ToString();
                obj.Email = dr["Email"].ToString();
                obj.Direccion = dr["Direccion"].ToString();
                obj.Estado = (Boolean)dr["Estado"];
                //obj.Departamento = dr["departamento"].ToString();

            }

            con.Close();
            return obj;
        }

        public List<Cliente> Buscar(Cliente c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            
            SqlCommand cmd = new SqlCommand("SP_Cliente_Buscar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", c.Nombres);
            cmd.Parameters.AddWithValue("ruc", c.Ruc);
            con.Open();
            List<Cliente> coleccion = new List<Cliente>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente obj = new Cliente();
                obj.idCliente = (Int32)dr["idCliente"];
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

        public Boolean Modificar(Cliente c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Cliente_Modificar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("idCliente", c.idCliente);
            cmd.Parameters.AddWithValue("Nombres", c.Nombres    );
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

        public List<Cliente> Listar(Cliente cliente)
        {
            SqlConnection con = Conexion.Instancia().conectar(); 
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Cliente_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Cliente> lista = new List<Cliente>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente objCliente = new Cliente();
                objCliente.idCliente = Convert.ToInt32(dr["idCliente"]);
                objCliente.Nombres = dr["Nombres"].ToString();
                objCliente.Direccion = dr["Direccion"].ToString();
                objCliente.Ruc = dr["Ruc"].ToString();
                objCliente.Telefono = dr["Telefono"].ToString();
                objCliente.Email = dr["Email"].ToString();
                objCliente.Estado = (Boolean)dr["Estado"];
                /*objCliente.Departamento = dr["departamento"].ToString();
                objCliente.Provincia = dr["provincia"].ToString();
                objCliente.Distrito = dr["distrito"].ToString();*/
                lista.Add(objCliente);
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}
    

