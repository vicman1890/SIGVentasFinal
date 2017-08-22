using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace FACHASA
{
    public partial class ConsultarVenta : Form
    {
        public ConsultarVenta()
        {
            InitializeComponent();
        }

        private void ConsultarVenta_Load(object sender, EventArgs e)
        {
            this.dgvVentas.AutoGenerateColumns = false;
            //this.dgvVentas.DataSource = ComprobanteNEG.ObtenerVenta(fechacomprobante);
        }
    }
}
