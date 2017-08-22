using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DetalleVentaDAO
    {

        public static DetalleVentaDAO _Instancia;
        private DetalleVentaDAO() { }
        public static DetalleVentaDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new DetalleVentaDAO();
            }
            return _Instancia;

        }


        public DataTable ListarDetalleVenta(int idVenta)
        {
            DataTable DtResultado = new DataTable("DetalleVenta");
            SqlConnection con = Conexion.Instancia().conectar();
            /*try
            {*/

            SqlCommand cmd = new SqlCommand("SP_DetalleVenta_Listar", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idVenta", idVenta);
            SqlDataAdapter SqlDat = new SqlDataAdapter(cmd);
            SqlDat.Fill(DtResultado);

            /*}
            catch (Exception ex)
            {
                DtResultado = null;
            }*/
            return DtResultado;

        }
    }
}
