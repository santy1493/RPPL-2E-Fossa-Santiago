using Biblioteca;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Empleado empleado = Empleado.ValidarUserPass(this.txtUser.Text, this.txtPass.Text);

            if (!(empleado is null))
            {
                Negocio.EmpleadoLogeado = empleado;
                FormMenu form = new FormMenu();
                form.Show();

            }
            else
            {
                this.txtUser.Text = "";
                this.txtPass.Text = "";
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "lucherrera";
            this.txtPass.Text = "manzana";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "robmolina";
            this.txtPass.Text = "banana";
        }
    }
}
