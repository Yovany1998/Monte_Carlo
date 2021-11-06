
namespace Monte_Carlos.Venta
{
    partial class Facturación
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblISV = new System.Windows.Forms.Label();
            this.dgListadeProductos = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaHoy = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodigoVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListadeProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 53;
            this.label6.Text = "Subtotal:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Total:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "ISV (12%):";
            // 
            // lblISV
            // 
            this.lblISV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISV.Location = new System.Drawing.Point(256, 365);
            this.lblISV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(73, 24);
            this.lblISV.TabIndex = 55;
            this.lblISV.Text = "L. 0.00";
            // 
            // dgListadeProductos
            // 
            this.dgListadeProductos.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListadeProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListadeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListadeProductos.Location = new System.Drawing.Point(142, 192);
            this.dgListadeProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgListadeProductos.Name = "dgListadeProductos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListadeProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgListadeProductos.RowHeadersWidth = 51;
            this.dgListadeProductos.RowTemplate.Height = 24;
            this.dgListadeProductos.Size = new System.Drawing.Size(643, 150);
            this.dgListadeProductos.TabIndex = 50;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(256, 401);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 24);
            this.lblSubtotal.TabIndex = 56;
            this.lblSubtotal.Text = "L. 0.00";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Lista de productos";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(256, 439);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 24);
            this.lblTotal.TabIndex = 57;
            this.lblTotal.Text = "L. 0.00";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cliente: ";
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.btnInsertarCliente.FlatAppearance.BorderSize = 0;
            this.btnInsertarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnInsertarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsertarCliente.Location = new System.Drawing.Point(142, 480);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(220, 37);
            this.btnInsertarCliente.TabIndex = 58;
            this.btnInsertarCliente.Text = "Confirmar venta";
            this.btnInsertarCliente.UseVisualStyleBackColor = false;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(138, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(224, 24);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Facturación de venta";
            // 
            // dtpFechaHoy
            // 
            this.dtpFechaHoy.Enabled = false;
            this.dtpFechaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHoy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHoy.Location = new System.Drawing.Point(653, 50);
            this.dtpFechaHoy.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHoy.Name = "dtpFechaHoy";
            this.dtpFechaHoy.Size = new System.Drawing.Size(132, 28);
            this.dtpFechaHoy.TabIndex = 59;
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(194, 89);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(168, 24);
            this.lblCliente.TabIndex = 48;
            this.lblCliente.Text = "Yovany Hernández";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lblCodigoVenta);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.dtpFechaHoy);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.btnInsertarCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.dgListadeProductos);
            this.panel1.Controls.Add(this.lblISV);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 572);
            this.panel1.TabIndex = 60;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCodigoVenta
            // 
            this.lblCodigoVenta.AutoSize = true;
            this.lblCodigoVenta.Location = new System.Drawing.Point(55, 89);
            this.lblCodigoVenta.Name = "lblCodigoVenta";
            this.lblCodigoVenta.Size = new System.Drawing.Size(35, 13);
            this.lblCodigoVenta.TabIndex = 60;
            this.lblCodigoVenta.Text = "label2";
            this.lblCodigoVenta.Visible = false;
            // 
            // Facturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Facturación_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListadeProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.DataGridView dgListadeProductos;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaHoy;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCodigoVenta;
    }
}