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
    public partial class frmCentral : Form
    {
        String userName;
        String nombres;
        String apellidoPaterno;
        String apellidoMaterno;
        int idUser;
        int idTipo;
        
        public frmCentral(int idUsuario, String UserName, String Nombres, String ApellidoPaterno, String ApellidoMaterno, int idTipoUsuario)
        {
            InitializeComponent();
            idUser = idUsuario;
            userName = UserName;
            nombres = Nombres;
            apellidoPaterno = ApellidoPaterno;
            apellidoMaterno = ApellidoMaterno;
            idTipo = idTipoUsuario;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionCliente))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionCliente();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnNuevoComprobante_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionVentas))
                {
                    f.Activate();
                    return;
                }
            }
            /*frmCentral cl = new frmCentral(userName, nombres, apellidoPaterno, apellidoMaterno);
            cl.Show();*/
            Form form1 = new frmGestionVentas(idUser);
            form1.MdiParent = this;
            form1.Show();
        }

        private void ribbonOrbOptionBtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void frmCentral_Load(object sender, EventArgs e)
        {
            if (idTipo != 1)
            {
                btnPersonal.Enabled = false;
                btnIngresosAlmacen.Enabled = false;
                btnStock.Enabled = false;
                btnReporteVentas.Enabled = false;
            }
            else
            {
                btnPersonal.Enabled = true;
                btnIngresosAlmacen.Enabled = true;
                //btnStock.Enabled = true;
            }

            btnStockAlmacen.Enabled = false;
            btnStock.Enabled = false;

            String nombreUsuario = nombres + " " + apellidoPaterno + " " + apellidoMaterno;
            toolStripLabelFecha.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");          
            toolStripLabelNombreCompleto.Text = nombreUsuario.ToUpper();
            this.Update();
        }

        private void frmCentral_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionPersonal))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionPersonal();
            form1.MdiParent = this;
            form1.Show();         
           
        
        }

        

        private void btnEgresosCaja_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmEgresoCaja))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmEgresoCaja();
            form1.MdiParent = this;
            form1.Show();         
        }

        private void btnIngresosAlmacen_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionIngresos))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionIngresos(idUser);
            form1.MdiParent = this;
            form1.Show();
        }

        private void ribbonOrbMenuRecursos_Click(object sender, EventArgs e)
        {
            ribbonPanelPersonal.Visible = true;
            btnPersonal.Visible = true;

            ribbonPanelClientes.Visible = false;
            btnClientes.Visible = false;

        

            ribbonPanelControl.Visible = false;
            btnControl.Visible = false;

            ribbonTabComprobantes.Visible = false;

        }

        private void ribbonOrbMenuAlmacen_Click(object sender, EventArgs e)
        {
            ribbonPanelIngresosAlmacen.Visible = true;
            btnIngresosAlmacen.Visible = true;
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionProveedor))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionProveedor();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionArticulos))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionArticulos();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionColores))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionColores();
            form1.MdiParent = this;
            form1.Show();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionTallas))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionTallas();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnEstilos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionEstilos))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionEstilos();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionStock))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionStock(idUser);
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmReporteVentas))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmReporteVentas();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnStockAlmacen_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmReporteInventarioAlmacen))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmReporteInventarioAlmacen();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionMarcas))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionMarcas();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionMarcas))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionMarcas();
            form1.MdiParent = this;
            form1.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmGestionMarcas))
                {
                    f.Activate();
                    return;
                }
            }
            Form form1 = new frmGestionMarcas();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
