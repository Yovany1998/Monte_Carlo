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
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBuscarEnElMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetallesPedido
            // 
            this.lblDetallesPedido.AutoSize = true;
            this.lblDetallesPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDetallesPedido.Location = new System.Drawing.Point(120, 154);
            this.lblDetallesPedido.Name = "lblDetallesPedido";
            this.lblDetallesPedido.Size = new System.Drawing.Size(151, 18);
            this.lblDetallesPedido.TabIndex = 41;
            this.lblDetallesPedido.Text = "Detalles del pedido";
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Location = new System.Drawing.Point(36, 200);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.RowHeadersWidth = 51;
            this.dgBebidas.Size = new System.Drawing.Size(361, 150);
            this.dgBebidas.TabIndex = 44;
            this.dgBebidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBebidas_CellDoubleClick);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(36, 28);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(372, 26);
            this.txtNombreCompleto.TabIndex = 46;
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(33, 7);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 24);
            this.lblNombre.TabIndex = 45;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtBuscarComidaOBebida
            // 
            this.txtBuscarComidaOBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarComidaOBebida.Location = new System.Drawing.Point(36, 113);
            this.txtBuscarComidaOBebida.Name = "txtBuscarComidaOBebida";
            this.txtBuscarComidaOBebida.Size = new System.Drawing.Size(222, 26);
            this.txtBuscarComidaOBebida.TabIndex = 48;
            this.txtBuscarComidaOBebida.TextChanged += new System.EventHandler(this.txtBuscarComidaOBebida_TextChanged);
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.BackColor = System.Drawing.Color.Transparent;
            this.lblBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBebidas.Location = new System.Drawing.Point(38, 179);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(68, 18);
            this.lblBebidas.TabIndex = 51;
            this.lblBebidas.Text = "Bebidas";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.BackColor = System.Drawing.Color.Transparent;
            this.lblComidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComidas.Location = new System.Drawing.Point(38, 362);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(75, 18);
            this.lblComidas.TabIndex = 53;
            this.lblComidas.Text = "Comidas";
            // 
            // dgComidas
            // 
            this.dgComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComidas.Location = new System.Drawing.Point(36, 383);
            this.dgComidas.Name = "dgComidas";
            this.dgComidas.RowHeadersWidth = 51;
            this.dgComidas.Size = new System.Drawing.Size(361, 150);
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
            this.btnContinuar.Location = new System.Drawing.Point(680, 511);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(178, 30);
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
            this.dgDetallesPedido.Location = new System.Drawing.Point(432, 111);
            this.dgDetallesPedido.Name = "dgDetallesPedido";
            this.dgDetallesPedido.ReadOnly = true;
            this.dgDetallesPedido.RowHeadersWidth = 51;
            this.dgDetallesPedido.Size = new System.Drawing.Size(444, 394);
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
            this.lblPedido.Location = new System.Drawing.Point(594, 90);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(60, 18);
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
            this.iconButton1.Location = new System.Drawing.Point(462, 511);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 39);
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
            this.btnOrdenesEnEspera.Location = new System.Drawing.Point(274, 104);
            this.btnOrdenesEnEspera.Name = "btnOrdenesEnEspera";
            this.btnOrdenesEnEspera.Size = new System.Drawing.Size(86, 47);
            this.btnOrdenesEnEspera.TabIndex = 50;
            this.btnOrdenesEnEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenesEnEspera.UseVisualStyleBackColor = true;
            this.btnOrdenesEnEspera.Click += new System.EventHandler(this.btnOrdenesEnEspera_Click_1);
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(36, 60);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(193, 32);
            this.btnBuscarCliente.TabIndex = 47;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(502, 28);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(273, 26);
            this.dtpFecha.TabIndex = 58;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(499, 9);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 24);
            this.lblFecha.TabIndex = 59;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblBuscarEnElMenu
            // 
            this.lblBuscarEnElMenu.AutoSize = true;
            this.lblBuscarEnElMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarEnElMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEnElMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuscarEnElMenu.Location = new System.Drawing.Point(33, 95);
            this.lblBuscarEnElMenu.Name = "lblBuscarEnElMenu";
            this.lblBuscarEnElMenu.Size = new System.Drawing.Size(148, 18);
            this.lblBuscarEnElMenu.TabIndex = 60;
            this.lblBuscarEnElMenu.Text = "Buscar en el menu";
            // 
            // Generar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 572);
            this.Controls.Add(this.lblBuscarEnElMenu);
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
            this.Controls.Add(this.txtBuscarComidaOBebida);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.lblDetallesPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Generar_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar_Venta";
            this.Load += new System.EventHandler(this.Generar_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetallesPedido)).EndInit();
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
        private System.Windows.Forms.Label lblBuscarEnElMenu;
    }
}