using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace FACHASA
{
    public partial class ReporteVenta : Form
    {
        crReporte rpt = new crReporte();
     
        public ReporteVenta(string valor1, string valor2)
        {
            InitializeComponent();
            txtNumero.Text=valor1;
            txtLetras.Text = valor2;
        }
        
       /* public ReporteVenta(Comprobante c)
        {
            InitializeComponent();
            txtIdComprobante.Text = c.numero.ToString();
            
        }*/


        private void btnMostrar_Click(object sender, EventArgs e)
        {
         
       
        }
        

        
    }
}
