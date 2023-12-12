using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_de_Ventas
{
    internal abstract class Persona
    {
        private string nombre;
        private int edad;
        private int id;

        public Persona(string n, int a, int i) { }

        public abstract string Name { 
            get;
            set;
        }
        public abstract int Age { 
            get;
            set;
        }
        public abstract int Id
        {
            get;
            set;
        }
    }
}
