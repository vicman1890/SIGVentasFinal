using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ArticuloNEG
    {
        public static ArticuloNEG _Instancia;
        private ArticuloNEG() { }
        public static ArticuloNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ArticuloNEG();
            }
            return _Instancia;

        }

        public Boolean Guardar(Articulo a)
        {
            //ClienteDAO dao = new ClienteDAO();
            //return dao.Guardar(c);
            return ArticuloDAO.Instancia().Guardar(a);
        }

        public List<Articulo> Listar(Articulo articulo)
        {
            return ArticuloDAO.Instancia().Listar(articulo);
        }

        public List<Articulo> Buscar(Articulo a)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(c);*/
            return ArticuloDAO.Instancia().Buscar(a);
        }

        public Boolean Modificar(Articulo a)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Modificar(c);*/
            return ArticuloDAO.Instancia().Modificar(a);
        }

        public Articulo ObtenerArticulo(String barcode)
        {

            return ArticuloDAO.Instancia().ObtenerArticulo(barcode);
        }

        public Articulo VerificarBarCode(String barcode)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Modificar(c);*/
            return ArticuloDAO.Instancia().VerificarPorCodigoDeBarras(barcode);
        }

    }
}
