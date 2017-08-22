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
    public partial class frmGestionServicios : Form
    {
        public frmGestionServicios()
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
                txtDescripcion.Text = _seleccion.Dni.ToString();
            

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

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "")
            {

                Usuario c = new Usuario();

                /*c.Nombres = txtNombre.Text;
                c.ApellidoPaterno = txtApePaterno.Text;
                c.ApellidoMaterno = txtApeMaterno.Text;
                c.Username = txtUsuario.Text;
                c.Password = txtPassword.Text;
               
                c.idTipoUsuario = cboTipoUsuario.SelectedIndex + 1;
                c.Dni = txtDescripcion.Text;
                c.Direccion = txtDomicilio.Text;
                c.FechaIngreso = dtpIngreso.Value;
                c.Salario = Convert.ToDecimal(txtSalario.Text);
                c.DiaPago = cboDiaPago.SelectedText;
                c.DiaDescanso = cboDiaDescanso.SelectedText;*/
                
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

             
              

            }
            else
            {
                Usuario c = new Usuario();
                c.idUsuario = Convert.ToInt32(txtIdUsuario.Text);

                /*c.Nombres = txtNombre.Text;
                c.ApellidoPaterno = txtApePaterno.Text;
                c.ApellidoMaterno = txtApeMaterno.Text;
                c.Username = txtUsuario.Text;
                c.Password = txtPassword.Text;
                c.idTipoUsuario = cboTipoUsuario.SelectedIndex + 1;
                c.Dni = txtDescripcion.Text;
                c.Direccion = txtDomicilio.Text;
                c.FechaIngreso = dtpIngreso.Value;
                c.Salario = Convert.ToDecimal(txtSalario.Text);
                c.DiaPago = cboDiaPago.Text;
                c.DiaDescanso = cboDiaDescanso.Text;*/

                if (radActivo.Enabled == true)
                {
                    c.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    c.Estado = false;
                }

               
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
            

            var dataSource2 = new List<DiasSemana>();
            dataSource2.Add(new DiasSemana() { idDia = "Lunes", DiaSemana = "Lunes" });
            dataSource2.Add(new DiasSemana() { idDia = "Martes", DiaSemana = "Martes" });
            dataSource2.Add(new DiasSemana() { idDia = "Miercoles", DiaSemana = "Miercoles" });
            dataSource2.Add(new DiasSemana() { idDia = "Jueves", DiaSemana = "Jueves" });
            dataSource2.Add(new DiasSemana() { idDia = "Viernes", DiaSemana = "Viernes" });
            dataSource2.Add(new DiasSemana() { idDia = "Sabado", DiaSemana = "Sabado" });
            dataSource2.Add(new DiasSemana() { idDia = "Domingo", DiaSemana = "Domingo" });

            btnRegistrar.Enabled = false;
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                btnRegistrar.Enabled = false;
                btnReporte.Enabled = true;
                btnModificar.Enabled = true;

                txtDescripcion.Clear();
               

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
    }
}
