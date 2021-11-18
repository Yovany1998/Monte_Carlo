using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Compras
{
    public partial class Grud_Compras : Form
    {
        DBFincaMonteCarloEntities1 Variables = new DBFincaMonteCarloEntities1();
        long idCompras = 0;

        public string empresa = string.Empty;
        public int idProveedor = 0;
        bool editar = false;
        Double Subto;
        int log;
        public Grud_Compras()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtObservacion.Text = "";
            txtProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            editar = false;
            dvCompra.ClearSelection();
            DgVerCompras.ClearSelection();
        }
        public DateTime FechaActual
        {
            get { return DateTime.Today; ; }
            set { this.FechaActual = value; }
        }
        private void Grud_Compras_Load(object sender, EventArgs e)
        {
            log = 1;
     
            CargaComprasDg();
            idCompras = 0;
            Limpiar();
            editar = false;
        }
        private void CargaDv()
        {
      
            try
            {
        
            }
            catch
            {

            }
        }  
        private void CargaComprasDg()
        {
            try
            {


                DateTime Fechas = Convert.ToDateTime(FechaActual.ToString("yyyy/MM/dd 00:00:00"));
                var tCompras = from Detalle in Variables.DetalleDeCompra
                               join Compras
                               in Variables.Compra on Detalle.IdCompra equals Compras.IdCompra
                               join Proveedor in Variables.Proveedor on Detalle.IdProveedor
                               equals Proveedor.IdProveedor
                               select new
                               {
                                   Compras.IdCompra,
                                   Proveedor.Empresa

                               };
                DgVerCompras.DataSource = tCompras.CopyAnonymusToDataTable();
                DgVerCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch
            {

            }
          
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Por favor seleccione el proveedor");
                return;
            }
            if (txtProducto.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingrese el producto");
                return;
            }
            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar el precio");
                return;
            }
            /*if (Convert.ToInt32(txtPrecio.Text) <= 0)
            {
                MessageBox.Show("El precio no puede ser menor o igual a 0");
                return;
            }*/
            if (txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar la cantidad de la compra");
                return;
            }

          //  Subto = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);

            if (editar)
            {

                
                var tDetalleDeCompra = Variables.DetalleDeCompra.FirstOrDefault(x => x.IdDetalle == idCompras);
                var tCompra = Variables.Compra.FirstOrDefault(x => x.IdCompra == idCompras);
                tDetalleDeCompra.Producto = txtProducto.Text;
                tDetalleDeCompra.PrecioUnitario = Convert.ToDecimal(txtPrecio.Text);
                tDetalleDeCompra.Cantidad = Convert.ToInt32(txtCantidad.Text);
                tCompra.Observacion = txtObservacion.Text;
                Variables.SaveChanges();
                MessageBox.Show("Compra modificada!");
            }
            else
            {
                var proveedor = Variables.Proveedor.FirstOrDefault(x => x.Empresa == txtNombre.Text);
                MessageBox.Show("Compra guardada");
                DetalleDeCompra tbDetalle = new DetalleDeCompra();
                Compra tbCompra = new Compra();
                   
                   
                    tbCompra.Observacion = txtObservacion.Text;
                    tbCompra.Fecha = FechaActual;
                    
                
               
                Variables.Compra.Add(tbCompra);
                Variables.SaveChanges();
                int codigoCompra = tbCompra.IdCompra;
                tbDetalle.IdProveedor = proveedor.IdProveedor;
                tbDetalle.IdCompra = codigoCompra;
                tbDetalle.Producto = txtProducto.Text;
                tbDetalle.PrecioUnitario = Convert.ToInt32(txtPrecio.Text);
                tbDetalle.Cantidad = Convert.ToInt32(txtCantidad.Text);
                Variables.DetalleDeCompra.Add(tbDetalle);
                Variables.SaveChanges();
            }
            editar = false;
            CargaDv();
            CargaComprasDg();
            idCompras = 0;
            Limpiar();
        }

        private void dvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            DgVerCompras.ClearSelection();
            dvCompra.ClearSelection();
            Limpiar();
            dvCompra.DataSource = " ";
            dvCompra.Refresh();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (editar == false)
            {
                MessageBox.Show("Debe haber un registro seleccionado para poder borrarlo");
            }
            else
            {
                if (dvCompra.RowCount == 2)
                {
                    MessageBox.Show("Si eliminas este registro no podras acceder al programa");
                }
                else
                {

                    Variables.DetalleDeCompra.RemoveRange(Variables.DetalleDeCompra.Where(x => x.IdCompra == idCompras));
                    Variables.SaveChanges();
                    Limpiar();
                    CargaDv();
                }
            }
        }

        private void dvCompra_SelectionChanged_1(object sender, EventArgs e)
        {

            try
            {
                idCompras = Convert.ToInt64(dvCompra.SelectedCells[0].Value);
                var tbCompra = Variables.Compra.FirstOrDefault(x => x.IdCompra == idCompras);
                var tbDetalle = Variables.DetalleDeCompra.FirstOrDefault(x => x.IdDetalle == idCompras);
                var tbProveedor = Variables.Proveedor.FirstOrDefault(x => x.IdProveedor == tbDetalle.IdProveedor );
                txtNombre.Text = tbProveedor.Empresa;
                txtCantidad.Text = Convert.ToString(tbDetalle.Cantidad);
                txtPrecio.Text = Convert.ToString(tbDetalle.PrecioUnitario);
                txtProducto.Text = tbDetalle.Producto;
                txtObservacion.Text = tbCompra.Observacion;
                editar = true;
                
            }
            catch (Exception)
            {
                editar = false;
            }
            if (log == 1)
            {
                dvCompra.DataSource = " ";
                dvCompra.Refresh();
                Limpiar();
            }



        }

        private void dvCompra_MouseClick_1(object sender, MouseEventArgs e)
        {

            if (log == 1)
            {
                log = 2;
            }
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            Compras.BuscarProveedor Proveedor = new Compras.BuscarProveedor();
            Proveedor.ShowDialog();
            EstablecerDatos(Proveedor.nombreProveedor, Proveedor.idProveedor);
        }
        private void EstablecerDatos(string nombre, int id)
        {
            if (id > 0)
            {
                empresa = nombre;
                idProveedor = id;
                txtNombre.Text = empresa;
            }
            else
            {
                MessageBox.Show("No selecciono ningun cliente");
            }
        }

        private void DgVerCompras_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int idCompre = Convert.ToInt32(DgVerCompras.SelectedCells[0].Value);
                DateTime Fechas = Convert.ToDateTime(FechaActual.ToString("yyyy/MM/dd 00:00:00"));
                var tCompras = from j in Variables.DetalleDeCompra
                               where j.IdCompra == idCompre
                               select new
                               {
                                   j.IdDetalle,
                                   j.Producto,
                                   j.PrecioUnitario,
                                   j.Cantidad,
                               };
                dvCompra.DataSource = tCompras.CopyAnonymusToDataTable();
                dvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            }
            catch (Exception)
            {
                editar = false;
            }
            if (log == 1)
            {
                dvCompra.DataSource = " ";
                dvCompra.Refresh();
                Limpiar();
            }

        }

        private void DgVerCompras_MouseClick(object sender, MouseEventArgs e)
        {
            if (log == 1)
            {
                log = 2;
            }
        }

        private void DgVerCompras_MouseMove(object sender, MouseEventArgs e)
        {
            if (log == 1)
            {
                log = 2;
            }
        }
    }
}
