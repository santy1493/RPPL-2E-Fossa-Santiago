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
    public partial class FormModificarCliente : ModificarPersona
    {
        static Cliente clienteAModificar;

        public FormModificarCliente(Cliente cliente)
        {
            InitializeComponent();

            clienteAModificar = cliente;

            txtNombre.Text = clienteAModificar.Nombre;
            txtApellido.Text = clienteAModificar.Apellido;
            txtCuil.Text = clienteAModificar.Cuil;
            txtSaldo.Text = clienteAModificar.Saldo.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarSinVacios())
            {
                if (clienteAModificar.ModificarCliente(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, this.txtSaldo.Text))
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
            if (!string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtSaldo.Text)
                && !string.IsNullOrEmpty(this.txtCuil.Text))
            {
                return true;
            }

            return false;
        }
    }
}
