
namespace Proyecto_Vacuna
{
    partial class FrmDatosPorUnidad
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCargarChart = new System.Windows.Forms.Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvCantidades = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbBuscarSilais = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cmbBuscarUnidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCantidades)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 387);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(580, 422);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnCargarChart
            // 
            this.btnCargarChart.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarChart.Location = new System.Drawing.Point(598, 387);
            this.btnCargarChart.Name = "btnCargarChart";
            this.btnCargarChart.Size = new System.Drawing.Size(100, 23);
            this.btnCargarChart.TabIndex = 6;
            this.btnCargarChart.Text = "Cargar Gràfica";
            this.btnCargarChart.UseVisualStyleBackColor = true;
            this.btnCargarChart.Click += new System.EventHandler(this.btnCargarChart_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.gvCantidades);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(14, 163);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(866, 208);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Informaciòn de Cantidad de Lotes por Unidad / SILAIS";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // gvCantidades
            // 
            this.gvCantidades.AllowUserToAddRows = false;
            this.gvCantidades.AllowUserToDeleteRows = false;
            this.gvCantidades.AllowUserToResizeColumns = false;
            this.gvCantidades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.gvCantidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCantidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCantidades.BackgroundColor = System.Drawing.Color.White;
            this.gvCantidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvCantidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvCantidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCantidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvCantidades.ColumnHeadersHeight = 32;
            this.gvCantidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCantidades.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvCantidades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.gvCantidades.Location = new System.Drawing.Point(0, 37);
            this.gvCantidades.Name = "gvCantidades";
            this.gvCantidades.ReadOnly = true;
            this.gvCantidades.RowHeadersVisible = false;
            this.gvCantidades.RowHeadersWidth = 32;
            this.gvCantidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCantidades.Size = new System.Drawing.Size(866, 168);
            this.gvCantidades.TabIndex = 0;
            this.gvCantidades.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Turquoise;
            this.gvCantidades.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.gvCantidades.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvCantidades.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvCantidades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvCantidades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvCantidades.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvCantidades.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.gvCantidades.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.gvCantidades.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvCantidades.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gvCantidades.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvCantidades.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvCantidades.ThemeStyle.HeaderStyle.Height = 32;
            this.gvCantidades.ThemeStyle.ReadOnly = true;
            this.gvCantidades.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.gvCantidades.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvCantidades.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gvCantidades.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gvCantidades.ThemeStyle.RowsStyle.Height = 22;
            this.gvCantidades.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            this.gvCantidades.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvCantidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.gvCantidades.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.guna2DataGridView1_CellValidating);
            // 
            // cmbBuscarSilais
            // 
            this.cmbBuscarSilais.BackColor = System.Drawing.Color.Transparent;
            this.cmbBuscarSilais.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBuscarSilais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarSilais.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBuscarSilais.FocusedState.Parent = this.cmbBuscarSilais;
            this.cmbBuscarSilais.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBuscarSilais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBuscarSilais.FormattingEnabled = true;
            this.cmbBuscarSilais.HoverState.Parent = this.cmbBuscarSilais;
            this.cmbBuscarSilais.ItemHeight = 30;
            this.cmbBuscarSilais.ItemsAppearance.Parent = this.cmbBuscarSilais;
            this.cmbBuscarSilais.Location = new System.Drawing.Point(13, 50);
            this.cmbBuscarSilais.Name = "cmbBuscarSilais";
            this.cmbBuscarSilais.ShadowDecoration.Parent = this.cmbBuscarSilais;
            this.cmbBuscarSilais.Size = new System.Drawing.Size(216, 36);
            this.cmbBuscarSilais.TabIndex = 10;
            this.cmbBuscarSilais.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarSilais_SelectedIndexChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(235, 50);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(107, 23);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Buscar SILAIS";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cmbBuscarUnidad
            // 
            this.cmbBuscarUnidad.BackColor = System.Drawing.Color.Transparent;
            this.cmbBuscarUnidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBuscarUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarUnidad.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBuscarUnidad.FocusedState.Parent = this.cmbBuscarUnidad;
            this.cmbBuscarUnidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBuscarUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBuscarUnidad.FormattingEnabled = true;
            this.cmbBuscarUnidad.HoverState.Parent = this.cmbBuscarUnidad;
            this.cmbBuscarUnidad.ItemHeight = 30;
            this.cmbBuscarUnidad.ItemsAppearance.Parent = this.cmbBuscarUnidad;
            this.cmbBuscarUnidad.Location = new System.Drawing.Point(478, 50);
            this.cmbBuscarUnidad.Name = "cmbBuscarUnidad";
            this.cmbBuscarUnidad.ShadowDecoration.Parent = this.cmbBuscarUnidad;
            this.cmbBuscarUnidad.Size = new System.Drawing.Size(254, 36);
            this.cmbBuscarUnidad.TabIndex = 12;
            this.cmbBuscarUnidad.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarUnidad_SelectedIndexChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(738, 50);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(107, 23);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "Buscar por Unidad";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(348, 50);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(107, 23);
            this.guna2Button3.TabIndex = 14;
            this.guna2Button3.Text = "Refrescar";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.cmbBuscarSilais);
            this.guna2GroupBox2.Controls.Add(this.guna2Button2);
            this.guna2GroupBox2.Controls.Add(this.guna2Button3);
            this.guna2GroupBox2.Controls.Add(this.cmbBuscarUnidad);
            this.guna2GroupBox2.Controls.Add(this.guna2Button1);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(14, 13);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(866, 122);
            this.guna2GroupBox2.TabIndex = 15;
            this.guna2GroupBox2.Text = "Criterios de Busqueda";
            this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
            // 
            // FrmDatosPorUnidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(901, 518);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnCargarChart);
            this.Controls.Add(this.chart1);
            this.Name = "FrmDatosPorUnidad";
            this.Text = "FrmDatosPorUnidad";
            this.Load += new System.EventHandler(this.FrmDatosPorUnidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCantidades)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCargarChart;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBuscarSilais;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBuscarUnidad;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        public Guna.UI2.WinForms.Guna2DataGridView gvCantidades;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}