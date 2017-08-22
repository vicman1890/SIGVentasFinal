namespace FACHASA
{
    partial class rptFactura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SP_Venta_Listar_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SigVentasDataSet = new FACHASA.SigVentasDataSet();
            this.VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_Venta_Listar_TableAdapter = new FACHASA.SigVentasDataSetTableAdapters.SP_Venta_Listar_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Venta_Listar_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SigVentasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_Venta_Listar_BindingSource
            // 
            this.SP_Venta_Listar_BindingSource.DataMember = "SP_Venta_Listar_";
            this.SP_Venta_Listar_BindingSource.DataSource = this.SigVentasDataSet;
            // 
            // SigVentasDataSet
            // 
            this.SigVentasDataSet.DataSetName = "SigVentasDataSet";
            this.SigVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VentaBindingSource
            // 
            this.VentaBindingSource.DataSource = typeof(CapaEntidades.Venta);
            // 
            // DetalleVentaBindingSource
            // 
            this.DetalleVentaBindingSource.DataSource = typeof(CapaEntidades.DetalleVenta);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Venta_Listar_BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FACHASA.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(633, 415);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_Venta_Listar_TableAdapter
            // 
            this.SP_Venta_Listar_TableAdapter.ClearBeforeFill = true;
            // 
            // rptFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 415);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptFactura";
            this.Text = "rptFactura";
            this.Load += new System.EventHandler(this.rptFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_Venta_Listar_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SigVentasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VentaBindingSource;
        private System.Windows.Forms.BindingSource DetalleVentaBindingSource;
        private System.Windows.Forms.BindingSource SP_Venta_Listar_BindingSource;
        private SigVentasDataSet SigVentasDataSet;
        private SigVentasDataSetTableAdapters.SP_Venta_Listar_TableAdapter SP_Venta_Listar_TableAdapter;
    }
}