namespace Registros_ABC__SQLServer
{
    partial class frmRegistro_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro_Usuario));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblConfir_Contrasena = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtConfir_Contrasena = new System.Windows.Forms.TextBox();
            this.lblRegistro_Usuarios = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(49, 135);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(67, 13);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña :";
            // 
            // lblConfir_Contrasena
            // 
            this.lblConfir_Contrasena.AutoSize = true;
            this.lblConfir_Contrasena.Location = new System.Drawing.Point(49, 178);
            this.lblConfir_Contrasena.Name = "lblConfir_Contrasena";
            this.lblConfir_Contrasena.Size = new System.Drawing.Size(111, 13);
            this.lblConfir_Contrasena.TabIndex = 2;
            this.lblConfir_Contrasena.Text = "Confirme Contraseña :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(166, 132);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(172, 20);
            this.txtContrasena.TabIndex = 4;
            // 
            // txtConfir_Contrasena
            // 
            this.txtConfir_Contrasena.Location = new System.Drawing.Point(166, 175);
            this.txtConfir_Contrasena.Name = "txtConfir_Contrasena";
            this.txtConfir_Contrasena.PasswordChar = '*';
            this.txtConfir_Contrasena.Size = new System.Drawing.Size(172, 20);
            this.txtConfir_Contrasena.TabIndex = 5;
            // 
            // lblRegistro_Usuarios
            // 
            this.lblRegistro_Usuarios.AutoSize = true;
            this.lblRegistro_Usuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro_Usuarios.Location = new System.Drawing.Point(116, 20);
            this.lblRegistro_Usuarios.Name = "lblRegistro_Usuarios";
            this.lblRegistro_Usuarios.Size = new System.Drawing.Size(295, 32);
            this.lblRegistro_Usuarios.TabIndex = 6;
            this.lblRegistro_Usuarios.Text = "Registro De Usuarios";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::Registros_ABC__SQLServer.Properties.Resources.checkmark;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(102, 256);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 31);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Registros_ABC__SQLServer.Properties.Resources.delete__2_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(350, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Registros_ABC__SQLServer.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(394, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegistro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 314);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblRegistro_Usuarios);
            this.Controls.Add(this.txtConfir_Contrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblConfir_Contrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro_Usuario";
            this.Text = "Registro Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblConfir_Contrasena;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtConfir_Contrasena;
        private System.Windows.Forms.Label lblRegistro_Usuarios;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}