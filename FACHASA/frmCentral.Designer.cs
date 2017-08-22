namespace FACHASA
{
    partial class frmCentral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCentral));
            this.ribbonTabGestion = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelClientes = new System.Windows.Forms.RibbonPanel();
            this.btnClientes = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelPersonal = new System.Windows.Forms.RibbonPanel();
            this.btnPersonal = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelIngresosAlmacen = new System.Windows.Forms.RibbonPanel();
            this.btnProveedor = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.btnArticulos = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.btnServicios = new System.Windows.Forms.RibbonButton();
            this.ribbonTabComprobantes = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelNuevoComprobante = new System.Windows.Forms.RibbonPanel();
            this.btnComprobante = new System.Windows.Forms.RibbonButton();
            this.ribbonTabAlmacen = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.btnIngresosAlmacen = new System.Windows.Forms.RibbonButton();
            this.btnStock = new System.Windows.Forms.RibbonButton();
            this.ribbonTabConfiguracion = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnColores = new System.Windows.Forms.RibbonButton();
            this.btnTalla = new System.Windows.Forms.RibbonButton();
            this.btnEstilos = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.btnMarcas = new System.Windows.Forms.RibbonButton();
            this.btnModelos = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelServicios = new System.Windows.Forms.RibbonPanel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.btnCentral = new System.Windows.Forms.RibbonOrbMenuItem();
            this.btnCerrar = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonTabReportes = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelReportes = new System.Windows.Forms.RibbonPanel();
            this.btnReporteVentas = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.btnStockAlmacen = new System.Windows.Forms.RibbonButton();
            this.btnStockTienda = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.toolStripStatusMostrarNombres = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelNombreCompleto = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripImgUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonSeparator4 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator5 = new System.Windows.Forms.RibbonSeparator();
            this.btnControl = new System.Windows.Forms.RibbonButton();
            this.ribbonOrbMenuRecursos = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuVentas = new System.Windows.Forms.RibbonOrbMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonTabGestion
            // 
            this.ribbonTabGestion.Panels.Add(this.ribbonPanelClientes);
            this.ribbonTabGestion.Panels.Add(this.ribbonPanelPersonal);
            this.ribbonTabGestion.Panels.Add(this.ribbonPanelIngresosAlmacen);
            this.ribbonTabGestion.Panels.Add(this.ribbonPanel2);
            this.ribbonTabGestion.Panels.Add(this.ribbonPanel6);
            this.ribbonTabGestion.Text = "Gestión ";
            // 
            // ribbonPanelClientes
            // 
            this.ribbonPanelClientes.Items.Add(this.btnClientes);
            this.ribbonPanelClientes.Text = "";
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::FACHASA.Properties.Resources.Client1;
            this.btnClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.SmallImage")));
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // ribbonPanelPersonal
            // 
            this.ribbonPanelPersonal.Items.Add(this.btnPersonal);
            this.ribbonPanelPersonal.Text = "";
            // 
            // btnPersonal
            // 
            this.btnPersonal.Image = global::FACHASA.Properties.Resources.icoPersonal;
            this.btnPersonal.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPersonal.SmallImage")));
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // ribbonPanelIngresosAlmacen
            // 
            this.ribbonPanelIngresosAlmacen.Items.Add(this.btnProveedor);
            this.ribbonPanelIngresosAlmacen.Text = "";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Image = global::FACHASA.Properties.Resources.proveedor;
            this.btnProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnProveedor.SmallImage")));
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.btnArticulos);
            this.ribbonPanel2.Text = "";
            // 
            // btnArticulos
            // 
            this.btnArticulos.Image = global::FACHASA.Properties.Resources.icoArticulos2;
            this.btnArticulos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnArticulos.SmallImage")));
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.btnServicios);
            this.ribbonPanel6.Text = "";
            // 
            // btnServicios
            // 
            this.btnServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnServicios.Image")));
            this.btnServicios.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnServicios.SmallImage")));
            this.btnServicios.Text = "Servicios";
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // ribbonTabComprobantes
            // 
            this.ribbonTabComprobantes.Panels.Add(this.ribbonPanelNuevoComprobante);
            this.ribbonTabComprobantes.Text = "Comprobantes";
            // 
            // ribbonPanelNuevoComprobante
            // 
            this.ribbonPanelNuevoComprobante.Items.Add(this.btnComprobante);
            this.ribbonPanelNuevoComprobante.Text = "";
            // 
            // btnComprobante
            // 
            this.btnComprobante.Image = global::FACHASA.Properties.Resources.venta;
            this.btnComprobante.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnComprobante.SmallImage")));
            this.btnComprobante.Text = "Comprobante";
            this.btnComprobante.Click += new System.EventHandler(this.btnNuevoComprobante_Click);
            // 
            // ribbonTabAlmacen
            // 
            this.ribbonTabAlmacen.Panels.Add(this.ribbonPanel3);
            this.ribbonTabAlmacen.Text = "Almacen";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.btnIngresosAlmacen);
            this.ribbonPanel3.Items.Add(this.btnStock);
            this.ribbonPanel3.Text = "Control Inventario";
            // 
            // btnIngresosAlmacen
            // 
            this.btnIngresosAlmacen.Image = global::FACHASA.Properties.Resources.productos;
            this.btnIngresosAlmacen.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnIngresosAlmacen.SmallImage")));
            this.btnIngresosAlmacen.Text = "Ingresos";
            this.btnIngresosAlmacen.Click += new System.EventHandler(this.btnIngresosAlmacen_Click);
            // 
            // btnStock
            // 
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnStock.SmallImage")));
            this.btnStock.Text = "Stock";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // ribbonTabConfiguracion
            // 
            this.ribbonTabConfiguracion.Panels.Add(this.ribbonPanel1);
            this.ribbonTabConfiguracion.Panels.Add(this.ribbonPanel5);
            this.ribbonTabConfiguracion.Text = "Configuración";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.btnColores);
            this.ribbonPanel1.Items.Add(this.btnTalla);
            this.ribbonPanel1.Items.Add(this.btnEstilos);
            this.ribbonPanel1.Text = "Configuracion Articulos de Vestir";
            // 
            // btnColores
            // 
            this.btnColores.Image = ((System.Drawing.Image)(resources.GetObject("btnColores.Image")));
            this.btnColores.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnColores.SmallImage")));
            this.btnColores.Text = "Colores";
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // btnTalla
            // 
            this.btnTalla.Image = ((System.Drawing.Image)(resources.GetObject("btnTalla.Image")));
            this.btnTalla.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnTalla.SmallImage")));
            this.btnTalla.Text = "Talla";
            this.btnTalla.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // btnEstilos
            // 
            this.btnEstilos.Image = ((System.Drawing.Image)(resources.GetObject("btnEstilos.Image")));
            this.btnEstilos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEstilos.SmallImage")));
            this.btnEstilos.Text = "Estilos";
            this.btnEstilos.Click += new System.EventHandler(this.btnEstilos_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.btnMarcas);
            this.ribbonPanel5.Items.Add(this.btnModelos);
            this.ribbonPanel5.Text = "Configuración de Vehiculos";
            // 
            // btnMarcas
            // 
            this.btnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcas.Image")));
            this.btnMarcas.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnMarcas.SmallImage")));
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.Image = ((System.Drawing.Image)(resources.GetObject("btnModelos.Image")));
            this.btnModelos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnModelos.SmallImage")));
            this.btnModelos.Text = "Modelos";
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // ribbonPanelServicios
            // 
            this.ribbonPanelServicios.Text = "";
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.btnCentral);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.OptionItems.Add(this.btnCerrar);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 116);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbText = "Panel de Control";
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonVisible = false;
            this.ribbon1.QuickAcessToolbar.Enabled = false;
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1113, 145);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTabGestion);
            this.ribbon1.Tabs.Add(this.ribbonTabComprobantes);
            this.ribbon1.Tabs.Add(this.ribbonTabAlmacen);
            this.ribbon1.Tabs.Add(this.ribbonTabConfiguracion);
            this.ribbon1.Tabs.Add(this.ribbonTabReportes);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Green;
            // 
            // btnCentral
            // 
            this.btnCentral.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btnCentral.Image = global::FACHASA.Properties.Resources.icoVenta;
            this.btnCentral.SmallImage = global::FACHASA.Properties.Resources.icoVenta;
            this.btnCentral.Text = "Central";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.SmallImage")));
            this.btnCerrar.Text = "Cerrar Sesion";
            // 
            // ribbonTabReportes
            // 
            this.ribbonTabReportes.Panels.Add(this.ribbonPanelReportes);
            this.ribbonTabReportes.Panels.Add(this.ribbonPanel4);
            this.ribbonTabReportes.Text = "Reportes";
            // 
            // ribbonPanelReportes
            // 
            this.ribbonPanelReportes.Items.Add(this.btnReporteVentas);
            this.ribbonPanelReportes.Text = "Control Ventas";
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.Image = global::FACHASA.Properties.Resources.Egreso;
            this.btnReporteVentas.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnReporteVentas.SmallImage")));
            this.btnReporteVentas.Text = "Ventas";
            this.btnReporteVentas.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.btnStockAlmacen);
            this.ribbonPanel4.Items.Add(this.btnStockTienda);
            this.ribbonPanel4.Text = "Control Stock";
            // 
            // btnStockAlmacen
            // 
            this.btnStockAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("btnStockAlmacen.Image")));
            this.btnStockAlmacen.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnStockAlmacen.SmallImage")));
            this.btnStockAlmacen.Text = "Almacen";
            this.btnStockAlmacen.Click += new System.EventHandler(this.btnStockAlmacen_Click);
            // 
            // btnStockTienda
            // 
            this.btnStockTienda.Image = ((System.Drawing.Image)(resources.GetObject("btnStockTienda.Image")));
            this.btnStockTienda.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnStockTienda.SmallImage")));
            this.btnStockTienda.Text = "Tienda";
            // 
            // toolStripStatusMostrarNombres
            // 
            this.toolStripStatusMostrarNombres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusMostrarNombres.Name = "toolStripStatusMostrarNombres";
            this.toolStripStatusMostrarNombres.Size = new System.Drawing.Size(55, 20);
            this.toolStripStatusMostrarNombres.Text = "Usuario :";
            // 
            // toolStripLabelNombreCompleto
            // 
            this.toolStripLabelNombreCompleto.Name = "toolStripLabelNombreCompleto";
            this.toolStripLabelNombreCompleto.Size = new System.Drawing.Size(56, 20);
            this.toolStripLabelNombreCompleto.Text = "Nombres";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 20);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripImgUsuario,
            this.toolStripStatusMostrarNombres,
            this.toolStripLabelNombreCompleto,
            this.toolStripStatusLabel1,
            this.toolStripLabelFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1113, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripImgUsuario
            // 
            this.toolStripImgUsuario.Image = ((System.Drawing.Image)(resources.GetObject("toolStripImgUsuario.Image")));
            this.toolStripImgUsuario.Name = "toolStripImgUsuario";
            this.toolStripImgUsuario.Size = new System.Drawing.Size(20, 20);
            // 
            // toolStripLabelFecha
            // 
            this.toolStripLabelFecha.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabelFecha.Image")));
            this.toolStripLabelFecha.Name = "toolStripLabelFecha";
            this.toolStripLabelFecha.Size = new System.Drawing.Size(85, 20);
            this.toolStripLabelFecha.Text = "12/10/2015";
            // 
            // btnControl
            // 
            this.btnControl.Image = ((System.Drawing.Image)(resources.GetObject("btnControl.Image")));
            this.btnControl.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnControl.SmallImage")));
            // 
            // ribbonOrbMenuRecursos
            // 
            this.ribbonOrbMenuRecursos.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuRecursos.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuRecursos.Image")));
            this.ribbonOrbMenuRecursos.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuRecursos.SmallImage")));
            this.ribbonOrbMenuRecursos.Text = "Módulo Recursos Humanos";
            this.ribbonOrbMenuRecursos.Click += new System.EventHandler(this.ribbonOrbMenuRecursos_Click);
            // 
            // ribbonOrbMenuVentas
            // 
            this.ribbonOrbMenuVentas.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuVentas.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuVentas.Image")));
            this.ribbonOrbMenuVentas.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuVentas.SmallImage")));
            this.ribbonOrbMenuVentas.Text = "Ventas";
            // 
            // frmCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 609);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Name = "frmCentral";
            this.Text = "SIGVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCentral_FormClosing);
            this.Load += new System.EventHandler(this.frmCentral_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribbonTabGestion;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbRecursosHumanos;
        private System.Windows.Forms.RibbonPanel ribbonPanelClientes;
        private System.Windows.Forms.RibbonTab ribbonTabComprobantes;
        private System.Windows.Forms.RibbonPanel ribbonPanelNuevoComprobante;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonTab ribbonTabAlmacen;
        private System.Windows.Forms.RibbonPanel ribbonPanelPersonal;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonTab ribbonTabConfiguracion;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanelIngresosAlmacen;
        private System.Windows.Forms.RibbonPanel ribbonPanelControl;
        private System.Windows.Forms.RibbonPanel ribbonPanelServicios;
        private System.Windows.Forms.RibbonButton btnControl;
        
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuAlmacen;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripImgUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMostrarNombres;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelNombreCompleto;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelFecha;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuRecursos;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuVentas;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator4;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator5;
        private System.Windows.Forms.RibbonOrbMenuItem btnCentral;
        private System.Windows.Forms.RibbonButton btnProveedor;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton btnArticulos;
        private System.Windows.Forms.RibbonButton btnClientes;
        private System.Windows.Forms.RibbonButton btnPersonal;
        private System.Windows.Forms.RibbonButton btnComprobante;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton btnIngresosAlmacen;
        private System.Windows.Forms.RibbonOrbOptionButton btnCerrar;
        private System.Windows.Forms.RibbonButton btnColores;
        private System.Windows.Forms.RibbonButton btnTalla;
        private System.Windows.Forms.RibbonButton btnEstilos;
        private System.Windows.Forms.RibbonButton btnStock;
        private System.Windows.Forms.RibbonTab ribbonTabReportes;
        private System.Windows.Forms.RibbonPanel ribbonPanelReportes;
        private System.Windows.Forms.RibbonButton btnReporteVentas;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton btnStockAlmacen;
        private System.Windows.Forms.RibbonButton btnStockTienda;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton btnMarcas;
        private System.Windows.Forms.RibbonButton btnModelos;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton btnServicios;
    }
}