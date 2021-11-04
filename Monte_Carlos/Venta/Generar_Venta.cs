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
    public partial class Generar_Venta : Form
    {
        double imp;
        private int conta = 0;
        int CodigoVenta;
        double total = 0.0;
        int log;
        int Validar = 0;
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        long idDetalleVenta = 0;
        string nombre = "";
        bool editar = false;
        bool ValidarCliente = false;
        double impuesto = 0.0;
        double TotImpuesto = 0.0;
        double TotSubtotal = 0.0;
        double Subtotal = 0.0;
        DataTable dtVentas = new DataTable();

        public Generar_Venta()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        

        private void DvDetalle()
        {

           

        }

        
        

       
        public DateTime FechaActual
        {
            get { return DateTime.Today; ; }
            set { this.FechaActual = value; }
        }

       
        
       


       

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }

        private void icoBuscarComidaObebida_Click(object sender, EventArgs e)
        {

        }
    }
}
