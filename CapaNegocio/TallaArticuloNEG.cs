using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class TallaArticuloNEG
    {
        public static TallaArticuloNEG _Instancia;
        private TallaArticuloNEG() { }
        public static TallaArticuloNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new TallaArticuloNEG();
            }
            return _Instancia;

        }
        public List<TallaArticulo> Listar(TallaArticulo talla)
        {
            return TallaArticuloDAO.Instancia().Listar(talla);
        }

        public Boolean Guardar(TallaArticulo c)
        {
            //ClienteDAO dao = new ClienteDAO();
            //return dao.Guardar(c);
            return TallaArticuloDAO.Instancia().Guardar(c);
        }

        public Boolean Modificar(TallaArticulo c)
        {

            return TallaArticuloDAO.Instancia().Modificar(c);
        }

        public List<TallaArticulo> Buscar(TallaArticulo c)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(c);*/
            return TallaArticuloDAO.Instancia().Buscar(c);
        }
    }
}
