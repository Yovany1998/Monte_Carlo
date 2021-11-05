using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Cliente
{
    public partial class BusquedaClientes : Form
    {
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();

        //Variables que almacenaran los datos del cliente para la reservacion
        public string nombreCliente = string.Empty;
        public int idCliente = 0;
        public string apellidoCliente = string.Empty;
        public BusquedaClientes()
        {
            InitializeComponent();
        }

        private void BusquedaClientes_Load(object sender, EventArgs e)
        {
            var tClientes = from clientes in Entity.Clientes
                           select new
                           {
                               clientes.IdCliente,
                               clientes.Nombre,
                               clientes.Apellido,
                               clientes.Telefono
                           };
            dgClientes.DataSource = tClientes.CopyAnonymusToDataTable();
            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dgClientes.CurrentCell.RowIndex;
            idCliente = Convert.ToInt32(dgClientes.Rows[indice].Cells[0].Value.ToString());
            nombreCliente = dgClientes.Rows[indice].Cells[1].Value.ToString();
            apellidoCliente = dgClientes.Rows[indice].Cells[2].Value.ToString();

            this.Close();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
