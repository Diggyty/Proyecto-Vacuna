namespace Proyecto_Vacuna
{
    partial class FrmConsultaHistorial
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
            this.dgvHistorial = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Group = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtNomVacuna = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.cmbBSilais = new Guna.UI2.WinForms.Guna2ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.guna2Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Fuchsia;
            this.guna2GroupBox1.Controls.Add(this.dgvHistorial);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(6, 208);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(897, 265);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Lista de Vacunaciones";
            // 
            // dgvHistorial
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorial.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.Color.Fuchsia;
            this.dgvHistorial.Location = new System.Drawing.Point(0, 46);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(894, 219);
            this.dgvHistorial.TabIndex = 1;
            this.dgvHistorial.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvHistorial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistorial.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHistorial.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHistorial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHistorial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHistorial.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistorial.ThemeStyle.GridColor = System.Drawing.Color.Fuchsia;
            this.dgvHistorial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHistorial.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistorial.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvHistorial.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHistorial.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHistorial.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvHistorial.ThemeStyle.ReadOnly = false;
            this.dgvHistorial.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHistorial.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorial.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvHistorial.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHistorial.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHistorial.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHistorial.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellContentClick_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // guna2Group
            // 
            this.guna2Group.BorderColor = System.Drawing.Color.Indigo;
            this.guna2Group.Controls.Add(this.cmbB);
            this.guna2Group.Controls.Add(this.TxtNomVacuna);
            this.guna2Group.Controls.Add(this.guna2Button2);
            this.guna2Group.Controls.Add(this.guna2Button3);
            this.guna2Group.Controls.Add(this.cmbBSilais);
            this.guna2Group.Controls.Add(this.label2);
            this.guna2Group.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Group.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Group.ForeColor = System.Drawing.Color.Black;
            this.guna2Group.Location = new System.Drawing.Point(6, 12);
            this.guna2Group.Name = "guna2Group";
            this.guna2Group.ShadowDecoration.Parent = this.guna2Group;
            this.guna2Group.Size = new System.Drawing.Size(897, 190);
            this.guna2Group.TabIndex = 6;
            this.guna2Group.Text = "HistorialVac";
            this.guna2Group.Click += new System.EventHandler(this.guna2Group_Click);
            // 
            // cmbB
            // 
            this.cmbB.BackColor = System.Drawing.Color.Transparent;
            this.cmbB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbB.FocusedColor = System.Drawing.Color.Empty;
            this.cmbB.FocusedState.Parent = this.cmbB;
            this.cmbB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbB.FormattingEnabled = true;
            this.cmbB.HoverState.Parent = this.cmbB;
            this.cmbB.ItemHeight = 30;
            this.cmbB.ItemsAppearance.Parent = this.cmbB;
            this.cmbB.Location = new System.Drawing.Point(85, 137);
            this.cmbB.Name = "cmbB";
            this.cmbB.ShadowDecoration.Parent = this.cmbB;
            this.cmbB.Size = new System.Drawing.Size(216, 36);
            this.cmbB.TabIndex = 28;
            this.cmbB.SelectedIndexChanged += new System.EventHandler(this.cmbB_SelectedIndexChanged);
            // 
            // TxtNomVacuna
            // 
            this.TxtNomVacuna.CheckedState.Parent = this.TxtNomVacuna;
            this.TxtNomVacuna.CustomImages.Parent = this.TxtNomVacuna;
            this.TxtNomVacuna.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomVacuna.ForeColor = System.Drawing.Color.White;
            this.TxtNomVacuna.HoverState.Parent = this.TxtNomVacuna;
            this.TxtNomVacuna.Location = new System.Drawing.Point(338, 150);
            this.TxtNomVacuna.Name = "TxtNomVacuna";
            this.TxtNomVacuna.ShadowDecoration.Parent = this.TxtNomVacuna;
            this.TxtNomVacuna.Size = new System.Drawing.Size(130, 23);
            this.TxtNomVacuna.TabIndex = 27;
            this.TxtNomVacuna.Text = "Buscar por Nom Vacuna ";
            this.TxtNomVacuna.Click += new System.EventHandler(this.TxtNomVacuna_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(338, 70);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(130, 23);
            this.guna2Button2.TabIndex = 26;
            this.guna2Button2.Text = "Buscar SILAIS";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(338, 112);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(130, 23);
            this.guna2Button3.TabIndex = 25;
            this.guna2Button3.Text = "Refrescar";
            // 
            // cmbBSilais
            // 
            this.cmbBSilais.BackColor = System.Drawing.Color.Transparent;
            this.cmbBSilais.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBSilais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBSilais.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBSilais.FocusedState.Parent = this.cmbBSilais;
            this.cmbBSilais.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBSilais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBSilais.FormattingEnabled = true;
            this.cmbBSilais.HoverState.Parent = this.cmbBSilais;
            this.cmbBSilais.ItemHeight = 30;
            this.cmbBSilais.ItemsAppearance.Parent = this.cmbBSilais;
            this.cmbBSilais.Location = new System.Drawing.Point(85, 70);
            this.cmbBSilais.Name = "cmbBSilais";
            this.cmbBSilais.ShadowDecoration.Parent = this.cmbBSilais;
            this.cmbBSilais.Size = new System.Drawing.Size(216, 36);
            this.cmbBSilais.TabIndex = 24;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(41, 500);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Nueva Vacuna";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // FrmConsultaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 608);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Group);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaHistorial";
            this.Text = "FrmConsultaHistorial";
            this.Load += new System.EventHandler(this.FrmConsultaHistorial_Load_1);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.guna2Group.ResumeLayout(false);
            this.guna2Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2Group;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHistorial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBSilais;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button TxtNomVacuna;
        private Guna.UI2.WinForms.Guna2ComboBox cmbB;
    }
}