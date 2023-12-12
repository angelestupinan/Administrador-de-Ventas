namespace Administrador_de_Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListaVentas list = new ListaVentas();

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = nombreG.Text;
            int age = int.Parse(edadG.Text);
            int id = int.Parse(idG.Text);
            int codigoCl = int.Parse(codigoClienteG.Text);
            double total = double.Parse(totalG.Text);
            string codigoVenta = codigoG.Text.ToUpper();

            int d, m, y;
            DateTime dt = DateTime.Today;
            d = dt.Day;
            m = dt.Month;
            y = dt.Year;

            Venta v = new Venta(new Cliente(nombre, age, id, codigoCl), new Fecha(d, m, y), total, codigoVenta);

            list.AgregarVenta(v);

            Ticket tc = new Ticket(v);
            tc.GuardarTicket();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Venta v = list.GetVenta(codVentC.Text.ToUpper());
            if (v != null )
            {
                nombreC.Text = v.Cliente.Name;
                edadC.Text = v.Cliente.Age.ToString();
                idC.Text = v.Cliente.Id.ToString();
                idCliC.Text = v.Cliente.IdCliente.ToString();
                totalC.Text = v.Total.ToString();
                dateC.Text = v.Fecha.Day + "/" + v.Fecha.Month + "/" + v.Fecha.Year;
            }

        }
    }
}
