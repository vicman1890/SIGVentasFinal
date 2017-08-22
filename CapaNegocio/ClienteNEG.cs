using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ClienteNEG
    {
        
        public static ClienteNEG _Instancia;
        private ClienteNEG() { }
        public static ClienteNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new ClienteNEG();
            }
            return _Instancia;

        }
               
        
        //ClienteDAO dao = new ClienteDAO();
        
        public Boolean Guardar(Cliente c)
        {
            //ClienteDAO dao = new ClienteDAO();
            //return dao.Guardar(c);
            return ClienteDAO.Instancia().Guardar(c);
        }
        public List<Cliente> Buscar(Cliente c)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(c);*/
            return ClienteDAO.Instancia().Buscar(c);
        }

        public List<Cliente> Listar(Cliente cliente)
        {
            //return dao.Listar(cliente);
            return ClienteDAO.Instancia().Listar(cliente);
        }

        public Boolean Modificar(Cliente c)
        {
           
            return ClienteDAO.Instancia().Modificar(c);
        }

        public Cliente VerificarPorRuc(String ruc)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Modificar(c);*/
            return ClienteDAO.Instancia().VerificarPorRuc(ruc);
        }
    }
}
