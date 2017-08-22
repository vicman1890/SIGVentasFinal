using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class DetalleIngresoAlmacenDAO
    {

        public static DetalleIngresoAlmacenDAO _Instancia;
        private DetalleIngresoAlmacenDAO() { }
        public static DetalleIngresoAlmacenDAO Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new DetalleIngresoAlmacenDAO();
            }
            return _Instancia;

        }

        public DetalleIngresoAlmacen obtenerPrecioVenta(int id)
        {
            string sql = @"SELECT TOP 1 PrecioVenta, idDetalleIngresoAlmacen FROM DetalleIngresoAlmacen WHERE idArticulo like @id ORDER BY idDetalleIngresoAlmacen DESC;";


            SqlConnection con = Conexion.Instancia().conectar();
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand command = new SqlCommand(sql, con);

            //string hash = Helper.EncodePassword(string.Concat(usuario, password));
            //command.Parameters.AddWithValue("@password", hash);
            command.Parameters.AddWithValue("id", id);
            con.Open();

            DetalleIngresoAlmacen obj = new DetalleIngresoAlmacen();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (dr["PrecioVenta"].ToString() == "")
                {
                    obj.PrecioVenta = 0;
                }
                else {
                    obj.PrecioVenta = (Decimal)dr["PrecioVenta"];
                }
                obj.idDetalleIngresoAlmacen = (Int32)dr["idDetalleIngresoAlmacen"];
            }
            con.Close();
            return obj;
        }
    }
}
