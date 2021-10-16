using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Direccion
    {
        string calle;
        int codPostal;

        public Direccion(string calle, int codPostal)
        {
            this.Calle = calle;
            this.CodPostal = codPostal;
        }

        public string Calle { get => calle; set => calle = value; }
        public int CodPostal { get => codPostal; set => codPostal = value; }
    }
}
