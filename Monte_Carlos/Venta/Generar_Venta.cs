using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Venta
{
    public partial class Generar_Venta : Form
    {
        
        DBFincaMonteCarloEntities1 Entity = new DBFincaMonteCarloEntities1();
        public string nombreCliente = string.Empty;
        public int idCliente = 0;
        public int codigoFactura = 0;
        

        public Generar_Venta()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        

        private void DvDetalle()
        {

           

        }
       
        public DateTime FechaActual
        {
            get { return DateTime.Today; ; }
            set { this.FechaActual = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (idCliente != 0)
            {
                ObtenerCodigoFactura();
                InsertarFactura();
                InsertarDetallesPedido();

            }
            else
            {
                MessageBox.Show("Verifique que el usuario sea correcto");
            }

        }

        private void Generar_Venta_Load(object sender, EventArgs e)
        {
            CargarComida();
            CargarBebida();
            ContarFacturasEnEspera();


        }

        //Cargamos los datos de las comidas que esten disponibles
        private void CargarComida()
        {
            var tComida = from Menu in Entity.Menu
                          where Menu.Tipo == "Comida" && Menu.Disponible == true
                          select new
                          {
                              Menu.IdMenu,
                              Menu.Nombre,
                              Menu.Precio
                          };

            dgComidas.DataSource = tComida.CopyAnonymusToDataTable();
            dgComidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        //Cargamos lo datos de las bebidas que esten disponibles
        private void CargarBebida()
        {
            var tBebidas = from Menu in Entity.Menu
                           where Menu.Tipo == "Bebida" && Menu.Disponible == true
                           select new
                           {
                               Menu.IdMenu,
                               Menu.Nombre,
                               Menu.Precio
                           };

            dgBebidas.DataSource = tBebidas.CopyAnonymusToDataTable();
            dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void dgBebidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CantidadProducto Cantidad = new CantidadProducto();
            Cantidad.ShowDialog();

            int cantidad = 0;
            cantidad = Cantidad.cantidad;

            int indice = dgBebidas.CurrentCell.RowIndex;
            int idBebida = Convert.ToInt32(dgBebidas.Rows[indice].Cells[0].Value.ToString());
            string nombreBebida = dgBebidas.Rows[indice].Cells[1].Value.ToString();
            decimal precio = Convert.ToDecimal(dgBebidas.Rows[indice].Cells[2].Value.ToString());

            AgregarDetalle(idBebida,nombreBebida, cantidad, precio);

        }

        private void AgregarDetalle(int codigo, string nombre, int cantidad, decimal precio)
        {
            dgDetallesPedido.Rows.Add(codigo, nombre, precio, cantidad);
        }

        private void dgComidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CantidadProducto Cantidad = new CantidadProducto();
            Cantidad.ShowDialog();

            int cantidad = 0;
            cantidad = Cantidad.cantidad;

            int indice = dgComidas.CurrentCell.RowIndex;
            int idComida = Convert.ToInt32(dgComidas.Rows[indice].Cells[0].Value.ToString());
            string nombreComida = dgComidas.Rows[indice].Cells[1].Value.ToString();
            decimal precio = Convert.ToDecimal(dgComidas.Rows[indice].Cells[2].Value.ToString());

            AgregarDetalle(idComida, nombreComida, cantidad, precio);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int indice = 0;
            if (dgDetallesPedido.SelectedRows.Count > 0)
            {
                indice = dgDetallesPedido.CurrentCell.RowIndex;
                dgDetallesPedido.Rows.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("No se puede eliminar ningun elemento");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Cliente.BusquedaClientes Cliente = new Cliente.BusquedaClientes();
            Cliente.ShowDialog();
            EstablecerDatos(Cliente.nombreCliente + " " + Cliente.apellidoCliente, Cliente.idCliente);
        }

        private void EstablecerDatos(string nombre, int id)
        {
            if (id > 0)
            {
                nombreCliente = nombre;
                idCliente = id;
                txtNombreCompleto.Text = nombreCliente;
            }
            else
            {
                MessageBox.Show("No selecciono ningun cliente");
            }
        }

        private void InsertarFactura()
        {
            if (idCliente !=0 && txtNombreCompleto.Text != string.Empty)
            {
                Facturas tFactura = new Facturas();

                tFactura.IdCliente = idCliente;
                tFactura.Fecha = dtpFecha.Value;
                tFactura.Estado = 0;

                Entity.Facturas.Add(tFactura);
                Entity.SaveChanges();
            }
            else
            {
                MessageBox.Show("Faltan datos para realizar la insercion");
            }

            
        }

        private void InsertarDetallesPedido()
        {
            int indice = dgDetallesPedido.Rows.Count;
            DetalleDeFactura tDetallesFactura = new DetalleDeFactura();

            if (indice > 0)
            {
                for (int i = 0; i <= indice -2; i++)
                {
                    tDetallesFactura.IdFactura = codigoFactura;
                    tDetallesFactura.IdMenu = Convert.ToInt32(dgDetallesPedido.Rows[i].Cells[0].Value.ToString());
                    tDetallesFactura.Cantidad = Convert.ToInt32(dgDetallesPedido.Rows[i].Cells[3].Value.ToString());

                    Entity.DetalleDeFactura.Add(tDetallesFactura);
                    Entity.SaveChanges();
                }
            }

            
        }

        private void ObtenerCodigoFactura()
        {
            string cadena = "";
            string[] valores;
            string[] valorFinal;
            int ultimoCodigo = 0;
            int siguienteCodigo = 0;


            var tFacturas = (from Facturas in Entity.Facturas
                             orderby Facturas.IdFactura descending
                             select new
                             {
                                 Facturas.IdFactura
                             }).Take(1);
                                    


            //Extraemos el codigo mediante dos splits(Posible mejora futura)
            if (tFacturas.ToList().Count > 0)
            {
                cadena = tFacturas.ToList()[0].ToString();
                valores = cadena.Split('=');
                valorFinal = valores[1].Split('}');
                ultimoCodigo = Convert.ToInt32(valorFinal[0]);
                siguienteCodigo = ultimoCodigo + 1;
            }
            else
            {
                ultimoCodigo = 0;
                siguienteCodigo = ultimoCodigo + 1;
            }

            codigoFactura = Convert.ToInt32(siguienteCodigo.ToString());

            
        }

        private void icoBuscarComidaObebida_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarComidaOBebida_TextChanged(object sender, EventArgs e)
        {
            FiltrarMenu(txtBuscarComidaOBebida.Text);
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenesEnEspera_Click(object sender, EventArgs e)
        {
            Venta.Ventas_En_Espera ventaEspera = new Venta.Ventas_En_Espera();
            ventaEspera.Show();
        }

        private void FiltrarMenu(string nombre)
        {

            //Filtramos la comida
            var tComida = from Menu in Entity.Menu
                          where Menu.Tipo == "Comida" && Menu.Disponible == true
                          where Menu.Nombre.Contains(nombre)
                          select new
                          {
                              Menu.IdMenu,
                              Menu.Nombre,
                              Menu.Precio
                          };

            dgComidas.DataSource = tComida.CopyAnonymusToDataTable();
            dgComidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Filtrar Bebidas
            var tBebidas = from Menu in Entity.Menu
                           where Menu.Tipo == "Bebida" && Menu.Disponible == true
                           where Menu.Nombre.Contains(nombre)
                           select new
                           {
                               Menu.IdMenu,
                               Menu.Nombre,
                               Menu.Precio
                           };

            dgBebidas.DataSource = tBebidas.CopyAnonymusToDataTable();
            dgBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ContarFacturasEnEspera()
        {
            var tFacturasEnEspera = from Facturas in Entity.Facturas
                                    where Facturas.Estado == 0
                                    select new
                                    {
                                        Facturas.IdFactura
                                    };
            int count = tFacturasEnEspera.Count();

            btnOrdenesEnEspera.Text = count.ToString();
        }
    }
}
