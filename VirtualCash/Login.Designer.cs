namespace VirtualCash
{
    partial class Login
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.LinkReestablecerClave = new System.Windows.Forms.LinkLabel();
            this.LinkNuevoRegistro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(37, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(37, 64);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(124, 61);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(158, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(311, 29);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(105, 48);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Iniciar sesión";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // LinkReestablecerClave
            // 
            this.LinkReestablecerClave.AutoSize = true;
            this.LinkReestablecerClave.Location = new System.Drawing.Point(203, 84);
            this.LinkReestablecerClave.Name = "LinkReestablecerClave";
            this.LinkReestablecerClave.Size = new System.Drawing.Size(79, 13);
            this.LinkReestablecerClave.TabIndex = 5;
            this.LinkReestablecerClave.TabStop = true;
            this.LinkReestablecerClave.Text = "Olvidé mi clave";
            // 
            // LinkNuevoRegistro
            // 
            this.LinkNuevoRegistro.AutoSize = true;
            this.LinkNuevoRegistro.Location = new System.Drawing.Point(222, 106);
            this.LinkNuevoRegistro.Name = "LinkNuevoRegistro";
            this.LinkNuevoRegistro.Size = new System.Drawing.Size(60, 13);
            this.LinkNuevoRegistro.TabIndex = 6;
            this.LinkNuevoRegistro.TabStop = true;
            this.LinkNuevoRegistro.Text = "Registrarse";
            this.LinkNuevoRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkNuevoRegistro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 143);
            this.Controls.Add(this.LinkNuevoRegistro);
            this.Controls.Add(this.LinkReestablecerClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblID);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel LinkReestablecerClave;
        private System.Windows.Forms.LinkLabel LinkNuevoRegistro;
    }
}