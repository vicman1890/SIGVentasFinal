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
    public partial class frmGestionEstilos : Form
    {
        public frmGestionEstilos()
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
            EstiloArticulo c = new EstiloArticulo();
            c.Descripcion = txtNombre_Busqueda.Text;
            dgvEstilos.DataSource = EstiloArticuloNEG.Instancia().Listar(c);
        }


        private EstiloArticulo _seleccion;

        internal EstiloArticulo Seleccion
        {
            get { return _seleccion; }
            set { _seleccion = value; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEstilos.CurrentRow != null)
            {
                _seleccion = (EstiloArticulo)dgvEstilos.CurrentRow.DataBoundItem;
                txtId.Text = _seleccion.idEstiloArticulo.ToString();
                txtDescripcionColor.Text = _seleccion.Descripcion.ToString();
                
                

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
            EstiloArticulo c = new EstiloArticulo();
            c.Descripcion = txtNombre_Busqueda.Text;
            
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvEstilos.DataSource = EstiloArticuloNEG.Instancia().Buscar(c);
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
           
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

                EstiloArticulo c = new EstiloArticulo();

                c.Descripcion = txtDescripcionColor.Text;
              
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
                if (EstiloArticuloNEG.Instancia().Guardar(c) == true)
                {
                    MessageBox.Show("El Estilo se grabó correctamente");

                    DialogResult result2 = MessageBox.Show("Desea registrar otro Estilo?", "Cerrar", MessageBoxButtons.YesNo);
                    if (result2 == DialogResult.Yes)
                    {
                        txtDescripcionColor.Clear();
                    }
                    else if (result2 == DialogResult.No)
                    {
                        this.Dispose();
                    }

                }

            }
            else
            {
                EstiloArticulo c = new EstiloArticulo();
                c.idEstiloArticulo = Convert.ToInt32(txtId.Text);
                c.Descripcion = txtDescripcionColor.Text;
               
                if (radActivo.Enabled == true)
                {
                    c.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    c.Estado = false;
                }

                //ClienteNEG bl = new ClienteNEG();
                if (EstiloArticuloNEG.Instancia().Modificar(c) == true)
                {
                    MessageBox.Show("Los datos del Estilo se actualizaron correctamente");
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

               
                txtDescripcionColor.Clear();
               

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
