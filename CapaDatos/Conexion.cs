using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        
        public static Conexion _Instancia;
		private Conexion(){}
        public static Conexion Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Conexion();
            }
            return _Instancia;

        }
               
        public SqlConnection conectar()
        {
            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
          
           //"Data Source = 192.168.2.50; Initial Catalog=SigVentas2; Persist Security Info=False; User ID = sa; Password = Amdmsi1890"; 
           //"Data Source = localhost; Initial Catalog=SigVentas; Persist Security Info=False; User ID = sa; Password = amdmsi1890";
            "Data Source = DACA-VCHAVEZ; Initial Catalog=SigVentas; Persist Security Info=False; User ID = sa; Password = amdmsi1890";
            return cn;
            
        }
    }
}
