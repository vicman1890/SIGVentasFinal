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
    public partial class frmGestionVentas: Form
    {

        internal int codigoClienteSeleccionado = -1;
        internal int codigoArticuloSeleccionado = -1;
        private decimal totalPagar = 0;
        private decimal igv = 0;
        private decimal sub = 0;
        private int idUsuario;

        //crReporte rpt = new crReporte();

        public frmGestionVentas(int idUser)
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

            btnRegistrar.Enabled = false;
            nudCantidad.Maximum = 1000;
            this.crearTabla();

            cboTipComp.DataSource = TipoComprobanteNEG.Instancia().Listar(new TipoComprobante());
            cboTipComp.DisplayMember = "Nombre"; //dato que queremos mostrar
            cboTipComp.ValueMember = "idTipoComprobante"; //dato que guardaremos, es el nombre declarado en la clase
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Creamos una variable del tipo del formulario que deseamos abrir
            frmSeleccionarArticulo frame = new frmSeleccionarArticulo();
            //Le pasamos como datos la información de nuestro formulario
            frame.estableceFormulario2(this);
            //Mostrar el formulario que tiene los productos que hemos seleccionado
            frame.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int stockFinal = Int32.Parse(txtStockActual.Text);
            decimal stockSolicitado = nudCantidad.Value;

            Conversion hl = new Conversion();

            if (this.codigoArticuloSeleccionado == -1)
            {
                this.mError("No ha seleccionado aún ningun Articulo");
            }

            else if(stockFinal<stockSolicitado)
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
                        this.mError("Ya se encuentra el Articulo en el detalle");
                    }
                }
                //Si podemos registrar el producto en el detalle
                if (registrar)
                {
                    //Calculamos el sub total del detalle sin descuento
                    decimal subTotal = Convert.ToDecimal(this.txtPrecio.Text) * nudCantidad.Value;
                    decimal igvTotal = Convert.ToDecimal(18);

                    this.totalPagar += subTotal;
                    string numero = Convert.ToString(totalPagar);
                    this.lblTotalPagar.Text = "Total Pagar: S/." + totalPagar.ToString("#0.00#");
                    this.sub = totalPagar / ((igvTotal / 100) + 1);
                    this.lblSubTotal.Text = "Sub Total: S/." + sub.ToString("#0.00#");
                    this.igv = totalPagar - sub;
                    this.lblIGV.Text = "IGV(18%): S/." + igv.ToString("#0.00#");
                    this.txtTotalNum.Text = hl.Convertir(numero, true);
                    DataRow row = this.dtDetalle.NewRow();
                    row["idArticulo"] = this.codigoArticuloSeleccionado;
                    row["Codigo"] = this.txtBarCodeArticulo.Text;
                    row["Nombre"] = this.txtNombreArticulo.Text;
                    row["Cantidad"] = this.nudCantidad.Value;
                    row["PU"] = this.txtPrecio.Text;

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
            this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("PU", System.Type.GetType("System.Decimal"));
            //this.dtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("subTotal", System.Type.GetType("System.Decimal"));
            //Relacionamos nuestro datagridview con nuestro datatable
            this.dgvDetalle.DataSource = this.dtDetalle;

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal igvTotal = Convert.ToDecimal(18);
                //Indice dila actualmente seleccionado y que vamos a eliminar
                int indiceFila = this.dgvDetalle.CurrentCell.RowIndex;
                //Fila que vamos a eliminar
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuimos el total a pagar
                this.totalPagar = this.totalPagar - Convert.ToDecimal(row["subTotal"].ToString());
                this.lblTotalPagar.Text = "Total Pagar: S/." + totalPagar.ToString("#0.00#");
                this.sub = totalPagar / ((igvTotal / 100) + 1);
                this.lblSubTotal.Text = "Sub Total: S/." + sub.ToString("#0.00#");
                this.igv = totalPagar - sub;
                this.lblIGV.Text = "IGV(18%): S/." + igv.ToString("#0.00#");
                
                
                //Removemos la fila
                this.dtDetalle.Rows.Remove(row);
            }


            catch (Exception ex)
            {
                mError("No hay fila para remover");
                mError(ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            //Creamos una variable del tipo del formulario que deseamos abrir
            frmSeleccionarCliente frame = new frmSeleccionarCliente();
            //Le pasamos como datos la información de nuestro formulario
            frame.estableceFormulario(this);
            //Mostrar el formulario que tiene los productos que hemos seleccionado
            frame.ShowDialog();
        }

        private void txtBarCodeArticulo_TextChanged(object sender, EventArgs e)
        {
            String barcode = txtBarCodeArticulo.Text;
            //ClienteNEG bl = new ClienteNEG();
            Articulo a = ArticuloNEG.Instancia().ObtenerArticulo(barcode);
            txtNombreArticulo.Text = a.Nombre;
            codigoArticuloSeleccionado = a.idArticulo;


            //DetalleIngresoAlmacen d = new DetalleIngresoAlmacen();
            //int stockFinal = IngresoAlmacenNEG.ObtenerStockActual(Convert.ToInt32(row.Cells["idArticulo"].Value));

            //DetalleStockTienda dStockFinal = StockTiendaNEG.Instancia().ObtenerStockActual(codigoArticuloSeleccionado);
            //txtStockActual.Text = dStockFinal.StockFinal.ToString();

            DetalleIngresoAlmacen dStockFinal = IngresoAlmacenNEG.Instancia().ObtenerStockActual(codigoArticuloSeleccionado);
            txtStockActual.Text = dStockFinal.CantidadFinal.ToString();

            DetalleIngresoAlmacen dPrecioActual = DetalleIngresoNEG.Instancia().obtenerPrecioVenta(codigoArticuloSeleccionado);
            txtPrecio.Text = dPrecioActual.PrecioVenta.ToString();

            //Cerrando el formulario
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            //if (nudCantidad.Value.ToString() ;
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {

            if (this.codigoClienteSeleccionado == -1)
            {
                this.mError("No ha seleccionado aún ningun Cliente");
            }

            if (txtCodigo.Text =="")
            {
                String NroActual;
                Venta nroVentaActual = VentaNEG.Instancia().obtenerUltimaVenta(cboTipComp.SelectedIndex + 1);

                if (nroVentaActual.NroDocumento == "")
                {
                    int i = 1;
                    NroActual = i.ToString("D7");
                    //obj.NroDocumento = "000001";
                }
                else
                {
                    string UltimoNro = nroVentaActual.NroDocumento;
                    int UltimoNroDoc;
                    int.TryParse(UltimoNro, out UltimoNroDoc);
                    int NuevoNum = UltimoNroDoc + 1;
                    NroActual = NuevoNum.ToString("D7");
                }

                Venta c = new Venta();
                c.FechaVenta = dtpFechaVenta.Value;
                c.idCliente = codigoClienteSeleccionado;
                c.TotalVenta = totalPagar;
                c.IgvVenta = igv;
                c.idUsuario = idUsuario;
                c.Correlativo = "001";

                if (radActivo.Enabled == true)
                {
                    c.Estado = true;
                }
                else if (radInactivo.Enabled == true)
                {
                    c.Estado = false;
                }

                //c.numero = Convert.ToInt32(txtNumero.Text);
                c.SubTotalVenta = sub;
                c.idTipoComprobante = cboTipComp.SelectedIndex + 1;
                c.NroDocumento = NroActual;

                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    DetalleVenta d = new DetalleVenta();

                    d.idArticulo = Convert.ToInt32(row.Cells["idArticulo"].Value);
                    d.PrecioVenta = Convert.ToDecimal(row.Cells["PU"].Value);
                    d.Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    d.idDetalleIngresoAlmacen = 1;
                    int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                    VentaNEG.Instancia().reducirStock(d.idArticulo, cantidad);
                    //StockTiendaNEG.Instancia().reducirStock(d.idArticulo, cantidad);
                    c.Lineas.Add(d);
                }

                VentaNEG.RegistrarFacturacion(c);
                txtSerie.Text = "001";
                txtCorrelativo.Text = NroActual;
                MessageBox.Show("La Venta se realizó correctamente.");

                DialogResult result = MessageBox.Show("Desea Imprimir?", "Imprimir", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    int idComp = cboTipComp.SelectedIndex + 1;
                            //rpt.SetDataSource(VentaNEG.ObtenerVenta(txtSerie.Text, NroActual, idComp));

                    //rpt.SetParameterValue("", d.);

                            //rpt.SetParameterValue("texto", txtTotalNum.Text);

                    //Establecemos los datos al reporte
                    //this.crReporte.ReportSource = rpt;

                            //rpt.PrintToPrinter(1, false, 1, 1);

                    //this.Dispose();


                }
                else if (result == DialogResult.No)
                {
                    DialogResult result2 = MessageBox.Show("Desea realizar otra venta?", "Cerrar", MessageBoxButtons.YesNo);
                    if (result2 == DialogResult.Yes)
                    {
                        this.Dispose();
                    }
                    else if (result2 == DialogResult.No)
                    {
                        txtBarCodeArticulo.Clear();
                        txtCodigo.Clear();
                        txtCorrelativo.Clear();
                        txtDireccionCliente.Clear();
                        txtNombreArticulo.Clear();
                        txtNombreCliente.Clear();
                        txtPrecio.Clear();
                        txtRucCliente.Clear();
                        txtSerie.Clear();
                        txtStockActual.Text = "0";
                        nudCantidad.Value = 1;
                        txtTotalNum.Clear();

                        foreach (DataGridViewRow row in dgvDetalle.Rows)
                        {
                            decimal igvTotal = Convert.ToDecimal(18);
                            //Indice dila actualmente seleccionado y que vamos a eliminar
                            int indiceFila = this.dgvDetalle.CurrentCell.RowIndex;
                            //Fila que vamos a eliminar
                            DataRow row2 = this.dtDetalle.Rows[indiceFila];
                            //Disminuimos el total a pagar
                            this.totalPagar = this.totalPagar - Convert.ToDecimal(row2["subTotal"].ToString());
                            this.lblTotalPagar.Text = "Total Pagar: S/." + totalPagar.ToString("#0.00#");
                            this.sub = totalPagar / ((igvTotal / 100) + 1);
                            this.lblSubTotal.Text = "Sub Total: S/." + sub.ToString("#0.00#");
                            this.igv = totalPagar - sub;
                            this.lblIGV.Text = "IGV(18%): S/." + igv.ToString("#0.00#");


                            //Removemos la fila
                            this.dtDetalle.Rows.Remove(row2);
                        }

                        txtTotalNum.Clear();
                    }
                }
            }

            /*else
            {

                //VALIDACIÓN PARA ANULAR FACTURA - VERIFICACIÓN POR CONTRASEÑA
                if (radInactivo.Checked ==true)
                {
                    
                    frmAnularVentaVerificar frame3 = new frmAnularVentaVerificar();
                    frame3.estableceFormulario3(this);
                    frame3.ShowDialog();
                }

                this.Dispose();

            }*/
                    

        }


        private void InvoiceGenerate()
        {
            //
            //Hacemos una instancia de la clase EFactura para
            //llenarla con los valores contenidos en los controles del Formulario
            String NroActual;
            Venta nroVentaActual = VentaNEG.Instancia().obtenerUltimaVenta(cboTipComp.SelectedIndex + 1);

            if (nroVentaActual.NroDocumento == "")
            {
                int i = 1;
                NroActual = i.ToString("D7");
                //obj.NroDocumento = "000001";
            }
            else
            {
                string UltimoNro = nroVentaActual.NroDocumento;
                int UltimoNroDoc;
                int.TryParse(UltimoNro, out UltimoNroDoc);
                int NuevoNum = UltimoNroDoc + 1;
                NroActual = NuevoNum.ToString("D7");
            }

            Venta c = new Venta();
            c.FechaVenta = dtpFechaVenta.Value;
            c.idCliente = codigoClienteSeleccionado;
            c.TotalVenta = totalPagar;
            c.IgvVenta = igv;
            c.idUsuario = idUsuario;
            c.Correlativo = "001";

            if (radActivo.Enabled == true)
            {
                c.Estado = true;
            }
            else if (radInactivo.Enabled == true)
            {
                c.Estado = false;
            }

            //c.numero = Convert.ToInt32(txtNumero.Text);
            c.SubTotalVenta = sub;
            c.idTipoComprobante = cboTipComp.SelectedIndex + 1;
            c.NroDocumento = NroActual;

            //Recorremos los Rows existentes actualmente en el control DataGridView
            //para asignar los datos a las propiedades
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                DetalleVenta d = new DetalleVenta();

                d.idArticulo = Convert.ToInt32(row.Cells["idArticulo"].Value);
                d.PrecioVenta = Convert.ToDecimal(row.Cells["PU"].Value);
                d.Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                d.idDetalleIngresoAlmacen = 1;
                int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                VentaNEG.Instancia().reducirStock(d.idArticulo, cantidad);
                //StockTiendaNEG.Instancia().reducirStock(d.idArticulo, cantidad);
                c.Lineas.Add(d);
            }

            //
            //Creamos una instancia del Formulario que contiene nuestro
            //ReportViewer
            //
            rptFactura frm = new rptFactura();

                      
            //Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
            //que se mostrara en los parametros creados en el LocalReport, para este ejemplo
            //estamos Seteando los valores directamente pero usted puede usar algun control
            //
            frm.Titulo = "Este es un ejemplo de Factura";
            frm.Empresa = "Este es un ejemplo del Nombre de la Empresa";
            //
            //Recuerde que invoice es una Lista Generica declarada en FacturaRtp, es una lista
            //porque el origen de datos del LocalReport unicamente permite ser enlazado a objetos que 
            //implementen IEnumerable.
            //
            //Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
            frm.Invoice.Add(c);
            //
            //Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
            //es un lista del tipo EArticulo bastara con igualarla
            //
            frm.Detail = c.Lineas;
            frm.Show();


            int idComp = cboTipComp.SelectedIndex + 1;
            //rpt.SetDataSource(VentaNEG.ObtenerVenta(txtSerie.Text, NroActual, idComp));
            //rpt.SetParameterValue("texto", txtTotalNum.Text);
            //rpt.PrintToPrinter(1, false, 1, 1);

 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrinterSettings settings = new PrinterSettings();
            MessageBox.Show(settings.PrinterName, "Cerrar", MessageBoxButtons.YesNo);
            

            string printerName = settings.PrinterName;
            string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printerName);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection coll = searcher.Get();

            foreach (ManagementObject printer in coll)
            {
                foreach (PropertyData property in printer.Properties)
                {
                    MessageBox.Show(string.Format("{0}: {1}", property.Name, property.Value), "Cerrar", MessageBoxButtons.YesNo);
                    Console.WriteLine(string.Format("{0}: {1}", property.Name, property.Value));
                }
            }
        }

        private void txtStockActual_TextChanged(object sender, EventArgs e)
        {
            int stockFinal = Int32.Parse(txtStockActual.Text);
            if (stockFinal <= 0)
            {
                btnAgregar.Enabled = false;
            } else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Venta c = new Venta();
            //c.Correlativo = txtCorrelativo_buscar.Text;
            c.NroDocumento = txtNro_busqueda.Text;
            //dgvClientes.DataSource = bl.Buscar(c);
            //dgvVentas.DataSource = VentaNEG.Instancia().Buscar(c)
            dgvVentas.DataSource = VentaNEG.Instancia().listarVentas();
        }

        private DataGridView _seleccion;

        internal DataGridView Seleccion
        {
            get { return _seleccion; }
            set { _seleccion = value; }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                this.txtCodigo.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["idVenta"].Value);
                codigoClienteSeleccionado = Int32.Parse(Convert.ToString(this.dgvVentas.CurrentRow.Cells["idCliente"].Value));
                txtCorrelativo.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["NroDocumento"].Value);
                txtSerie.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["Correlativo"].Value);
                cboTipComp.SelectedValue = Int32.Parse(Convert.ToString(this.dgvVentas.CurrentRow.Cells["idTipoComprobante"].Value));

                if (Boolean.Parse(Convert.ToString(this.dgvVentas.CurrentRow.Cells["Estado"].Value)) == true)
                {
                    radActivo.Checked = true;
                }
                else if (Boolean.Parse(Convert.ToString(this.dgvVentas.CurrentRow.Cells["Estado"].Value)) == false)
                {
                    radInactivo.Checked = true;
                }

                DateTime fechaVenta = DateTime.Parse(Convert.ToString(this.dgvVentas.CurrentRow.Cells["FechaVenta"].Value));

                dtpFechaVenta.Value = fechaVenta;

                dgvDetalle.DataSource = DetalleVentaNEG.Instancia().listarDetalleVentas(Int32.Parse(Convert.ToString(this.dgvVentas.CurrentRow.Cells["idVenta"].Value)));

                tabConsulta_Ventas.SelectedIndex = 1;
                
            }
        }

        private void tabConsulta_Ventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabConsulta_Ventas.SelectedIndex == 0)
            {
                btnRegistrar.Enabled = false;
                btnReporte.Enabled = true;
                btnModificar.Enabled = true;

                txtCodigo.Clear();
                txtCorrelativo.Clear();
                txtSerie.Clear();
                dtpFechaVenta.Value = DateTime.Today;
                

            }
            else if (tabConsulta_Ventas.SelectedIndex == 1)
            {
                btnRegistrar.Enabled = true;
                btnReporte.Enabled = false;
                btnModificar.Enabled = false;


            }
        }

        private void radActivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radInactivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceGenerate();
        }
    }
}
