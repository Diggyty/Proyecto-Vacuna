
namespace Proyecto_Vacuna
{
    partial class FrmDistribucionSilais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtcantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtCodigoSilais = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodigoVacuna = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cmbSilaisDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.cmbBuscarSilais = new System.Windows.Forms.ComboBox();
            this.cmbBuscarVacuna = new System.Windows.Forms.ComboBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(452, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cantidad de Vacunas a Distribuir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2Button4);
            this.guna2GroupBox1.Controls.Add(this.txtcantidad);
            this.guna2GroupBox1.Controls.Add(this.TxtCodigoSilais);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.TxtCodigoVacuna);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.TxtCodigo);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.Controls.Add(this.cmbSilaisDestino);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.guna2TileButton2);
            this.guna2GroupBox1.Controls.Add(this.guna2TileButton1);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 312);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(855, 180);
            this.guna2GroupBox1.TabIndex = 36;
            this.guna2GroupBox1.Text = "Selecciòn de Silais Para Distribuciòn";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcantidad.DefaultText = "";
            this.txtcantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcantidad.DisabledState.Parent = this.txtcantidad;
            this.txtcantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcantidad.FocusedState.Parent = this.txtcantidad;
            this.txtcantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcantidad.HoverState.Parent = this.txtcantidad;
            this.txtcantidad.Location = new System.Drawing.Point(635, 104);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.PasswordChar = '\0';
            this.txtcantidad.PlaceholderText = "";
            this.txtcantidad.SelectedText = "";
            this.txtcantidad.ShadowDecoration.Parent = this.txtcantidad;
            this.txtcantidad.Size = new System.Drawing.Size(200, 22);
            this.txtcantidad.TabIndex = 50;
            this.txtcantidad.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // TxtCodigoSilais
            // 
            this.TxtCodigoSilais.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigoSilais.DefaultText = "";
            this.TxtCodigoSilais.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodigoSilais.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodigoSilais.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoSilais.DisabledState.Parent = this.TxtCodigoSilais;
            this.TxtCodigoSilais.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoSilais.Enabled = false;
            this.TxtCodigoSilais.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoSilais.FocusedState.Parent = this.TxtCodigoSilais;
            this.TxtCodigoSilais.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoSilais.HoverState.Parent = this.TxtCodigoSilais;
            this.TxtCodigoSilais.Location = new System.Drawing.Point(187, 114);
            this.TxtCodigoSilais.Name = "TxtCodigoSilais";
            this.TxtCodigoSilais.PasswordChar = '\0';
            this.TxtCodigoSilais.PlaceholderText = "";
            this.TxtCodigoSilais.ReadOnly = true;
            this.TxtCodigoSilais.SelectedText = "";
            this.TxtCodigoSilais.ShadowDecoration.Parent = this.TxtCodigoSilais;
            this.TxtCodigoSilais.Size = new System.Drawing.Size(200, 22);
            this.TxtCodigoSilais.TabIndex = 49;
            this.TxtCodigoSilais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoSilais_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Còdigo Silais Procedencia";
            // 
            // TxtCodigoVacuna
            // 
            this.TxtCodigoVacuna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigoVacuna.DefaultText = "";
            this.TxtCodigoVacuna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodigoVacuna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodigoVacuna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoVacuna.DisabledState.Parent = this.TxtCodigoVacuna;
            this.TxtCodigoVacuna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigoVacuna.Enabled = false;
            this.TxtCodigoVacuna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoVacuna.FocusedState.Parent = this.TxtCodigoVacuna;
            this.TxtCodigoVacuna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigoVacuna.HoverState.Parent = this.TxtCodigoVacuna;
            this.TxtCodigoVacuna.Location = new System.Drawing.Point(187, 83);
            this.TxtCodigoVacuna.Name = "TxtCodigoVacuna";
            this.TxtCodigoVacuna.PasswordChar = '\0';
            this.TxtCodigoVacuna.PlaceholderText = "";
            this.TxtCodigoVacuna.ReadOnly = true;
            this.TxtCodigoVacuna.SelectedText = "";
            this.TxtCodigoVacuna.ShadowDecoration.Parent = this.TxtCodigoVacuna;
            this.TxtCodigoVacuna.Size = new System.Drawing.Size(200, 22);
            this.TxtCodigoVacuna.TabIndex = 47;
            this.TxtCodigoVacuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoVacuna_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(94, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Còdigo Vacuna";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodigo.DefaultText = "";
            this.TxtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigo.DisabledState.Parent = this.TxtCodigo;
            this.TxtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigo.FocusedState.Parent = this.TxtCodigo;
            this.TxtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodigo.HoverState.Parent = this.TxtCodigo;
            this.TxtCodigo.Location = new System.Drawing.Point(187, 52);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PasswordChar = '\0';
            this.TxtCodigo.PlaceholderText = "";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.SelectedText = "";
            this.TxtCodigo.ShadowDecoration.Parent = this.TxtCodigo;
            this.TxtCodigo.Size = new System.Drawing.Size(200, 22);
            this.TxtCodigo.TabIndex = 45;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged_1);
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(109, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Còdigo Lote";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(712, 145);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(123, 25);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "Distribuir Cantidad";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cmbSilaisDestino
            // 
            this.cmbSilaisDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.cmbSilaisDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSilaisDestino.FormattingEnabled = true;
            this.cmbSilaisDestino.Location = new System.Drawing.Point(635, 51);
            this.cmbSilaisDestino.Name = "cmbSilaisDestino";
            this.cmbSilaisDestino.Size = new System.Drawing.Size(200, 23);
            this.cmbSilaisDestino.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(537, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Silais de Destino";
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.CheckedState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.CustomImages.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Location = new System.Drawing.Point(340, 372);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(161, 48);
            this.guna2TileButton2.TabIndex = 40;
            this.guna2TileButton2.Text = "Mostrar Datos";
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.CheckedState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.CustomImages.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Location = new System.Drawing.Point(405, 339);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.ShadowDecoration.Parent = this.guna2TileButton1;
            this.guna2TileButton1.Size = new System.Drawing.Size(96, 27);
            this.guna2TileButton1.TabIndex = 39;
            this.guna2TileButton1.Text = "Distribuir";
            // 
            // guna2TileButton3
            // 
            this.guna2TileButton3.CheckedState.Parent = this.guna2TileButton3;
            this.guna2TileButton3.CustomImages.Parent = this.guna2TileButton3;
            this.guna2TileButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton3.HoverState.Parent = this.guna2TileButton3;
            this.guna2TileButton3.Location = new System.Drawing.Point(783, 274);
            this.guna2TileButton3.Name = "guna2TileButton3";
            this.guna2TileButton3.ShadowDecoration.Parent = this.guna2TileButton3;
            this.guna2TileButton3.Size = new System.Drawing.Size(69, 16);
            this.guna2TileButton3.TabIndex = 43;
            this.guna2TileButton3.Text = "Actualizar";
            this.guna2TileButton3.Click += new System.EventHandler(this.guna2TileButton3_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.guna2Button3);
            this.guna2GroupBox2.Controls.Add(this.guna2Button2);
            this.guna2GroupBox2.Controls.Add(this.cmbBuscarSilais);
            this.guna2GroupBox2.Controls.Add(this.cmbBuscarVacuna);
            this.guna2GroupBox2.Controls.Add(this.guna2TileButton3);
            this.guna2GroupBox2.Controls.Add(this.guna2DataGridView1);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(13, 13);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(855, 293);
            this.guna2GroupBox2.TabIndex = 37;
            this.guna2GroupBox2.Text = "Selecciòn de Lote";
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(646, 44);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(131, 24);
            this.guna2Button3.TabIndex = 52;
            this.guna2Button3.Text = "Buscar Silais";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(224, 45);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(131, 24);
            this.guna2Button2.TabIndex = 51;
            this.guna2Button2.Text = "Buscar Vacuna";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // cmbBuscarSilais
            // 
            this.cmbBuscarSilais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.cmbBuscarSilais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarSilais.FormattingEnabled = true;
            this.cmbBuscarSilais.Location = new System.Drawing.Point(440, 45);
            this.cmbBuscarSilais.Name = "cmbBuscarSilais";
            this.cmbBuscarSilais.Size = new System.Drawing.Size(200, 23);
            this.cmbBuscarSilais.TabIndex = 50;
            this.cmbBuscarSilais.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarSilais_SelectedIndexChanged);
            // 
            // cmbBuscarVacuna
            // 
            this.cmbBuscarVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.cmbBuscarVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarVacuna.FormattingEnabled = true;
            this.cmbBuscarVacuna.Location = new System.Drawing.Point(18, 45);
            this.cmbBuscarVacuna.Name = "cmbBuscarVacuna";
            this.cmbBuscarVacuna.Size = new System.Drawing.Size(200, 23);
            this.cmbBuscarVacuna.TabIndex = 48;
            this.cmbBuscarVacuna.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarVacuna_SelectedIndexChanged);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
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
            this.guna2DataGridView1.ColumnHeadersHeight = 32;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 85);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(852, 183);
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 32;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(540, 145);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(131, 24);
            this.guna2Button4.TabIndex = 52;
            this.guna2Button4.Text = "Volver";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // FrmDistribucionSilais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 504);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "FrmDistribucionSilais";
            this.Text = "FrmDistribucion";
            this.Load += new System.EventHandler(this.FrmDistribucion_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton3;
        private System.Windows.Forms.ComboBox cmbSilaisDestino;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodigoVacuna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBuscarSilais;
        private System.Windows.Forms.ComboBox cmbBuscarVacuna;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodigoSilais;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox txtcantidad;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}