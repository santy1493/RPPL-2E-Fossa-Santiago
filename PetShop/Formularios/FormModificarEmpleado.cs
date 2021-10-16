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
    public partial class FormModificarEmpleado : ModificarPersona
    {
        static Empleado empleadoAModificar;

        public FormModificarEmpleado(Empleado empleado)
        {
            InitializeComponent();

            empleadoAModificar = empleado;

            txtNombre.Text = empleadoAModificar.Nombre;
            txtApellido.Text = empleadoAModificar.Apellido;
            txtCuil.Text = empleadoAModificar.Cuil;
            txtUser.Text = empleadoAModificar.Usuario;
            txtPass.Text = empleadoAModificar.Contrasenia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarSinVacios())
            {
                if (empleadoAModificar.ModificarEmpleado(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, this.txtUser.Text, this.txtPass.Text))
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
            if (!string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtNombre.Text) && !string.IsNullOrEmpty(this.txtUser.Text)
                && !string.IsNullOrEmpty(this.txtCuil.Text) && !string.IsNullOrEmpty(this.txtPass.Text))
            {
                return true;
            }

            return false;
        }
    }
}
