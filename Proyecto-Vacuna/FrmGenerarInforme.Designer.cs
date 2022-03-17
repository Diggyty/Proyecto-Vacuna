
namespace Proyecto_Vacuna
{
    partial class FrmGenerarInforme
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.FechaInicial = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FechaFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Vacuna.reportes.GeneradorInformes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(198, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(771, 523);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 154);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(96, 21);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Generar Informe";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FechaInicial
            // 
            this.FechaInicial.CheckedState.Parent = this.FechaInicial;
            this.FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FechaInicial.HoverState.Parent = this.FechaInicial;
            this.FechaInicial.Location = new System.Drawing.Point(12, 36);
            this.FechaInicial.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FechaInicial.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.ShadowDecoration.Parent = this.FechaInicial;
            this.FechaInicial.Size = new System.Drawing.Size(180, 18);
            this.FechaInicial.TabIndex = 2;
            this.FechaInicial.Value = new System.DateTime(2021, 12, 9, 19, 4, 42, 292);
            // 
            // FechaFinal
            // 
            this.FechaFinal.CheckedState.Parent = this.FechaFinal;
            this.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FechaFinal.HoverState.Parent = this.FechaFinal;
            this.FechaFinal.Location = new System.Drawing.Point(12, 89);
            this.FechaFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FechaFinal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ShadowDecoration.Parent = this.FechaFinal;
            this.FechaFinal.Size = new System.Drawing.Size(180, 18);
            this.FechaFinal.TabIndex = 3;
            this.FechaFinal.Value = new System.DateTime(2021, 12, 9, 19, 4, 42, 292);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // FrmGenerarInforme
            // 
            this.ClientSize = new System.Drawing.Size(981, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.FechaInicial);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmGenerarInforme";
            this.Load += new System.EventHandler(this.FrmDatosPorUnidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DateTimePicker FechaInicial;
        private Guna.UI2.WinForms.Guna2DateTimePicker FechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}