namespace FACHASA
{
    partial class frmGestionCliente
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
            this.txtRuc_Busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre_Busqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelBotonera = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.gboxRegistro = new System.Windows.Forms.GroupBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarRucSunat = new System.Windows.Forms.Button();
            this.pictureCapchaR = new System.Windows.Forms.PictureBox();
            this.pictureCapchaE = new System.Windows.Forms.PictureBox();
            this.pictureCapcha = new System.Windows.Forms.PictureBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radInactivo = new System.Windows.Forms.RadioButton();
            this.radActivo = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.panelBotonera.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            this.tabMantenimiento.SuspendLayout();
            this.gboxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapchaR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapchaE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRuc_Busqueda
            // 
            this.txtRuc_Busqueda.Location = new System.Drawing.Point(598, 33);
            this.txtRuc_Busqueda.Name = "txtRuc_Busqueda";
            this.txtRuc_Busqueda.Size = new System.Drawing.Size(100, 20);
            this.txtRuc_Busqueda.TabIndex = 8;
            this.txtRuc_Busqueda.TextChanged += new System.EventHandler(this.txtRuc_TextChanged);
            this.txtRuc_Busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_Busqueda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "RUC:";
            // 
            // txtNombre_Busqueda
            // 
            this.txtNombre_Busqueda.Location = new System.Drawing.Point(211, 33);
            this.txtNombre_Busqueda.Name = "txtNombre_Busqueda";
            this.txtNombre_Busqueda.Size = new System.Drawing.Size(293, 20);
            this.txtNombre_Busqueda.TabIndex = 6;
            this.txtNombre_Busqueda.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Razon Social / Nombre :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(781, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "&Consultar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnModificar.Location = new System.Drawing.Point(693, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(768, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 35);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrar.Location = new System.Drawing.Point(617, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(76, 35);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "&Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelBotonera
            // 
            this.panelBotonera.Controls.Add(this.btnReporte);
            this.panelBotonera.Controls.Add(this.btnRegistrar);
            this.panelBotonera.Controls.Add(this.btnModificar);
            this.panelBotonera.Controls.Add(this.btnCerrar);
            this.panelBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotonera.Location = new System.Drawing.Point(0, 436);
            this.panelBotonera.Margin = new System.Windows.Forms.Padding(5);
            this.panelBotonera.Name = "panelBotonera";
            this.panelBotonera.Size = new System.Drawing.Size(843, 35);
            this.panelBotonera.TabIndex = 4;
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReporte.Location = new System.Drawing.Point(541, 0);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(76, 35);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "&Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(843, 436);
            this.panelPrincipal.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 436);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Controls.Add(this.tabMantenimiento);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 436);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.panel2);
            this.tabConsulta.Controls.Add(this.panelBusqueda);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(835, 410);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 334);
            this.panel2.TabIndex = 4;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Email,
            this.Nombre,
            this.Ruc,
            this.Dirección,
            this.Telefono});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(829, 334);
            this.dgvClientes.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idCliente";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombres";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 350;
            // 
            // Ruc
            // 
            this.Ruc.DataPropertyName = "Ruc";
            this.Ruc.HeaderText = "RUC";
            this.Ruc.Name = "Ruc";
            this.Ruc.ReadOnly = true;
            // 
            // Dirección
            // 
            this.Dirección.DataPropertyName = "Direccion";
            this.Dirección.HeaderText = "Direccion";
            this.Dirección.Name = "Dirección";
            this.Dirección.ReadOnly = true;
            this.Dirección.Width = 420;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.label3);
            this.panelBusqueda.Controls.Add(this.txtRuc_Busqueda);
            this.panelBusqueda.Controls.Add(this.txtNombre_Busqueda);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.label2);
            this.panelBusqueda.Controls.Add(this.label1);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Location = new System.Drawing.Point(3, 3);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(829, 70);
            this.panelBusqueda.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Busqueda de Clientes";
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.gboxRegistro);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(835, 410);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // gboxRegistro
            // 
            this.gboxRegistro.Controls.Add(this.txtCiudad);
            this.gboxRegistro.Controls.Add(this.label6);
            this.gboxRegistro.Controls.Add(this.btnBuscarRucSunat);
            this.gboxRegistro.Controls.Add(this.pictureCapchaR);
            this.gboxRegistro.Controls.Add(this.pictureCapchaE);
            this.gboxRegistro.Controls.Add(this.pictureCapcha);
            this.gboxRegistro.Controls.Add(this.txtTexto);
            this.gboxRegistro.Controls.Add(this.groupBox2);
            this.gboxRegistro.Controls.Add(this.txtId);
            this.gboxRegistro.Controls.Add(this.txtTelefono);
            this.gboxRegistro.Controls.Add(this.label4);
            this.gboxRegistro.Controls.Add(this.label5);
            this.gboxRegistro.Controls.Add(this.txtEmail);
            this.gboxRegistro.Controls.Add(this.label10);
            this.gboxRegistro.Controls.Add(this.txtDireccion);
            this.gboxRegistro.Controls.Add(this.txtNombre);
            this.gboxRegistro.Controls.Add(this.label11);
            this.gboxRegistro.Controls.Add(this.label12);
            this.gboxRegistro.Controls.Add(this.txtRuc);
            this.gboxRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRegistro.Location = new System.Drawing.Point(3, 3);
            this.gboxRegistro.Name = "gboxRegistro";
            this.gboxRegistro.Size = new System.Drawing.Size(829, 404);
            this.gboxRegistro.TabIndex = 4;
            this.gboxRegistro.TabStop = false;
            this.gboxRegistro.Text = "Nuevo Cliente";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(162, 167);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(146, 20);
            this.txtCiudad.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ciudad:";
            // 
            // btnBuscarRucSunat
            // 
            this.btnBuscarRucSunat.Location = new System.Drawing.Point(330, 34);
            this.btnBuscarRucSunat.Name = "btnBuscarRucSunat";
            this.btnBuscarRucSunat.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRucSunat.TabIndex = 4;
            this.btnBuscarRucSunat.Text = "&Buscar";
            this.btnBuscarRucSunat.UseVisualStyleBackColor = true;
            this.btnBuscarRucSunat.Click += new System.EventHandler(this.btnBuscarRucSunat_Click);
            // 
            // pictureCapchaR
            // 
            this.pictureCapchaR.Location = new System.Drawing.Point(728, 256);
            this.pictureCapchaR.Name = "pictureCapchaR";
            this.pictureCapchaR.Size = new System.Drawing.Size(145, 50);
            this.pictureCapchaR.TabIndex = 42;
            this.pictureCapchaR.TabStop = false;
            // 
            // pictureCapchaE
            // 
            this.pictureCapchaE.Location = new System.Drawing.Point(728, 189);
            this.pictureCapchaE.Name = "pictureCapchaE";
            this.pictureCapchaE.Size = new System.Drawing.Size(145, 50);
            this.pictureCapchaE.TabIndex = 41;
            this.pictureCapchaE.TabStop = false;
            // 
            // pictureCapcha
            // 
            this.pictureCapcha.Location = new System.Drawing.Point(728, 135);
            this.pictureCapcha.Name = "pictureCapcha";
            this.pictureCapcha.Size = new System.Drawing.Size(104, 48);
            this.pictureCapcha.TabIndex = 40;
            this.pictureCapcha.TabStop = false;
            this.pictureCapcha.Visible = false;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(728, 109);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ReadOnly = true;
            this.txtTexto.Size = new System.Drawing.Size(100, 20);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radInactivo);
            this.groupBox2.Controls.Add(this.radActivo);
            this.groupBox2.Location = new System.Drawing.Point(38, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 82);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // radInactivo
            // 
            this.radInactivo.AutoSize = true;
            this.radInactivo.Location = new System.Drawing.Point(40, 51);
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
            this.radActivo.Location = new System.Drawing.Point(40, 23);
            this.radActivo.Name = "radActivo";
            this.radActivo.Size = new System.Drawing.Size(55, 17);
            this.radActivo.TabIndex = 0;
            this.radActivo.TabStop = true;
            this.radActivo.Text = "Activo";
            this.radActivo.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1089, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(85, 20);
            this.txtId.TabIndex = 37;
            this.txtId.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(162, 141);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(146, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Razon Social / Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(162, 89);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(452, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(452, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "RUC:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(162, 37);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(146, 20);
            this.txtRuc.TabIndex = 0;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_KeyPress);
            // 
            // frmGestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 471);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelBotonera);
            this.Name = "frmGestionCliente";
            this.Load += new System.EventHandler(this.GestionCliente_Load);
            this.panelBotonera.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.tabMantenimiento.ResumeLayout(false);
            this.gboxRegistro.ResumeLayout(false);
            this.gboxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapchaR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapchaE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapcha)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre_Busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtRuc_Busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBotonera;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox gboxRegistro;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radInactivo;
        private System.Windows.Forms.RadioButton radActivo;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.PictureBox pictureCapcha;
        private System.Windows.Forms.PictureBox pictureCapchaE;
        private System.Windows.Forms.PictureBox pictureCapchaR;
        private System.Windows.Forms.Button btnBuscarRucSunat;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}