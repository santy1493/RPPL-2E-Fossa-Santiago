using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        int legajo;
        string usuario;
        string contrasenia;
        bool esAdmin;

        public Empleado(string nombre, string apellido, string cuil, string usuario, string contrasenia)
            :base(nombre,apellido,cuil)
        {
            this.Legajo = Negocio.RegistroLegajo + 1;
            Negocio.RegistroLegajo = this.legajo;
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
            this.EsAdmin = false;
        }

        public Empleado(string nombre, string apellido, string cuil, string usuario, string contrasenia, bool esAdmin)
            :this(nombre, apellido, cuil, usuario, contrasenia)
        {
            this.esAdmin = esAdmin;
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }


        public static bool CargarEmpleado(string nombre, string apellido, string cuil, string usuario, string contrasenia)
        {
            if (Validaciones.ValidarNombreApellido(nombre, apellido) && Validaciones.ValidarCuil(cuil))
            {
                Empleado nuevoEmpleado = new Empleado(nombre, apellido, cuil, usuario, contrasenia);

                Negocio.ListaEmpleados.Add(nuevoEmpleado);

                return true;
            }

            return false;

        }

        public static Empleado BuscarPorLegajo(int legajo)
        {
            foreach(Empleado e in Negocio.ListaEmpleados)
            {
                if(e.legajo == legajo)
                {
                    return e;
                }
            }

            return null;
        }

        public static bool BajaEmpleado(Empleado empleado)
        {
            if(!(empleado is null))
            {
                return Negocio.ListaEmpleados.Remove(empleado);
            }

            return false;
        }

        public bool ModificarEmpleado(string nombre, string apellido, string cuil, string usuario, string contrasenia)
        {
            if (Validaciones.ValidarNombreApellido(nombre, apellido) && Validaciones.ValidarCuil(cuil))
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Cuil = cuil;
                this.Usuario = usuario;
                this.contrasenia = contrasenia;

                return true;
            }

            return false;

        }

        public static Empleado BuscarEmpleadoPorUser(string user, string pass)
        {

            if(ValidarUserPass(user, pass))
            {
                foreach (Empleado e in Negocio.ListaEmpleados)
                {
                    if (e.usuario == user)
                    {
                        return e;
                    }
                }
            }
            else
            {
                throw new UsuarioInvalidoExeption();
            }

            

            return null;
        }

        public static bool ValidarUserPass(string user, string pass)
        {

            foreach (Empleado e in Negocio.ListaEmpleados)
            {
                if (e.usuario == user && e.contrasenia == pass)
                {
                    return true;
                }
            }

            return false;
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Usuario: {this.Usuario}");

            return sb.ToString();
        }


        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return (e1.Cuil == e2.Cuil);
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

    }
}
