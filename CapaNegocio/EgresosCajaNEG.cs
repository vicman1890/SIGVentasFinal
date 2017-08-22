using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class EgresosCajaNEG
    {
        public Boolean Guardar(EgresosCaja e)
        {
            EgresosCajaDAO dao = new EgresosCajaDAO();
            return dao.Guardar(e);
        }

        public Decimal getMontoEgresoActual()
        {
            EgresosCajaDAO dao = new EgresosCajaDAO();
            return dao.getMontoEgresoActual();
        }
    }
}
