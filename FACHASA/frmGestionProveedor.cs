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
    public partial class frmGestionProveedor : Form
    {
        public frmGestionProveedor()
        {
            InitializeComponent();
        }

        /*public void estableceFormulario(Central frame)
        {
            this.frame = frame;
        }*/

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Proveedor c = new Proveedor();
            c.Nombres = txtNombre_Busqueda.Text;
            c.Ruc = txtRuc_Busqueda.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvProveedores.DataSource = ProveedorNEG.Instancia().Buscar(c);
        }


        private Proveedor _seleccion;

        internal Proveedor Seleccion
        {
            get { return _seleccion; }
            set { _seleccion = value; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                _seleccion = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                txtId.Text = _seleccion.idProveedor.ToString();
                txtRuc.Text = _seleccion.Ruc.ToString();
                txtNombre.Text = _seleccion.Nombres.ToString();
                txtDireccion.Text = _seleccion.Direccion.ToString();
                txtEmail.Text = _seleccion.Email.ToString();
                txtTelefono.Text = _seleccion.Telefono.ToString();
                

                if (_seleccion.Estado == true)
                {
                    radActivo.Checked = true;
                }
                else if (_seleccion.Estado == false)
                {
                    radInactivo.Checked = true;
                }

                tabControl1.SelectedIndex = 1;
                /*ModificarServicios mc = new ModificarServicios(_seleccion);
                mc.Show();*/
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Proveedor c = new Proveedor();
            c.Nombres = txtNombre_Busqueda.Text;
            c.Ruc = txtRuc_Busqueda.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvProveedores.DataSource = ProveedorNEG.Instancia().Buscar(c);
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Proveedor c = new Proveedor();
            c.Nombres = txtNombre_Busqueda.Text;
            c.Ruc = txtRuc_Busqueda.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvProveedores.DataSource = ProveedorNEG.Instancia().Buscar(c);
        }

        private void GestionCliente_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {

                Proveedor c = new Proveedor();

                c.Nombres = txtNombre.Text;
                c.Direccion = txtDireccion.Text;
                c.Ruc = txtRuc.Text;
                c.Telefono = txtTelefono.Text;
                c.Email = txtEmail.Text;
                /* c.Departamento = txtDepartamento.Text;
                 c.Provincia = txtProvincia.Text;
                 c.Distrito = txtDistrito.Text;*/

                if (radActivo.Enabled == true)
                {
                    c.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    c.Estado = false;
                }

                //ClienteNEG bl = new ClienteNEG();
                // if (bl.Guardar(c) == true)
                if (ProveedorNEG.Instancia().Guardar(c) == true)
                {
                    MessageBox.Show("El Proveedor se grabó correctamente");
                    this.Dispose();
                }

            }
            else
            {
                Proveedor c = new Proveedor();
                c.idProveedor = Convert.ToInt32(txtId.Text);

                c.Nombres = txtNombre.Text;
                c.Direccion = txtDireccion.Text;
                c.Ruc = txtRuc.Text;
                c.Telefono = txtTelefono.Text;
                c.Email = txtEmail.Text;
                if (radActivo.Enabled == true)
                {
                    c.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    c.Estado = false;
                }

                //ClienteNEG bl = new ClienteNEG();
                if (ProveedorNEG.Instancia().Modificar(c) == true)
                {
                    MessageBox.Show("Los datos del Proveedor se actualizaron correctamente");
                    this.Dispose();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                btnRegistrar.Enabled = false;
                btnReporte.Enabled = true;
                btnModificar.Enabled = true;

                txtRuc.Clear();
                txtDireccion.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                btnRegistrar.Enabled = true;
                btnReporte.Enabled = false;
                btnModificar.Enabled = false;


            }
        }
    }
}
