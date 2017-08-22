using System;
using CapaEntidades;
using CapaNegocio;
using System.Windows.Forms;
using System.Data;

namespace FACHASA
{
    public partial class frmGestionStock : Form
    {

      
        internal int codigoArticuloSeleccionado = -1;

        private int idUsuario;

        public frmGestionStock(int idUser)
        {
            InitializeComponent();
            idUsuario = idUser;
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
            nudCantidad.Maximum = 1000;
            this.crearTabla();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Creamos una variable del tipo del formulario que deseamos abrir
            frmSeleccionarArticulo frame3 = new frmSeleccionarArticulo();
            //Le pasamos como datos la información de nuestro formulario
            frame3.estableceFormulario3(this);
            //Mostrar el formulario que tiene los productos que hemos seleccionado
            frame3.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conversion hl = new Conversion();
            int stockFinal = Int32.Parse(txtStock.Text);
            decimal stockSolicitado = nudCantidad.Value;

            //Valida que hemos seleccionado algun producto
            if (this.codigoArticuloSeleccionado == -1)
            {
                this.mError("No ha seleccionado aún ningun Producto o Servicio");
            }

            else if (stockFinal < stockSolicitado)
            {
                this.mError("No hay stock suficiente");
            }

            else
            {
                //Variable que va a indicar si podemos registrar el detalle
                bool registrar = true;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    if (Convert.ToInt32(row["idArticulo"]) == this.codigoArticuloSeleccionado)
                    {
                        registrar = false;
                        this.mError("Ya se encuentra el producto en el detalle");
                    }
                }
                //Si podemos registrar el producto en el detalle
                if (registrar)
                {
                    //Calculamos el sub total del detalle sin descuento
                   

                    decimal igvTotal = Convert.ToDecimal(18);

                    //Obtenemos el descuento


                    //Aumentamos el total a pagar

                  
                    //this.totalPagar += subTotal;
                
                    /*this.sub = totalPagar / ((igvTotal / 100) + 1);
                    this.lblSubTotal.Text = "Sub Total: S/." + sub.ToString("#0.00#");
                    this.igv = totalPagar - sub;
                    this.lblIGV.Text = "IGV(18%): S/." + igv.ToString("#0.00#");
                    this.txtTotalNum.Text = hl.Convertir(numero, true);*/
                    //Agregamos al fila a nuestro datatable
                    DataRow row = this.dtDetalle.NewRow();
                    row["idArticulo"] = this.codigoArticuloSeleccionado;
                    row["Codigo"] = this.txtCodigoArticulo.Text;
                    row["Nombre"] = this.txtNombreArticulo.Text;
                    row["cantidad"] = this.nudCantidad.Value;
                    

                    this.dtDetalle.Rows.Add(row);
                }
            }
        }

        private void crearTabla()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("idArticulo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Codigo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Nombre", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Decimal"));
           
            //Relacionamos nuestro datagridview con nuestro datatable
            this.dgvDetalleStock.DataSource = this.dtDetalle;

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {

                //Indice dila actualmente seleccionado y que vamos a eliminar
                int indiceFila = this.dgvDetalleStock.CurrentCell.RowIndex;
                //Fila que vamos a eliminar
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuimos el total a pagar
                
                //Removemos la fila
                this.dtDetalle.Rows.Remove(row);
            }


            catch (Exception ex)
            {
                mError("No hay fila para remover");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
          
        }

        private void txtCodigoArticulo_TextChanged(object sender, EventArgs e)
        {

            String barcode = txtCodigoArticulo.Text;
            //ClienteNEG bl = new ClienteNEG();
            Articulo a = ArticuloNEG.Instancia().ObtenerArticulo(barcode);
            txtNombreArticulo.Text = a.Nombre;
            codigoArticuloSeleccionado = a.idArticulo;
            //DetalleIngresoAlmacen d = new DetalleIngresoAlmacen();
            //int stockFinal = IngresoAlmacenNEG.ObtenerStockActual(Convert.ToInt32(row.Cells["idArticulo"].Value));
            DetalleIngresoAlmacen dStockFinal = IngresoAlmacenNEG.Instancia().ObtenerStockActual(codigoArticuloSeleccionado);
            txtStock.Text = dStockFinal.CantidadFinal.ToString();

            DetalleIngresoAlmacen dPrecioActual = DetalleIngresoNEG.Instancia().obtenerPrecioVenta(codigoArticuloSeleccionado);
            txtPrecio.Text = dPrecioActual.PrecioVenta.ToString();
            
            //Cerrando el formulario

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
              
                StockTienda c = new StockTienda();
                c.FechaIngresoTienda = dtpFechaIngreso.Value;
                //c.idCliente = codigoClienteSeleccionado;
                c.idUsuario = idUsuario;
               

                if (radActivo.Enabled == true)
                {
                    c.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    c.Estado = false;
                }

   
                foreach (DataGridViewRow row in dgvDetalleStock.Rows)
                {
                    DetalleStockTienda de = new DetalleStockTienda();
                    DetalleStockTienda dStockFinal = StockTiendaNEG.Instancia().ObtenerStockActual(Convert.ToInt32(row.Cells["idArticulo"].Value));
                   
                    
                    de.idArticulo = Convert.ToInt32(row.Cells["idArticulo"].Value);
                    DetalleIngresoAlmacen dPrecioActual = DetalleIngresoNEG.Instancia().obtenerPrecioVenta(de.idArticulo);
                    int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    de.idDetalleIngresoAlmacen = dPrecioActual.idDetalleIngresoAlmacen;
                    
                    de.StockInicial = Convert.ToInt32(row.Cells["cantidad"].Value);
                    de.StockFinal = Convert.ToInt32(row.Cells["cantidad"].Value) + dStockFinal.StockFinal;
                    VentaNEG.Instancia().reducirStock(de.idArticulo, cantidad);
                    c.Lineas.Add(de);
                }



                StockTiendaNEG.RegistrarIngresoTienda(c);
               
                MessageBox.Show("El ingreso de Stock a Tienda fue exitoso.");
                this.Dispose();
            }

            else
            {


                if (radInactivo.Checked == true)
                {
                   
                }

                this.Dispose();

            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            int stockFinal = Int32.Parse(txtStock.Text);
            if (stockFinal <= 0)
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            IngresoAlmacen c = new IngresoAlmacen();
            //c.Correlativo = txtCorrelativo_buscar.Text;
            //c.NroDocumento = txtNro_busqueda.Text;       
            dgvIngresosTienda.DataSource = StockTiendaNEG.Instancia().listarIngresosStock();
        }

        private void copyAlltoClipboard()
        {
            dgvIngresosTienda.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvIngresosTienda.MultiSelect = true;
            dgvIngresosTienda.SelectAll();
            DataObject dataObj = dgvIngresosTienda.GetClipboardContent();
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
