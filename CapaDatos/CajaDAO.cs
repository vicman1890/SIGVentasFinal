using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CajaDAO
    {
        /*public void Monto()
        {
            Decimal monto;
            
            SqlConnection con = Conexion.Instancia().conectar();
            SqlCommand cmd = new SqlCommand("Monto_Actual_Caja_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Connection.Open();
           
            //SqlDataReader dr = cmd.ExecuteReader();
            monto = Convert.ToDecimal(cmd.ExecuteScalar()); 
            cmd.Connection.Close();

            return monto > 0;*/

        public Decimal getMontoActual()
        {
            SqlConnection con = Conexion.Instancia().conectar();
            Decimal monto;
            SqlCommand cmd = new SqlCommand("Monto_Actual_Caja_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
            monto = Convert.ToDecimal(cmd.ExecuteScalar());

            cmd.Connection.Close();
            return monto;
        }


            
        }

        
            

         


            
    
}
