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

namespace FACHASA
{
    public partial class frmSeleccionarArticulo : Form
    {

        private frmGestionIngresos frame;
        private frmGestionVentas frame2;
        private frmGestionStock frame3;

        public frmSeleccionarArticulo()
        {
            InitializeComponent();
        }

        public void estableceFormulario(frmGestionIngresos frame)
        {
            this.frame = frame;
        }
        public void estableceFormulario2(frmGestionVentas frame2)
        {
            this.frame2 = frame2;
        }

        public void estableceFormulario3(frmGestionStock frame3)
        {
            this.frame3 = frame3;
        }

        private void frmSeleccionarArticulo_Load(object sender, EventArgs e)
        {
            Articulo a = new Articulo();
            dgvArticulos.DataSource = ArticuloNEG.Instancia().Listar(a);
        }

       

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

            if(frame != null)
                {

                    this.frame.codigoArticuloSeleccionado = Convert.ToInt32(this.dgvArticulos.CurrentRow.Cells["idArticulo"].Value);
                    this.frame.txtNombreArticulo.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["Nombre"].Value);
                    this.frame.txtCodigoArticulo.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["BarCode"].Value);
                    //this.frame.txtPrecioCompra.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["idEstilo"].Value);
                    //Cerrando el formulario
                    this.Hide();
                }

                else if (frame2 != null)

                {

                    this.frame2.codigoArticuloSeleccionado = Convert.ToInt32(this.dgvArticulos.CurrentRow.Cells["idArticulo"].Value);
                    this.frame2.txtNombreArticulo.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["Nombre"].Value);
                    this.frame2.txtBarCodeArticulo.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["BarCode"].Value);
                    //this.frame.txtPrecioCompra.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["idEstilo"].Value);
                    //Cerrando el formulario
                    this.Hide();
                }

                else if (frame3 != null)

                {

                    this.frame3.codigoArticuloSeleccionado = Convert.ToInt32(this.dgvArticulos.CurrentRow.Cells["idArticulo"].Value);
                    this.frame3.txtNombreArticulo.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["Nombre"].Value);
                    this.frame3.txtCodigoArticulo.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["BarCode"].Value);
                    //this.frame.txtPrecioCompra.Text = Convert.ToString(this.dgvArticulos.CurrentRow.Cells["idEstilo"].Value);
                    //Cerrando el formulario
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //ClienteNEG bl = new ClienteNEG();
            Articulo c = new Articulo();
            c.Nombre = txtNombreArticulo.Text;
            c.BarCode = txtBarCode_Busqueda.Text;
            //dgvCliente.DataSource = bl.Buscar(c);
            dgvArticulos.DataSource = ArticuloNEG.Instancia().Buscar(c);
        }
    }
}
