using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class TipoUsuarioDAO
    {
        public static TipoUsuarioDAO _Instancia;
        private TipoUsuarioDAO() { }
        public static TipoUsuarioDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new TipoUsuarioDAO();
            }
            return _Instancia;

        }

        public List<TipoUsuario> Listar(TipoUsuario tipoUsuario)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("SP_TipoUsuario_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<TipoUsuario> lista = new List<TipoUsuario>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TipoUsuario objTipoUsuario = new TipoUsuario();
                objTipoUsuario.idTipoUsuario = Convert.ToInt32(dr["idTipoUsuario"]);
                objTipoUsuario.Descripcion = dr["Descripcion"].ToString();
                lista.Add(objTipoUsuario);
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}