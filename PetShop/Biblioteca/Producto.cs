using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private double peso;
        private ETipoProducto tipo;

        public Producto(string nombre, string marca, int codigo, double precio, double peso, int stock)
        {
            this.Nombre = nombre;
            this.Marca = marca;
            this.Codigo = codigo;
            this.Precio = precio;
            this.Peso = peso;
            this.Stock = stock;
            this.Tipo = ETipoProducto.Otros;
        }

        public Producto(string nombre, string marca, int codigo, double precio, double peso, int stock, ETipoProducto tipo)
            : this(nombre, marca, codigo, precio, peso, stock)
        {
            this.Tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Stock { get => stock; set => stock = value; }
        public ETipoProducto Tipo { get => tipo; set => tipo = value; }


        public static bool CargarProducto(string nombre, string marca, string codigo, string precio, string peso, string stock, string tipo)
        {
            if (ValidarStockPrecioPesoCodigo(codigo, precio, peso, stock))
            {
                Producto nuevoProducto = new Producto(nombre, marca, int.Parse(codigo), double.Parse(precio), double.Parse(peso), int.Parse(stock), ValidarTipo(tipo));

                Negocio.ListaProductos.Add(nuevoProducto);

                return true;
            }

            return false;

        }

        public bool ModificarProducto(string nombre, string marca, string codigo, string precio, string peso, string stock, string tipo)
        {
            if (ValidarStockPrecioPesoCodigo(codigo, precio, peso, stock))
            {
                this.Nombre = nombre;
                this.Marca = marca;
                this.Codigo = int.Parse(codigo);
                this.Precio = double.Parse(precio);
                this.Peso = double.Parse(peso);
                this.Stock = int.Parse(stock);
                this.Tipo = ValidarTipo(tipo);

                return true;
            }

            return false;

        }

        public string DatosProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Codigo: {this.Codigo}");
            sb.AppendLine($"Precio: {this.Precio}");
            sb.AppendLine($"Stock: {this.Stock}");


            return sb.ToString();
        }

        public static string DatosProducto(int codigo)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto p in Negocio.ListaProductos)
            {
                if (p.Codigo == codigo)
                {

                    sb.AppendLine($"DATOS PRODUCTO:");
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

        private static bool ValidarStockPrecioPesoCodigo(string codigo, string precio, string peso, string stock)
        {

            if (Validaciones.ValidarEnteroPositivo(codigo) && Validaciones.ValidarDecimalPositivo(precio) &&
                Validaciones.ValidarDecimalPositivo(peso) && Validaciones.ValidarEnteroPositivo(stock))
            {
                return true;
            }

            return false;

        }

        private static ETipoProducto ValidarTipo(string tipo)
        {
            foreach (ETipoProducto item in Enum.GetValues(typeof(ETipoProducto)))
            {
                if (item.ToString() == tipo)
                    return item;
            }

            return ETipoProducto.Otros;
        }

        public static void ActualizarStock(List<ProductoComprado> listaProductosComprados)
        {
            foreach (ProductoComprado pc in listaProductosComprados)
            {
                foreach (Producto p in Negocio.ListaProductos)
                {
                    if (pc.Producto.Codigo == p.Codigo)
                    {
                        p.Stock -= pc.Cantidad;
                    }
                }
            }
        }



    }
}