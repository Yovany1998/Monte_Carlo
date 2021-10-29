
namespace Monte_Carlos.Cliente
{
    partial class Lista_Clientes
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
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.dgListaClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Enabled = false;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(219, 112);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(448, 30);
            this.txtBuscarCliente.TabIndex = 49;
            // 
            // dgListaClientes
            // 
            this.dgListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaClientes.Location = new System.Drawing.Point(164, 168);
            this.dgListaClientes.Name = "dgListaClientes";
            this.dgListaClientes.RowHeadersWidth = 51;
            this.dgListaClientes.RowTemplate.Height = 24;
            this.dgListaClientes.Size = new System.Drawing.Size(503, 388);
            this.dgListaClientes.TabIndex = 51;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 39;
            this.btnBuscar.Location = new System.Drawing.Point(164, 107);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(43, 39);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Lista de clientes";
            // 
            // Lista_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgListaClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarCliente);
            this.Name = "Lista_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarCliente;
        private FontAwesome.Sharp.IconPictureBox btnBuscar;
        private System.Windows.Forms.DataGridView dgListaClientes;
        private System.Windows.Forms.Label label1;
    }
}