using System;
using System.Collections.Generic;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class TipoComprobanteDAO
    {
        public static TipoComprobanteDAO _Instancia;
        private TipoComprobanteDAO() { }
        public static TipoComprobanteDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new TipoComprobanteDAO();
            }
            return _Instancia;

        }

        public List<TipoComprobante> Listar(TipoComprobante TipoCom)
        {
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("SP_TipoComprobante_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<TipoComprobante> lista = new List<TipoComprobante>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TipoComprobante objTipoCom = new TipoComprobante();
                objTipoCom.idTipoComprobante = Convert.ToInt32(dr["idTipoComprobante"]);
                objTipoCom.Nombre = dr["Nombre"].ToString();
                objTipoCom.Estado = (Boolean)dr["Estado"];
                
                lista.Add(objTipoCom);
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}
