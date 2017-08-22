using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FACHASA
{
    public partial class frmSeleccionServicios : Form
    {

        private int recibir_datos;
        public frmSeleccionServicios()
        {
            InitializeComponent();
        }

        public frmSeleccionServicios(int el_parametro) //Metodo de la clase que espera un parametro
        {
             InitializeComponent();
             recibir_datos = el_parametro;
        }
                         

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            //this.WindowState = FormWindowState.Maximized;
            this.BringToFront();


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (radLavExterno.Checked == true)
            {
                String des = "Lavado Básico";
                Servicio s1 = ServicioNEG.Instancia().ServicioPorTipoVehiculo(recibir_datos,des);
                Decimal precioServicio = s1.precio;
                String str = precioServicio.ToString();
                lblPrecio.Text = str;
            }
           
        }

        private void radLavExterno_CheckedChanged(object sender, EventArgs e)
        {
            if (radLavExterno.Checked == true)
            {

              
                String des = "Lavado Externo";
                Servicio s1 = ServicioNEG.Instancia().ServicioPorTipoVehiculo(recibir_datos,des);
                Decimal precioServicio = s1.precio;
                String str = precioServicio.ToString();
                lblPrecio.Text = "S/. "+str;
             
            }
        }

        private void radLavBásico_CheckedChanged(object sender, EventArgs e)
        {
            if (radLavBásico.Checked == true)
            {

                String des2 = "Lavado Básico";
                Servicio s2 = ServicioNEG.Instancia().ServicioPorTipoVehiculo(recibir_datos, des2);
                Decimal precioServicio2 = s2.precio;
                String str2 = precioServicio2.ToString();
                lblPrecio.Text = "S/. " + str2;
              

            }
        }

    }
}
