
namespace Monte_Carlos.Usuarios
{
    partial class Administrar_Usuarios
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
            this.lblAdministrarUsusarios = new System.Windows.Forms.Label();
            this.icoBuscarUsuarios = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscarUsuarios = new System.Windows.Forms.TextBox();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBorrarUsusario = new FontAwesome.Sharp.IconButton();
            this.icoActualizarUsusario = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.icoBuscarUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdministrarUsusarios
            // 
            this.lblAdministrarUsusarios.AutoSize = true;
            this.lblAdministrarUsusarios.BackColor = System.Drawing.Color.Transparent;
            this.lblAdministrarUsusarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrarUsusarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdministrarUsusarios.Location = new System.Drawing.Point(257, 54);
            this.lblAdministrarUsusarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdministrarUsusarios.Name = "lblAdministrarUsusarios";
            this.lblAdministrarUsusarios.Size = new System.Drawing.Size(275, 24);
            this.lblAdministrarUsusarios.TabIndex = 42;
            this.lblAdministrarUsusarios.Text = "Administracion de Ususarios";
            // 
            // icoBuscarUsuarios
            // 
            this.icoBuscarUsuarios.BackColor = System.Drawing.Color.White;
            this.icoBuscarUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icoBuscarUsuarios.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icoBuscarUsuarios.IconColor = System.Drawing.SystemColors.ControlText;
            this.icoBuscarUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBuscarUsuarios.IconSize = 39;
            this.icoBuscarUsuarios.Location = new System.Drawing.Point(261, 110);
            this.icoBuscarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.icoBuscarUsuarios.Name = "icoBuscarUsuarios";
            this.icoBuscarUsuarios.Size = new System.Drawing.Size(43, 39);
            this.icoBuscarUsuarios.TabIndex = 51;
            this.icoBuscarUsuarios.TabStop = false;
            this.icoBuscarUsuarios.Click += new System.EventHandler(this.icoBuscarUsuarios_Click);
            // 
            // txtBuscarUsuarios
            // 
            this.txtBuscarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuarios.Location = new System.Drawing.Point(328, 110);
            this.txtBuscarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarUsuarios.Name = "txtBuscarUsuarios";
            this.txtBuscarUsuarios.Size = new System.Drawing.Size(327, 30);
            this.txtBuscarUsuarios.TabIndex = 50;
            this.txtBuscarUsuarios.TextChanged += new System.EventHandler(this.txtBuscarUsuarios_TextChanged);
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(261, 192);
            this.dgUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.Size = new System.Drawing.Size(523, 211);
            this.dgUsuarios.TabIndex = 52;
            this.dgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellDoubleClick);
            this.dgUsuarios.SelectionChanged += new System.EventHandler(this.dgUsuarios_SelectionChanged);
            this.dgUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgUsuarios_MouseClick);
            // 
            // btnBorrarUsusario
            // 
            this.btnBorrarUsusario.FlatAppearance.BorderSize = 0;
            this.btnBorrarUsusario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarUsusario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnBorrarUsusario.IconColor = System.Drawing.Color.Black;
            this.btnBorrarUsusario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrarUsusario.IconSize = 52;
            this.btnBorrarUsusario.Location = new System.Drawing.Point(663, 110);
            this.btnBorrarUsusario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarUsusario.Name = "btnBorrarUsusario";
            this.btnBorrarUsusario.Size = new System.Drawing.Size(52, 52);
            this.btnBorrarUsusario.TabIndex = 53;
            this.btnBorrarUsusario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarUsusario.UseVisualStyleBackColor = true;
            this.btnBorrarUsusario.Click += new System.EventHandler(this.btnBorrarUsusario_Click);
            // 
            // icoActualizarUsusario
            // 
            this.icoActualizarUsusario.FlatAppearance.BorderSize = 0;
            this.icoActualizarUsusario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoActualizarUsusario.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.icoActualizarUsusario.IconColor = System.Drawing.Color.Black;
            this.icoActualizarUsusario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoActualizarUsusario.IconSize = 52;
            this.icoActualizarUsusario.Location = new System.Drawing.Point(732, 110);
            this.icoActualizarUsusario.Margin = new System.Windows.Forms.Padding(4);
            this.icoActualizarUsusario.Name = "icoActualizarUsusario";
            this.icoActualizarUsusario.Size = new System.Drawing.Size(52, 52);
            this.icoActualizarUsusario.TabIndex = 54;
            this.icoActualizarUsusario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoActualizarUsusario.UseVisualStyleBackColor = true;
            this.icoActualizarUsusario.Click += new System.EventHandler(this.icoActualizarUsusario_Click);
            // 
            // Administrar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 507);
            this.Controls.Add(this.icoActualizarUsusario);
            this.Controls.Add(this.btnBorrarUsusario);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.icoBuscarUsuarios);
            this.Controls.Add(this.txtBuscarUsuarios);
            this.Controls.Add(this.lblAdministrarUsusarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrar_Usuarios";
            this.Text = "Administrar_Usuarios";
            this.Load += new System.EventHandler(this.Administrar_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icoBuscarUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministrarUsusarios;
        private FontAwesome.Sharp.IconPictureBox icoBuscarUsuarios;
        private System.Windows.Forms.TextBox txtBuscarUsuarios;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private FontAwesome.Sharp.IconButton btnBorrarUsusario;
        private FontAwesome.Sharp.IconButton icoActualizarUsusario;
    }
}