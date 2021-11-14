
namespace Monte_Carlos.Usuarios
{
    partial class Ingresar_Usuarios
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
            this.txtRepetirContrasena = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBorrarUsusario = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepetirContrasena
            // 
            this.txtRepetirContrasena.AllowDrop = true;
            this.txtRepetirContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirContrasena.Location = new System.Drawing.Point(226, 275);
            this.txtRepetirContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRepetirContrasena.Multiline = true;
            this.txtRepetirContrasena.Name = "txtRepetirContrasena";
            this.txtRepetirContrasena.PasswordChar = '*';
            this.txtRepetirContrasena.Size = new System.Drawing.Size(351, 24);
            this.txtRepetirContrasena.TabIndex = 61;
            // 
            // txtPassword
            // 
            this.txtPassword.AllowDrop = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(226, 197);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(351, 24);
            this.txtPassword.TabIndex = 60;
            // 
            // txtUsername
            // 
            this.txtUsername.AllowDrop = true;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(226, 130);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(351, 24);
            this.txtUsername.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Username";
            // 
            // txtGuardar
            // 
            this.txtGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(51)))));
            this.txtGuardar.FlatAppearance.BorderSize = 0;
            this.txtGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardar.ForeColor = System.Drawing.Color.Black;
            this.txtGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtGuardar.Location = new System.Drawing.Point(226, 316);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(351, 37);
            this.txtGuardar.TabIndex = 68;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.UseVisualStyleBackColor = false;
            this.txtGuardar.Click += new System.EventHandler(this.txtGuardar_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 24);
            this.label5.TabIndex = 69;
            this.label5.Text = "Repita la Contraseña";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 70;
            this.label7.Text = "Password";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Creación de usuarios";
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Location = new System.Drawing.Point(614, 139);
            this.lblIdUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(27, 13);
            this.lblIdUser.TabIndex = 72;
            this.lblIdUser.Text = "user";
            this.lblIdUser.Visible = false;
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(205, 407);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.Size = new System.Drawing.Size(392, 171);
            this.dgUsuarios.TabIndex = 73;
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
            this.btnBorrarUsusario.Location = new System.Drawing.Point(555, 359);
            this.btnBorrarUsusario.Name = "btnBorrarUsusario";
            this.btnBorrarUsusario.Size = new System.Drawing.Size(39, 42);
            this.btnBorrarUsusario.TabIndex = 74;
            this.btnBorrarUsusario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarUsusario.UseVisualStyleBackColor = true;
            this.btnBorrarUsusario.Click += new System.EventHandler(this.btnBorrarUsusario_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnNuevo.IconColor = System.Drawing.Color.Black;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 52;
            this.btnNuevo.Location = new System.Drawing.Point(502, 359);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(39, 42);
            this.btnNuevo.TabIndex = 75;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Ingresar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBorrarUsusario);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRepetirContrasena);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar_Usuarios";
            this.Load += new System.EventHandler(this.Ingresar_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRepetirContrasena;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private FontAwesome.Sharp.IconButton btnBorrarUsusario;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}