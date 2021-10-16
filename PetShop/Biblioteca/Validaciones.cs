using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validaciones
    {
        public static bool ValidarEntero(string numero)
        {
            return int.TryParse(numero, out int entero);
        }

        public static bool ValidarDecimal(string numero)
        {
            return double.TryParse(numero, out double Decimal);
        }

        public static bool ValidarPalabra(string palabra)
        {
            Regex Val = new Regex(@"^[a-zA-Z]+$");

            return Val.IsMatch(palabra);
        }

        public static bool ValidarNombreApellido(string nombre, string apellido)
        {
            return (ValidarPalabra(nombre) && ValidarPalabra(apellido));
        }

        public static bool ValidarCuil(string cuil)
        {
            if(long.TryParse(cuil, out long Cuil))
            {
                if (Cuil > 1000000000 && Cuil < 99999999999)
                    return true;
            }

            return false;
        }

        //public static bool ValidarDireccion(Direccion direccion)
        //{
        //    if(direccion.CodPostal
        //}


    }
}
