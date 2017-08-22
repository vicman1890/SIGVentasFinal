using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class TipoUsuarioNEG
    {
        public static TipoUsuarioNEG _Instancia;
        private TipoUsuarioNEG() { }
        public static TipoUsuarioNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new TipoUsuarioNEG();
            }
            return _Instancia;

        }

        public List<TipoUsuario> Listar(TipoUsuario tipoUsuario)
        {
            return TipoUsuarioDAO.Instancia().Listar(tipoUsuario);
        }

       
    }
}
