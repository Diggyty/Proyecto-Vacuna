namespace Proyecto_Vacuna
{
    partial class FrmPrincipalSilaisUnidades
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lotes = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarlote = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuirLoteASilais = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuirLoteAUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.datosLotesEnUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.jornadas = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarJornadas = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeVacunaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.unidades = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnidadDeVacunaciòn = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunacion = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVacunaciòn = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotes,
            this.vacunas,
            this.jornadas,
            this.estadisticas,
            this.usuarios,
            this.unidades,
            this.pacientes,
            this.vacunacion,
            this.cerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lotes
            // 
            this.lotes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarlote,
            this.distribuirLoteASilais,
            this.distribuirLoteAUnidades,
            this.datosLotesEnUnidades});
            this.lotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lotes.Name = "lotes";
            this.lotes.Size = new System.Drawing.Size(55, 20);
            this.lotes.Text = "Lotes";
            this.lotes.Click += new System.EventHandler(this.lotes_Click);
            // 
            // registrarlote
            // 
            this.registrarlote.Name = "registrarlote";
            this.registrarlote.Size = new System.Drawing.Size(246, 22);
            this.registrarlote.Text = "Registrar Lote";
            this.registrarlote.Click += new System.EventHandler(this.registrarlote_Click);
            // 
            // distribuirLoteASilais
            // 
            this.distribuirLoteASilais.Name = "distribuirLoteASilais";
            this.distribuirLoteASilais.Size = new System.Drawing.Size(246, 22);
            this.distribuirLoteASilais.Text = "Distribuir Lote a SILAIS";
            this.distribuirLoteASilais.Click += new System.EventHandler(this.distribuirLoteASilais_Click);
            // 
            // distribuirLoteAUnidades
            // 
            this.distribuirLoteAUnidades.Name = "distribuirLoteAUnidades";
            this.distribuirLoteAUnidades.Size = new System.Drawing.Size(246, 22);
            this.distribuirLoteAUnidades.Text = "Distribuir Lote a Unidades";
            this.distribuirLoteAUnidades.Click += new System.EventHandler(this.distribuirLoteAUnidades_Click);
            // 
            // datosLotesEnUnidades
            // 
            this.datosLotesEnUnidades.Name = "datosLotesEnUnidades";
            this.datosLotesEnUnidades.Size = new System.Drawing.Size(246, 22);
            this.datosLotesEnUnidades.Text = "Datos Lotes en Unidades";
            this.datosLotesEnUnidades.Click += new System.EventHandler(this.datosLotesEnUnidades_Click);
            // 
            // vacunas
            // 
            this.vacunas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVacunas});
            this.vacunas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vacunas.Name = "vacunas";
            this.vacunas.Size = new System.Drawing.Size(75, 20);
            this.vacunas.Text = "Vacunas";
            this.vacunas.Click += new System.EventHandler(this.vacunas_Click);
            // 
            // agregarVacunas
            // 
            this.agregarVacunas.Name = "agregarVacunas";
            this.agregarVacunas.Size = new System.Drawing.Size(186, 22);
            this.agregarVacunas.Text = "Agregar Vacunas";
            this.agregarVacunas.Click += new System.EventHandler(this.agregarVacunas_Click);
            // 
            // jornadas
            // 
            this.jornadas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarJornadas});
            this.jornadas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jornadas.Name = "jornadas";
            this.jornadas.Size = new System.Drawing.Size(79, 20);
            this.jornadas.Text = "Jornadas";
            this.jornadas.Click += new System.EventHandler(this.jornadas_Click);
            // 
            // agregarJornadas
            // 
            this.agregarJornadas.Name = "agregarJornadas";
            this.agregarJornadas.Size = new System.Drawing.Size(190, 22);
            this.agregarJornadas.Text = "Agregar Jornadas";
            this.agregarJornadas.Click += new System.EventHandler(this.agregarJornadas_Click);
            // 
            // estadisticas
            // 
            this.estadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalDeVacunaciones});
            this.estadisticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.estadisticas.Name = "estadisticas";
            this.estadisticas.Size = new System.Drawing.Size(98, 20);
            this.estadisticas.Text = "Estadisticas";
            // 
            // totalDeVacunaciones
            // 
            this.totalDeVacunaciones.Name = "totalDeVacunaciones";
            this.totalDeVacunaciones.Size = new System.Drawing.Size(221, 22);
            this.totalDeVacunaciones.Text = "Total de Vacunaciones";
            this.totalDeVacunaciones.Click += new System.EventHandler(this.totalDeVacunaciones_Click);
            // 
            // usuarios
            // 
            this.usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarios});
            this.usuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(78, 20);
            this.usuarios.Text = "Usuarios";
            this.usuarios.Click += new System.EventHandler(this.usuarios_Click);
            // 
            // agregarUsuarios
            // 
            this.agregarUsuarios.Name = "agregarUsuarios";
            this.agregarUsuarios.Size = new System.Drawing.Size(189, 22);
            this.agregarUsuarios.Text = "Agregar Usuarios";
            this.agregarUsuarios.Click += new System.EventHandler(this.agregarUsuarios_Click);
            // 
            // unidades
            // 
            this.unidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUnidadDeVacunaciòn});
            this.unidades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unidades.Name = "unidades";
            this.unidades.Size = new System.Drawing.Size(79, 20);
            this.unidades.Text = "Unidades";
            // 
            // agregarUnidadDeVacunaciòn
            // 
            this.agregarUnidadDeVacunaciòn.Name = "agregarUnidadDeVacunaciòn";
            this.agregarUnidadDeVacunaciòn.Size = new System.Drawing.Size(274, 22);
            this.agregarUnidadDeVacunaciòn.Text = "Agregar Unidad de Vacunaciòn";
            this.agregarUnidadDeVacunaciòn.Click += new System.EventHandler(this.agregarUnidadDeVacunaciòn_Click);
            // 
            // pacientes
            // 
            this.pacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPaciente});
            this.pacientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pacientes.Name = "pacientes";
            this.pacientes.Size = new System.Drawing.Size(82, 20);
            this.pacientes.Text = "Pacientes";
            // 
            // agregarPaciente
            // 
            this.agregarPaciente.Name = "agregarPaciente";
            this.agregarPaciente.Size = new System.Drawing.Size(186, 22);
            this.agregarPaciente.Text = "Agregar Paciente";
            this.agregarPaciente.Click += new System.EventHandler(this.agregarPaciente_Click);
            // 
            // vacunacion
            // 
            this.vacunacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVacunaciòn});
            this.vacunacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vacunacion.Name = "vacunacion";
            this.vacunacion.Size = new System.Drawing.Size(95, 20);
            this.vacunacion.Text = "Vacunaciòn";
            // 
            // agregarVacunaciòn
            // 
            this.agregarVacunaciòn.Name = "agregarVacunaciòn";
            this.agregarVacunaciòn.Size = new System.Drawing.Size(206, 22);
            this.agregarVacunaciòn.Text = "Agregar Vacunaciòn";
            this.agregarVacunaciòn.Click += new System.EventHandler(this.agregarVacunaciòn_Click);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(108, 20);
            this.cerrarSesion.Text = "Cerrar Sesiòn";
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // FrmPrincipalSilaisUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Vacuna.Properties.Resources.istockphoto_1069481352_612x612;
            this.ClientSize = new System.Drawing.Size(757, 331);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPrincipalSilaisUnidades";
            this.Text = "FrmPrincipalSilaisUnidades";
            this.Load += new System.EventHandler(this.FrmPrincipalSilaisUnidades_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lotes;
        private System.Windows.Forms.ToolStripMenuItem registrarlote;
        private System.Windows.Forms.ToolStripMenuItem distribuirLoteASilais;
        private System.Windows.Forms.ToolStripMenuItem distribuirLoteAUnidades;
        private System.Windows.Forms.ToolStripMenuItem datosLotesEnUnidades;
        private System.Windows.Forms.ToolStripMenuItem vacunas;
        private System.Windows.Forms.ToolStripMenuItem agregarVacunas;
        private System.Windows.Forms.ToolStripMenuItem jornadas;
        private System.Windows.Forms.ToolStripMenuItem agregarJornadas;
        private System.Windows.Forms.ToolStripMenuItem estadisticas;
        private System.Windows.Forms.ToolStripMenuItem totalDeVacunaciones;
        private System.Windows.Forms.ToolStripMenuItem usuarios;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem unidades;
        private System.Windows.Forms.ToolStripMenuItem agregarUnidadDeVacunaciòn;
        private System.Windows.Forms.ToolStripMenuItem pacientes;
        private System.Windows.Forms.ToolStripMenuItem agregarPaciente;
        private System.Windows.Forms.ToolStripMenuItem vacunacion;
        private System.Windows.Forms.ToolStripMenuItem agregarVacunaciòn;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesion;
    }
}