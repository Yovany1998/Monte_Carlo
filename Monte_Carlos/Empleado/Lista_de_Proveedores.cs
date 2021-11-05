using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Empleado
{
    public partial class Lista_de_Proveedores : Form
    {
        DBFincaMonteCarloEntities1 entity = new DBFincaMonteCarloEntities1();
        long idProveedor = 0;
        bool editar = false;
        public Lista_de_Proveedores()
        {
            InitializeComponent();
        }

        private void CargarDv()
        {
            var tablaProveedor = from columna in entity.Proveedor
                                 select new
                                 {
                                     columna.IdProveedor,
                                     columna.Empresa,
                                     columna.NumeroDeTelefono,
                                     columna.NombreDeContacto,
                                     columna.RTN,
                                     columna.Observacion
                                 };
            dgProveedores.DataSource = tablaProveedor.CopyAnonymusToDataTable();
            dgProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        

        private void dgProveedores_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Lista_de_Proveedores_Load(object sender, EventArgs e)
        {
            CargarDv();
            // dvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;        
            dgProveedores.ClearSelection();
        }

        private void txtBuscarProveedores_TextChanged(object sender, EventArgs e)
        {
            string Provider = txtBuscarProveedores.Text;
            var tablaProveedor = from columna in entity.Proveedor
                                 where columna.Empresa.Contains(Provider)
                                 select new
                                 {
                                     columna.IdProveedor,
                                     columna.Empresa,
                                     columna.NumeroDeTelefono,
                                     columna.NombreDeContacto,
                                     columna.RTN,
                                     columna.Observacion
                                 };
            dgProveedores.DataSource = tablaProveedor.CopyAnonymusToDataTable();
            dgProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
