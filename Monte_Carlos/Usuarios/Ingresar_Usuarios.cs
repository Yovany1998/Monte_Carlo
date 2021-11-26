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
        //Se llamó a la base de datos DBFincaMonteCarlosEntities1
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        //Declaramos las variables que necesitaremos
        public long enviar;
        long idUsuario = 0;
        bool editar = false;
        int login = 0;
        //En el public Ingresar_Usuarios inicializamos el componente
        public Ingresar_Usuarios()
        {
            InitializeComponent();
        }
        //Funcion para  incryptar la contraseña y asi ser mas seguro el sistama
        public class Hash
        {
            //Obtine como parametro la contraseña insertada y la devuelve incryptada
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
        //Se creo una funcion que limpie los datos del formulario  y la selección 
        private void Limpiar()
        {
            txtUsername.Enabled = true;
            txtUsername.Text = "";
            txtPassword.Text = "";
            idUsuario = 0;
            editar = false;
            txtRepetirContrasena.Text = "";
            dgUsuarios.ClearSelection();
            
        }
        //Se creo la función CargarDv para llenar el DataGridView
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
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgUsuarios.ClearSelection();
        }
        //En esta función se incializan los valores del formulario ala hora de ser abierto
        private void Ingresar_Usuarios_Load(object sender, EventArgs e)
        {          
            CargarDv();           
            idUsuario = 0;
            login = 1;
            editar = false;
            dgUsuarios.ClearSelection();
            Limpiar();
        }
        //Boton de guardar este boton tiene doble función que es editar y guardar
        private void txtGuardar_Click(object sender, EventArgs e)
        {
            //Validamos los campos
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
            //Llamamos la función Hash para incryptar la contraseñá
            string pass = Hash.obtenerHash256(txtRepetirContrasena.Text);
        
                //Buscamos el empleado con el mismo nombre del usuaio
                var EmpleadoBuscar = Entity.Empleados.FirstOrDefault(x => x.Nombre == txtUsername.Text);
                int EmpleadoGuardar;
                EmpleadoGuardar = EmpleadoBuscar.IdEmpleado;
                //Validamos exista el empleado esto lo hacemos comparando el valor obtenido en el
                //apartado anterior
                if (EmpleadoGuardar == null)
                {
                    MessageBox.Show("El empleado no existe");
                Limpiar();
                return;
                }
                string Departamento = EmpleadoBuscar.Cargo;
                //Validamos la autoridad del empleado para verificar si puede o no 
                //tener acceso al sistema 
                if (Departamento == "Mesero" || Departamento == "Cocinero" || Departamento == "TI")
                {
                    MessageBox.Show("El empleado no tiene la autoridad suficiente para tener acceso al sistema");
                    Limpiar();
                    return;
                }
                //para editar el usuario este apartado solo modifica el la contraseña
                if (editar)
                {
                    var tusuario = Entity.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);                
                    tusuario.IdEmpleado = EmpleadoGuardar;
                    if (txtPassword.Text == "")
                    {
                    MessageBox.Show("No se realizaron cambios al usuario");
                    }
                    else
                    {
                        tusuario.Password = Convert.ToString(pass);
                    }
                    
                    tusuario.UserName = txtUsername.Text;
                    Entity.SaveChanges();
                    MessageBox.Show("Usuario modificado");                  
                }
                //Se guardan los datos del usuario
                else
                {
                    var Usuarios = Entity.Usuario.FirstOrDefault(x => x.UserName == txtUsername.Text);
                    if (Usuarios != null)
                    {
                        MessageBox.Show("Este empleado ya tiene acceso al sistema");
                        txtUsername.Text = "";
                        Limpiar();
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
                        Limpiar();
                    }
                    MessageBox.Show("Usuario guardado!");
                  
                }        
            CargarDv();
            Limpiar();
        }

        //Esta función se ejecuta cada vez que se selecciona algo en el DataGridView
        //Tiene como fin llenar los campos del formulario con el usuario seleccionado
        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idUsuario = Convert.ToInt64(dgUsuarios.SelectedCells[0].Value);
                var tUsuario = Entity.Usuario.FirstOrDefault(x => x.IdUsuario == idUsuario);
                txtUsername.Text = tUsuario.UserName;
                editar = true;
                txtUsername.Enabled = false;
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
        //Evita que Incie el formulario con una selección al inicio
        private void dgUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (login == 1)
            {
                login = 2;
            }
        }
        //Elimina el usuario seleccionado
        private void btnBorrarUsusario_Click(object sender, EventArgs e)
        {
            //Verificamos que alla algun usuario seleccionado para eliminarlo
            if (editar == false)
            {
                MessageBox.Show("Seleccione un registro para borrarlo");
            }
            else
            {
                MessageBox.Show("Se elimino el usuario con exito!");
                Entity.Usuario.RemoveRange(Entity.Usuario.Where(x => x.IdUsuario == idUsuario));
                Entity.SaveChanges();
                CargarDv();
                Limpiar();
            }
        }
        //Este botón solo ejecuta limpiar para incializa los componentes asu estado de inicio
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgUsuarios.ClearSelection();
            Limpiar();

        }
        //Evita que Incie el formulario con una selección al inicio
        private void dgUsuarios_MouseMove(object sender, MouseEventArgs e)
        {

            if (login == 1)
            {
                login = 2;
            }
        }
    }
}

        
