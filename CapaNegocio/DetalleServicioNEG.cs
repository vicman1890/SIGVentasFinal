using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class DetalleServicioNEG
    {

        public static DetalleServicioNEG _Instancia;
        private DetalleServicioNEG() { }
        public static DetalleServicioNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new DetalleServicioNEG();
            }
            return _Instancia;

        }

        public DetalleServicio VerificarServicioDia(String placa, DateTime fecha)
        {

            return DetalleServicioDAO.Instancia().Verificar(placa, fecha);
        }
    }
}
