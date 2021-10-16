using System;

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

        //protected static bool ValidarDatosPersona(string nombre, string apellido, string cuil, Direccion direccion)
        //{
        //    if()
        //}
    }
}


