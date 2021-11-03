namespace Monte_Carlos
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.IBtnProveedor = new FontAwesome.Sharp.IconButton();
            this.IBtnCliente = new FontAwesome.Sharp.IconButton();
            this.IBtnCarta = new FontAwesome.Sharp.IconButton();
            this.IBtnCompra = new FontAwesome.Sharp.IconButton();
            this.IBtnEmpleado = new FontAwesome.Sharp.IconButton();
            this.IBtnVenta = new FontAwesome.Sharp.IconButton();
            this.IBtnReservacion = new FontAwesome.Sharp.IconButton();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.ProgesoBarra = new System.Windows.Forms.Timer(this.components);
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.PanelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelIzquierdo.Controls.Add(this.iconButton2);
            this.PanelIzquierdo.Controls.Add(this.pictureBox1);
            this.PanelIzquierdo.Controls.Add(this.iconButton1);
            this.PanelIzquierdo.Controls.Add(this.IBtnProveedor);
            this.PanelIzquierdo.Controls.Add(this.IBtnCliente);
            this.PanelIzquierdo.Controls.Add(this.IBtnCarta);
            this.PanelIzquierdo.Controls.Add(this.IBtnCompra);
            this.PanelIzquierdo.Controls.Add(this.IBtnEmpleado);
            this.PanelIzquierdo.Controls.Add(this.IBtnVenta);
            this.PanelIzquierdo.Controls.Add(this.IBtnReservacion);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(206, 637);
            this.PanelIzquierdo.TabIndex = 16;
            this.PanelIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelIzquierdo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 52;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton1.Location = new System.Drawing.Point(1, 592);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(205, 44);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Cerrar Sesion";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // IBtnProveedor
            // 
            this.IBtnProveedor.FlatAppearance.BorderSize = 0;
            this.IBtnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.IBtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnProveedor.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.IBtnProveedor.IconColor = System.Drawing.Color.Black;
            this.IBtnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnProveedor.IconSize = 35;
            this.IBtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnProveedor.Location = new System.Drawing.Point(0, 476);
            this.IBtnProveedor.Name = "IBtnProveedor";
            this.IBtnProveedor.Size = new System.Drawing.Size(205, 37);
            this.IBtnProveedor.TabIndex = 7;
            this.IBtnProveedor.Text = "Proveedor";
            this.IBtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnProveedor.UseVisualStyleBackColor = true;
            this.IBtnProveedor.Click += new System.EventHandler(this.IBtnProveedor_Click_1);
            // 
            // IBtnCliente
            // 
            this.IBtnCliente.FlatAppearance.BorderSize = 0;
            this.IBtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.IBtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnCliente.IconChar = FontAwesome.Sharp.IconChar.Restroom;
            this.IBtnCliente.IconColor = System.Drawing.Color.Black;
            this.IBtnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnCliente.IconSize = 35;
            this.IBtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnCliente.Location = new System.Drawing.Point(0, 389);
            this.IBtnCliente.Name = "IBtnCliente";
            this.IBtnCliente.Size = new System.Drawing.Size(205, 37);
            this.IBtnCliente.TabIndex = 6;
            this.IBtnCliente.Text = "Cliente";
            this.IBtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnCliente.UseVisualStyleBackColor = true;
            this.IBtnCliente.Click += new System.EventHandler(this.IBtnCliente_Click);
            // 
            // IBtnCarta
            // 
            this.IBtnCarta.FlatAppearance.BorderSize = 0;
            this.IBtnCarta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.IBtnCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnCarta.IconChar = FontAwesome.Sharp.IconChar.Hotdog;
            this.IBtnCarta.IconColor = System.Drawing.Color.Black;
            this.IBtnCarta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnCarta.IconSize = 35;
            this.IBtnCarta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnCarta.Location = new System.Drawing.Point(0, 218);
            this.IBtnCarta.Name = "IBtnCarta";
            this.IBtnCarta.Size = new System.Drawing.Size(205, 37);
            this.IBtnCarta.TabIndex = 1;
            this.IBtnCarta.Text = "Carta";
            this.IBtnCarta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnCarta.UseVisualStyleBackColor = true;
            this.IBtnCarta.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // IBtnCompra
            // 
            this.IBtnCompra.FlatAppearance.BorderSize = 0;
            this.IBtnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.IBtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnCompra.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.IBtnCompra.IconColor = System.Drawing.Color.Black;
            this.IBtnCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnCompra.IconSize = 35;
            this.IBtnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnCompra.Location = new System.Drawing.Point(0, 432);
            this.IBtnCompra.Name = "IBtnCompra";
            this.IBtnCompra.Size = new System.Drawing.Size(205, 37);
            this.IBtnCompra.TabIndex = 5;
            this.IBtnCompra.Text = "Compra";
            this.IBtnCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnCompra.UseVisualStyleBackColor = true;
            this.IBtnCompra.Click += new System.EventHandler(this.IBtnCompra_Click);
            // 
            // IBtnEmpleado
            // 
            this.IBtnEmpleado.FlatAppearance.BorderSize = 0;
            this.IBtnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.IBtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnEmpleado.IconChar = FontAwesome.Sharp.IconChar.StreetView;
            this.IBtnEmpleado.IconColor = System.Drawing.Color.Black;
            this.IBtnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnEmpleado.IconSize = 35;
            this.IBtnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnEmpleado.Location = new System.Drawing.Point(0, 179);
            this.IBtnEmpleado.Name = "IBtnEmpleado";
            this.IBtnEmpleado.Size = new System.Drawing.Size(205, 37);
            this.IBtnEmpleado.TabIndex = 2;
            this.IBtnEmpleado.Text = "Empleado";
            this.IBtnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnEmpleado.UseVisualStyleBackColor = true;
            this.IBtnEmpleado.Click += new System.EventHandler(this.IBtnEmpleado_Click);
            // 
            // IBtnVenta
            // 
            this.IBtnVenta.FlatAppearance.BorderSize = 0;
            this.IBtnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.IBtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnVenta.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.IBtnVenta.IconColor = System.Drawing.Color.Black;
            this.IBtnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnVenta.IconSize = 35;
            this.IBtnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnVenta.Location = new System.Drawing.Point(0, 258);
            this.IBtnVenta.Name = "IBtnVenta";
            this.IBtnVenta.Size = new System.Drawing.Size(205, 37);
            this.IBtnVenta.TabIndex = 4;
            this.IBtnVenta.Text = "Venta";
            this.IBtnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnVenta.UseVisualStyleBackColor = true;
            this.IBtnVenta.Click += new System.EventHandler(this.IBtnVenta_Click);
            // 
            // IBtnReservacion
            // 
            this.IBtnReservacion.FlatAppearance.BorderSize = 0;
            this.IBtnReservacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.IBtnReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnReservacion.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.IBtnReservacion.IconColor = System.Drawing.Color.Black;
            this.IBtnReservacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnReservacion.IconSize = 35;
            this.IBtnReservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnReservacion.Location = new System.Drawing.Point(0, 303);
            this.IBtnReservacion.Name = "IBtnReservacion";
            this.IBtnReservacion.Size = new System.Drawing.Size(205, 37);
            this.IBtnReservacion.TabIndex = 3;
            this.IBtnReservacion.Text = "Reservacion";
            this.IBtnReservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnReservacion.UseVisualStyleBackColor = true;
            this.IBtnReservacion.Click += new System.EventHandler(this.IBtnReservacion_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.Transparent;
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCentral.Location = new System.Drawing.Point(206, 0);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(902, 637);
            this.PanelCentral.TabIndex = 17;
            this.PanelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCentral_Paint);
            // 
            // ProgesoBarra
            // 
            this.ProgesoBarra.Tick += new System.EventHandler(this.ProgesoBarra_Tick);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 346);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(205, 37);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "Usuario";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 637);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelIzquierdo);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.PanelIzquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Timer ProgesoBarra;
        private FontAwesome.Sharp.IconButton IBtnProveedor;
        private FontAwesome.Sharp.IconButton IBtnCliente;
        private FontAwesome.Sharp.IconButton IBtnCompra;
        private FontAwesome.Sharp.IconButton IBtnVenta;
        private FontAwesome.Sharp.IconButton IBtnReservacion;
        private FontAwesome.Sharp.IconButton IBtnEmpleado;
        private FontAwesome.Sharp.IconButton IBtnCarta;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}