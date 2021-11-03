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
    public partial class Insertar_Empleado : Form
    {
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        long idEmpleado = 0;
        bool editar = false;
        int Log;
        public Insertar_Empleado()
        {
            InitializeComponent();
           
        }
        private void CargarDv()
        {
            /*var tEmpleado = from p in Variables.Empleados
                            select new
                            {
                                p.IdEmpleado,
                                p.NIdentidad,
                                p.Nombre,
                                p.Apellidos,
                                p.Edad,
                                p.Cargo,
                                p.FechaIngreso
                            };

            dvEmpleado.DataSource = tEmpleado.CopyAnonymusToDataTable();*/
        }
        private void Insertar_Empleado_Load(object sender, EventArgs e)
        {
            //CargarDv();
            //dvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //idEmpleado = 0;
            //Limpiar();
            //editar = false;
            //Log = 1;
            //dvEmpleado.ClearSelection();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
           
        }

        private void Limpiar()
        {
            //dvEmpleado.ClearSelection();
       
            txtNombre.Text = "";
            txtApellido.Text = "";
           
            editar = false;

        }
        private void dvEmpleado_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                /*idEmpleado = Convert.ToInt64(dvEmpleado.SelectedCells[0].Value);
                var tEmpleado = Variables.Empleados.FirstOrDefault(x => x.IdEmpleado == idEmpleado);
          
                txtNombre.Text = tEmpleado.Nombre;
                txtApellido.Text = tEmpleado.Apellidos;
               
                editar = true;*/
            }
            catch (Exception)
            {
                //dvEmpleado.ClearSelection();
                editar = false;
            }

            if (Log == 1)
            {
                //dvEmpleado.ClearSelection();
                Limpiar();
            }
        }

        private void dvEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            if (Log == 1)
            {
                Log = 2;
            }
        }

        private void btnElimicar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                MessageBox.Show("Debe haber un registro seleccionado para poder borrarlo");
            }
            else
            {              
                    /*Variables.Empleados.RemoveRange(Variables.Empleados.Where(x => x.IdEmpleado == idEmpleado));
                    Variables.SaveChanges();
                    Limpiar();
                    CargarDv();*/
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
