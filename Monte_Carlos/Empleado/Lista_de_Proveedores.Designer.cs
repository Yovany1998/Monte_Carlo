﻿
namespace Monte_Carlos.Empleado
{
    partial class Lista_de_Proveedores
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
            this.dgProveedores = new System.Windows.Forms.DataGridView();
            this.icoBuscarProveedores = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscarProveedores = new System.Windows.Forms.TextBox();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoBuscarProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProveedores
            // 
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(265, 217);
            this.dgProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.RowHeadersWidth = 51;
            this.dgProveedores.Size = new System.Drawing.Size(523, 211);
            this.dgProveedores.TabIndex = 56;
            // 
            // icoBuscarProveedores
            // 
            this.icoBuscarProveedores.BackColor = System.Drawing.Color.White;
            this.icoBuscarProveedores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icoBuscarProveedores.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icoBuscarProveedores.IconColor = System.Drawing.SystemColors.ControlText;
            this.icoBuscarProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBuscarProveedores.IconSize = 39;
            this.icoBuscarProveedores.Location = new System.Drawing.Point(265, 135);
            this.icoBuscarProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.icoBuscarProveedores.Name = "icoBuscarProveedores";
            this.icoBuscarProveedores.Size = new System.Drawing.Size(43, 39);
            this.icoBuscarProveedores.TabIndex = 55;
            this.icoBuscarProveedores.TabStop = false;
            // 
            // txtBuscarProveedores
            // 
            this.txtBuscarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProveedores.Location = new System.Drawing.Point(332, 135);
            this.txtBuscarProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProveedores.Name = "txtBuscarProveedores";
            this.txtBuscarProveedores.Size = new System.Drawing.Size(327, 30);
            this.txtBuscarProveedores.TabIndex = 54;
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.BackColor = System.Drawing.Color.Transparent;
            this.lblListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblListaProveedores.Location = new System.Drawing.Point(261, 79);
            this.lblListaProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(207, 24);
            this.lblListaProveedores.TabIndex = 53;
            this.lblListaProveedores.Text = "Lista de Proveedores";
            // 
            // Lista_de_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 507);
            this.Controls.Add(this.dgProveedores);
            this.Controls.Add(this.icoBuscarProveedores);
            this.Controls.Add(this.txtBuscarProveedores);
            this.Controls.Add(this.lblListaProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_de_Proveedores";
            this.Text = "Lista_de_Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoBuscarProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProveedores;
        private FontAwesome.Sharp.IconPictureBox icoBuscarProveedores;
        private System.Windows.Forms.TextBox txtBuscarProveedores;
        private System.Windows.Forms.Label lblListaProveedores;
    }
}