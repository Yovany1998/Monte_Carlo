using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Reservaciones
{
    public partial class Insertar_Reservaciones : Form
    {

        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();

        //Variables que almacenaran los datos del cliente para la reservacion
        public string nombreCliente = string.Empty;
        public int idCliente = 0;


        public Insertar_Reservaciones()
        {
            InitializeComponent();
                 
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {

        
        }
     

        private void Insertar_Reservaciones_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
           

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void dvReservacion_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dvRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            

        }

        private void dvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
       
        }

        private void dvReservacion_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void btnLimpiarPedido_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarReservacion_Click(object sender, EventArgs e)
        {
            try
            {
                Reservacion tReservacion = new Reservacion();

                tReservacion.IdCliente = idCliente;
                tReservacion.Fecha = Fecha.Value;
                tReservacion.Mesa = Convert.ToInt32(txtMesa.Text);

                Entity.Reservacion.Add(tReservacion);

                Entity.SaveChanges();
                MessageBox.Show("Reservacion registrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            CargarTabla();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Cliente.BusquedaClientes Cliente = new Cliente.BusquedaClientes();
            Cliente.ShowDialog();
            EstablecerDatos(Cliente.nombreCliente, Cliente.idCliente);
        }

        private void EstablecerDatos(string nombre, int id)
        {
            if (id > 0)
            {
                nombreCliente = nombre;
                idCliente = id;
                txtNombreCompleto.Text = nombreCliente;
            }
            else
            {
                MessageBox.Show("No selecciono ningun cliente");
            }
        }

        private void CargarTabla()
        {
            var tReservaciones = from Reservacion in Entity.Reservacion
                                 join Cliente in Entity.Clientes
                                 on Reservacion.IdCliente equals Cliente.IdCliente
                                 select new
                                 {
                                     Reservacion.IdReservacion,
                                     Cliente.Nombre,
                                     Cliente.Apellido,
                                     Reservacion.Fecha,
                                     Reservacion.Mesa
                                 };

            dgListaReservaciones.DataSource = tReservaciones.CopyAnonymusToDataTable();
            dgListaReservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
