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
    public partial class frmGestionPersonal : Form
    {
        public frmGestionPersonal()
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
            Usuario c = new Usuario();
            c.Nombres = txtNombre_Busqueda.Text;
            c.Username = txtUsuario_Busqueda.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            dgvUsuarios.DataSource = UsuarioNEG.Instancia().Buscar(c);
        }


        private Usuario _seleccion;

        internal Usuario Seleccion
        {
            get { return _seleccion; }
            set { _seleccion = value; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                _seleccion = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                txtIdUsuario.Text = _seleccion.idUsuario.ToString();
                txtDni.Text = _seleccion.Dni.ToString();
                txtNombre.Text = _seleccion.Nombres.ToString();
                txtApePaterno.Text = _seleccion.ApellidoPaterno.ToString();
                txtApeMaterno.Text = _seleccion.ApellidoMaterno.ToString();
                txtUsuario.Text = _seleccion.Username.ToString();
                txtDomicilio.Text = _seleccion.Direccion.ToString();
                txtSalario.Text = _seleccion.Salario.ToString();
                dtpIngreso.Value = _seleccion.FechaIngreso;
                cboDiaDescanso.SelectedValue = _seleccion.DiaDescanso;
                cboDiaPago.SelectedValue = _seleccion.DiaPago;
                txtUsuario.Text = _seleccion.Username;

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
           
        }

      
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Usuario c = new Usuario();

            c.Nombres = txtNombre.Text;
            c.ApellidoPaterno = txtApePaterno.Text;
            c.ApellidoMaterno = txtApeMaterno.Text;
            c.Username = txtUsuario.Text;
            c.Password = txtPassword.Text;
            c.idTipoUsuario = cboTipoUsuario.SelectedIndex + 1;
            c.Dni = txtDni.Text;
            c.Direccion = txtDomicilio.Text;
            c.FechaIngreso = dtpIngreso.Value;
            c.Salario = Convert.ToDecimal(txtSalario.Text);
            c.DiaPago = cboDiaPago.SelectedText;
            c.DiaDescanso = cboDiaDescanso.SelectedText;

            if (radActivo.Enabled == true)
                {
                c.Estado = true;
                }
            else if (radInactivo.Enabled == true)
                {
                    c.Estado = false;
                }

            if (txtPassword.Text == txtPass2.Text) { 

                if (txtIdUsuario.Text == "")
                {
                    if (UsuarioNEG.Instancia().Guardar(c) == true)
                    {
                        MessageBox.Show("El Usuario se registró correctamente");
                        this.Dispose();
                    }
                }
                else
                {
                    c.idUsuario = Convert.ToInt32(txtIdUsuario.Text);
                    if (UsuarioNEG.Instancia().Modificar(c) == true)
                    {
                        MessageBox.Show("Los datos del Usuario se actualizarón correctamente");
                        this.Dispose();
                    }               
                }

            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GestionPersonal_Load(object sender, EventArgs e)
        {
  
            var dataSource = new List<DiasSemana>();
            dataSource.Add(new DiasSemana() { idDia = "Lunes", DiaSemana = "Lunes" });
            dataSource.Add(new DiasSemana() { idDia = "Martes", DiaSemana = "Martes" });
            dataSource.Add(new DiasSemana() { idDia = "Miercoles", DiaSemana = "Miercoles" });
            dataSource.Add(new DiasSemana() { idDia = "Jueves", DiaSemana = "Jueves" });
            dataSource.Add(new DiasSemana() { idDia = "Viernes", DiaSemana = "Viernes" });
            dataSource.Add(new DiasSemana() { idDia = "Sabado", DiaSemana = "Sabado" });
            dataSource.Add(new DiasSemana() { idDia = "Domingo", DiaSemana = "Domingo" });

            cboDiaDescanso.DataSource = dataSource;
            cboDiaDescanso.DisplayMember = "idDia"; //dato que queremos mostrar
            cboDiaDescanso.ValueMember = "DiaSemana"; //dato que guardaremos, es el nombre declarado en la clase

            var dataSource2 = new List<DiasSemana>();
            dataSource2.Add(new DiasSemana() { idDia = "Lunes", DiaSemana = "Lunes" });
            dataSource2.Add(new DiasSemana() { idDia = "Martes", DiaSemana = "Martes" });
            dataSource2.Add(new DiasSemana() { idDia = "Miercoles", DiaSemana = "Miercoles" });
            dataSource2.Add(new DiasSemana() { idDia = "Jueves", DiaSemana = "Jueves" });
            dataSource2.Add(new DiasSemana() { idDia = "Viernes", DiaSemana = "Viernes" });
            dataSource2.Add(new DiasSemana() { idDia = "Sabado", DiaSemana = "Sabado" });
            dataSource2.Add(new DiasSemana() { idDia = "Domingo", DiaSemana = "Domingo" });

            btnRegistrar.Enabled = false;
            cboTipoUsuario.DataSource = TipoUsuarioNEG.Instancia().Listar(new TipoUsuario());
            cboTipoUsuario.DisplayMember = "Descripcion"; //dato que queremos mostrar
            cboTipoUsuario.ValueMember = "idTipoUsuario"; //dato que guardaremos, es el nombre declarado en la clase
           
            cboDiaPago.DataSource = dataSource2;
            cboDiaPago.DisplayMember = "idDia"; //dato que queremos mostrar
            cboDiaPago.ValueMember = "DiaSemana"; //dato que guardaremos, es el nombre declarado en la clase

            txtSalario.Text = string.Format("{0:#,##0.00}", double.Parse(txtSalario.Text));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                btnRegistrar.Enabled = false;
                btnReporte.Enabled = true;
                btnModificar.Enabled = true;

                txtDni.Clear();
                txtNombre.Clear();
                txtApePaterno.Clear();
                txtApeMaterno.Clear();
                txtUsuario.Clear();
                txtPassword.Clear();
                txtPass2.Clear();
                txtDomicilio.Clear();
                txtSalario.Clear();
                cboDiaPago.Refresh();
                cboDiaDescanso.Refresh();
                dtpIngreso.Refresh();

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
            dgvUsuarios.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvUsuarios.MultiSelect = true;
            dgvUsuarios.SelectAll();
            DataObject dataObj = dgvUsuarios.GetClipboardContent();
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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoNumeros(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoNumeros(e);
        }

        public void IngresoNumeros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) //Al pulsar teclas de números.
            {
                e.Handled = false; //Se acepta
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta 
            }
            else
            {
                e.Handled = true; //No se acepta
            }
        }
    }
}
