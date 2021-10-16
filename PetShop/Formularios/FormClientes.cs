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
    public partial class FormClientes : FormMenu
    {
        static string cuilSeleccionado;

        public FormClientes()
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {

            dtgvEmpleados.Rows.Clear();

            int n;

            foreach (KeyValuePair<string, Cliente> item in Negocio.ListaClientes)
            {
                n = dtgvEmpleados.Rows.Add();

                dtgvEmpleados.Rows[n].Cells[0].Value = item.Value.Id;
                dtgvEmpleados.Rows[n].Cells[1].Value = item.Value.Apellido + " " + item.Value.Nombre;
                dtgvEmpleados.Rows[n].Cells[2].Value = item.Value.Cuil;
                dtgvEmpleados.Rows[n].Cells[3].Value = item.Value.Saldo;

            }

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarSinVacios())
            {
                if (Cliente.CargarCliente(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, this.txtSaldo.Text))
                {
                    MessageBox.Show("ALTA DE CLIENTE EXITOSA");
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


        private void BorrarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCuil.Text = string.Empty;
            txtSaldo.Text = string.Empty;
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

        private void dtgvEmpleados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cuilSeleccionado = dtgvEmpleados.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.BuscarCliente(cuilSeleccionado);

            if ((MessageBox.Show("Se dara de baja a " + cliente.Apellido + " " + cliente.Nombre + " Legajo: " + cliente.Id, "BAJA EMPLEADO",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
            {
                if (cliente.BajaCliente())
                {
                    MessageBox.Show("Se dio de baja al cliente con exito");
                }

                else
                {
                    MessageBox.Show("No se pudo dar de baja al cliente");
                }
            }

            LlenarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = Cliente.BuscarCliente(cuilSeleccionado);

            FormModificarCliente form = new FormModificarCliente(cliente);
            form.ShowDialog();
            LlenarGrilla();
        }
    }
}
