using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_de_Ventas
{
    internal class Cliente : Persona, IPersona
    {
        private string nombre;
        private int edad;
        private int id;
        private int idCliente;

        public Cliente(string n, int a, int i, int ic) 
            : base(n, a, i)
        {
            this.nombre = n;
            this.edad = a;
            this.id = i;
            this.idCliente = ic;
        }

        public override string Name
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public override int Age
        {
            get { return edad; }
            set {  edad = value; }
        }
        public override int Id
        {
            get { return id; }
            set {  id = value; }
        }
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
    }
}
