namespace Proyecto_Vacuna
{
    partial class FrmAgregarUnidadVacunacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.TxtNombreUnidad = new System.Windows.Forms.TextBox();
            this.CbxMunicipio = new System.Windows.Forms.ComboBox();
            this.CmbSilais = new System.Windows.Forms.ComboBox();
            this.TxtSector = new System.Windows.Forms.TextBox();
            this.TxtDireccionUnida = new System.Windows.Forms.TextBox();
            this.TxtBarrioLocalidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvUnidades = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.textBox1);
            this.guna2GroupBox1.Controls.Add(this.BtnGuardar);
            this.guna2GroupBox1.Controls.Add(this.TxtNombreUnidad);
            this.guna2GroupBox1.Controls.Add(this.CbxMunicipio);
            this.guna2GroupBox1.Controls.Add(this.CmbSilais);
            this.guna2GroupBox1.Controls.Add(this.TxtSector);
            this.guna2GroupBox1.Controls.Add(this.TxtDireccionUnida);
            this.guna2GroupBox1.Controls.Add(this.TxtBarrioLocalidad);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(779, 184);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Registrar Nueva Unidad de vacunación";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Agregar nuevo silais";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 32;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.CheckedState.Parent = this.BtnGuardar;
            this.BtnGuardar.CustomImages.Parent = this.BtnGuardar;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.HoverState.Parent = this.BtnGuardar;
            this.BtnGuardar.Location = new System.Drawing.Point(491, 142);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.ShadowDecoration.Parent = this.BtnGuardar;
            this.BtnGuardar.Size = new System.Drawing.Size(125, 23);
            this.BtnGuardar.TabIndex = 31;
            this.BtnGuardar.Text = "Registrar Unidad";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNombreUnidad
            // 
            this.TxtNombreUnidad.Location = new System.Drawing.Point(140, 113);
            this.TxtNombreUnidad.Name = "TxtNombreUnidad";
            this.TxtNombreUnidad.Size = new System.Drawing.Size(167, 23);
            this.TxtNombreUnidad.TabIndex = 30;
            // 
            // CbxMunicipio
            // 
            this.CbxMunicipio.FormattingEnabled = true;
            this.CbxMunicipio.Location = new System.Drawing.Point(449, 53);
            this.CbxMunicipio.Name = "CbxMunicipio";
            this.CbxMunicipio.Size = new System.Drawing.Size(167, 23);
            this.CbxMunicipio.TabIndex = 29;
            // 
            // CmbSilais
            // 
            this.CmbSilais.FormattingEnabled = true;
            this.CmbSilais.Location = new System.Drawing.Point(140, 53);
            this.CmbSilais.Name = "CmbSilais";
            this.CmbSilais.Size = new System.Drawing.Size(167, 23);
            this.CmbSilais.TabIndex = 28;
            // 
            // TxtSector
            // 
            this.TxtSector.Location = new System.Drawing.Point(449, 83);
            this.TxtSector.Name = "TxtSector";
            this.TxtSector.Size = new System.Drawing.Size(167, 23);
            this.TxtSector.TabIndex = 27;
            this.TxtSector.TextChanged += new System.EventHandler(this.TxtSector_TextChanged);
            // 
            // TxtDireccionUnida
            // 
            this.TxtDireccionUnida.Location = new System.Drawing.Point(449, 112);
            this.TxtDireccionUnida.Name = "TxtDireccionUnida";
            this.TxtDireccionUnida.Size = new System.Drawing.Size(167, 23);
            this.TxtDireccionUnida.TabIndex = 26;
            this.TxtDireccionUnida.TextChanged += new System.EventHandler(this.TxtDireccionUnida_TextChanged);
            // 
            // TxtBarrioLocalidad
            // 
            this.TxtBarrioLocalidad.Location = new System.Drawing.Point(140, 142);
            this.TxtBarrioLocalidad.Name = "TxtBarrioLocalidad";
            this.TxtBarrioLocalidad.Size = new System.Drawing.Size(167, 23);
            this.TxtBarrioLocalidad.TabIndex = 25;
            this.TxtBarrioLocalidad.TextChanged += new System.EventHandler(this.TxtBarrioLocalidad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Direcciòn Exacta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Municipio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Barrio / Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Silais existentes";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.dgvUnidades);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 202);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(779, 186);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Data Grid Unidades";
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AllowUserToAddRows = false;
            this.dgvUnidades.AllowUserToDeleteRows = false;
            this.dgvUnidades.AllowUserToResizeColumns = false;
            this.dgvUnidades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvUnidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnidades.ColumnHeadersHeight = 32;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnidades.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnidades.EnableHeadersVisualStyles = false;
            this.dgvUnidades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvUnidades.Location = new System.Drawing.Point(0, 34);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.ReadOnly = true;
            this.dgvUnidades.RowHeadersVisible = false;
            this.dgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidades.Size = new System.Drawing.Size(776, 152);
            this.dgvUnidades.TabIndex = 0;
            this.dgvUnidades.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Turquoise;
            this.dgvUnidades.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvUnidades.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUnidades.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUnidades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUnidades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUnidades.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnidades.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvUnidades.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.dgvUnidades.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUnidades.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvUnidades.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUnidades.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnidades.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvUnidades.ThemeStyle.ReadOnly = true;
            this.dgvUnidades.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.dgvUnidades.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnidades.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvUnidades.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUnidades.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUnidades.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            this.dgvUnidades.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUnidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellContentClick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 394);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(96, 25);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "Actualizar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FrmAgregarUnidadVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 527);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarUnidadVacunacion";
            this.Text = "FrmAgregarUnidadVacunacion";
            this.Load += new System.EventHandler(this.FrmAgregarUnidadVacunacion_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNombreUnidad;
        private System.Windows.Forms.ComboBox CbxMunicipio;
        private System.Windows.Forms.ComboBox CmbSilais;
        private System.Windows.Forms.TextBox TxtSector;
        private System.Windows.Forms.TextBox TxtDireccionUnida;
        private System.Windows.Forms.TextBox TxtBarrioLocalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUnidades;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}