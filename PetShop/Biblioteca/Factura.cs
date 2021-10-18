using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Factura
    {
        int numFactura;
        DateTime fecha;
        Cliente cliente;
        List<ProductoComprado> listaProductosComprados;

        public Factura(Cliente cliente, List<ProductoComprado> listaProductoComprados)
        {
            this.NumFactura = Negocio.RegistroFactura + 1;
            this.Fecha = DateTime.Now;
            this.Cliente = cliente;
            this.ListaProductosComprados = listaProductoComprados;
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<ProductoComprado> ListaProductosComprados { get => listaProductosComprados; set => listaProductosComprados = value; }
        public int NumFactura { get => numFactura; set => numFactura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string MostrarFactura()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Fecha.ToString());
            sb.AppendLine("\n\nDatos Cliente:");
            sb.AppendLine(this.cliente.Mostrar());
            sb.AppendLine("\nItems:");

            for(int i=0; i<listaProductosComprados.Count; i++)
            {
                sb.AppendLine(listaProductosComprados[i].Producto.DatosProducto());
            }

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
    }
}
