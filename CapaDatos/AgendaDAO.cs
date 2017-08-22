using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class AgendaDAO
    {
        public Boolean Guardar(Agenda a)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Agenda_Insertar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramId = new SqlParameter("id", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramId);

            cmd.Parameters.AddWithValue("Nombre", a.nombre);
            cmd.Parameters.AddWithValue("idTipo", a.idTipo);
            cmd.Parameters.AddWithValue("telefono", a.telefono);
            cmd.Parameters.AddWithValue("rpc", a.rpc);
            cmd.Parameters.AddWithValue("rpm", a.rpm);
           

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            a.id = (Int32)paramId.Value;
            return true;
        }

        public List<Agenda> Buscar(Agenda a)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.con);
            SqlCommand cmd = new SqlCommand("Agenda_Buscar_PA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombre", a.nombre);
            con.Open();
            List<Agenda> coleccion = new List<Agenda>();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agenda obj = new Agenda();
                obj.id = (Int32)dr["Id"];
                obj.nombre = dr["nombre"].ToString();
                obj.idTipo = (Int32)dr["idTipo"];
                obj.telefono = dr["telefono"].ToString();
                obj.rpc = dr["rpc"].ToString();
                obj.rpm = dr["rpm"].ToString();
                

                coleccion.Add(obj);
            }

            con.Close();
            return coleccion;
        }

        

        
    }
}
