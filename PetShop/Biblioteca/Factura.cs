using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Factura
    {
        public enum ETipoEnvio
        {
            moto, miniflete, RetiroCliente
        }

        int numFactura;
        DateTime fecha;
        Cliente cliente;
        List<ProductoComprado> listaProductosComprados;
        double precioEnvio;
        ETipoEnvio tipo;


        public Factura(Cliente cliente, List<ProductoComprado> listaProductoComprados)
        {
            this.NumFactura = Negocio.RegistroFactura + 1;
            Negocio.RegistroFactura = this.NumFactura;
            this.Fecha = DateTime.Now;
            this.Cliente = cliente;
            this.ListaProductosComprados = listaProductoComprados;
            this.precioEnvio = 0;
            this.Tipo = ETipoEnvio.RetiroCliente;
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<ProductoComprado> ListaProductosComprados { get => listaProductosComprados; set => listaProductosComprados = value; }
        public int NumFactura { get => numFactura; set => numFactura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double PrecioEnvio { get => precioEnvio; set => precioEnvio = value; }
        public ETipoEnvio Tipo { get => tipo; set => tipo = value; }

        public string MostrarFactura()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Fecha.ToString());
            sb.AppendLine("\n\nDatos Cliente:");
            sb.AppendLine(this.cliente.Mostrar());
            sb.AppendLine(this.MostrarListaProducto());

            sb.AppendLine(this.MostrarEnvio());

            sb.AppendLine($"TOTAL: ${this.CalcularPrecioTotal()}");

            return sb.ToString();
        }

        public static Factura BuscarFactura(int numFactura)
        {
            foreach(Factura factura in Negocio.ListaFacturas)
            {
                if (factura.NumFactura == numFactura)
                    return factura;
            }

            return null;
        }

        public static double CalcularDistanciaEnvio()
        {
            Random random = new Random();
            double distancia = random.Next(1, 150);

            return distancia;

        }

        public static ETipoEnvio CalcularTipoEnvio(List<ProductoComprado> productosComprados)
        {
            double pesoTotal = 0;
            int cantTotal = 0;

            foreach (ProductoComprado p in productosComprados)
            {
                pesoTotal += p.Producto.Peso;
                cantTotal += p.Cantidad;
            }

            if (pesoTotal > 5 || cantTotal > 4)
            {
                return ETipoEnvio.miniflete;
            }

            return ETipoEnvio.moto;
        }

        public static double CalcularPrecioEnvio(List<ProductoComprado> productosComprados, double distancia)
        {
            ETipoEnvio tipo = CalcularTipoEnvio(productosComprados);

            if(tipo==ETipoEnvio.moto)
            {
                return distancia * 10;
            }
            else
            {
                return distancia * 20;
            }
        }

        public double CalcularPrecioTotal()
        {
            double precioTotal = 0;

            foreach(ProductoComprado p in this.listaProductosComprados)
            {
                precioTotal += p.Producto.Precio * p.Cantidad;
            }

            precioTotal += this.precioEnvio;

            return precioTotal;
        }

        private string MostrarEnvio()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***ENVIO***");
            sb.AppendLine($"Tipo de envio: {this.tipo}");
            sb.AppendLine($"Costo de envio: {this.precioEnvio}");

            return sb.ToString();
        }

        public string MostrarListaProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("****ITEMS****\n");

            foreach(ProductoComprado p in this.listaProductosComprados)
            {
                sb.AppendLine($"Nombre: {p.Producto.Nombre}");
                sb.AppendLine($"Marca: {p.Producto.Marca}");
                sb.AppendLine($"Precio Unit.: {p.Producto.Precio}");
                sb.AppendLine($"Cant.: {p.Cantidad}");
                sb.AppendLine($"Precio: {p.Producto.Precio*p.Cantidad}");
            }

            return sb.ToString();
        }
    }
}
