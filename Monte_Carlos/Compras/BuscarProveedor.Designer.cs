
namespace Monte_Carlos.Compras
{
    partial class BuscarProveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscaProveedor = new System.Windows.Forms.TextBox();
            this.dvProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Buscar Proveedor";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre:";
            // 
            // txtbuscaProveedor
            // 
            this.txtbuscaProveedor.AllowDrop = true;
            this.txtbuscaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscaProveedor.Location = new System.Drawing.Point(167, 95);
            this.txtbuscaProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscaProveedor.Multiline = true;
            this.txtbuscaProveedor.Name = "txtbuscaProveedor";
            this.txtbuscaProveedor.Size = new System.Drawing.Size(352, 29);
            this.txtbuscaProveedor.TabIndex = 40;
            // 
            // dvProveedores
            // 
            this.dvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvProveedores.Location = new System.Drawing.Point(59, 136);
            this.dvProveedores.Name = "dvProveedores";
            this.dvProveedores.Size = new System.Drawing.Size(539, 198);
            this.dvProveedores.TabIndex = 39;
            this.dvProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvProveedores_CellDoubleClick);
            // 
            // BuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbuscaProveedor);
            this.Controls.Add(this.dvProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscarProveedor";
            this.Load += new System.EventHandler(this.BuscarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscaProveedor;
        private System.Windows.Forms.DataGridView dvProveedores;
    }
}