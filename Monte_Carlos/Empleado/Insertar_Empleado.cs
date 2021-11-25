﻿using System;
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
        }
        private void Insertar_Empleado_Load(object sender, EventArgs e)
        {
            editar = false;
            Log = 1;
            CargarDv();
           // dvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;        
            dvEmpleado.ClearSelection();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
           
        }

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
        private void dvEmpleado_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                idEmpleado = Convert.ToInt64(dvEmpleado.SelectedCells[0].Value);
                var tEmpleado = Entity.Empleados.FirstOrDefault(x => x.IdEmpleado == idEmpleado);
                txtNombre.Text = tEmpleado.Nombre;
                txtApellido.Text = tEmpleado.Apellido;

                editar = true;
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
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btninsertar_Click_1(object sender, EventArgs e)
        {           

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
            DateTime FechaNacimiento = Convert.ToDateTime(Nacimiento.Value.ToString("yyyy/MM/dd 00:00:00"));
            DateTime FechaIngreso = Convert.ToDateTime(Ingreso.Value.ToString("yyyy/MM/dd 00:00:00"));
           
            if (CmbCargo.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Asigne un cargo al empleado");
                return;
            }

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
          
            CargarDv();
            Limpiar();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            dvEmpleado.ClearSelection();
            Limpiar();
        }

        private void dvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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

        private void dvEmpleado_MouseClick_1(object sender, MouseEventArgs e)
        {

            if (Log == 1)
            {
                Log = 2;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dvEmpleado_MouseMove(object sender, MouseEventArgs e)
        {

            if (Log == 1)
            {
                Log = 2;
            }
        }
    }
}
