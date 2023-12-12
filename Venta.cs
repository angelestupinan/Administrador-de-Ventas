using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_de_Ventas
{
    internal class Venta
    {
        private Cliente client;
        private Fecha fecha;
        private double total;
        private string codigoVenta;

        public Venta(Cliente c, Fecha f, double t, string cv)
        {
            this.client = c;
            this.fecha = f;
            this.total = t;
            this.codigoVenta = cv;
        }

        public Cliente Cliente
        {
            get { return client; } 
            set { client = value; }
        }
        public Fecha Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public string CodigoVenta
        {
            get { return codigoVenta; }
            set { codigoVenta = value; }
        }
    }
}
