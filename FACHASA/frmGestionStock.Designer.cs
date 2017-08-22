namespace FACHASA
{
    partial class frmGestionStock
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
            this.dgvIngresosTienda = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMantenimiento_Ingresos = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvDetalleStock = new System.Windows.Forms.DataGridView();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radInactivo = new System.Windows.Forms.RadioButton();
            this.radActivo = new System.Windows.Forms.RadioButton();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalInvertido = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBotonera = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.idStockTienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngresoTienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabConsulta_Ingresos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosTienda)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabMantenimiento_Ingresos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleStock)).BeginInit();
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
            this.tabConsulta_Ingresos.Size = new System.Drawing.Size(1243, 589);
            this.tabConsulta_Ingresos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvIngresosTienda);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvIngresosTienda
            // 
            this.dgvIngresosTienda.AllowUserToAddRows = false;
            this.dgvIngresosTienda.AllowUserToDeleteRows = false;
            this.dgvIngresosTienda.AllowUserToOrderColumns = true;
            this.dgvIngresosTienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresosTienda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStockTienda,
            this.FechaIngresoTienda,
            this.CodigoArticulo,
            this.NombreArticulo,
            this.StockInicial,
            this.StockFinal,
            this.Estado,
            this.Username});
            this.dgvIngresosTienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngresosTienda.Location = new System.Drawing.Point(3, 80);
            this.dgvIngresosTienda.Name = "dgvIngresosTienda";
            this.dgvIngresosTienda.ReadOnly = true;
            this.dgvIngresosTienda.Size = new System.Drawing.Size(1229, 480);
            this.dgvIngresosTienda.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 77);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Consulta Stock Tienda";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(902, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre :";
            // 
            // tabMantenimiento_Ingresos
            // 
            this.tabMantenimiento_Ingresos.Controls.Add(this.panel3);
            this.tabMantenimiento_Ingresos.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento_Ingresos.Name = "tabMantenimiento_Ingresos";
            this.tabMantenimiento_Ingresos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento_Ingresos.Size = new System.Drawing.Size(1235, 563);
            this.tabMantenimiento_Ingresos.TabIndex = 1;
            this.tabMantenimiento_Ingresos.Text = "Ingresos Tienda";
            this.tabMantenimiento_Ingresos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1229, 557);
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
            this.groupBox1.Size = new System.Drawing.Size(1229, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar Stock";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvDetalleStock);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1223, 421);
            this.panel6.TabIndex = 44;
            // 
            // dgvDetalleStock
            // 
            this.dgvDetalleStock.AllowUserToAddRows = false;
            this.dgvDetalleStock.AllowUserToDeleteRows = false;
            this.dgvDetalleStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.codigo,
            this.Nombre,
            this.cantidad});
            this.dgvDetalleStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleStock.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalleStock.MultiSelect = false;
            this.dgvDetalleStock.Name = "dgvDetalleStock";
            this.dgvDetalleStock.ReadOnly = true;
            this.dgvDetalleStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleStock.Size = new System.Drawing.Size(1223, 421);
            this.dgvDetalleStock.TabIndex = 30;
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
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Articulo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 400;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtPrecio);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtStock);
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Controls.Add(this.txtCodigoArticulo);
            this.panel7.Controls.Add(this.txtCodigo);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.btnBuscarProducto);
            this.panel7.Controls.Add(this.nudCantidad);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.dtpFechaIngreso);
            this.panel7.Controls.Add(this.txtNombreArticulo);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.btnQuitar);
            this.panel7.Controls.Add(this.btnAgregar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1223, 84);
            this.panel7.TabIndex = 43;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(720, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(57, 20);
            this.txtPrecio.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(677, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(603, 44);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(68, 20);
            this.txtStock.TabIndex = 48;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radInactivo);
            this.groupBox2.Controls.Add(this.radActivo);
            this.groupBox2.Location = new System.Drawing.Point(1007, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 36);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // radInactivo
            // 
            this.radInactivo.AutoSize = true;
            this.radInactivo.Location = new System.Drawing.Point(117, 13);
            this.radInactivo.Name = "radInactivo";
            this.radInactivo.Size = new System.Drawing.Size(63, 17);
            this.radInactivo.TabIndex = 1;
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
            this.txtCodigoArticulo.Location = new System.Drawing.Point(87, 44);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(123, 20);
            this.txtCodigoArticulo.TabIndex = 40;
            this.txtCodigoArticulo.TextChanged += new System.EventHandler(this.txtCodigoArticulo_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(519, 42);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(34, 23);
            this.btnBuscarProducto.TabIndex = 39;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(870, 47);
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
            this.nudCantidad.TabIndex = 38;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(812, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Cantidad:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaIngreso.Location = new System.Drawing.Point(1007, 12);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 19;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(216, 44);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.ReadOnly = true;
            this.txtNombreArticulo.Size = new System.Drawing.Size(297, 20);
            this.txtNombreArticulo.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(923, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Fecha Ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Producto:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(970, 45);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(32, 23);
            this.btnQuitar.TabIndex = 27;
            this.btnQuitar.Text = "-";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(934, 45);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 23);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTotalInvertido);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 521);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1223, 33);
            this.panel5.TabIndex = 41;
            // 
            // lblTotalInvertido
            // 
            this.lblTotalInvertido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalInvertido.AutoSize = true;
            this.lblTotalInvertido.Location = new System.Drawing.Point(1056, 11);
            this.lblTotalInvertido.Name = "lblTotalInvertido";
            this.lblTotalInvertido.Size = new System.Drawing.Size(78, 13);
            this.lblTotalInvertido.TabIndex = 40;
            this.lblTotalInvertido.Text = "Total Invertido:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panelBotonera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 624);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabConsulta_Ingresos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1243, 589);
            this.panel4.TabIndex = 8;
            // 
            // panelBotonera
            // 
            this.panelBotonera.Controls.Add(this.btnReporte);
            this.panelBotonera.Controls.Add(this.btnRegistrar);
            this.panelBotonera.Controls.Add(this.btnModificar);
            this.panelBotonera.Controls.Add(this.btnCerrar);
            this.panelBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotonera.Location = new System.Drawing.Point(0, 589);
            this.panelBotonera.Margin = new System.Windows.Forms.Padding(5);
            this.panelBotonera.Name = "panelBotonera";
            this.panelBotonera.Size = new System.Drawing.Size(1243, 35);
            this.panelBotonera.TabIndex = 7;
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReporte.Location = new System.Drawing.Point(941, 0);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(76, 35);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrar.Location = new System.Drawing.Point(1017, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(76, 35);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModificar.Location = new System.Drawing.Point(1093, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(1168, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // idStockTienda
            // 
            this.idStockTienda.DataPropertyName = "idStockTienda";
            this.idStockTienda.HeaderText = "Codigo Ingreso";
            this.idStockTienda.Name = "idStockTienda";
            this.idStockTienda.ReadOnly = true;
            this.idStockTienda.Visible = false;
            // 
            // FechaIngresoTienda
            // 
            this.FechaIngresoTienda.DataPropertyName = "FechaIngresoTienda";
            this.FechaIngresoTienda.HeaderText = "Fecha Ingreso";
            this.FechaIngresoTienda.Name = "FechaIngresoTienda";
            this.FechaIngresoTienda.ReadOnly = true;
            this.FechaIngresoTienda.Width = 150;
            // 
            // CodigoArticulo
            // 
            this.CodigoArticulo.DataPropertyName = "CodigoArticulo";
            this.CodigoArticulo.HeaderText = "Codigo Articulo";
            this.CodigoArticulo.Name = "CodigoArticulo";
            this.CodigoArticulo.ReadOnly = true;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.DataPropertyName = "NombreArticulo";
            this.NombreArticulo.HeaderText = "Nombre Articulo";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            this.NombreArticulo.Width = 220;
            // 
            // StockInicial
            // 
            this.StockInicial.DataPropertyName = "StockInicial";
            this.StockInicial.HeaderText = "Stock Ingreso";
            this.StockInicial.Name = "StockInicial";
            this.StockInicial.ReadOnly = true;
            this.StockInicial.Width = 80;
            // 
            // StockFinal
            // 
            this.StockFinal.DataPropertyName = "StockFinal";
            this.StockFinal.HeaderText = "Stock Actual";
            this.StockFinal.Name = "StockFinal";
            this.StockFinal.ReadOnly = true;
            this.StockFinal.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Usuario";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // frmGestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 624);
            this.Controls.Add(this.panel2);
            this.Name = "frmGestionStock";
            this.Text = "Gestion de Stock";
            this.Load += new System.EventHandler(this.frmGestionIngresos_Load);
            this.tabConsulta_Ingresos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosTienda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabMantenimiento_Ingresos.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleStock)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvIngresosTienda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetalleStock;
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
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.RadioButton radInactivo;
        internal System.Windows.Forms.RadioButton radActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStockTienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngresoTienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockFinal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}