using Biblioteca;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormVentas : FormMenu
    {
        static string cuilSeleccionado;
        static int codigoSeleccionado;
        static Cliente clienteSleccionado;
        List<ProductoComprado> listaProductosComprados = new List<ProductoComprado>();

        public FormVentas()
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            dtgvClientes.Rows.Clear();

            int n;

            foreach (KeyValuePair<string, Cliente> item in Negocio.ListaClientes)
            {
                n = dtgvClientes.Rows.Add();

                dtgvClientes.Rows[n].Cells[0].Value = item.Value.Cuil;
                dtgvClientes.Rows[n].Cells[1].Value = item.Value.Apellido + " " + item.Value.Nombre;
                dtgvClientes.Rows[n].Cells[2].Value = item.Value.Saldo;

            }

            dtgvProductos.Rows.Clear();

            foreach (Producto producto in Negocio.ListaProductos)
            {
                n = dtgvProductos.Rows.Add();

                dtgvProductos.Rows[n].Cells[0].Value = producto.Codigo;
                dtgvProductos.Rows[n].Cells[1].Value = producto.Nombre;
                dtgvProductos.Rows[n].Cells[2].Value = producto.Tipo;
                dtgvProductos.Rows[n].Cells[3].Value = producto.Precio;
                dtgvProductos.Rows[n].Cells[4].Value = producto.Stock;

            }

        }

        private void LlenarGrillaCarrito()
        {
            dtgvCarrito.Rows.Clear();

            int n;

            foreach (ProductoComprado productoComprado in listaProductosComprados)
            {
                n = dtgvCarrito.Rows.Add();

                dtgvCarrito.Rows[n].Cells[0].Value = productoComprado.Producto.Codigo;
                dtgvCarrito.Rows[n].Cells[1].Value = productoComprado.Producto.Nombre;
                dtgvCarrito.Rows[n].Cells[2].Value = productoComprado.Producto.Marca;
                dtgvCarrito.Rows[n].Cells[3].Value = productoComprado.Cantidad;
                dtgvCarrito.Rows[n].Cells[4].Value = productoComprado.Producto.Precio*productoComprado.Cantidad;

            }

        }

        private void dtgvClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cuilSeleccionado = dtgvClientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            clienteSleccionado = Cliente.BuscarCliente(cuilSeleccionado);
            lblDatosCliente.Text = clienteSleccionado.Mostrar();
        }

        private void dtgvProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            codigoSeleccionado = (int)dtgvProductos.CurrentRow.Cells[0].Value;
        }

        private void btnAgregarCarrito_Click(object sender, System.EventArgs e)
        {
            int cantidad;
            Producto producto;
            ProductoComprado productoComprado;

            if (ValidarNoEstaCarrito(codigoSeleccionado))
            {
                if (int.TryParse(nupCantidad.Text, out cantidad) && cantidad > 0)
                {

                    producto = Producto.BuscarProductoPorCod(codigoSeleccionado);

                    if (producto != null && producto >= cantidad)
                    {
                        productoComprado = new ProductoComprado(producto, cantidad);
                        listaProductosComprados.Add(productoComprado);
                        LlenarGrillaCarrito();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto");
                        nupCantidad.Value = 0;
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese cantidad");
                    nupCantidad.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("El producto ya esta en el carrito");
                nupCantidad.Value = 0;
            }
        }

        private void btnComprar_Click(object sender, System.EventArgs e)
        {
            double precioTotal = 0;
            Cliente cliente = clienteSleccionado;
            List<ProductoComprado> facturaProductos = new List<ProductoComprado>();
            foreach(ProductoComprado p in listaProductosComprados)
            {
                facturaProductos.Add(p);
            }

            if (listaProductosComprados.Count > 0 && !(cliente is null))
            {
                foreach (ProductoComprado p in listaProductosComprados)
                {
                    precioTotal += p.Producto.Precio * p.Cantidad;
                }

                if (cliente.Saldo >= precioTotal)
                {
                    MessageBox.Show("Venta exitosa precio total: " + precioTotal + "saldo cliente: " + cliente.Saldo);
                    cliente.ActualizarSaldo(precioTotal);
                    MessageBox.Show(facturaProductos.Count.ToString());
                    Negocio.ListaFacturas.Add(new Factura(cliente, facturaProductos));
                    Producto.ActualizarStock(listaProductosComprados);
                    
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }
            }

            else
            {
                MessageBox.Show("No se pudo realizar operacion");
            }

            LlenarGrilla();
            dtgvCarrito.Rows.Clear();
            clienteSleccionado = null;
            listaProductosComprados.Clear();
            lblDatosCliente.Text = "Seleccione un cliente";


        }

        //private void btnVenta_Click(object sender, EventArgs e)
        //{
        //    double precioTotal = 0;

        //    if (listaProductosComprados.Count > 0 && !(clienteSeleccionado is null))
        //    {
        //        foreach (Producto p in productosComprados)
        //        {
        //            precioTotal += p.Precio * p.cantVenta;
        //        }

        //        if (clienteComprando.Saldo >= precioTotal)
        //        {
        //            MessageBox.Show("Venta exitosa precio total: " + precioTotal + "saldo cliente: " + clienteComprando.Saldo);
        //            Cliente.ActualizarSaldo(clienteComprando, precioTotal);
        //            Negocio.ActualizarStock();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Saldo insuficiente");
        //        }
        //    }

        //    else
        //    {
        //        MessageBox.Show("No se pudo realizar operacion");
        //    }

        //    LlenarGrilla();
        //    BorrarTextBoxProducto();
        //    lblCliente.Text = string.Empty;
        //    dtgvCarrito.Rows.Clear();
        //    clienteComprando = null;
        //    productosComprados.Clear();
        //    Negocio.RestablecerCantVentas();

        //}

        private bool ValidarNoEstaCarrito(int codigo)
        {
            foreach (DataGridViewRow fila in dtgvCarrito.Rows)
            {
                if ((int)fila.Cells[0].Value == codigo)
                    return false;
            }

            return true;
        }

        //private void AgregarFilaCarrito(int cantidad)
        //{
        //    int n;

        //    n = dtgvCarrito.Rows.Add();

        //    dtgvCarrito.Rows[n].Cells[0].Value = productoSeleccionado.Codigo;
        //    dtgvCarrito.Rows[n].Cells[1].Value = productoSeleccionado.Nombre;
        //    dtgvCarrito.Rows[n].Cells[2].Value = productoSeleccionado.Marca;
        //    dtgvCarrito.Rows[n].Cells[3].Value = cantidad;
        //    dtgvCarrito.Rows[n].Cells[4].Value = productoSeleccionado.Precio*cantidad;

        //}


    }
}
