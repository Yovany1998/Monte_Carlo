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
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscarComidaOBebida = new System.Windows.Forms.TextBox();
            this.lblBebidas = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.dgComidas = new System.Windows.Forms.DataGridView();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.dgDetallesPedido = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPedido = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnOrdenesEnEspera = new FontAwesome.Sharp.IconButton();
            this.icoBuscarComidaObebida = new FontAwesome.Sharp.IconPictureBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoBuscarComidaObebida)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetallesPedido
            // 
            this.lblDetallesPedido.AutoSize = true;
            this.lblDetallesPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDetallesPedido.Location = new System.Drawing.Point(44, 119);
            this.lblDetallesPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetallesPedido.Name = "lblDetallesPedido";
            this.lblDetallesPedido.Size = new System.Drawing.Size(190, 24);
            this.lblDetallesPedido.TabIndex = 41;
            this.lblDetallesPedido.Text = "Detalles del pedido";
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Location = new System.Drawing.Point(41, 226);
            this.dgBebidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.RowHeadersWidth = 51;
            this.dgBebidas.Size = new System.Drawing.Size(481, 185);
            this.dgBebidas.TabIndex = 44;
            this.dgBebidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBebidas_CellDoubleClick);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(48, 34);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(495, 30);
            this.txtNombreCompleto.TabIndex = 46;
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(44, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 30);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBuscarComidaOBebida
            // 
            this.txtBuscarComidaOBebida.Enabled = false;
            this.txtBuscarComidaOBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarComidaOBebida.Location = new System.Drawing.Point(125, 154);
            this.txtBuscarComidaOBebida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarComidaOBebida.Name = "txtBuscarComidaOBebida";
            this.txtBuscarComidaOBebida.Size = new System.Drawing.Size(295, 30);
            this.txtBuscarComidaOBebida.TabIndex = 48;
            this.txtBuscarComidaOBebida.TextChanged += new System.EventHandler(this.txtBuscarComidaOBebida_TextChanged);
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.BackColor = System.Drawing.Color.Transparent;
            this.lblBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBebidas.Location = new System.Drawing.Point(44, 201);
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
            this.lblComidas.Location = new System.Drawing.Point(44, 426);
            this.lblComidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(91, 24);
            this.lblComidas.TabIndex = 53;
            this.lblComidas.Text = "Comidas";
            // 
            // dgComidas
            // 
            this.dgComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComidas.Location = new System.Drawing.Point(41, 452);
            this.dgComidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgComidas.Name = "dgComidas";
            this.dgComidas.RowHeadersWidth = 51;
            this.dgComidas.Size = new System.Drawing.Size(481, 185);
            this.dgComidas.TabIndex = 52;
            this.dgComidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgComidas_CellDoubleClick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(907, 629);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(237, 37);
            this.btnContinuar.TabIndex = 54;
            this.btnContinuar.Text = "Generar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // dgDetallesPedido
            // 
            this.dgDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetallesPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Cantidad});
            this.dgDetallesPedido.Location = new System.Drawing.Point(576, 137);
            this.dgDetallesPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgDetallesPedido.Name = "dgDetallesPedido";
            this.dgDetallesPedido.ReadOnly = true;
            this.dgDetallesPedido.RowHeadersWidth = 51;
            this.dgDetallesPedido.Size = new System.Drawing.Size(592, 485);
            this.dgDetallesPedido.TabIndex = 55;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPedido.Location = new System.Drawing.Point(792, 111);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(76, 24);
            this.lblPedido.TabIndex = 56;
            this.lblPedido.Text = "Pedido";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(616, 629);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(47, 48);
            this.iconButton1.TabIndex = 57;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnOrdenesEnEspera
            // 
            this.btnOrdenesEnEspera.FlatAppearance.BorderSize = 0;
            this.btnOrdenesEnEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenesEnEspera.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.btnOrdenesEnEspera.IconColor = System.Drawing.Color.Black;
            this.btnOrdenesEnEspera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrdenesEnEspera.IconSize = 52;
            this.btnOrdenesEnEspera.Location = new System.Drawing.Point(429, 137);
            this.btnOrdenesEnEspera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenesEnEspera.Name = "btnOrdenesEnEspera";
            this.btnOrdenesEnEspera.Size = new System.Drawing.Size(115, 58);
            this.btnOrdenesEnEspera.TabIndex = 50;
            this.btnOrdenesEnEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenesEnEspera.UseVisualStyleBackColor = true;
            //this.btnOrdenesEnEspera.Click += new System.EventHandler(this.btnOrdenesEnEspera_Click);
            // 
            // icoBuscarComidaObebida
            // 
            this.icoBuscarComidaObebida.BackColor = System.Drawing.Color.White;
            this.icoBuscarComidaObebida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icoBuscarComidaObebida.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icoBuscarComidaObebida.IconColor = System.Drawing.SystemColors.ControlText;
            this.icoBuscarComidaObebida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBuscarComidaObebida.IconSize = 39;
            this.icoBuscarComidaObebida.Location = new System.Drawing.Point(75, 145);
            this.icoBuscarComidaObebida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icoBuscarComidaObebida.Name = "icoBuscarComidaObebida";
            this.icoBuscarComidaObebida.Size = new System.Drawing.Size(43, 39);
            this.icoBuscarComidaObebida.TabIndex = 49;
            this.icoBuscarComidaObebida.TabStop = false;
            this.icoBuscarComidaObebida.Click += new System.EventHandler(this.icoBuscarComidaObebida_Click);
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(48, 74);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(257, 39);
            this.btnBuscarCliente.TabIndex = 47;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(669, 34);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(363, 30);
            this.dtpFecha.TabIndex = 58;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(665, 11);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(132, 30);
            this.lblFecha.TabIndex = 59;
            this.lblFecha.Text = "Fecha:";
            // 
            // Generar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 704);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.dgDetallesPedido);
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
            this.Load += new System.EventHandler(this.Generar_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoBuscarComidaObebida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDetallesPedido;
        private System.Windows.Forms.DataGridView dgBebidas;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBuscarComidaOBebida;
        private FontAwesome.Sharp.IconPictureBox icoBuscarComidaObebida;
        private FontAwesome.Sharp.IconButton btnOrdenesEnEspera;
        private System.Windows.Forms.Label lblBebidas;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.DataGridView dgComidas;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.DataGridView dgDetallesPedido;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
    }
}