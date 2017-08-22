using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ArticuloDAO
    {

        public static ArticuloDAO _Instancia;
        private ArticuloDAO() { }
        public static ArticuloDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ArticuloDAO();
            }
            return _Instancia;

        }

        public Boolean Guardar(Articulo a)
        {

            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Articulo_Insertar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("idArticulo", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("Codigo", a.Codigo);
            cmd.Parameters.AddWithValue("BarCode", a.BarCode);
            cmd.Parameters.AddWithValue("Nombre", a.Nombre);
            cmd.Parameters.AddWithValue("Descripcion", a.Descripcion);
            cmd.Parameters.AddWithValue("idColorArticulo", a.idColorArticulo);
            cmd.Parameters.AddWithValue("idEstiloArticulo", a.idEstiloArticulo);
            cmd.Parameters.AddWithValue("idTallaArticulo", a.idTallaArticulo);
            cmd.Parameters.AddWithValue("idGeneroArticulo", a.idGeneroArticulo);
            cmd.Parameters.AddWithValue("Estado", a.Estado);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            a.idArticulo = (Int32)paramId.Value;
            return true;
        }

        public List<Articulo> Buscar(Articulo a)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            SqlCommand cmd = new SqlCommand("SP_Articulo_Buscar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("Codigo", a.Codigo);
            cmd.Parameters.AddWithValue("BarCode", a.BarCode);
            cmd.Parameters.AddWithValue("Nombre", a.Nombre);
            con.Open();
            List<Articulo> coleccion = new List<Articulo>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Articulo obj = new Articulo();
                obj.idArticulo = (Int32)dr["idArticulo"];
                obj.Codigo = dr["Codigo"].ToString();
                obj.BarCode = dr["BarCode"].ToString();
                obj.Nombre = dr["Nombre"].ToString();
                obj.Descripcion = dr["Descripcion"].ToString();
                obj.idColorArticulo = (Int32)dr["idColorArticulo"];
                obj.idTallaArticulo = (Int32)dr["idTallaArticulo"];
                obj.idEstiloArticulo = (Int32)dr["idEstiloArticulo"];
                obj.idGeneroArticulo = (Int32)dr["idGeneroArticulo"];
                obj.Estado = (Boolean)dr["Estado"];


                coleccion.Add(obj);
            }

            con.Close();
            return coleccion;
        }

        public List<Articulo> Listar(Articulo articulo)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Articulo_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<Articulo> lista = new List<Articulo>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Articulo obj = new Articulo();
                obj.idArticulo = (Int32)dr["idArticulo"];
                obj.Codigo = dr["Codigo"].ToString();
                obj.BarCode = dr["BarCode"].ToString();
                obj.Nombre = dr["Nombre"].ToString();
                obj.Descripcion = dr["Descripcion"].ToString();                      
                obj.idEstiloArticulo = (Int32)dr["idEstiloArticulo"];
                obj.idTallaArticulo = (Int32)dr["idTallaArticulo"];
                obj.idColorArticulo = (Int32)dr["idColorArticulo"];
                obj.idGeneroArticulo = (Int32)dr["idGeneroArticulo"];
                obj.Estado = (Boolean)dr["Estado"];
                lista.Add(obj);
            }
            cmd.Connection.Close();
            return lista;
        }

        public Boolean Modificar(Articulo a)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("SP_Articulo_Modificar", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("idArticulo", a.idArticulo);
            cmd.Parameters.AddWithValue("Codigo", a.Codigo);
            cmd.Parameters.AddWithValue("BarCode", a.BarCode);
            cmd.Parameters.AddWithValue("Nombre", a.Nombre);
            cmd.Parameters.AddWithValue("Descripcion", a.Descripcion);
            cmd.Parameters.AddWithValue("idColorArticulo", a.idColorArticulo);
            cmd.Parameters.AddWithValue("idTallaArticulo", a.idTallaArticulo);
            cmd.Parameters.AddWithValue("idEstiloArticulo", a.idEstiloArticulo);
            cmd.Parameters.AddWithValue("idGeneroArticulo", a.idGeneroArticulo);
            cmd.Parameters.AddWithValue("Estado", a.Estado);
            con.Open();
            Int32 i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1) return true;
            else return false;
        }

        public Articulo ObtenerArticulo(String BarCode)
        {
            string sql = @"SELECT *
                      FROM Articulo
                      WHERE BarCode = @barcode";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@barcode", BarCode);
            con.Open();

            Articulo obj = new Articulo();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                obj.idArticulo = (Int32)dr["idArticulo"];
                obj.Codigo = dr["Codigo"].ToString();
                obj.Nombre = dr["Nombre"].ToString();
                obj.BarCode = dr["BarCode"].ToString();
               

            }

            con.Close();
            return obj;


        }

        public Articulo VerificarPorCodigoDeBarras(String barcode)
        {



            string sql = @"SELECT *
                      FROM Articulo
                      WHERE BarCode = @barcode";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);

            //SqlCommand cmd = new SqlCommand("Cliente_Buscar_PA", con);
            SqlCommand command = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("nombre", c.nombre);
            command.Parameters.AddWithValue("barcode", barcode);
            con.Open();

            Articulo obj = new Articulo();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {

                obj.idArticulo = (Int32)dr["idArticulo"];
                obj.Codigo = dr["Codigo"].ToString();
                obj.Descripcion = dr["Descripcion"].ToString();
                obj.Nombre = dr["Nombre"].ToString();
                obj.idColorArticulo = (Int32)dr["idColorArticulo"];
                obj.idEstiloArticulo = (Int32)dr["idEstiloArticulo"];
                obj.idGeneroArticulo = (Int32)dr["idGeneroArticulo"];
                obj.idTallaArticulo = (Int32)dr["idTallaArticulo"];
                obj.Estado = (Boolean)dr["Estado"];
                //obj.Departamento = dr["departamento"].ToString();

            }

            con.Close();
            return obj;
        }


    }
}
