using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class ServicioNEG
    {

        public static ServicioNEG _Instancia;
        private ServicioNEG() { }
        public static ServicioNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ServicioNEG();
            }
            return _Instancia;

        }
        
        
        
        public List<Servicio> Listar(Servicio servicio)
        {
            return ServicioDAO.Instancia().Listar(servicio);
        }

        public Boolean Guardar(Servicio s)
        {
           
            return ServicioDAO.Instancia().Guardar(s);
        }

        public List<Servicio> Buscar(Servicio s)
        {
          
            return ServicioDAO.Instancia().Buscar(s);
        }
        public Boolean Modificar(Servicio s)
        {
            
            return ServicioDAO.Instancia().Modificar(s);
        }

        public Servicio ServicioPorTipoVehiculo(int ModeloMarca, String desc)
        {

            return ServicioDAO.Instancia().ServicioSeleccionadoTipoVehiculo(ModeloMarca, desc);
        }


    }
}
