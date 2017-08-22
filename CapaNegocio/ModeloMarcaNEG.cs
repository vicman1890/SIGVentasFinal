using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class ModeloMarcaNEG
    {

       public static ModeloMarcaNEG _Instancia;
       private ModeloMarcaNEG() { }
       public static ModeloMarcaNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ModeloMarcaNEG();
            }
            return _Instancia;

        }

       public List<ModeloVehiculo> ListarModelos(int idMarcaVehiculo)
       {
          return ModeloVehiculoDAO.Instancia().ListarModeloMarca(idMarcaVehiculo);
       }

    }
}
