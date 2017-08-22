using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace FACHASA
{
    public partial class frmSeleccionarCliente : Form
    {
        private frmGestionVentas frame;

        public frmSeleccionarCliente()
        {
            InitializeComponent();
        }

        public void estableceFormulario(frmGestionVentas frame)
        {
            this.frame = frame;
        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Cliente c = new Cliente();

            //dgvCliente.DataSource = bl.Listar(c); 
            dgvCliente.DataSource = ClienteNEG.Instancia().Listar(c);

        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.frame.codigoClienteSeleccionado = Convert.ToInt32(this.dgvCliente.CurrentRow.Cells["idCliente"].Value);
            this.frame.txtNombreCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["Nombres"].Value);
            this.frame.txtDireccionCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["Direccion"].Value);
            this.frame.txtRucCliente.Text = Convert.ToString(this.dgvCliente.CurrentRow.Cells["Ruc"].Value);
            
            //Cerrando el formulario
            this.Hide();
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Cliente c = new Cliente();
            c.Nombres = txtNombre.Text;
            c.Ruc = txtRuc.Text;
            //dgvCliente.DataSource = bl.Buscar(c);
            dgvCliente.DataSource = ClienteNEG.Instancia().Buscar(c);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Cliente c = new Cliente();
            c.Nombres = txtNombre.Text;
            c.Ruc = txtRuc.Text;
            //dgvCliente.DataSource = bl.Buscar(c);
            dgvCliente.DataSource = ClienteNEG.Instancia().Buscar(c);
        }

        
    }

}
