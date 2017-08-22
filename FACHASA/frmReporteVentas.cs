using System;
using CapaEntidades;
using CapaNegocio;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Printing;
using System.Management;
using System.Globalization;

namespace FACHASA
{
    public partial class frmReporteVentas : Form
    {

        internal int codigoClienteSeleccionado = -1;
        internal int codigoArticuloSeleccionado = -1;
        private decimal totalPagar = 0;
        private decimal igv = 0;
        private decimal sub = 0;
      

        crReporte rpt = new crReporte();

        public frmReporteVentas()
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

        private DataTable dtDetalle;

        private void mError(string mensaje)
        {
            MessageBox.Show(this, mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void mOk(string mensaje)
        {
            MessageBox.Show(this, mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmGestionIngresos_Load(object sender, EventArgs e)
        {

            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
         

            
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

      

        private void btnQuitar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBarCodeArticulo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            //if (nudCantidad.Value.ToString() ;
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {



        }
        private void copyAlltoClipboard()
        {
            dgvReporteVentas.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvReporteVentas.MultiSelect = true;
            dgvReporteVentas.SelectAll();
            DataObject dataObj = dgvReporteVentas.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void txtStockActual_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
             dgvReporteVentas.DataSource = VentaNEG.Instancia().reporteVentasxDias("24/07/2016", "25/08/2016");
        }

    

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void tabConsulta_Ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radActivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radInactivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
