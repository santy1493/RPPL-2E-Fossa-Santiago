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
    public partial class FormFacturacion : FormMenu
    {
        static int numFacturaSeleccionado;

        public FormFacturacion()
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            dtgvFacturas.Rows.Clear();
            int n;


            foreach (Factura factura in Negocio.ListaFacturas)
            {
                n = dtgvFacturas.Rows.Add();

                dtgvFacturas.Rows[n].Cells[0].Value = factura.NumFactura;
                dtgvFacturas.Rows[n].Cells[1].Value = factura.Fecha.ToString();
                dtgvFacturas.Rows[n].Cells[2].Value = factura.Cliente.Apellido;


            }
        }

        private void dtgvFacturas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            numFacturaSeleccionado = (int)dtgvFacturas.CurrentRow.Cells[0].Value;
        }

        private void btnMostrarFactura_Click(object sender, EventArgs e)
        {
            Factura factura = Factura.BuscarFactura(numFacturaSeleccionado);

            if(!(factura is null))
            {
                MessageBox.Show(factura.MostrarFactura());
            }
        }
    }

}
