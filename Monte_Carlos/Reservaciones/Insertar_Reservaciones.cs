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
        long idReservacion = 0;
        bool editar = false;
        int Log;


        public Insertar_Reservaciones()
        {
            InitializeComponent();
                 
        }


       private void Limpiar()
        {
            txtNombreCompleto.Text = "";
            txtMesa.Text = "";
            dgListaReservaciones.ClearSelection();

        } 

        private void Insertar_Reservaciones_Load(object sender, EventArgs e)
        {
            CargarTabla();
            Log = 1;
            Limpiar();

        }

        private void dvRegistro_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAgregarReservacion_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                var tReservacion = Entity.Reservacion.FirstOrDefault(x => x.IdReservacion == idReservacion);
                tReservacion.Fecha= Fecha.Value;
                tReservacion.Mesa = Convert.ToInt32(txtMesa.Text);
                Entity.SaveChanges();
                MessageBox.Show("Reservación modifiada");
            }
            else
            {
                Reservacion tReservacion = new Reservacion();

                tReservacion.IdCliente = idCliente;
                tReservacion.Fecha = Fecha.Value;
                tReservacion.Mesa = Convert.ToInt32(txtMesa.Text);

                Entity.Reservacion.Add(tReservacion);
                Entity.SaveChanges();
                MessageBox.Show("Reservacion registrada");
            }
            Limpiar();
            editar = false;
            idCliente = 0;
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

        private void dgListaReservaciones_MouseMove(object sender, MouseEventArgs e)
        {
            if (Log == 1)
            {
                Log = 2;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgListaReservaciones_SelectionChanged(object sender, EventArgs e)
        {
           
                if (Log == 1)
                {
                    dgListaReservaciones.ClearSelection();
                    Limpiar();
                }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            int idReservacion = 0;
            if (dgListaReservaciones.SelectedRows.Count > 0)
            {
                indice = dgListaReservaciones.CurrentCell.RowIndex;
                idReservacion = Convert.ToInt32(dgListaReservaciones.Rows[indice].Cells[0].Value.ToString());
                Entity.Reservacion.RemoveRange(Entity.Reservacion.Where(x => x.IdReservacion == idReservacion));
                Entity.SaveChanges();
                CargarTabla();
                MessageBox.Show("Se ha eliminado correctamente la reservacion");
            }
            else
            {
                MessageBox.Show("No se puede eliminar ningun elemento");
            }
        }

        private void dgListaReservaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar = true;
            int indice = 0;
            indice = dgListaReservaciones.CurrentCell.RowIndex;
            idReservacion = Convert.ToInt32(dgListaReservaciones.Rows[indice].Cells[0].Value.ToString());
            txtNombreCompleto.Text = dgListaReservaciones.Rows[indice].Cells[1].Value.ToString();
            txtMesa.Text = dgListaReservaciones.Rows[indice].Cells[4].Value.ToString();
        }
    }
}
