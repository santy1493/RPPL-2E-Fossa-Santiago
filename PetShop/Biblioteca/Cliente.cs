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
    }
}
