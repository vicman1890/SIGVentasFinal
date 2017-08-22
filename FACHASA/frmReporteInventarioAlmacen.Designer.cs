namespace FACHASA
{
    partial class frmReporteInventarioAlmacen
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
            this.tabConsulta_Ventas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvReporteStockAlmacen = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBotonera = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabConsulta_Ventas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteStockAlmacen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConsulta_Ventas
            // 
            this.tabConsulta_Ventas.Controls.Add(this.tabPage1);
            this.tabConsulta_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConsulta_Ventas.Location = new System.Drawing.Point(0, 0);
            this.tabConsulta_Ventas.Name = "tabConsulta_Ventas";
            this.tabConsulta_Ventas.SelectedIndex = 0;
            this.tabConsulta_Ventas.Size = new System.Drawing.Size(1243, 589);
            this.tabConsulta_Ventas.TabIndex = 0;
            this.tabConsulta_Ventas.SelectedIndexChanged += new System.EventHandler(this.tabConsulta_Ventas_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvReporteStockAlmacen);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvReporteStockAlmacen
            // 
            this.dgvReporteStockAlmacen.AllowUserToAddRows = false;
            this.dgvReporteStockAlmacen.AllowUserToDeleteRows = false;
            this.dgvReporteStockAlmacen.AllowUserToOrderColumns = true;
            this.dgvReporteStockAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteStockAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.Codigo,
            this.Nombre,
            this.Color,
            this.Estilo,
            this.Talla,
            this.Genero,
            this.Estado});
            this.dgvReporteStockAlmacen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteStockAlmacen.Location = new System.Drawing.Point(3, 80);
            this.dgvReporteStockAlmacen.Name = "dgvReporteStockAlmacen";
            this.dgvReporteStockAlmacen.ReadOnly = true;
            this.dgvReporteStockAlmacen.Size = new System.Drawing.Size(1229, 480);
            this.dgvReporteStockAlmacen.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBuscar);
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
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Consulta de Inventario Almacen";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1114, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.panel4.Controls.Add(this.tabConsulta_Ventas);
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
            this.btnReporte.Click += new System.EventHandler(this.button3_Click);
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
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
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
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            // idArticulo
            // 
            this.idArticulo.DataPropertyName = "idArticulo";
            this.idArticulo.HeaderText = "Codigo Articulo";
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Articulo";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color Articulo";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Estilo
            // 
            this.Estilo.DataPropertyName = "Estilo";
            this.Estilo.HeaderText = "Estilo Articulo";
            this.Estilo.Name = "Estilo";
            this.Estilo.ReadOnly = true;
            // 
            // Talla
            // 
            this.Talla.DataPropertyName = "Talla";
            this.Talla.HeaderText = "Talla Articulo";
            this.Talla.Name = "Talla";
            this.Talla.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero Articulo";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // frmReporteInventarioAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 624);
            this.Controls.Add(this.panel2);
            this.Name = "frmReporteInventarioAlmacen";
            this.Text = "Reporte Inventario";
            this.Load += new System.EventHandler(this.frmGestionIngresos_Load);
            this.tabConsulta_Ventas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteStockAlmacen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelBotonera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConsulta_Ventas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReporteStockAlmacen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelBotonera;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}