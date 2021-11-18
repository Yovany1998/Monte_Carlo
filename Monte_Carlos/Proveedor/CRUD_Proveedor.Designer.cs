
namespace Monte_Carlos.Proveedor
{
    partial class CRUD_Proveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInsertarProveedor = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.dgProvedores = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDeContacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProvedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInsertarProveedor);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.dgProvedores);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRTN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombreDeContacto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumeroTelefono);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmpresa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 802);
            this.panel1.TabIndex = 2;
            // 
            // lblInsertarProveedor
            // 
            this.lblInsertarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertarProveedor.Location = new System.Drawing.Point(283, 7);
            this.lblInsertarProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsertarProveedor.Name = "lblInsertarProveedor";
            this.lblInsertarProveedor.Size = new System.Drawing.Size(218, 24);
            this.lblInsertarProveedor.TabIndex = 50;
            this.lblInsertarProveedor.Text = "Insertar Proveedores";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 52;
            this.btnEliminar.Location = new System.Drawing.Point(758, 420);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(39, 42);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnNuevo.IconColor = System.Drawing.Color.Black;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 52;
            this.btnNuevo.Location = new System.Drawing.Point(706, 420);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(39, 42);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgProvedores
            // 
            this.dgProvedores.BackgroundColor = System.Drawing.Color.White;
            this.dgProvedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProvedores.Location = new System.Drawing.Point(2, 467);
            this.dgProvedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgProvedores.Name = "dgProvedores";
            this.dgProvedores.RowHeadersWidth = 51;
            this.dgProvedores.RowTemplate.Height = 24;
            this.dgProvedores.Size = new System.Drawing.Size(794, 271);
            this.dgProvedores.TabIndex = 9;
            this.dgProvedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProvedores_CellContentClick);
            this.dgProvedores.SelectionChanged += new System.EventHandler(this.dgProvedores_SelectionChanged);
            this.dgProvedores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgProvedores_MouseMove);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(0, 359);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(794, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(0, 241);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(795, 97);
            this.txtObservacion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 429);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lista de proveedores";
            // 
            // txtRTN
            // 
            this.txtRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRTN.Location = new System.Drawing.Point(410, 173);
            this.txtRTN.Margin = new System.Windows.Forms.Padding(2);
            this.txtRTN.MaxLength = 14;
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(386, 26);
            this.txtRTN.TabIndex = 4;
            this.txtRTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRTN_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Observacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "RTN";
            // 
            // txtNombreDeContacto
            // 
            this.txtNombreDeContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeContacto.Location = new System.Drawing.Point(0, 173);
            this.txtNombreDeContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDeContacto.Name = "txtNombreDeContacto";
            this.txtNombreDeContacto.Size = new System.Drawing.Size(386, 26);
            this.txtNombreDeContacto.TabIndex = 3;
            this.txtNombreDeContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDeContacto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre de contacto";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTelefono.Location = new System.Drawing.Point(410, 94);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(386, 26);
            this.txtNumeroTelefono.TabIndex = 2;
            this.txtNumeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero de telefono";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(0, 94);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(386, 26);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // CRUD_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 555);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUD_Proveedor";
            this.Text = "CRUD_Proveedor";
            this.Load += new System.EventHandler(this.CRUD_Proveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProvedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private System.Windows.Forms.DataGridView dgProvedores;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreDeContacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInsertarProveedor;
    }
}