using System;
using System.Collections.Generic;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class TipoComprobanteNEG
    {
        public static TipoComprobanteNEG _Instancia;
        private TipoComprobanteNEG() { }
        public static TipoComprobanteNEG Instancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new TipoComprobanteNEG();
            }
            return _Instancia;

        }

        public List<TipoComprobante> Listar(TipoComprobante tipocom)
        {
            return TipoComprobanteDAO.Instancia().Listar(tipocom);
        }
    }
}
