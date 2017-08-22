using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaNegocio;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace FACHASA
{
    public partial class rptFactura : Form
    {
        public rptFactura()
        {
            InitializeComponent();
        }


        //
        //Cree dos listas una para el Encabezado y otra para el detalle
        //
        public List<Venta> Invoice = new List<Venta>();
        public List<DetalleVenta> Detail = new List<DetalleVenta>();
        //
        //Cree las propiedades publicas Titulo y Empresa
        //
        public string Titulo { get; set; }
        public string Empresa { get; set; }

      



        private void rptFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SigVentasDataSet.SP_Venta_Listar_' Puede moverla o quitarla según sea necesario.
           
            // TODO: esta línea de código carga datos en la tabla 'SigVentasDataSet.SP_Venta_Listar_' Puede moverla o quitarla según sea necesario.


            DataTable dt = VentaNEG.ObtenerVenta("001", "0000001", 1);

            //Limpiemos el DataSource del informe
         

            reportViewer1.Visible = true;
            reportViewer1.LocalReport.DataSources.Clear();
           
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SigVentasDataSet", dt));
            
            reportViewer1.LocalReport.Refresh();


            /*RptCrm.Visible = true;
            RptCrm.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsCrmrpt", dtval);*/
            /*RptCrm.LocalReport.ReportPath = "Report1.rdlc";
            RptCrm.LocalReport.DataSources.Add(rds);
            RptCrm.DataBind();
            RptCrm.LocalReport.Refresh();*/
  


    /*ReportParameter[] parameters = new ReportParameter[2];
    parameters[0] = new ReportParameter("parameterTitulo", Titulo);
    parameters[1] = new ReportParameter("parameterEmpresa", Empresa);

    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Encabezado", Invoice));
    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detail));


    reportViewer1.LocalReport.SetParameters(parameters);



    reportViewer1.RefreshReport();*/

    }
}
}