using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class AgendaNEG
    {
        AgendaDAO dao = new AgendaDAO();

        public Boolean Guardar(Agenda a)
        {
            AgendaDAO dao = new AgendaDAO();
            return dao.Guardar(a);
        }

        public List<Agenda> Buscar(Agenda a)
        {
            AgendaDAO dao = new AgendaDAO();
            return dao.Buscar(a);
        }
    }
}
