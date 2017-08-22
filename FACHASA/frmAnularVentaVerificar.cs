using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FACHASA
{
    public partial class frmAnularVentaVerificar : Form
    {

        private frmGestionVentas frame3;

        public frmAnularVentaVerificar()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

    }
        public void estableceFormulario3(frmGestionVentas frame3)
        {
            this.frame3 = frame3;
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {


            string nombre = txtUsuario.Text;
            string password = txtContraseña.Text;

            Usuario u = UsuarioNEG.Instancia().Login(nombre, password);

            if (u.idUsuario > 0)
            {

                //this.Dispose();
                int idUsuario = u.idUsuario;
                String userName = u.Username;
                String nombres = u.Nombres;
                String apellidoPaterno = u.ApellidoPaterno;
                String apellidoMaterno = u.ApellidoMaterno;
                int idTipo = u.idTipoUsuario;

                if(idTipo == 1)
                {
                    this.frame3.radInactivo.Checked = true;
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("El usuario no tiene privilegios suficientes");
                    this.Dispose();
                    this.frame3.radInactivo.Checked = false;

                }

            }

            else { MessageBox.Show("El usuario no esta registrado"); 
            }
             
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
              
                string nombre = txtUsuario.Text;
                string password = txtContraseña.Text;             

                Usuario u = UsuarioNEG.Instancia().Login(nombre, password);

                if (u.idUsuario > 0)
                {

                    //this.Dispose();
                    int idUsuario = u.idUsuario;
                    String userName = u.Username; 
                    String nombres = u.Nombres; 
                    String apellidoPaterno = u.ApellidoPaterno;
                    String apellidoMaterno = u.ApellidoMaterno;
                    int idTipo = u.idTipoUsuario;

                    frmCentral cl = new frmCentral(idUsuario, userName,nombres, apellidoPaterno, apellidoMaterno, idTipo);
                    cl.Show();
                    this.Hide();

                }
                else { MessageBox.Show("El usuario no esta registrado"); }


            }
            
        }
    }
}
