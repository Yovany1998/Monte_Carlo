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
    public partial class CantidadProducto : Form
    {
        public int cantidad;
        public CantidadProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una cantiadad");

            }
            else
            {
                cantidad = Convert.ToInt32(txtCantidad.Text);
                this.Close();
            }
        }
    }
}
