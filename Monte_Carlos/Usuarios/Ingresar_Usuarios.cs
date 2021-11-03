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

        private void Ingresar_Usuarios_Load(object sender, EventArgs e)
        {

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
            
            var EmpleadoBuscar = Entity.Empleados.FirstOrDefault(x => x.Nombre == txtUsername.Text);
            int EmpleadoGuardar;
            EmpleadoGuardar = EmpleadoBuscar.IdEmpleado;

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
                MessageBox.Show("El usuario no Empleado no esta registrado revise");
                txtUsername.Focus();
                return;
            }

         
          

            MessageBox.Show("Usuario guardado!");
        }

                
           
    }
}

        
