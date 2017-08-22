using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using Tesseract;
using AForge;
using AForge.Imaging.Filters;
using System.Text.RegularExpressions;
using System.Drawing;

namespace FACHASA
{
    public partial class frmGestionCliente : Form
    {
        IntRange red = new IntRange(0, 255);
        IntRange green = new IntRange(0, 255);
        IntRange blue = new IntRange(0, 255);
        Sunat MyInfoSunat;
        string Texto = string.Empty;

        public frmGestionCliente()
        {
            InitializeComponent();
            try
            {
                CargarImagenSunat();
                LeerCaptchaSunat();
                //CargarImagenReniec();
                //AplicacionFiltros();
                //LeerCaptchaReniec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public void BuscarCliente()
        {         
            Cliente c = new Cliente();
            c.Nombres = txtNombre_Busqueda.Text;
            c.Ruc = txtRuc_Busqueda.Text;         
            dgvClientes.DataSource = ClienteNEG.Instancia().Buscar(c);
        }


        private bool ValidarDatos()
        {
            foreach (Control c in this.gboxRegistro.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {
                        MessageBox.Show("No pueden quedar espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private Cliente _seleccion;

        internal Cliente Seleccion
        {
            get { return _seleccion; }
            set { _seleccion = value; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                _seleccion = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                txtId.Text = _seleccion.idCliente.ToString();
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
            BuscarCliente();
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            BuscarCliente();
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

            if (ValidarDatos())
            {

                email_bien_escrito(txtEmail.Text);
                Cliente c = new Cliente();
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
                if (txtId.Text == "" && ClienteNEG.Instancia().Guardar(c) == true)
                {
                    MessageBox.Show("El Cliente se registró con exito");
                    this.Dispose();
                }
                else
                {
                    c.idCliente = Convert.ToInt32(txtId.Text);
                    if (ClienteNEG.Instancia().Modificar(c) == true)
                    {
                        MessageBox.Show("Los datos del Cliente se actualizarón correctamente");
                        this.Dispose();
                    }
                }
            }

            else
            {
                MessageBox.Show("No se realizó el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                txtId.Clear();
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

        private void copyAlltoClipboard()
        {
            dgvClientes.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvClientes.MultiSelect = true;
            dgvClientes.SelectAll();
            DataObject dataObj = dgvClientes.GetClipboardContent();
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

           

        private void CargarImagenSunat()
        {
            try
            {
                if (MyInfoSunat == null)
                    MyInfoSunat = new Sunat();
                this.pictureCapcha.Image = MyInfoSunat.GetCapcha;
                LeerCaptchaSunat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LeerCaptchaSunat()
        {
            //using (var engine2 = new TesseractEngine())

            try
            {

                using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var image = new System.Drawing.Bitmap(pictureCapcha.Image))
                {
                    using (var pix = PixConverter.ToPix(image))
                    {
                        using (var page = engine.Process(pix))
                        {
                            var Porcentaje = String.Format("{0:P}", page.GetMeanConfidence());
                            string CaptchaTexto = page.GetText();
                            char[] eliminarChars = { '\n', ' ' };
                            CaptchaTexto = CaptchaTexto.TrimEnd(eliminarChars);
                            CaptchaTexto = CaptchaTexto.Replace(" ", string.Empty);
                            CaptchaTexto = Regex.Replace(CaptchaTexto, "[^a-zA-Z]+", string.Empty);
                            if (CaptchaTexto != string.Empty & CaptchaTexto.Length == 4)
                                txtTexto.Text = CaptchaTexto.ToUpper();
                            else
                                CargarImagenSunat();
                        }
                    }
                }

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AplicacionFiltros()
        {
            Bitmap bmp = new Bitmap(pictureCapchaR.Image);
            FiltroInvertir(bmp);
            ColorFiltros();
            Bitmap bmp1 = new Bitmap(pictureCapchaE.Image);
            FiltroInvertir(bmp1);
            Bitmap bmp2 = new Bitmap(pictureCapchaE.Image);
            FiltroSharpen(bmp2);
        }
        private void FiltroInvertir(Bitmap bmp)
        {
            IFilter Filtro = new Invert();
            Bitmap XImage = Filtro.Apply(bmp);
            pictureCapchaE.Image = XImage;
        }
        private void ColorFiltros()
        {
            red.Min = Math.Min(red.Max, byte.Parse("229"));
            red.Max = Math.Max(red.Min, byte.Parse("255"));
            green.Min = Math.Min(green.Max, byte.Parse("0"));
            green.Max = Math.Max(green.Min, byte.Parse("255"));
            blue.Min = Math.Min(blue.Max, byte.Parse("0"));
            blue.Max = Math.Max(blue.Min, byte.Parse("130"));
            ActualizarFiltro();
        }
        private void ActualizarFiltro()
        {
            ColorFiltering FiltroColor = new ColorFiltering();
            FiltroColor.Red = red;
            FiltroColor.Green = green;
            FiltroColor.Blue = blue;
            IFilter Filtro = FiltroColor;
            Bitmap bmp = new Bitmap(pictureCapchaE.Image);
            Bitmap XImage = Filtro.Apply(bmp);
            pictureCapchaE.Image = XImage;
        }
        private void FiltroSharpen(Bitmap bmp)
        {
            IFilter Filtro = new Sharpen();
            Bitmap XImage = Filtro.Apply(bmp);
            pictureCapchaE.Image = XImage;
        }

        private void btnBuscarRucSunat_Click(object sender, EventArgs e)
        {
            //txtTexto.Text = string.Empty;
            MyInfoSunat.GetInfo(this.txtRuc.Text, this.txtTexto.Text);
            switch (MyInfoSunat.GetResul)
            {
                case Sunat.Resul.Ok:
                    //limpiarSunat();
                    //txt.Text = MyInfoSunat.Ruc;
                    String a = MyInfoSunat.Ruc;
                    txtDireccion.Text = MyInfoSunat.Direcion;
                    txtNombre.Text = MyInfoSunat.RazonSocial;
                    //txtestado.Text = MyInfoSunat.EstadoContr;
                    String x = MyInfoSunat.EstadoContr;
                    txtTelefono.Text = MyInfoSunat.Telefono;
                   
                    String ax = MyInfoSunat.TipoContr;
                    //txttipo.Text = MyInfoSunat.TipoContr;
                    String xss = MyInfoSunat.Direcion;
                    //Ciudad(MyInfoSunat.Direcion);
                    break;
                case Sunat.Resul.NoResul:
                    //limpiarSunat();
                    MessageBox.Show("No Existe RUC");
                    break;
                case Sunat.Resul.ErrorCapcha:
                    //limpiarSunat();
                    MessageBox.Show("Ingrese imagen correctamente");
                    break;
                default:
                    MessageBox.Show("Error Desconocido");
                    break;
            }
            CargarImagenSunat();
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresoNumeros(e);
        }

        private void txtRuc_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
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

        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
