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

namespace Monte_Carlos
{
    public partial class Login : Form
    {
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        internal static string nombreUsuario;
        public Login()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese usuario");
                return;
            }

            if (txtContraseña.Text == string.Empty)
            {
                MessageBox.Show("Ingrese contraseña");
                return;
            }
            string pass = Hash.obtenerHash256(txtContraseña.Text);

            var tUsuarios = Entity.Usuario.FirstOrDefault(x => x.UserName == txtUsuario.Text && x.Password == pass);

            if (tUsuarios == null)
            {
                MessageBox.Show("Usuario o Contrasenia incorrecto");
                Limpiar();
                return;
            }
            else
            {
                nombreUsuario = txtUsuario.Text;
              //  MessageBox.Show(nombreUsuario);
                Limpiar();
                
                this.Hide();
                Inicio ventana = new Inicio();
                ventana.Show();

            }

            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblSistema.Parent = pictureBox1;
            lblSistema.BackColor = Color.Transparent;
        }

        

        private void lblIngresar_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '●';
        }
    }
}
