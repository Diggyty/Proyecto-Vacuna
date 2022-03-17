
namespace Proyecto_Vacuna
{
    partial class FrmDistribucion
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
            this.LblNombreVac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNombreVac
            // 
            this.LblNombreVac.AutoSize = true;
            this.LblNombreVac.ForeColor = System.Drawing.Color.Black;
            this.LblNombreVac.Location = new System.Drawing.Point(21, 76);
            this.LblNombreVac.Name = "LblNombreVac";
            this.LblNombreVac.Size = new System.Drawing.Size(56, 15);
            this.LblNombreVac.TabIndex = 30;
            this.LblNombreVac.Text = "Unidades";
            this.LblNombreVac.Click += new System.EventHandler(this.LblNombreVac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cantidad de vacunas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbRol
            // 
            this.CmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Items.AddRange(new object[] {
            "Supervisor",
            "Vacunador"});
            this.CmbRol.Location = new System.Drawing.Point(94, 76);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(168, 23);
            this.CmbRol.TabIndex = 35;
            this.CmbRol.Text = "Seleccione";
            this.CmbRol.SelectedIndexChanged += new System.EventHandler(this.CmbRol_SelectedIndexChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2TileButton2);
            this.guna2GroupBox1.Controls.Add(this.guna2TileButton1);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox2);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.guna2TextBox1);
            this.guna2GroupBox1.Controls.Add(this.CmbRol);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.LblNombreVac);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(776, 426);
            this.guna2GroupBox1.TabIndex = 36;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(144, 122);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre Vacuna";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(198, 178);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(233, 42);
            this.guna2TextBox2.TabIndex = 38;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Location = new System.Drawing.Point(250, 244);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Size = new System.Drawing.Size(161, 48);
            this.guna2TileButton1.TabIndex = 39;
            this.guna2TileButton1.Text = "Guardar";
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.CheckedState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.CustomImages.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Location = new System.Drawing.Point(612, 375);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(161, 48);
            this.guna2TileButton2.TabIndex = 40;
            this.guna2TileButton2.Text = "Mostrar Datos";
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // FrmDistribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "FrmDistribucion";
            this.Text = "FrmDiatribucion";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblNombreVac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbRol;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label2;
    }
}