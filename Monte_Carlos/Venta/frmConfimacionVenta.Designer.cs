
namespace Monte_Carlos.Venta
{
    partial class frmConfimacionVenta
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 74;
            this.iconPictureBox1.Location = new System.Drawing.Point(81, 32);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(81, 74);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(28, 172);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(193, 32);
            this.btnBuscarCliente.TabIndex = 34;
            this.btnBuscarCliente.Text = "Continuar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Total de venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Total de venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConfimacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 251);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfimacionVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfimacionVenta";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}