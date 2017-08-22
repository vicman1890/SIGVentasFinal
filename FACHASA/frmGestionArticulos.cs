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
    public partial class frmGestionArticulos : Form
    {
        public frmGestionArticulos()
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                Articulo a = new Articulo();
                a.Codigo = txtCodigo.Text;
                a.BarCode = txtBarCode.Text;
                a.Nombre = txtNombre.Text;
                a.Descripcion = txtDescripcion.Text;
                a.idColorArticulo = cboColor.SelectedIndex + 1;
                a.idEstiloArticulo = cboEstilo.SelectedIndex + 1;
                a.idGeneroArticulo = cboGenero.SelectedIndex + 1;
                a.idTallaArticulo = cboTalla.SelectedIndex + 1;

                if (radActivo.Checked == true)
                {
                    a.Estado = true;
                }
                else if (radInactivo.Checked == true)
                {
                    a.Estado = false;
                }
                if (txtIdArticulo.Text == "" && ArticuloNEG.Instancia().Guardar(a) == true)
                {
                    MessageBox.Show("El Articulo se registró correctamente");
                }
                else
                {
                    a.idArticulo = Convert.ToInt32(txtIdArticulo.Text);
                    if (ArticuloNEG._Instancia.Modificar(a) == true)
                    {
                        MessageBox.Show("El Articulo se modificó correctamente");
                    }
                }
                txtIdArticulo.Text = "";
                tabControl1.SelectedIndex = 0;
            }
            else {
                MessageBox.Show("No se realizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private bool ValidarDatos()
        {
            foreach (Control c in this.gboxArticulos.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {
                        //MessageBox.Show("No pueden quedar espacios en blanco.");
                        MessageBox.Show("No se realizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }

        private void frmGestionArticulos_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
            /*Articulo a = new Articulo();
            dgvArticulos.DataSource = ArticuloNEG.Instancia().Listar(a);*/

            cboEstilo.DataSource = EstiloArticuloNEG.Instancia().Listar(new EstiloArticulo());
            cboEstilo.DisplayMember = "Descripcion"; //dato que queremos mostrar
            cboEstilo.ValueMember = "idEstiloArticulo"; //dato que guardaremos, es el nombre declarado en la clase

            cboColor.DataSource = ColorArticuloNEG.Instancia().Listar(new ColorArticulo());
            cboColor.DisplayMember = "Descripcion"; //dato que queremos mostrar
            cboColor.ValueMember = "idColor"; //dato que guardaremos, es el nombre declarado en la clase

            cboGenero.DataSource = GeneroArticuloNEG.Instancia().Listar(new GeneroArticulo());
            cboGenero.DisplayMember = "Descripcion"; //dato que queremos mostrar
            cboGenero.ValueMember = "idGeneroArticulo"; //dato que guardaremos, es el nombre declarado en la clase

            cboTalla.DataSource = TallaArticuloNEG.Instancia().Listar(new TallaArticulo());
            cboTalla.DisplayMember = "Descripcion"; //dato que queremos mostrar
            cboTalla.ValueMember = "idTallaArticulo"; //dato que guardaremos, es el nombre declarado en la clase

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Articulo a = new Articulo();
            a.Nombre = txtCod.Text;
            a.BarCode = txtBarras.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvArticulos.DataSource = ArticuloNEG.Instancia().Buscar(a);
        }

        private Articulo _seleccion;

        internal Articulo Seleccion
        {
            get { return _seleccion; }
            set { _seleccion = value; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                _seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                txtIdArticulo.Text = _seleccion.idArticulo.ToString();
                txtCodigo.Text = _seleccion.Codigo.ToString();
                txtBarCode.Text = _seleccion.BarCode.ToString();
                txtNombre.Text = _seleccion.Nombre.ToString();
                txtDescripcion.Text = _seleccion.Descripcion.ToString();
                cboEstilo.SelectedValue = Convert.ToInt32(_seleccion.idEstiloArticulo);
                cboColor.SelectedValue = Convert.ToInt32(_seleccion.idColorArticulo);
                cboGenero.SelectedValue = Convert.ToInt32(_seleccion.idGeneroArticulo);
                cboTalla.SelectedValue = Convert.ToInt32(_seleccion.idTallaArticulo);


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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                btnRegistrar.Enabled = false;
                btnReporte.Enabled = true;
                btnModificar.Enabled = true;

                txtCodigo.Clear();
                txtBarCode.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                btnRegistrar.Enabled = true;
                btnReporte.Enabled = false;
                btnModificar.Enabled = false;
                txtIdArticulo.Text = "";

            }
        }

        private void txtBarras_TextChanged(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Articulo a = new Articulo();
            a.Nombre = txtCod.Text;
            a.BarCode = txtBarras.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvArticulos.DataSource = ArticuloNEG.Instancia().Buscar(a);
        }

        private void copyAlltoClipboard()
        {
            dgvArticulos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvArticulos.MultiSelect = true;
            dgvArticulos.SelectAll();
            DataObject dataObj = dgvArticulos.GetClipboardContent();
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

        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            Articulo cRegistrado = ArticuloNEG.Instancia().VerificarBarCode(txtBarCode.Text);
            if (cRegistrado.idArticulo > 0)
            {
                txtIdArticulo.Text = cRegistrado.idArticulo.ToString();
                txtNombre.Text = cRegistrado.Nombre;
                txtBarCode.Text = cRegistrado.BarCode;
                txtCodigo.Text = cRegistrado.Codigo.ToString();
                txtDescripcion.Text = cRegistrado.Descripcion.ToString();
                cboEstilo.SelectedValue = Convert.ToInt32(cRegistrado.idEstiloArticulo);
                cboColor.SelectedValue = Convert.ToInt32(cRegistrado.idColorArticulo);
                cboGenero.SelectedValue = Convert.ToInt32(cRegistrado.idGeneroArticulo);
                cboTalla.SelectedValue = Convert.ToInt32(cRegistrado.idTallaArticulo);

                MessageBox.Show("Este Codigo de Barras ya esta asignado a un articulo");

            }         
        }
    }
}
