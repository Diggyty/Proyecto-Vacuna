namespace Proyecto_Vacuna
{
    partial class FrmAgregarPersona
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.LblnDosis = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblDesarrollador = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombreVac = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nombrepersonasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopersonasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvacunadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idunidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistapersonasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
           
            this.proyectovacunaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.vistapersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.vistapersonasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistapersonasBindingSource2)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.proyectovacunaDataSetBindingSource)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.vistapersonasBindingSource)).BeginInit();
         
            ((System.ComponentModel.ISupportInitialize)(this.vistapersonasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.BtnAgregar);
            this.guna2GroupBox1.Controls.Add(this.CmbRol);
            this.guna2GroupBox1.Controls.Add(this.LblnDosis);
            this.guna2GroupBox1.Controls.Add(this.TxtApellido);
            this.guna2GroupBox1.Controls.Add(this.LblDesarrollador);
            this.guna2GroupBox1.Controls.Add(this.TxtNombre);
            this.guna2GroupBox1.Controls.Add(this.LblNombreVac);
            this.guna2GroupBox1.Controls.Add(this.TxtCedula);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(586, 188);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Agregar Personas";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(252, 145);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 35;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.FrmAgregarPersona_Load);
            // 
            // CmbRol
            // 
            this.CmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Items.AddRange(new object[] {
            "Supervisor",
            "Vacunador"});
            this.CmbRol.Location = new System.Drawing.Point(433, 116);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(138, 23);
            this.CmbRol.TabIndex = 34;
            this.CmbRol.Text = "Seleccione";
            // 
            // LblnDosis
            // 
            this.LblnDosis.AutoSize = true;
            this.LblnDosis.ForeColor = System.Drawing.Color.Black;
            this.LblnDosis.Location = new System.Drawing.Point(26, 119);
            this.LblnDosis.Name = "LblnDosis";
            this.LblnDosis.Size = new System.Drawing.Size(51, 15);
            this.LblnDosis.TabIndex = 33;
            this.LblnDosis.Text = "Apellido";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(187, 116);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(231, 23);
            this.TxtApellido.TabIndex = 32;
            // 
            // LblDesarrollador
            // 
            this.LblDesarrollador.AutoSize = true;
            this.LblDesarrollador.ForeColor = System.Drawing.Color.Black;
            this.LblDesarrollador.Location = new System.Drawing.Point(26, 87);
            this.LblDesarrollador.Name = "LblDesarrollador";
            this.LblDesarrollador.Size = new System.Drawing.Size(51, 15);
            this.LblDesarrollador.TabIndex = 31;
            this.LblDesarrollador.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(187, 84);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(231, 23);
            this.TxtNombre.TabIndex = 30;
            // 
            // LblNombreVac
            // 
            this.LblNombreVac.AutoSize = true;
            this.LblNombreVac.ForeColor = System.Drawing.Color.Black;
            this.LblNombreVac.Location = new System.Drawing.Point(26, 58);
            this.LblNombreVac.Name = "LblNombreVac";
            this.LblNombreVac.Size = new System.Drawing.Size(44, 15);
            this.LblNombreVac.TabIndex = 29;
            this.LblNombreVac.Text = "Cedula";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(187, 55);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(231, 23);
            this.TxtCedula.TabIndex = 28;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.guna2DataGridView2);
            this.guna2GroupBox2.Controls.Add(this.guna2DataGridView1);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 206);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(586, 200);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Lista de Personas";
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView2.AutoGenerateColumns = false;
            this.guna2DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeight = 17;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrepersonasDataGridViewTextBoxColumn,
            this.apellidopersonasDataGridViewTextBoxColumn,
            this.idvacunadorDataGridViewTextBoxColumn,
            this.idunidadDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn});
            this.guna2DataGridView2.DataSource = this.vistapersonasBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.EnableHeadersVisualStyles = false;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(3, 47);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.ReadOnly = true;
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView2.Size = new System.Drawing.Size(580, 150);
            this.guna2DataGridView2.TabIndex = 1;
            this.guna2DataGridView2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 17;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // nombrepersonasDataGridViewTextBoxColumn
            // 
            this.nombrepersonasDataGridViewTextBoxColumn.DataPropertyName = "nombre_personas";
            this.nombrepersonasDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombrepersonasDataGridViewTextBoxColumn.Name = "nombrepersonasDataGridViewTextBoxColumn";
            this.nombrepersonasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidopersonasDataGridViewTextBoxColumn
            // 
            this.apellidopersonasDataGridViewTextBoxColumn.DataPropertyName = "apellido_personas";
            this.apellidopersonasDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidopersonasDataGridViewTextBoxColumn.Name = "apellidopersonasDataGridViewTextBoxColumn";
            this.apellidopersonasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idvacunadorDataGridViewTextBoxColumn
            // 
            this.idvacunadorDataGridViewTextBoxColumn.DataPropertyName = "id_vacunador";
            this.idvacunadorDataGridViewTextBoxColumn.HeaderText = "Vacunador";
            this.idvacunadorDataGridViewTextBoxColumn.Name = "idvacunadorDataGridViewTextBoxColumn";
            this.idvacunadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idunidadDataGridViewTextBoxColumn
            // 
            this.idunidadDataGridViewTextBoxColumn.DataPropertyName = "id_unidad";
            this.idunidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.idunidadDataGridViewTextBoxColumn.Name = "idunidadDataGridViewTextBoxColumn";
            this.idunidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistapersonasBindingSource2
            // 
            this.vistapersonasBindingSource2.DataMember = "vistapersonas";
            
            // 
            // _proyecto_vacunaDataSet3
 
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(178, 175);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(240, 150);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // _proyecto_vacunaDataSet
            // 
           
            // 
            // proyectovacunaDataSetBindingSource
            // 
            
            this.proyectovacunaDataSetBindingSource.Position = 0;
            // 
            // _proyecto_vacunaDataSet1
            // 
          
           
            // 
            // vistapersonasBindingSource
            // 
            this.vistapersonasBindingSource.DataMember = "vistapersonas";
            
            // 
            // vistapersonasTableAdapter
            // 
            
            // 
            // _proyecto_vacunaDataSet2
            // 
            
            
            // 
            // vistapersonasBindingSource1
            // 
            this.vistapersonasBindingSource1.DataMember = "vistapersonas";
            
            // 
            // vistapersonasTableAdapter1
            // 
            
            // 
            // vistapersonasTableAdapter2
            // 
            
            // 
            // FrmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarPersona";
            this.Text = "FrmAgregarPersonal";
            this.Load += new System.EventHandler(this.FrmAgregarPersona_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistapersonasBindingSource2)).EndInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
         
            ((System.ComponentModel.ISupportInitialize)(this.proyectovacunaDataSetBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.vistapersonasBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.vistapersonasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.Label LblnDosis;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblDesarrollador;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombreVac;
        private System.Windows.Forms.TextBox TxtCedula;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        
        private System.Windows.Forms.BindingSource proyectovacunaDataSetBindingSource;
        
        private System.Windows.Forms.BindingSource vistapersonasBindingSource;
        
        
        private System.Windows.Forms.BindingSource vistapersonasBindingSource1;
        
        
        private System.Windows.Forms.BindingSource vistapersonasBindingSource2;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepersonasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopersonasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvacunadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idunidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
    }
}