using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Proveedor
{
    public partial class CRUD_Proveedor : Form
    {
        DBFincaMonteCarloEntities1 entity = new DBFincaMonteCarloEntities1();
        long idProveedor = 0;
        bool editar = false;
        public CRUD_Proveedor()
        {
            InitializeComponent();
        }

        private void CRUD_Proveedor_Load(object sender, EventArgs e)
        {
            SelectAll();
            dgProvedores.ClearSelection();
            LimpiarTextBoxs();
        }

        private void SelectAll()
        {

                var tablaProveedor = from columna in entity.Proveedor
                                     select new
                                     {
                                         columna.IdProveedor,
                                         columna.Empresa,
                                         columna.NumeroDeTelefono,
                                         columna.NombreDeContacto,
                                         columna.RTN,
                                         columna.Observacion
                                     };
                dgProvedores.DataSource = tablaProveedor.CopyAnonymusToDataTable();
                dgProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
       

        }

        private void LimpiarTextBoxs()
        {
            txtEmpresa.Text = txtNombreDeContacto.Text = txtNumeroTelefono.Text = txtObservacion.Text = txtRTN.Text = string.Empty;
        }

        private void dgProvedores_SelectionChanged(object sender, EventArgs e)
        {

            if (dgProvedores.SelectedRows.Count > 0)
            {
                try
                {
                    idProveedor = Convert.ToInt64(dgProvedores.SelectedCells[0].Value);
                    var rowProveedor = entity.Proveedor.FirstOrDefault(x => x.IdProveedor == idProveedor);
                    txtEmpresa.Text = rowProveedor.Empresa;
                    txtNombreDeContacto.Text = rowProveedor.NombreDeContacto;
                    txtNumeroTelefono.Text = rowProveedor.NumeroDeTelefono;
                    txtRTN.Text = rowProveedor.RTN;
                    txtObservacion.Text = rowProveedor.Observacion;
                    editar = true;
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgProvedores.ClearSelection();
            LimpiarTextBoxs();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    var rowProveedor = entity.Proveedor.FirstOrDefault(x => x.IdProveedor == idProveedor);
                    rowProveedor.NombreDeContacto = txtNombreDeContacto.Text;
                    rowProveedor.NumeroDeTelefono = txtNumeroTelefono.Text;
                    rowProveedor.Observacion = txtObservacion.Text;
                    rowProveedor.RTN = txtRTN.Text;
                    rowProveedor.Empresa = txtEmpresa.Text;
                    entity.SaveChanges();
                    MessageBox.Show("Provedor actualizado");
                    SelectAll();
                }
                else
                {
                    Proveedores rowProveedores = new Proveedores();
                    rowProveedores.NombreDeContacto = txtNombreDeContacto.Text;
                    rowProveedores.NumeroDeTelefono = txtNumeroTelefono.Text;
                    rowProveedores.Observacion = txtObservacion.Text;
                    rowProveedores.RTN = txtRTN.Text;
                    rowProveedores.Empresa = txtEmpresa.Text;

                    entity.Proveedor.Add(rowProveedores);
                    entity.SaveChanges();
                    SelectAll();
                    LimpiarTextBoxs();
                    MessageBox.Show("Provedor guardado");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idProveedor.ToString());
            try 
            {
                entity.Proveedor.RemoveRange(entity.Proveedor.Where(x => x.IdProveedor == idProveedor));
                MessageBox.Show("El proveedor se elimino");
                entity.SaveChanges();
                SelectAll();
                LimpiarTextBoxs();
                dgProvedores.ClearSelection();
            } catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (' ')) && (e.KeyChar != (char)Keys.Back) )
            {
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != ('-')))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreDeContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (' ')) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
