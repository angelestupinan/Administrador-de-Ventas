using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Administrador_de_Ventas
{
    internal class Ticket
    {
        private Venta venta;

        public Ticket(Venta v)
        {
            this.venta = v;
        }

        public Venta Venta
        {
            get { return venta; }
            set { venta = value; }
        }

        public void GuardarTicket()
        {
            Venta v = venta;

            string nombre = v.Cliente.Name;
            string edad = v.Cliente.Age.ToString();
            string id = v.Cliente.Id.ToString();
            string idCliente = v.Cliente.IdCliente.ToString();

            string dia = v.Fecha.Day.ToString();
            string mes = v.Fecha.Month.ToString();
            string anio = v.Fecha.Year.ToString();

            string total = v.Total.ToString();
            string codigoVenta = v.CodigoVenta.ToString();

            string path = @$"TICKET{codigoVenta}.txt";
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Datos del Cliente:");
                sw.WriteLine("Nombre: " + nombre);
                sw.WriteLine("Edad: " + edad);
                sw.WriteLine("Id: " + id);
                sw.WriteLine("ID del Cliente: " + idCliente);
                sw.WriteLine("-------------------------------");
                sw.WriteLine("Fecha:");
                sw.WriteLine("(dd/mm/yyyy)  " + dia + "/" + mes + "/" + anio);
                sw.WriteLine("-------------------------------");
                sw.WriteLine("Total:");
                sw.WriteLine(total);
                sw.WriteLine("-------------------------------");
                sw.WriteLine("Codigo de la venta: " + codigoVenta);
                sw.WriteLine("Gracias Por Visitarnos");
            }
        }
    }
}
