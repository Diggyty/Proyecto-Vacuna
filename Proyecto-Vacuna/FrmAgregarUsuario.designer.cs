namespace Proyecto_Vacuna
{
    partial class FrmAgregarUsuario
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
            this.GbxRegistro = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnRegistrarse = new Guna.UI2.WinForms.Guna2Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtConfirmPass = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LblPassword2 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblNombreD = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.GbxRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxRegistro
            // 
            this.GbxRegistro.Controls.Add(this.BtnRegistrarse);
            this.GbxRegistro.Controls.Add(this.LblPassword);
            this.GbxRegistro.Controls.Add(this.TxtConfirmPass);
            this.GbxRegistro.Controls.Add(this.TxtPass);
            this.GbxRegistro.Controls.Add(this.LblPassword2);
            this.GbxRegistro.Controls.Add(this.LblUserName);
            this.GbxRegistro.Controls.Add(this.LblNombreD);
            this.GbxRegistro.Controls.Add(this.TxtUsername);
            this.GbxRegistro.Controls.Add(this.txtnombre);
            this.GbxRegistro.CustomBorderColor = System.Drawing.Color.PaleGoldenrod;
            this.GbxRegistro.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.GbxRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbxRegistro.ForeColor = System.Drawing.Color.Black;
            this.GbxRegistro.Location = new System.Drawing.Point(12, 12);
            this.GbxRegistro.Name = "GbxRegistro";
            this.GbxRegistro.ShadowDecoration.Parent = this.GbxRegistro;
            this.GbxRegistro.Size = new System.Drawing.Size(377, 480);
            this.GbxRegistro.TabIndex = 0;
            this.GbxRegistro.Text = "Registro usuario";
            this.GbxRegistro.Click += new System.EventHandler(this.GbxRegistro_Click);
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.CheckedState.Parent = this.BtnRegistrarse;
            this.BtnRegistrarse.CustomImages.Parent = this.BtnRegistrarse;
            this.BtnRegistrarse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarse.HoverState.Parent = this.BtnRegistrarse;
            this.BtnRegistrarse.Location = new System.Drawing.Point(38, 383);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.ShadowDecoration.Parent = this.BtnRegistrarse;
            this.BtnRegistrarse.Size = new System.Drawing.Size(180, 45);
            this.BtnRegistrarse.TabIndex = 30;
            this.BtnRegistrarse.Text = "Registrarse";
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(22, 228);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(67, 15);
            this.LblPassword.TabIndex = 29;
            this.LblPassword.Text = "Contraseña";
            // 
            // TxtConfirmPass
            // 
            this.TxtConfirmPass.Location = new System.Drawing.Point(25, 317);
            this.TxtConfirmPass.Name = "TxtConfirmPass";
            this.TxtConfirmPass.Size = new System.Drawing.Size(231, 23);
            this.TxtConfirmPass.TabIndex = 28;
            this.TxtConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConfirmPass_KeyPress);
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(25, 257);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(231, 23);
            this.TxtPass.TabIndex = 27;
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // LblPassword2
            // 
            this.LblPassword2.AutoSize = true;
            this.LblPassword2.Location = new System.Drawing.Point(22, 289);
            this.LblPassword2.Name = "LblPassword2";
            this.LblPassword2.Size = new System.Drawing.Size(122, 15);
            this.LblPassword2.TabIndex = 26;
            this.LblPassword2.Text = "Confirmar contraseña";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(22, 157);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(94, 15);
            this.LblUserName.TabIndex = 25;
            this.LblUserName.Text = "Nombre Usuario";
            // 
            // LblNombreD
            // 
            this.LblNombreD.AutoSize = true;
            this.LblNombreD.Location = new System.Drawing.Point(22, 97);
            this.LblNombreD.Name = "LblNombreD";
            this.LblNombreD.Size = new System.Drawing.Size(51, 15);
            this.LblNombreD.TabIndex = 23;
            this.LblNombreD.Text = "Nombre";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(25, 186);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(231, 23);
            this.TxtUsername.TabIndex = 22;
            this.TxtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsername_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(25, 125);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(231, 23);
            this.txtnombre.TabIndex = 20;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // FrmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 496);
            this.Controls.Add(this.GbxRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarUsuario";
            this.Text = "FrmAgregarUsuario";
            this.Load += new System.EventHandler(this.FrmAgregarUsuario_Load);
            this.GbxRegistro.ResumeLayout(false);
            this.GbxRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbxRegistro;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblNombreD;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtConfirmPass;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LblPassword2;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrarse;
    }
}