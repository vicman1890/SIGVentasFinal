using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class GeneroArticuloDAO
    {
        public static GeneroArticuloDAO _Instancia;
        private GeneroArticuloDAO() { }
        public static GeneroArticuloDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new GeneroArticuloDAO();
            }
            return _Instancia;

        }

        public List<GeneroArticulo> Listar(GeneroArticulo genero)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("SP_Genero_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<GeneroArticulo> lista = new List<GeneroArticulo>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GeneroArticulo objGenero = new GeneroArticulo();
                objGenero.idGeneroArticulo = Convert.ToInt32(dr["idGenero"]);
                objGenero.Descripcion = dr["Nombre"].ToString();
                //objEstilo.Estado = Convert.ToBoolean(dr["Estado"]);
                lista.Add(objGenero);
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}
