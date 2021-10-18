using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Biblioteca;

namespace Formularios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            //lblUsuario.Text = Negocio.EmpleadoLogeado.Mostrar();
            //if(Negocio.EmpleadoLogeado.EsAdmin==false)
            //{
            //    lblAdmin.Text = string.Empty;
            //    btnEmpleados.Enabled = false;
            //}
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show();
            this.Close();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.Show();
            this.Close();
        }

        public void ExportarCSV(DataGridView dataGridView)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo CSV|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> cabeceras = new List<string>();
                foreach (DataGridViewColumn col in dataGridView.Columns)
                {
                    cabeceras.Add(col.HeaderText);
                }
                string SEP = ",";
                filas.Add(string.Join(SEP, cabeceras));

                foreach (DataGridViewRow fila in dataGridView.Rows)
                {
                    try
                    {

                        List<string> celdas = new List<string>();
                        foreach (DataGridViewCell c in fila.Cells)
                            celdas.Add(c.Value.ToString());

                        filas.Add(string.Join(SEP, celdas));
                    }
                    catch (Exception ex) { }
                }

                File.WriteAllLines(sfd.FileName, filas);
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FormFacturacion formFacturacion = new FormFacturacion();
            formFacturacion.Show();
            this.Close();
        }
    }
}
