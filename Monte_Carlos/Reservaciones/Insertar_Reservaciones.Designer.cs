namespace Monte_Carlos.Reservaciones
{
    partial class Insertar_Reservaciones
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
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.lblMesa = new System.Windows.Forms.Label();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.btnAgregarReservacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.dgListaReservaciones = new System.Windows.Forms.DataGridView();
            this.lblInsertarReservacion = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(307, 147);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(273, 26);
            this.Fecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(304, 128);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 24);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(307, 68);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(273, 26);
            this.txtNombreCompleto.TabIndex = 32;
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(307, 94);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(193, 32);
            this.btnBuscarCliente.TabIndex = 33;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblMesa
            // 
            this.lblMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(304, 192);
            this.lblMesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(99, 24);
            this.lblMesa.TabIndex = 36;
            this.lblMesa.Text = "Mesa";
            // 
            // txtMesa
            // 
            this.txtMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.Location = new System.Drawing.Point(307, 212);
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(273, 26);
            this.txtMesa.TabIndex = 37;
            // 
            // btnAgregarReservacion
            // 
            this.btnAgregarReservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.btnAgregarReservacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReservacion.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarReservacion.Location = new System.Drawing.Point(307, 242);
            this.btnAgregarReservacion.Name = "btnAgregarReservacion";
            this.btnAgregarReservacion.Size = new System.Drawing.Size(273, 42);
            this.btnAgregarReservacion.TabIndex = 38;
            this.btnAgregarReservacion.Text = "Agregar";
            this.btnAgregarReservacion.UseVisualStyleBackColor = false;
            this.btnAgregarReservacion.Click += new System.EventHandler(this.btnAgregarReservacion_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Lista de reservaciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 52;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(624, 289);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgListaReservaciones
            // 
            this.dgListaReservaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgListaReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaReservaciones.Location = new System.Drawing.Point(231, 338);
            this.dgListaReservaciones.Name = "dgListaReservaciones";
            this.dgListaReservaciones.Size = new System.Drawing.Size(448, 150);
            this.dgListaReservaciones.TabIndex = 43;
            this.dgListaReservaciones.SelectionChanged += new System.EventHandler(this.dgListaReservaciones_SelectionChanged);
            this.dgListaReservaciones.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgListaReservaciones_MouseMove);
            // 
            // lblInsertarReservacion
            // 
            this.lblInsertarReservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertarReservacion.Location = new System.Drawing.Point(340, 9);
            this.lblInsertarReservacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsertarReservacion.Name = "lblInsertarReservacion";
            this.lblInsertarReservacion.Size = new System.Drawing.Size(220, 24);
            this.lblInsertarReservacion.TabIndex = 50;
            this.lblInsertarReservacion.Text = "Insertar Reservacion";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 52;
            this.btnLimpiar.Location = new System.Drawing.Point(582, 293);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(39, 42);
            this.btnLimpiar.TabIndex = 76;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Insertar_Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 499);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblInsertarReservacion);
            this.Controls.Add(this.dgListaReservaciones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarReservacion);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Insertar_Reservaciones";
            this.Text = "Insertar_Reservaciones";
            this.Load += new System.EventHandler(this.Insertar_Reservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaReservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.Button btnAgregarReservacion;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.DataGridView dgListaReservaciones;
        private System.Windows.Forms.Label lblInsertarReservacion;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}