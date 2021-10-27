using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlos.Demas
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

     /*   private void IBtnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IBtnMax.Visible = true;
            IBtnNormal.Visible = false;
        }

        private void IBtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IBtnMax.Visible = false;
            IBtnNormal.Visible = true;
        }*/
    }
}
