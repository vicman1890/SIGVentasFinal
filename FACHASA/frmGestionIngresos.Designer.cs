namespace FACHASA
{
    partial class frmGestionIngresos
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
            this.tabConsulta_Ingresos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvIngresosAlmacen = new System.Windows.Forms.DataGridView();
            this.idIngresoAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadStockAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProveedorBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMantenimiento_Ingresos = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radInactivo = new System.Windows.Forms.RadioButton();
            this.radActivo = new System.Windows.Forms.RadioButton();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTipoComprobante = new System.Windows.Forms.ComboBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpIngresoAlmacen = new System.Windows.Forms.DateTimePicker();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalInvertido = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBotonera = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabConsulta_Ingresos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosAlmacen)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabMantenimiento_Ingresos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConsulta_Ingresos
            // 
            this.tabConsulta_Ingresos.Controls.Add(this.tabPage1);
            this.tabConsulta_Ingresos.Controls.Add(this.tabMantenimiento_Ingresos);
            this.tabConsulta_Ingresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConsulta_Ingresos.Location = new System.Drawing.Point(0, 0);
            this.tabConsulta_Ingresos.Name = "tabConsulta_Ingresos";
            this.tabConsulta_Ingresos.SelectedIndex = 0;
            this.tabConsulta_Ingresos.Size = new System.Drawing.Size(1253, 452);
            this.tabConsulta_Ingresos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvIngresosAlmacen);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvIngresosAlmacen
            // 
            this.dgvIngresosAlmacen.AllowUserToAddRows = false;
            this.dgvIngresosAlmacen.AllowUserToDeleteRows = false;
            this.dgvIngresosAlmacen.AllowUserToOrderColumns = true;
            this.dgvIngresosAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresosAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIngresoAlmacen,
            this.NombreTipoComprobante,
            this.idTipoComprobante,
            this.Serie,
            this.Correlativo,
            this.NombreProveedor,
            this.CodigoArticulo,
            this.NombreArticulo,
            this.FechaIngreso,
            this.CantidadIngreso,
            this.CantidadStockAlmacen,
            this.Estado,
            this.Username});
            this.dgvIngresosAlmacen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngresosAlmacen.Location = new System.Drawing.Point(3, 80);
            this.dgvIngresosAlmacen.Name = "dgvIngresosAlmacen";
            this.dgvIngresosAlmacen.ReadOnly = true;
            this.dgvIngresosAlmacen.Size = new System.Drawing.Size(1239, 343);
            this.dgvIngresosAlmacen.TabIndex = 1;
            // 
            // idIngresoAlmacen
            // 
            this.idIngresoAlmacen.DataPropertyName = "idIngresoAlmacen";
            this.idIngresoAlmacen.HeaderText = "Codigo Ingreso";
            this.idIngresoAlmacen.Name = "idIngresoAlmacen";
            this.idIngresoAlmacen.ReadOnly = true;
            this.idIngresoAlmacen.Visible = false;
            // 
            // NombreTipoComprobante
            // 
            this.NombreTipoComprobante.DataPropertyName = "NombreTipoComprobante";
            this.NombreTipoComprobante.HeaderText = "Comprobante";
            this.NombreTipoComprobante.Name = "NombreTipoComprobante";
            this.NombreTipoComprobante.ReadOnly = true;
            // 
            // idTipoComprobante
            // 
            this.idTipoComprobante.DataPropertyName = "idTipoComprobante";
            this.idTipoComprobante.HeaderText = "Codigo Comprobante";
            this.idTipoComprobante.Name = "idTipoComprobante";
            this.idTipoComprobante.ReadOnly = true;
            this.idTipoComprobante.Visible = false;
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "Serie";
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            this.Serie.Width = 80;
            // 
            // Correlativo
            // 
            this.Correlativo.DataPropertyName = "Correlativo";
            this.Correlativo.HeaderText = "Correlativo";
            this.Correlativo.Name = "Correlativo";
            this.Correlativo.ReadOnly = true;
            this.Correlativo.Width = 80;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.DataPropertyName = "NombreProveedor";
            this.NombreProveedor.HeaderText = "Proveedor";
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            this.NombreProveedor.Width = 220;
            // 
            // CodigoArticulo
            // 
            this.CodigoArticulo.DataPropertyName = "CodigoArticulo";
            this.CodigoArticulo.HeaderText = "Codigo Articulo";
            this.CodigoArticulo.Name = "CodigoArticulo";
            this.CodigoArticulo.ReadOnly = true;
            this.CodigoArticulo.Width = 80;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.DataPropertyName = "NombreArticulo";
            this.NombreArticulo.HeaderText = "Nombre Articulo";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            this.NombreArticulo.Width = 220;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha de Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 140;
            // 
            // CantidadIngreso
            // 
            this.CantidadIngreso.DataPropertyName = "CantidadIngreso";
            this.CantidadIngreso.HeaderText = "Cantidad Ingreso";
            this.CantidadIngreso.Name = "CantidadIngreso";
            this.CantidadIngreso.ReadOnly = true;
            this.CantidadIngreso.Width = 80;
            // 
            // CantidadStockAlmacen
            // 
            this.CantidadStockAlmacen.DataPropertyName = "CantidadStockAlmacen";
            this.CantidadStockAlmacen.HeaderText = "Stock";
            this.CantidadStockAlmacen.Name = "CantidadStockAlmacen";
            this.CantidadStockAlmacen.ReadOnly = true;
            this.CantidadStockAlmacen.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 80;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Usuario";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombreProveedorBusqueda);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 77);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(462, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo Comprobante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Consulta de Ingresos Almacen";
            // 
            // txtNombreProveedorBusqueda
            // 
            this.txtNombreProveedorBusqueda.Location = new System.Drawing.Point(130, 37);
            this.txtNombreProveedorBusqueda.Name = "txtNombreProveedorBusqueda";
            this.txtNombreProveedorBusqueda.Size = new System.Drawing.Size(211, 20);
            this.txtNombreProveedorBusqueda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.Location = new System.Drawing.Point(1149, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre Proveedor:";
            // 
            // tabMantenimiento_Ingresos
            // 
            this.tabMantenimiento_Ingresos.Controls.Add(this.panel3);
            this.tabMantenimiento_Ingresos.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento_Ingresos.Name = "tabMantenimiento_Ingresos";
            this.tabMantenimiento_Ingresos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento_Ingresos.Size = new System.Drawing.Size(1245, 426);
            this.tabMantenimiento_Ingresos.TabIndex = 1;
            this.tabMantenimiento_Ingresos.Text = "Ingresos Almacen";
            this.tabMantenimiento_Ingresos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 420);
            this.panel3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1239, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Ingreso";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvDetalle);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1233, 233);
            this.panel6.TabIndex = 44;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.codigo,
            this.Articulo,
            this.cantidad,
            this.PU,
            this.subTotal});
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1233, 233);
            this.dgvDetalle.TabIndex = 30;
            // 
            // idArticulo
            // 
            this.idArticulo.DataPropertyName = "idArticulo";
            this.idArticulo.HeaderText = "ID";
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.ReadOnly = true;
            this.idArticulo.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.DataPropertyName = "Nombre";
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 400;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // PU
            // 
            this.PU.DataPropertyName = "PU";
            this.PU.HeaderText = "PU";
            this.PU.Name = "PU";
            this.PU.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "subTotal";
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Controls.Add(this.txtCodigoArticulo);
            this.panel7.Controls.Add(this.txtNombreProveedor);
            this.panel7.Controls.Add(this.btnBuscarProducto);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.nudCantidad);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.cboTipoComprobante);
            this.panel7.Controls.Add(this.txtPrecioVenta);
            this.panel7.Controls.Add(this.btnBuscarProveedor);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.dtpIngresoAlmacen);
            this.panel7.Controls.Add(this.txtNombreArticulo);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.btnQuitar);
            this.panel7.Controls.Add(this.txtSerie);
            this.panel7.Controls.Add(this.txtPrecioCompra);
            this.panel7.Controls.Add(this.txtCorrelativo);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.btnAgregar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1233, 135);
            this.panel7.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.radInactivo);
            this.groupBox2.Controls.Add(this.radActivo);
            this.groupBox2.Location = new System.Drawing.Point(1012, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 38);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // radInactivo
            // 
            this.radInactivo.AutoSize = true;
            this.radInactivo.Location = new System.Drawing.Point(117, 13);
            this.radInactivo.Name = "radInactivo";
            this.radInactivo.Size = new System.Drawing.Size(63, 17);
            this.radInactivo.TabIndex = 0;
            this.radInactivo.Text = "Inactivo";
            this.radInactivo.UseVisualStyleBackColor = true;
            // 
            // radActivo
            // 
            this.radActivo.AutoSize = true;
            this.radActivo.Checked = true;
            this.radActivo.Location = new System.Drawing.Point(30, 13);
            this.radActivo.Name = "radActivo";
            this.radActivo.Size = new System.Drawing.Size(55, 17);
            this.radActivo.TabIndex = 0;
            this.radActivo.TabStop = true;
            this.radActivo.Text = "Activo";
            this.radActivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(102, 99);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(105, 20);
            this.txtCodigoArticulo.TabIndex = 2;
            this.txtCodigoArticulo.TextChanged += new System.EventHandler(this.txtCodigoArticulo_TextChanged);
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(378, 41);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProveedor.Size = new System.Drawing.Size(316, 20);
            this.txtNombreProveedor.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(531, 96);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarProducto.TabIndex = 4;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Proveedor:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(650, 102);
            this.nudCantidad.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(57, 20);
            this.nudCantidad.TabIndex = 5;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Comprobante:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(592, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Cantidad:";
            // 
            // cboTipoComprobante
            // 
            this.cboTipoComprobante.FormattingEnabled = true;
            this.cboTipoComprobante.Location = new System.Drawing.Point(103, 41);
            this.cboTipoComprobante.Name = "cboTipoComprobante";
            this.cboTipoComprobante.Size = new System.Drawing.Size(121, 21);
            this.cboTipoComprobante.TabIndex = 1;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(967, 101);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(58, 20);
            this.txtPrecioVenta.TabIndex = 7;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(712, 39);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnBuscarProveedor.Text = "...";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(890, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Precio Venta:";
            // 
            // dtpIngresoAlmacen
            // 
            this.dtpIngresoAlmacen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpIngresoAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngresoAlmacen.Location = new System.Drawing.Point(995, 15);
            this.dtpIngresoAlmacen.Name = "dtpIngresoAlmacen";
            this.dtpIngresoAlmacen.Size = new System.Drawing.Size(222, 21);
            this.dtpIngresoAlmacen.TabIndex = 10;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(216, 99);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.ReadOnly = true;
            this.txtNombreArticulo.Size = new System.Drawing.Size(297, 20);
            this.txtNombreArticulo.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(911, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha Ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Producto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Número:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(1080, 99);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(32, 23);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "-";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(103, 12);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(29, 20);
            this.txtSerie.TabIndex = 0;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(817, 101);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(58, 20);
            this.txtPrecioCompra.TabIndex = 6;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Location = new System.Drawing.Point(138, 12);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(86, 20);
            this.txtCorrelativo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(732, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Precio Compra:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1044, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTotalInvertido);
            this.panel5.Controls.Add(this.txtCodigo);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 384);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1233, 33);
            this.panel5.TabIndex = 41;
            // 
            // lblTotalInvertido
            // 
            this.lblTotalInvertido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalInvertido.AutoSize = true;
            this.lblTotalInvertido.Location = new System.Drawing.Point(1066, 11);
            this.lblTotalInvertido.Name = "lblTotalInvertido";
            this.lblTotalInvertido.Size = new System.Drawing.Size(78, 13);
            this.lblTotalInvertido.TabIndex = 40;
            this.lblTotalInvertido.Text = "Total Invertido:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(425, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            this.label4.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panelBotonera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1253, 487);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabConsulta_Ingresos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1253, 452);
            this.panel4.TabIndex = 8;
            // 
            // panelBotonera
            // 
            this.panelBotonera.Controls.Add(this.btnReporte);
            this.panelBotonera.Controls.Add(this.btnRegistrar);
            this.panelBotonera.Controls.Add(this.btnModificar);
            this.panelBotonera.Controls.Add(this.btnCerrar);
            this.panelBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotonera.Location = new System.Drawing.Point(0, 452);
            this.panelBotonera.Margin = new System.Windows.Forms.Padding(5);
            this.panelBotonera.Name = "panelBotonera";
            this.panelBotonera.Size = new System.Drawing.Size(1253, 35);
            this.panelBotonera.TabIndex = 7;
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReporte.Location = new System.Drawing.Point(951, 0);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(76, 35);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "&Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrar.Location = new System.Drawing.Point(1027, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(76, 35);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "&Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModificar.Location = new System.Drawing.Point(1103, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(1178, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 35);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmGestionIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 487);
            this.Controls.Add(this.panel2);
            this.Name = "frmGestionIngresos";
            this.Text = "GestionIngresos";
            this.Load += new System.EventHandler(this.frmGestionIngresos_Load);
            this.tabConsulta_Ingresos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosAlmacen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabMantenimiento_Ingresos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelBotonera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConsulta_Ingresos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabMantenimiento_Ingresos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIngresosAlmacen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProveedorBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoComprobante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpIngresoAlmacen;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Button btnQuitar;
        internal System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetalle;
        internal System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblTotalInvertido;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelBotonera;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        internal System.Windows.Forms.TextBox txtNombreArticulo;
        internal System.Windows.Forms.TextBox txtCodigoArticulo;
        internal System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIngresoAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadStockAlmacen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.RadioButton radInactivo;
        internal System.Windows.Forms.RadioButton radActivo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}