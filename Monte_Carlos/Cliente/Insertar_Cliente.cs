﻿using System;
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
    public partial class Insertar_Cliente : Form
    {
        MonteCarlo Variables = new MonteCarlo();
        long idCliente = 0;
        bool editar = false;
        int Log=0;

        public Insertar_Cliente()
        {
            InitializeComponent();
        
        }


        private void txtInsertarCliente_Click(object sender, EventArgs e)
        {
            /*String Identidad = txtIdentidad.Text;
            var TamanoIdentidad = txtIdentidad.TextLength;
            if (TamanoIdentidad < 15)
            {
                MessageBox.Show("El numero de identidad es muy corto");
               // txtIdentidad.Focus();
                return;
            }

            char guion = Convert.ToChar("-");
            char Guion1 = txtIdentidad.Text[4];
            char Guion2 = txtIdentidad.Text[9];
       if(Guion1 != guion ||  Guion2 != guion) {
                MessageBox.Show("El numero de idententidad debe llevar guiones o esta mal escrito");
             //   txtIdentidad.Focus();
                return;
            }
            */

         /*   if (txtIdentidad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el numero de identidad");
                return;
            }*/
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el nombre");
                return;
            }
            if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el Apellido");
                return;
            }
           /* if (txtEdad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar la edad");
                return;
            }
           */
            if (txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el numero telefonico");
                return;
            }
            var TamanoTelefono = txtTelefono.TextLength;
            if (TamanoTelefono < 8)
            {
                MessageBox.Show("El numero de telefono es muy corto");
                txtTelefono.Focus();
                return;
            }

            int si = 0;
            //Agregar validacion para 2
            char TigoClaro = Convert.ToChar(txtTelefono.Text[0]);
            //  MessageBox.Show(Convert.ToString(txtTelefono.Text[0]));
            if (TigoClaro == Convert.ToChar("3") || TigoClaro == Convert.ToChar("8") || TigoClaro == Convert.ToChar("9"))
            {
                si = 1;
            }
            else
            {
                if(si != 1)
                {

                    MessageBox.Show("El numero de telefono debe ser Tigo o Claro");
                    txtTelefono.Focus();
                    return;
                }
              
            }
            /*if (txtCorreo.Text != "")
            {
                int NArroba = 0;
               // var TamanoCorreo = txtCorreo.TextLength;
                for (int r=0; r < TamanoCorreo; r++) {
                  //  char Arroba = txtCorreo.Text[r];
                    if ( Arroba == Convert.ToChar("@"))
                    {
                         NArroba ++;
                    }

                }

                if(NArroba == 0)
                {
                    MessageBox.Show("El correo ingresado debe llevar @");
                  //  txtCorreo.Focus();
                    return;
                }
            }*/
       

            if (editar)
            {
                MessageBox.Show("Cliente modificado!");
                var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);
             //   tCliente.Identidad = txtIdentidad.Text;
                tCliente.Nombre = txtNombre.Text;
                tCliente.Apellido = txtApellido.Text;
               // tCliente.Edad = Convert.ToInt32(txtEdad.Text);
                tCliente.Telefono = Convert.ToInt32(txtTelefono.Text);
              //  tCliente.Correo = txtCorreo.Text;

                Variables.SaveChanges();
            }
            else
            {
              /*  var tClientee = Variables.Clientes.FirstOrDefault(x => x.Identidad == Identidad);

                if (tClientee != null)
                {
                    MessageBox.Show("El numero de identidad ya existe");
                   // txtIdentidad.Focus();
                    return;
                }*/
                MessageBox.Show("Cliente guardado!");
                Clientes tbClientes = new Clientes
                {
                  //  Identidad = txtIdentidad.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                  //  Edad = Convert.ToInt32(txtEdad.Text),
                    Telefono = Convert.ToInt32(txtTelefono.Text),
                  //  Correo = txtCorreo.Text
                };
                Variables.Clientes.Add(tbClientes);

                Variables.SaveChanges();
            }
            CargaDv();
            Limpiar();
        }
        private void CargaDv()
        {
            var tClientes = from p in Variables.Clientes
                            select new
                            {
                                p.IdCliente,
                                p.Identidad,
                                p.Nombre,
                                p.Apellido,
                                p.Edad,
                                p.Telefono,
                                p.Correo,
                            };
            dvClientes.DataSource = tClientes.CopyAnonymusToDataTable();
        }
        private void Limpiar()
        {
          //  txtIdentidad.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            //txtEdad.Text = "";
            txtTelefono.Text = "";
           // txtCorreo.Text = "";
            idCliente = 0;
            editar = false;
            dvClientes.ClearSelection();


        }

        private void Insertar_Cliente_Load(object sender, EventArgs e)
        {
            Log = 1;
            CargaDv();
            dvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Limpiar();
        }

       

        private void dvClientes_SelectionChanged(object sender, EventArgs e)
        {
          
                try
                {
                    idCliente = Convert.ToInt64(dvClientes.SelectedCells[0].Value);
                    var tCliente = Variables.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);
                    //txtIdentidad.Text = tCliente.Identidad;
                    txtNombre.Text = tCliente.Nombre;
                    txtApellido.Text = tCliente.Apellido;
                    //txtEdad.Text = Convert.ToString(tCliente.Edad);
                    txtTelefono.Text = Convert.ToString(tCliente.Telefono);
//txtCorreo.Text = tCliente.Correo;
                    editar = true;

                }
                catch (Exception)
                {
                   
                }
            
            if(Log==1)
            {
                Limpiar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dvClientes_MouseClick(object sender, MouseEventArgs e)
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
                    Variables.Clientes.RemoveRange(Variables.Clientes.Where(x => x.IdCliente == idCliente));
                    Variables.SaveChanges();
                    Limpiar();
                    CargaDv();
                          }
        }
    }
}
