using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Venta
{
    public partial class Facturación : Form
    {
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        public Facturación()
        {
            InitializeComponent();
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(lblCodigoVenta.Text);
            var tbFactura = Entity.Facturas.FirstOrDefault(x => x.IdFactura == codigo);
            tbFactura.Estado = 1;
            Entity.SaveChanges();
            MessageBox.Show("¡Venta generada correctamente!");
            
            this.Dispose();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Facturación_Load(object sender, EventArgs e)
        {
            
            lblCodigoVenta.Text = Ventas_En_Espera.codigoVenta.ToString();
            int codigo = Convert.ToInt32(lblCodigoVenta.Text);
            var cliente = Entity.DetalleDeFactura.FirstOrDefault(x => x.IdFactura == codigo);
            string nombreCompleto = cliente.Facturas.Clientes.Nombre.ToString() + " " + cliente.Facturas.Clientes.Apellido.ToString();
            lblCliente.Text = nombreCompleto;

            var tFactura = from Detalle in Entity.DetalleDeFactura
                           join Facturas in Entity.Facturas
                           on Detalle.IdFactura equals Facturas.IdFactura
                           join Menu in Entity.Menu
                           on Detalle.IdMenu equals Menu.IdMenu
                           join Clientes in Entity.Clientes
                           on Facturas.IdCliente equals Clientes.IdCliente
                           where Facturas.Estado == 0
                           where Facturas.IdFactura == codigo
                           select new
                           {
                               Producto = Menu.Nombre,
                               Cantidad = Detalle.Cantidad,
                               Precio = Menu.Precio,
                               Total = Detalle.Cantidad * Menu.Precio
                           };
           
            dgListadeProductos.DataSource = tFactura.CopyAnonymusToDataTable();
            dgListadeProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            calculos();

         
        }

        public void calculos()
        {
            int cantidadProductos = dgListadeProductos.Rows.Count;
            decimal isv;
            decimal subTotal;            
            decimal total;


            if (cantidadProductos > 0)
            {
                subTotal = 0;
                for (int i = 0; i <= cantidadProductos - 2; i++)
                {
                    subTotal = subTotal + Convert.ToDecimal(dgListadeProductos.Rows[i].Cells[3].Value.ToString());
                }
                isv = decimal.Round(decimal.Multiply(subTotal, Convert.ToDecimal(0.12)), 2);
                total = subTotal + isv;

                lblISV.Text = isv.ToString();
                lblSubtotal.Text = subTotal.ToString();
                lblTotal.Text = total.ToString();
            }

        }
    }
}
