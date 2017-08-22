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
    public partial class frmGestionVehiculo : Form
    {
        public frmGestionVehiculo()
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
            Cliente c = new Cliente();
            c.Nombres = txtNombre_Busqueda.Text;
            c.Ruc = txtRuc_Busqueda.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvVehiculos.DataSource = ClienteNEG.Instancia().Buscar(c);
        }


        private Cliente _seleccion;

        internal Cliente Seleccion
        {
            get { return _seleccion; }
            set { _seleccion = value; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow != null)
            {
                _seleccion = (Cliente)dgvVehiculos.CurrentRow.DataBoundItem;
                txtId.Text = _seleccion.idCliente.ToString();
                txtPlaca.Text = _seleccion.Ruc.ToString();
                txtColor.Text = _seleccion.Nombres.ToString();
                /*txtDireccion.Text = _seleccion.Direccion.ToString();
                txtEmail.Text = _seleccion.Email.ToString();
                txtTelefono.Text = _seleccion.Telefono.ToString();*/
                

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
            Cliente c = new Cliente();
            c.Nombres = txtNombre_Busqueda.Text;
            c.Ruc = txtRuc_Busqueda.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvVehiculos.DataSource = ClienteNEG.Instancia().Buscar(c);
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Cliente c = new Cliente();
            c.Nombres = txtNombre_Busqueda.Text;
            c.Ruc = txtRuc_Busqueda.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvVehiculos.DataSource = ClienteNEG.Instancia().Buscar(c);
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

                Vehiculo v = new Vehiculo();

                v.Placa = txtPlaca.Text;
                v.Color = txtColor.Text;
                v.idMarca = cboMarca.SelectedIndex;
                v.idModelo = cboModelo.SelectedIndex;
                v.idCliente = 1;//DE PRUEBA


                if (radActivo.Enabled == true)
                {
                    v.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    v.Estado = false;
                }

                //ClienteNEG bl = new ClienteNEG();
                // if (bl.Guardar(c) == true)
                if (VehiculoNEG.Instancia().Guardar(v) == true)
                {
                    MessageBox.Show("El vehículo se registro correctamente");
                    this.Dispose();
                }

            }
            else
            {
                Vehiculo v = new Vehiculo();

                v.Placa = txtPlaca.Text;
                v.Color = txtColor.Text;
                v.idMarca = cboMarca.SelectedIndex;
                v.idModelo = cboModelo.SelectedIndex;
                v.idCliente = 1;//DE PRUEBA
                if (radActivo.Enabled == true)
                {
                    v.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    v.Estado = false;
                }

                //ClienteNEG bl = new ClienteNEG();
                /*if (VehiculoNEG.Instancia().Modificar(v) == true)
                {
                    MessageBox.Show("Los datos del Cliente se actualizó correctamente");
                    this.Dispose();
                }*/
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

                txtPlaca.Clear();
                txtColor.Clear();
                /*txt.Clear();
                txtEmail.Clear();*/

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                btnRegistrar.Enabled = true;
                btnReporte.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void copyAlltoClipboard()
        {
            dgvVehiculos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvVehiculos.MultiSelect = true;
            dgvVehiculos.SelectAll();
            DataObject dataObj = dgvVehiculos.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void txtRuc_TextChanged_1(object sender, EventArgs e)
        {
            
           
        }

        private void txtRuc_Leave(object sender, EventArgs e)
        {
            Cliente cRegistrado = ClienteNEG.Instancia().VerificarPorRuc(txtPlaca.Text);
            if (txtPlaca.TextLength != 11)
            {
                MessageBox.Show("El RUC debe tener 11 digitos");
                //txtRuc.Focus();

            }
            else if(cRegistrado.idCliente > 0)
            {

                txtColor.Text = cRegistrado.Nombres;
                /*txtDireccion.Text = cRegistrado.Direccion;
                txtTelefono.Text = cRegistrado.Telefono;
                txtEmail.Text = cRegistrado.Email;*/
                txtId.Text = (cRegistrado.idCliente).ToString();

                MessageBox.Show("Ese RUC ya esta registrado");
                
            }

            /*else
            {

                txtNombre.Clear();
                txtDireccion.Clear();
                txtDepartamento.Clear();
                btnGuardar.Text = "Guardar";
                
            }*/
        }
    }
}
