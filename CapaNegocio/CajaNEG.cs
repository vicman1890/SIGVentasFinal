using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CajaNEG
    {

        public Decimal getMontoActual()
        {
            CajaDAO dao = new CajaDAO();
            return dao.getMontoActual();
        }

    }
}
