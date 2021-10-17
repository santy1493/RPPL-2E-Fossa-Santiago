using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Formularios
{
    public partial class FormModificarProducto : ModificarPersona
    {
        static Producto productoAModificar;
        public FormModificarProducto(Producto producto)
        {
            InitializeComponent();
            productoAModificar = producto;

            cmbTipo.DataSource = Enum.GetValues(typeof(ETipoProducto));
            ETipoProducto tipo;
            Enum.TryParse<ETipoProducto>(cmbTipo.SelectedValue.ToString(), out tipo);

            txtNombre.Text = productoAModificar.Nombre;
            txtMarca.Text = productoAModificar.Marca;
            txtCodigo.Text = productoAModificar.Codigo.ToString();
            txtPrecio.Text = productoAModificar.Precio.ToString();
            nupStock.Text = productoAModificar.Stock.ToString();
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (ValidarSinVacios())
            {
                if (productoAModificar.ModificarProducto(this.txtNombre.Text, this.txtMarca.Text, this.txtCodigo.Text, this.txtPrecio.Text, this.nupStock.Text, this.cmbTipo.Text))
                {
                    MessageBox.Show("DATOS GUARDADOS CON EXITO");
                }
                else
                {
                    MessageBox.Show("Datos ingresados incorrectos!!");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private bool ValidarSinVacios()
        {
            if (!string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtMarca.Text) && !string.IsNullOrEmpty(this.txtCodigo.Text)
                && !string.IsNullOrEmpty(this.txtPrecio.Text))
            {
                return true;
            }

            return false;
        }
    }
}
