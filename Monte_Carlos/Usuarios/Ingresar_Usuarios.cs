using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Monte_Carlos.Usuarios
{
    public partial class Ingresar_Usuarios : Form
    {

        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        public long enviar;
        long idUsuario = 0;
        bool editar = false;
        int login = 0;

        public Ingresar_Usuarios()
        {
            InitializeComponent();
        }

        public class Hash
        {
            public static string obtenerHash256(string text)
            {

                byte[] bytes = Encoding.Unicode.GetBytes(text);
                SHA256Managed hashString = new SHA256Managed();
                byte[] hash = hashString.ComputeHash(bytes);
                string hashStr = string.Empty;
                foreach (byte x in hash)
                {
                    hashStr += String.Format("{0:x2}", x);
                }
                return hashStr;
            }
        }
        private void Limpiar()
        {
            //dvEmpleado.ClearSelection();

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtRepetirContrasena.Text = "";


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
            dgUsuarios.ClearSelection();
        }


        private void Ingresar_Usuarios_Load(object sender, EventArgs e)
        {
            /*var Id = 0;
            lblIdUser.Text = Administrar_Usuarios.idUser.ToString();
            Id = Convert.ToInt32(lblIdUser.Text);
            var TUser = Entity.Usuario.FirstOrDefault(x => x.IdUsuario == Id);
            txtUsername.Text = TUser.UserName;*/
          
            CargarDv();
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            idUsuario = 0;
            login = 1;
            editar = false;
            dgUsuarios.ClearSelection();
            Limpiar();
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el Nombre");
                return;
            }
            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese la contraseñá");
                return;
            }
            if (txtRepetirContrasena.Text != txtPassword.Text)
            {
                MessageBox.Show("La contraseñá no concide");
                txtPassword.Text = "";
                txtRepetirContrasena.Text = "";
                return;
            }
            if (txtRepetirContrasena.Text.Equals(""))
            {
                MessageBox.Show("Por favor repita la contraseñá");
                return;
            }

            string pass = Hash.obtenerHash256(txtRepetirContrasena.Text);



            var EmpleadoBuscar = Entity.Empleados.FirstOrDefault(x => x.Nombre == txtUsername.Text);
            int EmpleadoGuardar;
            EmpleadoGuardar = EmpleadoBuscar.IdEmpleado;
            string Departamento = EmpleadoBuscar.Cargo;

            if (Departamento == "Mesero" || Departamento == "Cocinero" || Departamento == "TI")
            {
                MessageBox.Show("El empleado no tiene la autoridad suficiente para tener acceso al sistema");
                return;
            }

            if (editar)
            {
    
                var tusuario = Entity.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
                tusuario.IdEmpleado = EmpleadoGuardar;
                if (txtPassword.Text == "")
                {

                }
                else
                {
                    tusuario.Password = Convert.ToString(pass);
                }
                tusuario.UserName = txtUsername.Text;
                Entity.SaveChanges();
                MessageBox.Show("Usuario modificado");
            }
            else
            {
                var Usuarios = Entity.Usuario.FirstOrDefault(x => x.UserName == txtUsername.Text);
                if (Usuarios != null)
                {
                    MessageBox.Show("Este empleado ya tiene acceso al sistema");
                    txtUsername.Text = "";
                    txtUsername.Focus();
                    return;
                }
                try
                {
                    Usuario Uusuario = new Usuario
                    {
                        IdEmpleado = EmpleadoGuardar,
                        Password = Convert.ToString(pass),
                        UserName = txtUsername.Text
                    };
                    Entity.Usuario.Add(Uusuario);
                    Entity.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("El Empleado no esta registrado revise");
                    txtUsername.Focus();
                    return;
                }
                Limpiar();
                MessageBox.Show("Usuario guardado!");
            }

            editar = false;
            idUsuario = 0;
            CargarDv();
            Limpiar();
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                idUsuario = Convert.ToInt64(dgUsuarios.SelectedCells[0].Value);
                var tUsuario = Entity.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
              //  txtPassword.Text = tUsuario.Password;
              //  txtRepetirContrasena.Text = tUsuario.Password;
                txtUsername.Text = tUsuario.UserName;
                editar = true;

            }
            catch (Exception)
            {
                dgUsuarios.ClearSelection();
            }
            if (login == 1)
            {
                Limpiar();
                dgUsuarios.ClearSelection();
            }
        }

        private void dgUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (login == 1)
            {
                login = 2;
            }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgUsuarios.ClearSelection();
            Limpiar();

        }
    }
}

        
