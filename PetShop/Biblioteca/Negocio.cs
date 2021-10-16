using System.Collections.Generic;

namespace Biblioteca
{
    public static class Negocio
    {
        static Empleado empleadoLogeado;
        public static List<Empleado> listaEmpleados;
        static Dictionary<string, Cliente> listaClientes;

        static int registroLegajo = 1000;
        static int registroId = 100;

        static Negocio()
        {
            listaEmpleados = new List<Empleado>() {

            new Empleado("Teresa", "Micheli", "27223544182", "termicheli", "sandia", true),
            new Empleado("Roberto", "Molina", "20195474332", "robmolina", "banana", true),
            new Empleado("Luciano", "Herrera", "20173434425", "lucherrera", "manzana", false),
            new Empleado("Roberto", "Gamarra", "23125486225", "robgamarra", "cuchara", false),
            new Empleado("Maria", "Sanchez", "22348542215", "marsanchez", "tenedor", false)

            };
            ListaClientes = new Dictionary<string, Cliente>();

            ListaClientes.Add("20374532217", new Cliente("Mariano", "Rodriguez", "20374532217", 57813));
            ListaClientes.Add("27186565343", new Cliente("Sofia", "Gonzalez", "27186565343", 87611));
            ListaClientes.Add("22356565343", new Cliente("Jose", "Hernandez", "22356565343", 2107));
            ListaClientes.Add("23276565343", new Cliente("Antonio", "Montana", "23276565343", 321));
            ListaClientes.Add("24348565343", new Cliente("Juliana", "Awada", "24348565343", 65482));

            //listaProductos = new List<Producto>()
            //    {
            //        new Producto("dogui", "Purina", 101, 600, 15, ETipoProducto.Alimento),
            //        new Producto("hueso", "PetToy", 102, 230, 3, ETipoProducto.Juguete),
            //        new Producto("collar", "PetChain", 103, 300, 2, ETipoProducto.Correa),
            //        new Producto("shampoo", "PetShamp", 104, 250, 6, ETipoProducto.Limpieza),
            //        new Producto("pipeta", "Purina", 105, 400, 9, ETipoProducto.Medicamento),

            //    };

        }

        public static int RegistroLegajo { get => registroLegajo; set => registroLegajo = value; }
        public static int RegistroId { get => registroId; set => registroId = value; }
        public static Empleado EmpleadoLogeado { get => empleadoLogeado; set => empleadoLogeado = value; }
        // public static Dictionary<string, Empleado> ListaEmpleados { get => listaEmpleados; set => listaEmpleados = value; }
        public static Dictionary<string, Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        public static List<Empleado> ListaEmpleados { get => listaEmpleados; set => listaEmpleados = value; }
    }
}
