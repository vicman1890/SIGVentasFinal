using System;
using CapaEntidades;
using CapaNegocio;
using System.Windows.Forms;
using System.Data;

namespace FACHASA
{
    public partial class frmGestionIngresos : Form
    {

        internal int codigoProveedorSeleccionado = -1;
        internal int codigoArticuloSeleccionado = -1;
        private int idUsuario;
        private decimal totalInvertido = 0;
        private decimal igv = 0;
        private decimal sub = 0;

        public frmGestionIngresos(int idUser)
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
            myToolTip();
        }

        private void myToolTip()
        {
            ToolTip myToolTip = new ToolTip();
            myToolTip.SetToolTip(btnBuscarProducto, "Buscar Producto");
            myToolTip.SetToolTip(btnAgregar, "Agregar Ingreso");
            myToolTip.SetToolTip(btnQuitar, "Quitar Ingreso");
            myToolTip.SetToolTip(btnBuscarProveedor, "Buscar Proveedor");
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

            cboTipoComprobante.DataSource = TipoComprobanteNEG.Instancia().Listar(new TipoComprobante());
            cboTipoComprobante.DisplayMember = "Nombre"; //dato que queremos mostrar
            cboTipoComprobante.ValueMember = "idTipoComprobante"; //dato que guardaremos, es el nombre declarado en la clase
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Creamos una variable del tipo del formulario que deseamos abrir
            frmSeleccionarArticulo frame = new frmSeleccionarArticulo();
            //Le pasamos como datos la información de nuestro formulario
            frame.estableceFormulario(this);
            //Mostrar el formulario que tiene los productos que hemos seleccionado
            frame.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conversion hl = new Conversion();

            if (this.codigoArticuloSeleccionado == -1)
            {
                this.mError("No ha seleccionado aún ningun Producto o Servicio");
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
                    decimal subTotal = Convert.ToDecimal(this.txtPrecioCompra.Text) * nudCantidad.Value;
                    decimal igvTotal = Convert.ToDecimal(18);

                    totalInvertido += subTotal;
                    //this.totalPagar += subTotal;
                    string numero = Convert.ToString(totalInvertido);
                    this.lblTotalInvertido.Text = "Total Pagado: S/." + totalInvertido.ToString("#0.00#");
                    //Agregamos al fila a nuestro datatable
                    DataRow row = this.dtDetalle.NewRow();
                    row["idArticulo"] = this.codigoArticuloSeleccionado;
                    row["Codigo"] = this.txtCodigoArticulo.Text;
                    row["Nombre"] = this.txtNombreArticulo.Text;
                    row["Cantidad"] = this.nudCantidad.Value;
                    row["PUCompra"] = this.txtPrecioCompra.Text;
                    row["PUVenta"] = this.txtPrecioVenta.Text;
                    //row["Descuento"] = descuento;
                    row["subTotal"] = subTotal;
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
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("PUCompra", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("PUVenta", System.Type.GetType("System.Decimal"));
            //this.dtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("subTotal", System.Type.GetType("System.Decimal"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.dgvDetalle.DataSource = this.dtDetalle;

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {

                //Indice dila actualmente seleccionado y que vamos a eliminar
                int indiceFila = this.dgvDetalle.CurrentCell.RowIndex;
                //Fila que vamos a eliminar
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuimos el total a pagar
                this.totalInvertido = this.totalInvertido - Convert.ToDecimal(row["subTotal"].ToString());
                this.lblTotalInvertido.Text = "Total Pagar: S/." + totalInvertido.ToString("#0.00#");
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
            //Creamos una variable del tipo del formulario que deseamos abrir
            frmSeleccionarProveedor frame = new frmSeleccionarProveedor();
            //Le pasamos como datos la información de nuestro formulario
            frame.estableceFormulario(this);
            //Mostrar el formulario que tiene los productos que hemos seleccionado
            frame.ShowDialog();
        }

        private void txtCodigoArticulo_TextChanged(object sender, EventArgs e)
        {

            String barcode = txtCodigoArticulo.Text;
            //ClienteNEG bl = new ClienteNEG();
            Articulo a = ArticuloNEG.Instancia().ObtenerArticulo(barcode);
            txtNombreArticulo.Text = a.Nombre;
            codigoArticuloSeleccionado = a.idArticulo;

            ColorArticulo c = new ColorArticulo();
            c.idColor = a.idColorArticulo;
            int Color = a.idColorArticulo;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (this.codigoProveedorSeleccionado == -1)
            {
                this.mError("No ha seleccionado aún ningun Proveedor");
            }
            else {

                IngresoAlmacen c = new IngresoAlmacen();
                c.idTipoComprobante = cboTipoComprobante.SelectedIndex + 1;
                c.FechaIngreso = dtpIngresoAlmacen.Value;
                c.idProveedor = codigoProveedorSeleccionado;
                c.Serie = txtSerie.Text;
                c.NroDocumento = txtCorrelativo.Text;
                c.TotalPagado = totalInvertido;
                c.igv = igv;
                c.idUsuario = idUsuario;
                //c.numero = Convert.ToInt32(txtNumero.Text);
                c.subTotal = sub;

                if (radActivo.Enabled == true)
                {
                    c.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    c.Estado = false;
                }


                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    DetalleIngresoAlmacen d = new DetalleIngresoAlmacen();
                    //int stockFinal = IngresoAlmacenNEG.ObtenerStockActual(Convert.ToInt32(row.Cells["idArticulo"].Value));
                    DetalleIngresoAlmacen dStockFinal = IngresoAlmacenNEG.Instancia().ObtenerStockActual(Convert.ToInt32(row.Cells["idArticulo"].Value));
                    d.idArticulo = Convert.ToInt32(row.Cells["idArticulo"].Value);
                    d.PrecioCompra = Convert.ToDecimal(row.Cells["PUCompra"].Value);
                    d.PrecioVenta = Convert.ToDecimal(row.Cells["PUVenta"].Value);
                    d.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    d.CantidadFinal = Convert.ToInt32(row.Cells["Cantidad"].Value) + dStockFinal.CantidadFinal;
                    c.Lineas.Add(d);
                }

                IngresoAlmacenNEG.RegistrarIngreso(c);
                MessageBox.Show("El Ingreso se registro correctamente.");

                DialogResult result = MessageBox.Show("Desea realizar un nuevo ingreso?", "Ingreso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    txtCodigoArticulo.Clear();
                    txtCodigo.Clear();
                    txtCorrelativo.Clear();
                    txtNombreArticulo.Clear();
                    txtNombreProveedor.Clear();
                    txtPrecioCompra.Clear();
                    txtPrecioVenta.Clear();

                    txtSerie.Clear();

                    nudCantidad.Value = 1;


                    foreach (DataGridViewRow row in dgvDetalle.Rows)
                    {
                        //Indice dila actualmente seleccionado y que vamos a eliminar
                        int indiceFila = this.dgvDetalle.CurrentCell.RowIndex;
                        //Fila que vamos a eliminar
                        DataRow row2 = this.dtDetalle.Rows[indiceFila];
                        //Disminuimos el total a pagar
                        this.totalInvertido = this.totalInvertido - Convert.ToDecimal(row2["subTotal"].ToString());
                        this.lblTotalInvertido.Text = "Total Pagar: S/." + totalInvertido.ToString("#0.00#");
                        //Removemos la fila
                        this.dtDetalle.Rows.Remove(row2);
                    }

                    this.lblTotalInvertido.Text = "Total Invertido: S/. 0.00";

                }
                else
                {
                    this.Dispose();
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            IngresoAlmacen c = new IngresoAlmacen();
            //c.Correlativo = txtCorrelativo_buscar.Text;
            //c.NroDocumento = txtNro_busqueda.Text;       
            dgvIngresosAlmacen.DataSource = IngresoAlmacenNEG.Instancia().listarIngresos();
        }

        private void copyAlltoClipboard()
        {
            dgvIngresosAlmacen.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvIngresosAlmacen.MultiSelect = true;
            dgvIngresosAlmacen.SelectAll();
            DataObject dataObj = dgvIngresosAlmacen.GetClipboardContent();
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
