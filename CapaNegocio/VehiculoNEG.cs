using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class VehiculoNEG
    {
        
        public static VehiculoNEG _Instancia;
        private VehiculoNEG() { }
        public static VehiculoNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new VehiculoNEG();
            }
            return _Instancia;

        }



        public Boolean Guardar(Vehiculo u)
        {

            return VehiculoDAO.Instancia().Guardar(u);
        }

        public Vehiculo Verificar(String placa)
        {

            return VehiculoDAO.Instancia().Verificar(placa);
        }
        
      

    }
}
