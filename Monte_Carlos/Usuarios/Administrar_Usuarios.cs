using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Usuarios
{
    public partial class Administrar_Usuarios : Form
    {
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        long idUsuario = 0;
        bool editar = false;
        public Administrar_Usuarios()
        {
            InitializeComponent();
        }

        private void CargarDv()
        {
            var tUsuario = from p in Entity.Usuario
                            select new
                            {
                                p.IdUsuario,
                                p.IdEmpleado,
                                p.UserName,
                                p.Password
                            };

            dgUsuarios.DataSource = tUsuario.CopyAnonymusToDataTable();
        }

        private void Administrar_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDv();
            // dvEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;        
            dgUsuarios.ClearSelection();
        }

        private void txtBuscarUsuarios_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnBorrarUsusario_Click(object sender, EventArgs e)
        {
         
            if (editar == false)
            {
                MessageBox.Show("SELECCIONE EL REGISTRO PARA PODER BORRARLO");
            }
            else
            {
                MessageBox.Show("SE ELIMINO EL USUSARIO Y TODAS SUS REFERENCIAS");
                Entity.Usuario.RemoveRange(Entity.Usuario.Where(x => x.IdUsuario == idUsuario));
                Entity.SaveChanges();
                CargarDv();
            }
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idUsuario = Convert.ToInt64(dgUsuarios.SelectedCells[0].Value);
                editar = true;
            }
            catch (Exception)
            {
                dgUsuarios.ClearSelection();
                editar = false;
            }
        }

        private void dgUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                idUsuario = Convert.ToInt64(dgUsuarios.SelectedCells[0].Value);
                editar = true;
            }
            catch (Exception)
            {
                editar = false;
            }
        }
    }
}
