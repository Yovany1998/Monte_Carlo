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
    public partial class Ventas_En_Espera : Form
    {
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        internal static int codigoVenta;
        public Ventas_En_Espera()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_En_Espera_Load(object sender, EventArgs e)
        {
            CambiarFactura();
        }
        private void CambiarFactura()
        {
            var tFacturas = from Factura in Entity.Facturas
                            join Detalle in Entity.DetalleDeFactura
                            on Factura.IdFactura equals Detalle.IdFactura
                            join Menu in Entity.Menu
                            on Detalle.IdMenu equals Menu.IdMenu
                            join Cliente in Entity.Clientes
                            on Factura.IdCliente equals Cliente.IdCliente
                            where Factura.Estado == false
                            group Factura by new { Factura.IdFactura, Cliente.Nombre, Cliente.Apellido } into t
                            select new { ID = t.Key.IdFactura, Cliente = t.Key.Nombre + " " + t.Key.Apellido };
            dvVentaEspera.DataSource = tFacturas.CopyAnonymusToDataTable();
            dvVentaEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreCliente = textBox1.Text;

            var tFacturas = from Factura in Entity.Facturas
                            join Detalle in Entity.DetalleDeFactura
                            on Factura.IdFactura equals Detalle.IdFactura
                            join Menu in Entity.Menu
                            on Detalle.IdMenu equals Menu.IdMenu
                            join Cliente in Entity.Clientes
                            on Factura.IdCliente equals Cliente.IdCliente
                            where Factura.Estado == false
                            where (Cliente.Nombre + " " + Cliente.Apellido).Contains(nombreCliente)
                            group Factura by new { Factura.IdFactura, Cliente.Nombre, Cliente.Apellido } into t
                            select new { ID = t.Key.IdFactura, Cliente = t.Key.Nombre + " " + t.Key.Apellido };
            dvVentaEspera.DataSource = tFacturas.CopyAnonymusToDataTable();
            dvVentaEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dvVentaEspera_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dvVentaEspera.CurrentCell.RowIndex;
            codigoVenta = Convert.ToInt32(dvVentaEspera.Rows[indice].Cells[0].Value.ToString());
            Facturación factura = new Facturación();
            factura.ShowDialog();
        }
    }
}
