using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        int id;
        double saldo;

        public Cliente(string nombre, string apellido, string cuil)
            :base(nombre,apellido,cuil)
        {
            this.Id = Negocio.RegistroId + 1;
            Negocio.RegistroId = this.Id;
            this.Saldo = 0;
        }

        public Cliente(string nombre, string apellido, string cuil, double saldo)
            :this(nombre,apellido,cuil)
        {
            this.saldo = saldo;
        }

        public int Id { get => id; set => id = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public static bool CargarCliente(string nombre, string apellido, string cuil, string saldo)
        {
            if (ValidarDatosCliente(nombre, apellido, cuil, saldo))
            {
                Negocio.ListaClientes.Add(cuil, new Cliente(nombre, apellido, cuil, double.Parse(saldo)));

                return true;
            }

            return false;

        }

        public static Cliente BuscarCliente(string cuil)
        {
            Cliente cliente;

            if(Negocio.ListaClientes.TryGetValue(cuil, out cliente))
            {
                return cliente;
            }

            return null;
        }

        public bool ModificarCliente(string nombre, string apellido, string cuil, string saldo)
        {
            
            if (ValidarDatosCliente(nombre, apellido, cuil, saldo))
            {
                string keyAntigua = this.Cuil;

                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Cuil = cuil;
                this.Saldo = double.Parse(saldo);

                Negocio.ListaClientes.Remove(keyAntigua);
                Negocio.ListaClientes.Add(this.Cuil, this);
                


                return true;
            }

            return false;

        }

        private static bool ValidarDatosCliente(string nombre, string apellido, string cuil, string saldo)
        {
            if (Validaciones.ValidarNombreApellido(nombre, apellido) && Validaciones.ValidarCuil(cuil) && Validaciones.ValidarDecimal(saldo))
            {
                return true;
            }

            return false;
        }


        public bool BajaCliente()
        {
            if (!(this is null))
            {
                return Negocio.ListaClientes.Remove(this.Cuil);
            }

            return false;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID Cliente: {this.id}");
            sb.Append(base.Mostrar());
            sb.Append($"Saldo: ${this.saldo}");

            return sb.ToString();
        }
    }
}
