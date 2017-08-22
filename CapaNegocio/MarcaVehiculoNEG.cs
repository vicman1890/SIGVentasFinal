using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
   public class MarcaVehiculoNEG
    {

       public static MarcaVehiculoNEG _Instancia;
       private MarcaVehiculoNEG() { }
       public static MarcaVehiculoNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new MarcaVehiculoNEG();
            }
            return _Instancia;

        }

       public List<MarcaVehiculo> ListarMarcas(MarcaVehiculo marca)
       {
           //return dao.Listar(cliente);
           return MarcaVehiculoDAO.Instancia().ListarMarcas(marca);
       }

        public Boolean Guardar(MarcaVehiculo c)
        {
            //ClienteDAO dao = new ClienteDAO();
            //return dao.Guardar(c);
            return MarcaVehiculoDAO.Instancia().Guardar(c);
        }

    }
}
