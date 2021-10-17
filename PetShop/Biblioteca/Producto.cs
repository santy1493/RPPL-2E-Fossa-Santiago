using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum ETipoProducto
    {
        Alimento, Juguete, Correa, Limpieza, Pipeta, Medicamento, Otros
    }

    public class Producto
    {
        private string nombre;
        private string marca;
        private int codigo;
        private double precio;
        private int stock;
        private ETipoProducto tipo;

        public Producto(string nombre, string marca, int codigo, double precio, int stock)
        {
            this.Nombre = nombre;
            this.Marca = marca;
            this.Codigo = codigo;
            this.Precio = precio;
            this.Stock = stock;
            this.Tipo = ETipoProducto.Otros;
        }

        public Producto(string nombre, string marca, int codigo, double precio, int stock, ETipoProducto tipo)
            : this(nombre, marca, codigo, precio, stock)
        {
            this.Tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public ETipoProducto Tipo { get => tipo; set => tipo = value; }


        public static bool CargarProducto(string nombre, string marca, string codigo, string precio, string stock, string tipo)
        {
            if (ValidarStockPrecioCodigo(codigo, precio, stock))
            {
                Producto nuevoProducto = new Producto(nombre, marca, int.Parse(codigo), double.Parse(precio), int.Parse(stock), ValidarTipo(tipo));

                Negocio.ListaProductos.Add(nuevoProducto);

                return true;
            }

            return false;

        }

        public bool ModificarProducto(string nombre, string marca, string codigo, string precio, string stock, string tipo)
        {
            if (ValidarStockPrecioCodigo(codigo, precio, stock))
            {
                this.Nombre = nombre;
                this.Marca = marca;
                this.Codigo = int.Parse(codigo);
                this.Precio = double.Parse(precio);
                this.Stock = int.Parse(stock);
                this.Tipo = ValidarTipo(tipo);

                return true;
            }

            return false;

        }

        public static string DatosProducto(int codigo)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto p in Negocio.ListaProductos)
            {
                if (p.Codigo == codigo)
                {

                    sb.AppendLine($"DATOS EMPLEADO:");
                    sb.AppendLine($"Nombre: {p.Nombre}");
                    sb.AppendLine($"Marca: {p.Marca}");
                    sb.AppendLine($"Codigo: {p.Codigo}");
                    sb.AppendLine($"Precio: {p.Precio}");
                    sb.AppendLine($"Stock: {p.Stock}");
                }
            }

            return sb.ToString();
        }

        public static string MostrarProductoPorIndice(int indice)
        {
            string datos;

            Producto producto = Negocio.ListaProductos.ElementAt(indice);

            datos = DatosProducto(producto.Codigo);

            return datos;
        }

        public static bool EliminarProducto(Producto producto)
        {
            if (!(producto is null))
            {
                return Negocio.ListaProductos.Remove(producto);
            }

            return false;
        }

        public static Producto BuscarProductoPorCod(int codigo)
        {
            foreach (Producto p in Negocio.ListaProductos)
            {
                if (p.Codigo == codigo)
                {
                    return p;
                }
            }

            return null;
        }

        public static bool operator >=(Producto p, int cantidad)
        {
            if (p.stock >= cantidad)
            {
                return true;
            }

            return false;
        }

        public static bool operator <=(Producto p, int cantidad)
        {
            return !(p >= cantidad);
        }

        private static bool ValidarCodigo(string codigo)
        {
            int codigoInt;

            if (int.TryParse(codigo, out codigoInt))
            {
                if (codigoInt > 0)
                    return true;
            }

            return false;
        }

        private static bool ValidarStockPrecioCodigo(string codigo, string precio, string stock)
        {
            int codigoInt;
            int stockInt;
            double precioDouble;

            if (int.TryParse(codigo, out codigoInt) && double.TryParse(precio, out precioDouble) && int.TryParse(stock, out stockInt))
            {
                if (codigoInt > 0 && precioDouble > 0 && stockInt > 0)
                    return true;
            }

            return false;

        }

        private static ETipoProducto ValidarTipo(string tipo)
        {
            int enumLenght = Enum.GetNames(typeof(ETipoProducto)).Length;

            foreach(ETipoProducto item in Enum.GetValues(typeof(ETipoProducto)))
            {
                if (item.ToString() == tipo)
                    return item;
            }

            return ETipoProducto.Otros;
        }



    }
}