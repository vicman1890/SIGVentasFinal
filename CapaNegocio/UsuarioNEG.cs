using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioNEG
    {
        
        public static UsuarioNEG _Instancia;
        private UsuarioNEG() { }
        public static UsuarioNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new UsuarioNEG();
            }
            return _Instancia;

        }

    
        public Boolean Guardar(Usuario u)
        {

            return UsuarioDAO.Instancia().Guardar(u);
        }

        public Boolean Modificar(Usuario u)
        {

            return UsuarioDAO.Instancia().Modificar(u);
        }

        public Usuario Login(String username, String password)
        {
           
            return UsuarioDAO.Instancia().Autenticar(username, password);  
        }

        public List<Usuario> Buscar(Usuario c)
        {
            /*ClienteDAO dao = new ClienteDAO();
            return dao.Buscar(c);*/
            return UsuarioDAO.Instancia().Buscar(c);
        }
    }
}
