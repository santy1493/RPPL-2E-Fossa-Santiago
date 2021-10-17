using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        string cuil;

        public Persona(string nombre, string apellido, string cuil)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cuil = cuil;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cuil { get => cuil; set => cuil = value; }

        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {p.nombre}");
            sb.AppendLine($"Apellido: {p.apellido}");
            sb.AppendLine($"CUIL: {p.cuil}");

            return sb.ToString();
        }
    }
}


