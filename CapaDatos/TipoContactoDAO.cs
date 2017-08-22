using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class TipoContactoDAO
    {
        public List<TipoContacto> Listar(TipoContacto tipoContacto)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("TipoContacto_Listar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<TipoContacto> lista = new List<TipoContacto>();
            cmd.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TipoContacto objTipoContacto = new TipoContacto();
                objTipoContacto.id = Convert.ToInt32(dr["id"]);
                objTipoContacto.descripcion = dr["descripcion"].ToString();
                lista.Add(objTipoContacto);
            }
            cmd.Connection.Close();
            return lista;
        }
    }
}
