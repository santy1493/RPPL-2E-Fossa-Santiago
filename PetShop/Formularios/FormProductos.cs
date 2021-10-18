using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Formularios
{
    public partial class FormProductos : FormMenu
    {
        static int codigoSeleccionado;
        SoundPlayer sonido = new SoundPlayer();

        public FormProductos()
        {
            InitializeComponent();
            LlenarGrilla();

            cmbTipo.DataSource = Enum.GetValues(typeof(ETipoProducto));
            ETipoProducto tipo;
            Enum.TryParse<ETipoProducto>(cmbTipo.SelectedValue.ToString(), out tipo);
        }


        private void LlenarGrilla()
        {

            dtgvProductos.Rows.Clear();

            int n;

            foreach (Producto producto in Negocio.ListaProductos)
            {
                n = dtgvProductos.Rows.Add();

                dtgvProductos.Rows[n].Cells[0].Value = producto.Codigo;
                dtgvProductos.Rows[n].Cells[1].Value = producto.Nombre;
                dtgvProductos.Rows[n].Cells[2].Value = producto.Marca;
                dtgvProductos.Rows[n].Cells[3].Value = producto.Tipo;
                dtgvProductos.Rows[n].Cells[4].Value = producto.Precio;
                dtgvProductos.Rows[n].Cells[5].Value = producto.Peso;
                dtgvProductos.Rows[n].Cells[6].Value = producto.Stock;

            }

        }

        private bool ValidarSinVacios()
        {
            if (!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtMarca.Text) && !string.IsNullOrEmpty(this.txtCodigo.Text)
                && !string.IsNullOrEmpty(this.txtPrecio.Text) && !string.IsNullOrEmpty(this.txtPeso.Text))
            {
                return true;
            }

            return false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        { 
       
            if (ValidarSinVacios())
            {
                if (Producto.CargarProducto(this.txtNombre.Text, this.txtMarca.Text, this.txtCodigo.Text,
                    this.txtPrecio.Text, this.txtPeso.Text, this.txtStock.Text, this.cmbTipo.Text))
                {
                    sonido.Stream = Properties.Resources.tada2;
                    sonido.Play();
                    MessageBox.Show("ALTA DE PRODUCTO EXITOSA");
                }
                else
                {
                    MessageBox.Show("Datos ingresados incorrectos");
                }
                BorrarTextBox();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }

            LlenarGrilla();
        }

        private void BorrarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtStock.Text = string.Empty;
        }

        private void dtgvProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            codigoSeleccionado = (int)dtgvProductos.CurrentRow.Cells[0].Value;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Producto producto = Producto.BuscarProductoPorCod(codigoSeleccionado);

            if ((MessageBox.Show("Se eliminara el siguiente producto:\nCodigo: " + producto.Codigo + "\nNombre " + producto.Nombre + "\nMarca: " + producto.Marca, "ELIMINAR PRODUCTO",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
            {
                if (Producto.EliminarProducto(producto))
                {
                    MessageBox.Show("Se elimino el producto con exito");
                }

                else
                {
                    MessageBox.Show("No se pudo eliminar el producto");
                }
            }

            LlenarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto producto = Producto.BuscarProductoPorCod(codigoSeleccionado);

            FormModificarProducto form = new FormModificarProducto(producto);
            form.ShowDialog();
            LlenarGrilla();

        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            ExportarCSV(dtgvProductos);
        }
    }
}
