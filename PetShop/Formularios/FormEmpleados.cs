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
    public partial class FormEmpleados : FormMenu
    {
        static int legajoSeleccionado;

        public FormEmpleados()
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {

            dtgvEmpleados.Rows.Clear();

            int n;

            foreach (Empleado empleado in Negocio.listaEmpleados)
            {
                n = dtgvEmpleados.Rows.Add();

                dtgvEmpleados.Rows[n].Cells[0].Value = empleado.Legajo;
                dtgvEmpleados.Rows[n].Cells[1].Value = empleado.Apellido + " " + empleado.Nombre;
                dtgvEmpleados.Rows[n].Cells[2].Value = empleado.Cuil;
                dtgvEmpleados.Rows[n].Cells[3].Value = empleado.Usuario;

            }      

        }

        private void BorrarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCuil.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
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

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarSinVacios())
            {
                if (Empleado.CargarEmpleado(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, this.txtUser.Text, this.txtPass.Text))
                {
                    MessageBox.Show("ALTA DE EMPLEADO EXITOSA");
                }
                else
                {
                    MessageBox.Show("Datos ingresados incorrectos!!");
                }

                BorrarTextBox();
                LlenarGrilla();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }

        }

        private void dtgvEmpleados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string legajo = dtgvEmpleados.CurrentRow.Cells[0].Value.ToString();

            legajoSeleccionado = int.Parse(legajo);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Empleado empleado = Empleado.BuscarPorLegajo(legajoSeleccionado);

            if ((MessageBox.Show("Se dara de baja a " + empleado.Apellido + " " + empleado.Nombre + " Legajo: " + empleado.Legajo, "BAJA EMPLEADO",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
            {
                if(Empleado.BajaEmpleado(empleado))
                {
                    MessageBox.Show("Se dio de baja al empleado con exito");
                }

                else
                {
                    MessageBox.Show("No se pudo dar de baja al empleado");
                }
            }

            LlenarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = Empleado.BuscarPorLegajo(legajoSeleccionado);

            FormModificarEmpleado form = new FormModificarEmpleado(empleado);
            form.ShowDialog();
            LlenarGrilla();
        }
    }
}
