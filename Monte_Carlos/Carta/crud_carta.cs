using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Carta
{
    public partial class Ingreso_Carta : Form
    {
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        long idMenu = 0;
        bool editar = false;
        int log;

        public Ingreso_Carta()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el Nombre");
                return;
            }
            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el precio");
                return;
            }

            if (Convert.ToInt32(txtPrecio.Text) <= 0)
            {
                MessageBox.Show("El precio no puede ser menor o igual a 0");
                return;
            }
            if (cmbTipo.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Asignar un tipo de comida");
                return;
            }

            if (editar)
            {
                MessageBox.Show("Menu modificado!");
                var tMenu = Entity.Menu.FirstOrDefault(x => x.IdMenu == idMenu);
                tMenu.Nombre =txtNombre.Text;
                //tMenu.Precio = Convert.ToDouble(txtPrecio.Text);
                tMenu.Tipo = cmbTipo.SelectedItem.ToString();
                Entity.SaveChanges();
            }
            else
            {

                MessageBox.Show("Menu guardado!");
                Menu tbMenu = new Menu
                {
                    Nombre = Convert.ToString(txtNombre.Text),
                    //Precio = Convert.ToDouble(txtPrecio.Text),
                    Tipo = Convert.ToString(cmbTipo.SelectedItem.ToString())
                };
                Entity.Menu.Add(tbMenu);
                Entity.SaveChanges();
            }
            
            Limpiar();
            editar = false;
            idMenu = 0;

            CargaDv();

            Limpiar();
            
        }
    
        private void CargaDv()
        {
            var tbComidaBebida = from p in Entity.Menu
                                 select new
                                 {
                                     p.IdMenu,
                                     p.Nombre,
                                     p.Precio,
                                     p.Tipo,

                                 };
            dvComida.DataSource = tbComidaBebida.CopyAnonymusToDataTable();
        }

    
    
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            cmbTipo.SelectedIndex = cmbTipo.SelectedIndex = cmbTipo.SelectedIndex = -1;
            dvComida.ClearSelection();
        }
    
        private void Ingreso_Comida_Load(object sender, EventArgs e)
        {
            CargaDv();
            dvComida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idMenu = 0;
            Limpiar();
            editar = false;
            log = 1;
        }
        private void dvComida_SelectionChanged(object sender, EventArgs e)
        {

                try
                {
                    /*idComidaBebida = Convert.ToInt64(dvComida.SelectedCells[0].Value);
                    var tComidaBebida = Variables.Menu.FirstOrDefault(x => x.IdComidaBebida == idComidaBebida);
                    txtNombre.Text = tComidaBebida.Nombre;
                    txtPrecio.Text = Convert.ToString(tComidaBebida.Precio);
                    cmbTipo.Text = Convert.ToString(tComidaBebida.Tipo);
                    editar = true;*/
                }
                catch (Exception)
                {
                editar = false;
            }
            if (log == 1)
            {
                Limpiar();
            }
        
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dvComida_MouseClick(object sender, MouseEventArgs e)
        {
            if (log == 1)
            {
                log = 2;
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
               /* Variables.Menu.RemoveRange(Variables.Menu.Where(x => x.IdComidaBebida == idComidaBebida));
                Variables.SaveChanges();
                Limpiar();
                CargaDv();*/
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
