﻿namespace Monte_Carlos.Cliente
{
    partial class Insertar_Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsertarCliente = new System.Windows.Forms.Button();
            this.dvClientes = new System.Windows.Forms.DataGridView();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.AllowDrop = true;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(369, 138);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(468, 35);
            this.txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(371, 69);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(468, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre:";
            // 
            // txtInsertarCliente
            // 
            this.txtInsertarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.txtInsertarCliente.FlatAppearance.BorderSize = 0;
            this.txtInsertarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtInsertarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsertarCliente.ForeColor = System.Drawing.Color.Black;
            this.txtInsertarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtInsertarCliente.Location = new System.Drawing.Point(371, 266);
            this.txtInsertarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInsertarCliente.Name = "txtInsertarCliente";
            this.txtInsertarCliente.Size = new System.Drawing.Size(468, 46);
            this.txtInsertarCliente.TabIndex = 4;
            this.txtInsertarCliente.Text = "Agregar";
            this.txtInsertarCliente.UseVisualStyleBackColor = false;
            this.txtInsertarCliente.Click += new System.EventHandler(this.txtInsertarCliente_Click);
            // 
            // dvClientes
            // 
            this.dvClientes.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvClientes.Location = new System.Drawing.Point(371, 415);
            this.dvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvClientes.Name = "dvClientes";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dvClientes.RowHeadersWidth = 51;
            this.dvClientes.Size = new System.Drawing.Size(468, 190);
            this.dvClientes.TabIndex = 7;
            this.dvClientes.SelectionChanged += new System.EventHandler(this.dvClientes_SelectionChanged);
            this.dvClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvClientes_MouseClick);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AccessibleDescription = "";
            this.txtTelefono.AllowDrop = true;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(371, 207);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(467, 35);
            this.txtTelefono.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 30);
            this.label4.TabIndex = 45;
            this.label4.Text = "Número de teléfono:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 52;
            this.btnEliminar.Location = new System.Drawing.Point(785, 357);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(52, 50);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo1
            // 
            this.btnNuevo1.FlatAppearance.BorderSize = 0;
            this.btnNuevo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNuevo1.IconColor = System.Drawing.Color.Black;
            this.btnNuevo1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo1.IconSize = 52;
            this.btnNuevo1.Location = new System.Drawing.Point(725, 357);
            this.btnNuevo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo1.Name = "btnNuevo1";
            this.btnNuevo1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnNuevo1.Size = new System.Drawing.Size(52, 50);
            this.btnNuevo1.TabIndex = 5;
            this.btnNuevo1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo1.UseVisualStyleBackColor = true;
            this.btnNuevo1.Click += new System.EventHandler(this.btnNuevo1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Lista de clientes";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.txtInsertarCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNuevo1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dvClientes);
            this.panel1.Location = new System.Drawing.Point(-150, -80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 644);
            this.panel1.TabIndex = 1;
            // 
            // Insertar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 512);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Insertar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar_Cliente";
            this.Load += new System.EventHandler(this.Insertar_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtInsertarCliente;
        private System.Windows.Forms.DataGridView dvClientes;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnNuevo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}