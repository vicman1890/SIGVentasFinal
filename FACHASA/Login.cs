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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void ValidarCredenciales()
        {
            string nombre = txtUsuario.Text;
            string password = txtContraseña.Text;

            Usuario u = UsuarioNEG.Instancia().Login(nombre, password);

            if (u.idUsuario > 0)
            {
                int idUsuario = u.idUsuario;
                String userName = u.Username;
                String nombres = u.Nombres;
                String apellidoPaterno = u.ApellidoPaterno;
                String apellidoMaterno = u.ApellidoMaterno;
                int idTipo = u.idTipoUsuario;

                frmCentral cl = new frmCentral(idUsuario, userName, nombres, apellidoPaterno, apellidoMaterno, idTipo);
                cl.Show();
                this.Hide();

            }
            else { MessageBox.Show("El usuario no esta registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand); }

            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarCredenciales();
            }
            
        }
    }
}
