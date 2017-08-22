using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;


namespace CapaDatos
{
    public class UsuarioDAO
    {

         public static UsuarioDAO _Instancia;
         private UsuarioDAO() { }
         public static UsuarioDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new UsuarioDAO();
            }
            return _Instancia;

        }

        public Usuario Autenticar(String usuario, String password)
        {
            string sql = @"SELECT *
                      FROM Usuario
                      WHERE Username = @Username AND Password = @Password AND Estado = 1";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Username", usuario);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("@Password", password);
            con.Open();

           

            Usuario obj = new Usuario();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
               
                obj.idUsuario = (Int32)dr["idUsuario"];
                obj.Username = dr["Username"].ToString();
                obj.Nombres = dr["Nombres"].ToString();
                obj.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                obj.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                obj.idTipoUsuario = (Int32)dr["idTipoUsuario"];
         

            }

            con.Close();
            return obj;



            /*SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader.GetString(1)+" "+reader.GetString(8)+" "+reader.GetString(9)+" "+reader.GetString(10));
                    
                }
                return true;
            }
            else
            {
                return false;
                Console.WriteLine("No rows found.");
            }
            reader.Close();*/



        }

        public Boolean Modificar(Usuario c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Usuario_Modificar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("idUsuario", c.idUsuario);
            cmd.Parameters.AddWithValue("Nombres", c.Nombres);
            cmd.Parameters.AddWithValue("Username", c.Username);
            cmd.Parameters.AddWithValue("Dni", c.Dni);
            cmd.Parameters.AddWithValue("Password", c.Password);
            cmd.Parameters.AddWithValue("ApellidoPaterno", c.ApellidoPaterno);
            cmd.Parameters.AddWithValue("ApellidoMaterno", c.ApellidoMaterno);
            cmd.Parameters.AddWithValue("idTipoUsuario", c.idTipoUsuario);
            cmd.Parameters.AddWithValue("Estado", c.Estado);
            cmd.Parameters.AddWithValue("FechaIngreso", c.FechaIngreso);
            cmd.Parameters.AddWithValue("Salario", c.Salario);
            cmd.Parameters.AddWithValue("Direccion", c.Direccion);
            cmd.Parameters.AddWithValue("DiaPago", c.DiaPago);
            cmd.Parameters.AddWithValue("DiaDescanso", c.DiaDescanso);

            con.Open();
            Int32 i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1) return true;
            else return false;
        }

        public Boolean Guardar(Usuario c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("SP_Usuario_Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idUsuario", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("Nombres", c.Nombres);
            cmd.Parameters.AddWithValue("Username", c.Username);
            cmd.Parameters.AddWithValue("Dni", c.Dni);
            cmd.Parameters.AddWithValue("Password", c.Password);
            cmd.Parameters.AddWithValue("ApellidoPaterno", c.ApellidoPaterno);
            cmd.Parameters.AddWithValue("ApellidoMaterno", c.ApellidoMaterno);
            cmd.Parameters.AddWithValue("idTipoUsuario", c.idTipoUsuario);
            cmd.Parameters.AddWithValue("Estado", c.Estado);
            cmd.Parameters.AddWithValue("FechaIngreso", c.FechaIngreso);
            cmd.Parameters.AddWithValue("Salario", c.Salario);
            cmd.Parameters.AddWithValue("Direccion", c.Direccion);
            cmd.Parameters.AddWithValue("DiaPago", c.DiaPago);
            cmd.Parameters.AddWithValue("DiaDescanso", c.DiaDescanso);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            c.idUsuario = (Int32)paramId.Value;
            return true;
        }

        public List<Usuario> Buscar(Usuario c)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            SqlCommand cmd = new SqlCommand("SP_Usuario_Buscar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombres", c.Nombres);
            cmd.Parameters.AddWithValue("username", c.Username);
            con.Open();
            List<Usuario> coleccion = new List<Usuario>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario obj = new Usuario();
                obj.idUsuario = (Int32)dr["idUsuario"];
                obj.Nombres = dr["Nombres"].ToString();
                obj.Username = dr["Username"].ToString();
                obj.Dni = dr["Dni"].ToString();
                obj.Password = dr["Password"].ToString();
                obj.idTipoUsuario = (Int32)dr["idTipoUsuario"];
                obj.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                obj.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                obj.Estado = (Boolean)dr["Estado"];
                obj.FechaIngreso = (DateTime)dr["FechaIngreso"];
                obj.Salario = (Decimal)dr["Salario"];
                obj.Direccion = dr["Direccion"].ToString();
                obj.DiaPago = dr["DiaPago"].ToString();
                obj.DiaDescanso = dr["DiaDescanso"].ToString();
                coleccion.Add(obj);
            }

            con.Close();
            return coleccion;
        }
    }
}
