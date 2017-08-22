using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ProveedorNEG
    {
        public static ProveedorNEG _Instancia;
        private ProveedorNEG() { }
        public static ProveedorNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ProveedorNEG();
            }
            return _Instancia;

        }

     
        public List<Proveedor> Listar(Proveedor proveedor)
        {
            return ProveedorDAO.Instancia().Listar(proveedor);
        }

        public Boolean Guardar(Proveedor c)
        {
            //ClienteDAO dao = new ClienteDAO();
            //return dao.Guardar(c);
            return ProveedorDAO.Instancia().Guardar(c);
        }
        public List<Proveedor> Buscar(Proveedor c)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(c);*/
            return ProveedorDAO.Instancia().Buscar(c);
        }

        public Boolean Modificar(Proveedor c)
        {

            return ProveedorDAO.Instancia().Modificar(c);
        }
    }
}
