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
        //Se llamo a la base de datos DBFincaMonteCarlosEntities1
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        //Declaramos las variables que necesitaremos
        long idEmpleado = 0;
        bool editar = false;
        int Log;
        //En el public Insertar_Empleado inicializamos el componente
        public Insertar_Empleado()
        {
            InitializeComponent();
           
        }
        //Se creo la función CargarDv para llenar el DataGridView
        private void CargarDv()
        {
            var tEmpleado = from p in Entity.Empleados
                            select new
                            {
                                p.IdEmpleado,                               
                                p.Nombre,
                                p.Apellido,
                                p.FechaDeNacimiento,
                                p.Cargo,
                                p.FechaDeIngreso
                            };

            dvEmpleado.DataSource = tEmpleado.CopyAnonymusToDataTable();
            dvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        //Los función que se ejecuta al entrar ala ventana de clientes 
        private void Insertar_Empleado_Load(object sender, EventArgs e)
        {
            editar = false;
            Log = 1;
            CargarDv();     
            dvEmpleado.ClearSelection();
        }

        //Se creo una funcion que limpie los datos del formulario  y la selección del DataGridView
        private void Limpiar()
        {
            dvEmpleado.ClearSelection();       
            txtNombre.Text = "";
            txtApellido.Text = "";
            Ingreso.Value = DateTime.Today;
            Nacimiento.Value = DateTime.Today;
            CmbCargo.SelectedIndex = CmbCargo.SelectedIndex = CmbCargo.SelectedIndex = -1;
            editar = false;

        }
  
        //Evita que Incie el formulario con una selección al inicio
        private void dvEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            if (Log == 1)
            {
                Log = 2;
            }
        }
      
 
        //Boton de insertar empleado este tiene doble funcionalidad de guardar y eliminar
        private void btninsertar_Click_1(object sender, EventArgs e)
        {           
            //Validamos los campos
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                txtNombre.Focus();
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingrese el apellido");
                txtApellido.Focus();
                return;
            }
            //Convertimos la fecha tomada en el formato de la base de datos
            DateTime FechaNacimiento = Convert.ToDateTime(Nacimiento.Value.ToString("yyyy/MM/dd 00:00:00"));
            DateTime FechaIngreso = Convert.ToDateTime(Ingreso.Value.ToString("yyyy/MM/dd 00:00:00"));
           
            if (CmbCargo.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Asigne un cargo al empleado");
                return;
            }
            //Editar edita los campos modificados se convierte en veradera la condicion en el SelecciónChange
            if (editar)
            {
                MessageBox.Show("Empleado modificado");
                var tEmpleado = Entity.Empleados.FirstOrDefault(x => x.IdEmpleado == idEmpleado);
                tEmpleado.Nombre = txtNombre.Text;
                tEmpleado.Apellido = txtApellido.Text;
                tEmpleado.Cargo = CmbCargo.SelectedItem.ToString();
                tEmpleado.FechaDeIngreso = FechaIngreso;
                tEmpleado.FechaDeNacimiento = FechaNacimiento;
                Entity.SaveChanges();
            }
            //Guarda los el empleado agregado
            else
            {
                MessageBox.Show("Empleado guardado");
                Empleados tbEmpleado = new Empleados
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaDeNacimiento = FechaNacimiento,
                    FechaDeIngreso = FechaIngreso,
                    Cargo = CmbCargo.SelectedItem.ToString()
                };
                Entity.Empleados.Add(tbEmpleado);
                Entity.SaveChanges();
            }
            //se actualiza el DataGridView y se limpian los campos y variables
            CargarDv();
            Limpiar();
        }
        //Este botón solo ejecuta limpiar para incializa los componentes asu estado de inicio
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        //Se ejecuta cada vez que hacemos una selección en el DataGridView
        private void dvEmpleado_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Log == 1)
                {
                    dvEmpleado.ClearSelection();
                    Limpiar();
                }

                idEmpleado = Convert.ToInt64(dvEmpleado.SelectedCells[0].Value);
                var tEmpleado = Entity.Empleados.FirstOrDefault(x => x.IdEmpleado == idEmpleado);
                txtNombre.Text = tEmpleado.Nombre;
                txtApellido.Text = tEmpleado.Apellido;
                CmbCargo.Text = Convert.ToString(tEmpleado.Cargo);
                Ingreso.Value = tEmpleado.FechaDeIngreso;
                Nacimiento.Value = tEmpleado.FechaDeNacimiento;
                editar = true;
            }
            catch (Exception)
            {
                dvEmpleado.ClearSelection();
                editar = false;
            }        
        }
        //Evita que Incie el formulario con una selección al inicio
        private void dvEmpleado_MouseClick_1(object sender, MouseEventArgs e)
        {

            if (Log == 1)
            {
                Log = 2;
            }
        }
        //Elimina el cliente seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
          //Verificamos que alla algun empleado seleccionado para eliminarlo
            if (editar == false)
            {
                MessageBox.Show("Seleccione un registro para poder borrarlo");
            }
            else
            {
                MessageBox.Show("Se elimino el empleado y todas sus dependencias");
                Entity.Empleados.RemoveRange(Entity.Empleados.Where(x => x.IdEmpleado == idEmpleado));
                Entity.Usuario.RemoveRange(Entity.Usuario.Where(x => x.IdEmpleado == idEmpleado));
                Entity.SaveChanges();
                Limpiar();
                CargarDv();
            }
        }

        //Evita que Incie el formulario con una selección al inicio
        private void dvEmpleado_MouseMove(object sender, MouseEventArgs e)
        {

            if (Log == 1)
            {
                Log = 2;
            }
        }
    }
}
