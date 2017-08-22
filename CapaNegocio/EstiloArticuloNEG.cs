using System;
using System.Collections.Generic;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class EstiloArticuloNEG
    {

        public static EstiloArticuloNEG _Instancia;
        private EstiloArticuloNEG() { }
        public static EstiloArticuloNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new EstiloArticuloNEG();
            }
            return _Instancia;

        }

        public List<EstiloArticulo> Listar(EstiloArticulo estilo)
        {
            return EstiloArticuloDAO.Instancia().Listar(estilo);
        }

        public Boolean Guardar(EstiloArticulo c)
        {
            //ClienteDAO dao = new ClienteDAO();
            //return dao.Guardar(c);
            return EstiloArticuloDAO.Instancia().Guardar(c);
        }

        public Boolean Modificar(EstiloArticulo c)
        {

            return EstiloArticuloDAO.Instancia().Modificar(c);
        }

        public List<EstiloArticulo> Buscar(EstiloArticulo c)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(c);*/
            return EstiloArticuloDAO.Instancia().Buscar(c);
        }

    }
}
