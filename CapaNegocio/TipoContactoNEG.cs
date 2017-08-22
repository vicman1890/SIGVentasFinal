using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class TipoContactoNEG
    {
        TipoContactoDAO dao = new TipoContactoDAO();

        public List<TipoContacto> Listar(TipoContacto tipoContacto)
        {
            return dao.Listar(tipoContacto);
        }
    }
}
