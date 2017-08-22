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
    public partial class frmSeleccionarProveedor : Form
    {
        public frmSeleccionarProveedor()
        {
            InitializeComponent();
        }

        private frmGestionIngresos frame;
   

        public void estableceFormulario(frmGestionIngresos frame)
        {
            this.frame = frame;
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.frame.codigoProveedorSeleccionado = Convert.ToInt32(this.dgvProveedor.CurrentRow.Cells["idProveedor"].Value);
            this.frame.txtNombreProveedor.Text = Convert.ToString(this.dgvProveedor.CurrentRow.Cells["Nombres"].Value);
            
        
            //Cerrando el formulario
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            dgvProveedor.DataSource = ProveedorNEG.Instancia().Listar(p);
        }

        private void txtNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Proveedor c = new Proveedor();
            c.Nombres = txtNombreProveedor.Text;
            c.Ruc = txtRucProveedor.Text;
            //dgvCliente.DataSource = bl.Buscar(c);
            dgvProveedor.DataSource = ProveedorNEG.Instancia().Buscar(c);
        }

        private void txtRucProveedor_TextChanged(object sender, EventArgs e)
        {
            Proveedor c = new Proveedor();
            c.Nombres = txtNombreProveedor.Text;
            c.Ruc = txtRucProveedor.Text;
            //dgvCliente.DataSource = bl.Buscar(c);
            dgvProveedor.DataSource = ProveedorNEG.Instancia().Buscar(c);
        }
    }
}
