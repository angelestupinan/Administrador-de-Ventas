using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_de_Ventas
{
    internal class ListaVentas
    {
        private List<Venta> ventas;

        public ListaVentas()
        {
            ventas = new List<Venta>();
        }

        public List<Venta> Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }

        public void AgregarVenta(Venta v)
        {
            bool confirmation = false;

            if(ventas.Count > 0)
            {
                for(int i = 0; i < ventas.Count; i++)
                {
                    if (v != null && v.CodigoVenta != ventas[i].CodigoVenta) 
                    {
                        ventas.Add(v);
                        confirmation = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una venta con ese código");
                        break;
                    }
                }
            }
            else
            {
                ventas.Add(v);
                confirmation = true;
            }

            if(confirmation)
            {
                MessageBox.Show("Guardado Corectamente");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        public Venta GetVenta(string c)
        {
            bool check = false;
            Venta v = null;
            for(int i = 0;i < ventas.Count(); i++)
            {
                if(c == ventas[i].CodigoVenta)
                {
                    v = ventas[i];
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("No se encuentra la venta");
            }
            return v;
        }
    }
}
