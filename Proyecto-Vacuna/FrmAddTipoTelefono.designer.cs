namespace Proyecto_Vacuna
{
    partial class FrmAddTipoTelefono
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtTipoTelefono = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBuscarTelefono = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvMostrarT = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.TxtTipoTelefono);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Tipo De Telefono";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(104, 63);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtTipoTelefono
            // 
            this.TxtTipoTelefono.Location = new System.Drawing.Point(6, 32);
            this.TxtTipoTelefono.Name = "TxtTipoTelefono";
            this.TxtTipoTelefono.Size = new System.Drawing.Size(270, 20);
            this.TxtTipoTelefono.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtBuscarTelefono);
            this.groupBox2.Location = new System.Drawing.Point(312, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // TxtBuscarTelefono
            // 
            this.TxtBuscarTelefono.Location = new System.Drawing.Point(6, 32);
            this.TxtBuscarTelefono.Name = "TxtBuscarTelefono";
            this.TxtBuscarTelefono.Size = new System.Drawing.Size(298, 20);
            this.TxtBuscarTelefono.TabIndex = 1;
            this.TxtBuscarTelefono.TextChanged += new System.EventHandler(this.TxtBuscarTelefono_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvMostrarT);
            this.groupBox3.Location = new System.Drawing.Point(12, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 192);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipos De Telefonos";
            // 
            // DgvMostrarT
            // 
            this.DgvMostrarT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrarT.Location = new System.Drawing.Point(6, 19);
            this.DgvMostrarT.Name = "DgvMostrarT";
            this.DgvMostrarT.Size = new System.Drawing.Size(598, 173);
            this.DgvMostrarT.TabIndex = 0;
            // 
            // FrmAddTipoTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 325);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddTipoTelefono";
            this.Text = "FrmAddTipoTelefono";
            this.Load += new System.EventHandler(this.FrmAddTipoTelefono_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrarT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTipoTelefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtBuscarTelefono;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvMostrarT;
        private System.Windows.Forms.Button BtnAgregar;
    }
}