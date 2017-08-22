using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class EgresosCajaDAO
    {
        public Boolean Guardar(EgresosCaja e)
        {

            SqlConnection con = Conexion.Instancia().conectar();

            //SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("EgresoCaja_Insertar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("id", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("descripcion", e.descripcion);
            cmd.Parameters.AddWithValue("monto", e.monto);
            cmd.Parameters.AddWithValue("fecha", e.fecha);
            

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            e.id = (Int32)paramId.Value;
            return true;
        }

        public Decimal getMontoEgresoActual()
        {
            SqlConnection con = Conexion.Instancia().conectar();
            Decimal egresos;
            SqlCommand cmd = new SqlCommand("Egreso_Actual_Caja_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
           

                egresos = Convert.ToDecimal(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return egresos;

            
        }
    }
}
