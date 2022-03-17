namespace Proyect_vacuna
{
    partial class FrmAgregarPaciente
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
            this.GroupBoxDatospaciente = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccionP = new System.Windows.Forms.Label();
            this.FechaNac = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LblfechaNacP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.LblApellidoD = new System.Windows.Forms.Label();
            this.TxtApellidoD = new System.Windows.Forms.TextBox();
            this.LblNombreD = new System.Windows.Forms.Label();
            this.TxtNombreD = new System.Windows.Forms.TextBox();
            this.LblCedulaD = new System.Windows.Forms.Label();
            this.TxtCedulaD = new System.Windows.Forms.TextBox();
            this.GroupBoxDatospaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxDatospaciente
            // 
            this.GroupBoxDatospaciente.Controls.Add(this.label3);
            this.GroupBoxDatospaciente.Controls.Add(this.BtnCancelar);
            this.GroupBoxDatospaciente.Controls.Add(this.BtnRegistrar);
            this.GroupBoxDatospaciente.Controls.Add(this.TxtTelefono);
            this.GroupBoxDatospaciente.Controls.Add(this.label2);
            this.GroupBoxDatospaciente.Controls.Add(this.TxtDireccion);
            this.GroupBoxDatospaciente.Controls.Add(this.LblDireccionP);
            this.GroupBoxDatospaciente.Controls.Add(this.FechaNac);
            this.GroupBoxDatospaciente.Controls.Add(this.LblfechaNacP);
            this.GroupBoxDatospaciente.Controls.Add(this.label1);
            this.GroupBoxDatospaciente.Controls.Add(this.CmbSexo);
            this.GroupBoxDatospaciente.Controls.Add(this.LblApellidoD);
            this.GroupBoxDatospaciente.Controls.Add(this.TxtApellidoD);
            this.GroupBoxDatospaciente.Controls.Add(this.LblNombreD);
            this.GroupBoxDatospaciente.Controls.Add(this.TxtNombreD);
            this.GroupBoxDatospaciente.Controls.Add(this.LblCedulaD);
            this.GroupBoxDatospaciente.Controls.Add(this.TxtCedulaD);
            this.GroupBoxDatospaciente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupBoxDatospaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupBoxDatospaciente.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxDatospaciente.Name = "GroupBoxDatospaciente";
            this.GroupBoxDatospaciente.ShadowDecoration.Parent = this.GroupBoxDatospaciente;
            this.GroupBoxDatospaciente.Size = new System.Drawing.Size(686, 377);
            this.GroupBoxDatospaciente.TabIndex = 0;
            this.GroupBoxDatospaciente.Text = "Registro de Paciente";
            this.GroupBoxDatospaciente.Click += new System.EventHandler(this.GroupBoxDatospaciente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Datos Personales";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.CheckedState.Parent = this.BtnCancelar;
            this.BtnCancelar.CustomImages.Parent = this.BtnCancelar;
            this.BtnCancelar.FillColor = System.Drawing.Color.Silver;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.HoverState.Parent = this.BtnCancelar;
            this.BtnCancelar.Location = new System.Drawing.Point(341, 304);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.ShadowDecoration.Parent = this.BtnCancelar;
            this.BtnCancelar.Size = new System.Drawing.Size(94, 45);
            this.BtnCancelar.TabIndex = 29;
            this.BtnCancelar.Text = "Cancelar";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.CheckedState.Parent = this.BtnRegistrar;
            this.BtnRegistrar.CustomImages.Parent = this.BtnRegistrar;
            this.BtnRegistrar.FillColor = System.Drawing.Color.Silver;
            this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistrar.HoverState.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Location = new System.Drawing.Point(451, 304);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.ShadowDecoration.Parent = this.BtnRegistrar;
            this.BtnRegistrar.Size = new System.Drawing.Size(180, 45);
            this.BtnRegistrar.TabIndex = 28;
            this.BtnRegistrar.Text = "Registrar Datos";
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(182, 261);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(231, 23);
            this.TxtTelefono.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Numero Telefono";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(182, 236);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(231, 23);
            this.TxtDireccion.TabIndex = 25;
            // 
            // LblDireccionP
            // 
            this.LblDireccionP.AutoSize = true;
            this.LblDireccionP.Location = new System.Drawing.Point(71, 236);
            this.LblDireccionP.Name = "LblDireccionP";
            this.LblDireccionP.Size = new System.Drawing.Size(57, 15);
            this.LblDireccionP.TabIndex = 24;
            this.LblDireccionP.Text = "Dirección";
            // 
            // FechaNac
            // 
            this.FechaNac.CheckedState.Parent = this.FechaNac;
            this.FechaNac.FillColor = System.Drawing.Color.Silver;
            this.FechaNac.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaNac.ForeColor = System.Drawing.Color.Black;
            this.FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNac.HoverState.Parent = this.FechaNac;
            this.FechaNac.Location = new System.Drawing.Point(194, 206);
            this.FechaNac.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FechaNac.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ShadowDecoration.Parent = this.FechaNac;
            this.FechaNac.Size = new System.Drawing.Size(219, 23);
            this.FechaNac.TabIndex = 23;
            this.FechaNac.Value = new System.DateTime(2021, 5, 16, 19, 46, 35, 722);
            // 
            // LblfechaNacP
            // 
            this.LblfechaNacP.AutoSize = true;
            this.LblfechaNacP.Location = new System.Drawing.Point(71, 209);
            this.LblfechaNacP.Name = "LblfechaNacP";
            this.LblfechaNacP.Size = new System.Drawing.Size(117, 15);
            this.LblfechaNacP.TabIndex = 22;
            this.LblfechaNacP.Text = "Fecha de nacimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sexo";
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Location = new System.Drawing.Point(182, 177);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(231, 23);
            this.CmbSexo.TabIndex = 20;
            this.CmbSexo.SelectedIndexChanged += new System.EventHandler(this.CmbSexo_SelectedIndexChanged);
            // 
            // LblApellidoD
            // 
            this.LblApellidoD.AutoSize = true;
            this.LblApellidoD.Location = new System.Drawing.Point(71, 152);
            this.LblApellidoD.Name = "LblApellidoD";
            this.LblApellidoD.Size = new System.Drawing.Size(51, 15);
            this.LblApellidoD.TabIndex = 19;
            this.LblApellidoD.Text = "Apellido";
            // 
            // TxtApellidoD
            // 
            this.TxtApellidoD.Location = new System.Drawing.Point(182, 148);
            this.TxtApellidoD.Name = "TxtApellidoD";
            this.TxtApellidoD.Size = new System.Drawing.Size(231, 23);
            this.TxtApellidoD.TabIndex = 18;
            // 
            // LblNombreD
            // 
            this.LblNombreD.AutoSize = true;
            this.LblNombreD.Location = new System.Drawing.Point(71, 123);
            this.LblNombreD.Name = "LblNombreD";
            this.LblNombreD.Size = new System.Drawing.Size(51, 15);
            this.LblNombreD.TabIndex = 17;
            this.LblNombreD.Text = "Nombre";
            // 
            // TxtNombreD
            // 
            this.TxtNombreD.Location = new System.Drawing.Point(182, 119);
            this.TxtNombreD.Name = "TxtNombreD";
            this.TxtNombreD.Size = new System.Drawing.Size(231, 23);
            this.TxtNombreD.TabIndex = 16;
            this.TxtNombreD.TextChanged += new System.EventHandler(this.TxtNombreD_TextChanged);
            // 
            // LblCedulaD
            // 
            this.LblCedulaD.AutoSize = true;
            this.LblCedulaD.Location = new System.Drawing.Point(71, 94);
            this.LblCedulaD.Name = "LblCedulaD";
            this.LblCedulaD.Size = new System.Drawing.Size(44, 15);
            this.LblCedulaD.TabIndex = 15;
            this.LblCedulaD.Text = "Cedula";
            // 
            // TxtCedulaD
            // 
            this.TxtCedulaD.Location = new System.Drawing.Point(182, 90);
            this.TxtCedulaD.Name = "TxtCedulaD";
            this.TxtCedulaD.Size = new System.Drawing.Size(231, 23);
            this.TxtCedulaD.TabIndex = 14;
            // 
            // FrmAgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 401);
            this.Controls.Add(this.GroupBoxDatospaciente);
            this.Name = "FrmAgregarPaciente";
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.FrmAgregarPaciente_Load);
            this.GroupBoxDatospaciente.ResumeLayout(false);
            this.GroupBoxDatospaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxDatospaciente;
        private System.Windows.Forms.Label LblApellidoD;
        private System.Windows.Forms.TextBox TxtApellidoD;
        private System.Windows.Forms.Label LblNombreD;
        private System.Windows.Forms.TextBox TxtNombreD;
        private System.Windows.Forms.Label LblCedulaD;
        private System.Windows.Forms.TextBox TxtCedulaD;
        private System.Windows.Forms.Label LblfechaNacP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDireccionP;
        private Guna.UI2.WinForms.Guna2DateTimePicker FechaNac;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button BtnCancelar;
        private Guna.UI2.WinForms.Guna2Button BtnRegistrar;
    }
}