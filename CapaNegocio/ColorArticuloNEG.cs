using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class ColorArticuloNEG
    {
        public static ColorArticuloNEG _Instancia;
        private ColorArticuloNEG() { }
        public static ColorArticuloNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ColorArticuloNEG();
            }
            return _Instancia;

        }

        public List<ColorArticulo> Listar(ColorArticulo color)
        {
            return ColorArticuloDAO.Instancia().Listar(color);
        }

        public Boolean Guardar(ColorArticulo c)
        {
            //ClienteDAO dao = new ClienteDAO();
            //return dao.Guardar(c);
            return ColorArticuloDAO.Instancia().Guardar(c);
        }

        public Boolean Modificar(ColorArticulo c)
        {

            return ColorArticuloDAO.Instancia().Modificar(c);
        }

        public List<ColorArticulo> Buscar(ColorArticulo c)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(c);*/
            return ColorArticuloDAO.Instancia().Buscar(c);
        }
    }
}
