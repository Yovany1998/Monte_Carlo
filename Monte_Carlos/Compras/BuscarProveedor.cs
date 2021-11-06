using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Compras
{
    public partial class BuscarProveedor : Form
    {

        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();

        //Variables que almacenaran los datos del cliente para la reservacion
        public string nombreProveedor = string.Empty;
        public int idProveedor = 0;
        public string nombreContacto = string.Empty;
        public BuscarProveedor()
        {
            InitializeComponent();
        }

        private void BuscarProveedor_Load(object sender, EventArgs e)
        {
            var tProveedores = from Proveedor in Entity.Proveedor
                            select new
                            {
                                Proveedor.IdProveedor,
                                Proveedor.Empresa,
                                Proveedor.NumeroDeTelefono,
                                Proveedor.NombreDeContacto,
                                Proveedor.RTN
                            };
            dvProveedores.DataSource = tProveedores.CopyAnonymusToDataTable();
            dvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dvProveedores.CurrentCell.RowIndex;
            idProveedor = Convert.ToInt32(dvProveedores.Rows[indice].Cells[0].Value.ToString());
            nombreProveedor = dvProveedores.Rows[indice].Cells[1].Value.ToString();
            nombreContacto = dvProveedores.Rows[indice].Cells[2].Value.ToString();

            this.Close();
        }
    }
}
