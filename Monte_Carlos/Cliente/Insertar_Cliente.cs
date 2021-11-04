using System;
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
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        long idCliente = 0;
        bool editar = false;
        int Log=0;

        public Insertar_Cliente()
        {
            InitializeComponent();
        
        }


        private void txtInsertarCliente_Click(object sender, EventArgs e)
        {
            
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
       

            if (editar)
            {
                MessageBox.Show("Cliente modificado!");
                var tCliente = Entity.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);            
                tCliente.Nombre = txtNombre.Text;
                tCliente.Apellido = txtApellido.Text;               
                tCliente.Telefono = txtTelefono.Text;                

                Entity.SaveChanges();
            }
            else
            {
               
                MessageBox.Show("Cliente guardado!");
                Clientes tbClientes = new Clientes
                {                  
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,                 
                    Telefono = txtTelefono.Text,                  
                };
                Entity.Clientes.Add(tbClientes);

                Entity.SaveChanges();
            }
            CargaDv();
            Limpiar();
        }
        private void CargaDv()
        {
            var tClientes = from p in Entity.Clientes
                            select new
                            {
                                p.IdCliente,                                
                                p.Nombre,
                                p.Apellido,
                                p.Telefono,      
                            };
            dvClientes.DataSource = tClientes.CopyAnonymusToDataTable();
        }
        private void Limpiar()
        {          
            txtNombre.Text = "";
            txtApellido.Text = "";            
            txtTelefono.Text = "";           
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
                    var tCliente = Entity.Clientes.FirstOrDefault(x => x.IdCliente == idCliente);                    
                    txtNombre.Text = tCliente.Nombre;
                    txtApellido.Text = tCliente.Apellido;                    
                    txtTelefono.Text = tCliente.Telefono;
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

       

        private void dvClientes_MouseClick(object sender, MouseEventArgs e)
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
                MessageBox.Show("Debe haber un registro seleccionado para poder borrarlo");
            }
            else
            {
                Entity.Clientes.RemoveRange(Entity.Clientes.Where(x => x.IdCliente == idCliente));
                Entity.SaveChanges();
                Limpiar();
                CargaDv();
            }
        }

        private void btnNuevo1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
