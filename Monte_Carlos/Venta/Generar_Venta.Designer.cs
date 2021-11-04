namespace Monte_Carlos.Venta
{
    partial class Generar_Venta
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
            this.lblDetallesPedido = new System.Windows.Forms.Label();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscarComidaOBebida = new System.Windows.Forms.TextBox();
            this.icoBuscarComidaObebida = new FontAwesome.Sharp.IconPictureBox();
            this.btnOrdenesEnEspera = new FontAwesome.Sharp.IconButton();
            this.lblBebidas = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.dgComidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoBuscarComidaObebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetallesPedido
            // 
            this.lblDetallesPedido.AutoSize = true;
            this.lblDetallesPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDetallesPedido.Location = new System.Drawing.Point(305, 122);
            this.lblDetallesPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetallesPedido.Name = "lblDetallesPedido";
            this.lblDetallesPedido.Size = new System.Drawing.Size(190, 24);
            this.lblDetallesPedido.TabIndex = 41;
            this.lblDetallesPedido.Text = "Detalles del pedido";
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgBebidas.Location = new System.Drawing.Point(303, 229);
            this.dgBebidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.RowHeadersWidth = 51;
            this.dgBebidas.Size = new System.Drawing.Size(503, 185);
            this.dgBebidas.TabIndex = 44;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.Location = new System.Drawing.Point(309, 76);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(257, 39);
            this.btnBuscarCliente.TabIndex = 47;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(309, 37);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(495, 30);
            this.txtNombreCompleto.TabIndex = 46;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(305, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 30);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBuscarComidaOBebida
            // 
            this.txtBuscarComidaOBebida.Enabled = false;
            this.txtBuscarComidaOBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarComidaOBebida.Location = new System.Drawing.Point(387, 156);
            this.txtBuscarComidaOBebida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarComidaOBebida.Name = "txtBuscarComidaOBebida";
            this.txtBuscarComidaOBebida.Size = new System.Drawing.Size(295, 30);
            this.txtBuscarComidaOBebida.TabIndex = 48;
            // 
            // icoBuscarComidaObebida
            // 
            this.icoBuscarComidaObebida.BackColor = System.Drawing.Color.White;
            this.icoBuscarComidaObebida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icoBuscarComidaObebida.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icoBuscarComidaObebida.IconColor = System.Drawing.SystemColors.ControlText;
            this.icoBuscarComidaObebida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBuscarComidaObebida.IconSize = 39;
            this.icoBuscarComidaObebida.Location = new System.Drawing.Point(336, 148);
            this.icoBuscarComidaObebida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icoBuscarComidaObebida.Name = "icoBuscarComidaObebida";
            this.icoBuscarComidaObebida.Size = new System.Drawing.Size(43, 39);
            this.icoBuscarComidaObebida.TabIndex = 49;
            this.icoBuscarComidaObebida.TabStop = false;
            this.icoBuscarComidaObebida.Click += new System.EventHandler(this.icoBuscarComidaObebida_Click);
            // 
            // btnOrdenesEnEspera
            // 
            this.btnOrdenesEnEspera.Enabled = false;
            this.btnOrdenesEnEspera.FlatAppearance.BorderSize = 0;
            this.btnOrdenesEnEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenesEnEspera.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.btnOrdenesEnEspera.IconColor = System.Drawing.Color.Black;
            this.btnOrdenesEnEspera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrdenesEnEspera.IconSize = 52;
            this.btnOrdenesEnEspera.Location = new System.Drawing.Point(691, 139);
            this.btnOrdenesEnEspera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenesEnEspera.Name = "btnOrdenesEnEspera";
            this.btnOrdenesEnEspera.Size = new System.Drawing.Size(115, 58);
            this.btnOrdenesEnEspera.TabIndex = 50;
            this.btnOrdenesEnEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenesEnEspera.UseVisualStyleBackColor = true;
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.BackColor = System.Drawing.Color.Transparent;
            this.lblBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBebidas.Location = new System.Drawing.Point(305, 203);
            this.lblBebidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(85, 24);
            this.lblBebidas.TabIndex = 51;
            this.lblBebidas.Text = "Bebidas";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.BackColor = System.Drawing.Color.Transparent;
            this.lblComidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComidas.Location = new System.Drawing.Point(305, 428);
            this.lblComidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(91, 24);
            this.lblComidas.TabIndex = 53;
            this.lblComidas.Text = "Comidas";
            // 
            // dgComidas
            // 
            this.dgComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dgComidas.Location = new System.Drawing.Point(303, 454);
            this.dgComidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgComidas.Name = "dgComidas";
            this.dgComidas.RowHeadersWidth = 51;
            this.dgComidas.Size = new System.Drawing.Size(503, 185);
            this.dgComidas.TabIndex = 52;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(568, 646);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(237, 37);
            this.btnContinuar.TabIndex = 54;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Generar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 704);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.dgComidas);
            this.Controls.Add(this.lblBebidas);
            this.Controls.Add(this.btnOrdenesEnEspera);
            this.Controls.Add(this.icoBuscarComidaObebida);
            this.Controls.Add(this.txtBuscarComidaOBebida);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.lblDetallesPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Generar_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar_Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoBuscarComidaObebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDetallesPedido;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBuscarComidaOBebida;
        private FontAwesome.Sharp.IconPictureBox icoBuscarComidaObebida;
        private FontAwesome.Sharp.IconButton btnOrdenesEnEspera;
        private System.Windows.Forms.Label lblBebidas;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.DataGridView dgComidas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnContinuar;
    }
}