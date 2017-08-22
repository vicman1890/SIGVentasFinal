using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class GeneroArticuloNEG
    { 
        public static GeneroArticuloNEG _Instancia;
        private GeneroArticuloNEG() { }
        public static GeneroArticuloNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new GeneroArticuloNEG();
            }
            return _Instancia;

        }

        public List<GeneroArticulo> Listar(GeneroArticulo genero)
        {
            return GeneroArticuloDAO.Instancia().Listar(genero);
        }
    }
}
