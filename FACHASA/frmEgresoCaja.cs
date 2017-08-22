using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace FACHASA
{
    public partial class frmEgresoCaja : Form
    {
        public frmEgresoCaja()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*EgresosCaja s = new EgresosCaja();

            s.descripcion = txtDescripcion.Text;
            s.monto = Convert.ToDecimal(txtMonto.Text);
            s.fecha = Convert.ToDateTime(txtFecha.Text);


            EgresosCajaNEG bl = new EgresosCajaNEG();
            if (bl.Guardar(s) == true)
            {
                MessageBox.Show("El egreso se registro Correctamente");
                this.Dispose();
            }*/
        }

        private void EgresoCaja_Load(object sender, EventArgs e)
        {
            //txtFecha.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }
    }
}
