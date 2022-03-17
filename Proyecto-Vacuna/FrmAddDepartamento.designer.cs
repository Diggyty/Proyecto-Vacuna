namespace Proyecto_Vacuna
{
    partial class FrmAddDepartamento
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
            this.gbxDepartamentos = new System.Windows.Forms.GroupBox();
            this.DgvMostrar = new System.Windows.Forms.DataGridView();
            this.GbxBuscar = new System.Windows.Forms.GroupBox();
            this.TxtBuscarDep = new System.Windows.Forms.TextBox();
            this.GbxAgregarDepartamentos = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtDepartamentos = new System.Windows.Forms.TextBox();
            this.gbxDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrar)).BeginInit();
            this.GbxBuscar.SuspendLayout();
            this.GbxAgregarDepartamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDepartamentos
            // 
            this.gbxDepartamentos.Controls.Add(this.DgvMostrar);
            this.gbxDepartamentos.Location = new System.Drawing.Point(19, 241);
            this.gbxDepartamentos.Name = "gbxDepartamentos";
            this.gbxDepartamentos.Size = new System.Drawing.Size(532, 175);
            this.gbxDepartamentos.TabIndex = 14;
            this.gbxDepartamentos.TabStop = false;
            this.gbxDepartamentos.Text = "Departamentos";
            // 
            // DgvMostrar
            // 
            this.DgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrar.Location = new System.Drawing.Point(7, 19);
            this.DgvMostrar.Name = "DgvMostrar";
            this.DgvMostrar.Size = new System.Drawing.Size(519, 156);
            this.DgvMostrar.TabIndex = 0;
            // 
            // GbxBuscar
            // 
            this.GbxBuscar.Controls.Add(this.TxtBuscarDep);
            this.GbxBuscar.Location = new System.Drawing.Point(19, 151);
            this.GbxBuscar.Name = "GbxBuscar";
            this.GbxBuscar.Size = new System.Drawing.Size(532, 84);
            this.GbxBuscar.TabIndex = 13;
            this.GbxBuscar.TabStop = false;
            this.GbxBuscar.Text = "Buscar";
            // 
            // TxtBuscarDep
            // 
            this.TxtBuscarDep.Location = new System.Drawing.Point(6, 30);
            this.TxtBuscarDep.Name = "TxtBuscarDep";
            this.TxtBuscarDep.Size = new System.Drawing.Size(494, 20);
            this.TxtBuscarDep.TabIndex = 0;
            this.TxtBuscarDep.TextChanged += new System.EventHandler(this.TxtBuscarDep_TextChanged);
            // 
            // GbxAgregarDepartamentos
            // 
            this.GbxAgregarDepartamentos.Controls.Add(this.BtnAgregar);
            this.GbxAgregarDepartamentos.Controls.Add(this.TxtDepartamentos);
            this.GbxAgregarDepartamentos.Location = new System.Drawing.Point(19, 12);
            this.GbxAgregarDepartamentos.Name = "GbxAgregarDepartamentos";
            this.GbxAgregarDepartamentos.Size = new System.Drawing.Size(532, 111);
            this.GbxAgregarDepartamentos.TabIndex = 12;
            this.GbxAgregarDepartamentos.TabStop = false;
            this.GbxAgregarDepartamentos.Text = "Agregar Departamentos";
            this.GbxAgregarDepartamentos.Enter += new System.EventHandler(this.GbxAgregarDepartamentos_Enter);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(425, 41);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtDepartamentos
            // 
            this.TxtDepartamentos.Location = new System.Drawing.Point(7, 43);
            this.TxtDepartamentos.Name = "TxtDepartamentos";
            this.TxtDepartamentos.Size = new System.Drawing.Size(412, 20);
            this.TxtDepartamentos.TabIndex = 1;
            // 
            // FrmAddDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 429);
            this.Controls.Add(this.gbxDepartamentos);
            this.Controls.Add(this.GbxBuscar);
            this.Controls.Add(this.GbxAgregarDepartamentos);
            this.Name = "FrmAddDepartamento";
            this.Text = "FrmAddDepartamento";
            this.Load += new System.EventHandler(this.FrmAddDepartamento_Load);
            this.gbxDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrar)).EndInit();
            this.GbxBuscar.ResumeLayout(false);
            this.GbxBuscar.PerformLayout();
            this.GbxAgregarDepartamentos.ResumeLayout(false);
            this.GbxAgregarDepartamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDepartamentos;
        private System.Windows.Forms.DataGridView DgvMostrar;
        private System.Windows.Forms.GroupBox GbxBuscar;
        private System.Windows.Forms.TextBox TxtBuscarDep;
        private System.Windows.Forms.GroupBox GbxAgregarDepartamentos;
        private System.Windows.Forms.TextBox TxtDepartamentos;
        private System.Windows.Forms.Button BtnAgregar;
    }
}