
namespace Proyecto_Vacuna
{
    partial class PrincipalSilaisUnidades
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
            this.jornadas = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.unidades = new System.Windows.Forms.ToolStripMenuItem();
            this.barrios = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunacion = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarJornadas = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnidadDeVacunaciòn = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVacunaciòn = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarVacunaciòn = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarBarrio = new System.Windows.Forms.ToolStripMenuItem();
            this.lotes = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarlote = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuirLoteASilais = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuirLoteAUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.datosLotes = new System.Windows.Forms.ToolStripMenuItem();
            this.datosLotesEnSILAIS = new System.Windows.Forms.ToolStripMenuItem();
            this.datosLotesEnUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVacunas = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeVacunaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotes,
            this.vacunas,
            this.jornadas,
            this.estadisticas,
            this.usuarios,
            this.unidades,
            this.barrios,
            this.pacientes,
            this.vacunacion,
            this.cerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jornadas
            // 
            this.jornadas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarJornadas});
            this.jornadas.Name = "jornadas";
            this.jornadas.Size = new System.Drawing.Size(65, 20);
            this.jornadas.Text = "Jornadas";
            this.jornadas.Click += new System.EventHandler(this.unidadDeVacunaciònToolStripMenuItem_Click);
            // 
            // usuarios
            // 
            this.usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarios});
            this.usuarios.Name = "usuarios";
            this.usuarios.Size = new System.Drawing.Size(64, 20);
            this.usuarios.Text = "Usuarios";
            this.usuarios.Click += new System.EventHandler(this.jornadasToolStripMenuItem_Click);
            // 
            // unidades
            // 
            this.unidades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUnidadDeVacunaciòn});
            this.unidades.Name = "unidades";
            this.unidades.Size = new System.Drawing.Size(68, 20);
            this.unidades.Text = "Unidades";
            // 
            // barrios
            // 
            this.barrios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarBarrio});
            this.barrios.Name = "barrios";
            this.barrios.Size = new System.Drawing.Size(55, 20);
            this.barrios.Text = "Barrios";
            // 
            // pacientes
            // 
            this.pacientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPaciente,
            this.visualizarPacientes});
            this.pacientes.Name = "pacientes";
            this.pacientes.Size = new System.Drawing.Size(69, 20);
            this.pacientes.Text = "Pacientes";
            // 
            // vacunacion
            // 
            this.vacunacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVacunaciòn,
            this.visualizarVacunaciòn});
            this.vacunacion.Name = "vacunacion";
            this.vacunacion.Size = new System.Drawing.Size(80, 20);
            this.vacunacion.Text = "Vacunaciòn";
            // 
            // agregarJornadas
            // 
            this.agregarJornadas.Name = "agregarJornadas";
            this.agregarJornadas.Size = new System.Drawing.Size(180, 22);
            this.agregarJornadas.Text = "Agregar Jornadas";
            // 
            // agregarUsuarios
            // 
            this.agregarUsuarios.Name = "agregarUsuarios";
            this.agregarUsuarios.Size = new System.Drawing.Size(180, 22);
            this.agregarUsuarios.Text = "Agregar Usuarios";
            this.agregarUsuarios.Click += new System.EventHandler(this.agregarUsuarios_Click);
            // 
            // agregarUnidadDeVacunaciòn
            // 
            this.agregarUnidadDeVacunaciòn.Name = "agregarUnidadDeVacunaciòn";
            this.agregarUnidadDeVacunaciòn.Size = new System.Drawing.Size(237, 22);
            this.agregarUnidadDeVacunaciòn.Text = "Agregar Unidad de Vacunaciòn";
            // 
            // agregarPaciente
            // 
            this.agregarPaciente.Name = "agregarPaciente";
            this.agregarPaciente.Size = new System.Drawing.Size(180, 22);
            this.agregarPaciente.Text = "Agregar Paciente";
            // 
            // agregarVacunaciòn
            // 
            this.agregarVacunaciòn.Name = "agregarVacunaciòn";
            this.agregarVacunaciòn.Size = new System.Drawing.Size(187, 22);
            this.agregarVacunaciòn.Text = "Agregar Vacunaciòn";
            // 
            // visualizarPacientes
            // 
            this.visualizarPacientes.Name = "visualizarPacientes";
            this.visualizarPacientes.Size = new System.Drawing.Size(180, 22);
            this.visualizarPacientes.Text = "Visualizar Pacientes";
            // 
            // visualizarVacunaciòn
            // 
            this.visualizarVacunaciòn.Name = "visualizarVacunaciòn";
            this.visualizarVacunaciòn.Size = new System.Drawing.Size(187, 22);
            this.visualizarVacunaciòn.Text = "Visualizar Vacunaciòn";
            // 
            // agregarBarrio
            // 
            this.agregarBarrio.Name = "agregarBarrio";
            this.agregarBarrio.Size = new System.Drawing.Size(180, 22);
            this.agregarBarrio.Text = "Agregar Barrio";
            // 
            // lotes
            // 
            this.lotes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarlote,
            this.distribuirLoteASilais,
            this.distribuirLoteAUnidades,
            this.datosLotes,
            this.datosLotesEnSILAIS,
            this.datosLotesEnUnidades});
            this.lotes.Name = "lotes";
            this.lotes.Size = new System.Drawing.Size(47, 20);
            this.lotes.Text = "Lotes";
            // 
            // registrarlote
            // 
            this.registrarlote.Name = "registrarlote";
            this.registrarlote.Size = new System.Drawing.Size(209, 22);
            this.registrarlote.Text = "Registrar Lote";
            // 
            // distribuirLoteASilais
            // 
            this.distribuirLoteASilais.Name = "distribuirLoteASilais";
            this.distribuirLoteASilais.Size = new System.Drawing.Size(209, 22);
            this.distribuirLoteASilais.Text = "Distribuir Lote a SILAIS";
            // 
            // distribuirLoteAUnidades
            // 
            this.distribuirLoteAUnidades.Name = "distribuirLoteAUnidades";
            this.distribuirLoteAUnidades.Size = new System.Drawing.Size(209, 22);
            this.distribuirLoteAUnidades.Text = "Distribuir Lote a Unidades";
            // 
            // datosLotes
            // 
            this.datosLotes.Name = "datosLotes";
            this.datosLotes.Size = new System.Drawing.Size(209, 22);
            this.datosLotes.Text = "Datos Lotes";
            // 
            // datosLotesEnSILAIS
            // 
            this.datosLotesEnSILAIS.Name = "datosLotesEnSILAIS";
            this.datosLotesEnSILAIS.Size = new System.Drawing.Size(209, 22);
            this.datosLotesEnSILAIS.Text = "Datos Lotes en SILAIS";
            // 
            // datosLotesEnUnidades
            // 
            this.datosLotesEnUnidades.Name = "datosLotesEnUnidades";
            this.datosLotesEnUnidades.Size = new System.Drawing.Size(209, 22);
            this.datosLotesEnUnidades.Text = "Datos Lotes en Unidades";
            // 
            // vacunas
            // 
            this.vacunas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVacunas});
            this.vacunas.Name = "vacunas";
            this.vacunas.Size = new System.Drawing.Size(62, 20);
            this.vacunas.Text = "Vacunas";
            // 
            // agregarVacunas
            // 
            this.agregarVacunas.Name = "agregarVacunas";
            this.agregarVacunas.Size = new System.Drawing.Size(180, 22);
            this.agregarVacunas.Text = "Agregar Vacunas";
            // 
            // estadisticas
            // 
            this.estadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalDeVacunaciones});
            this.estadisticas.Name = "estadisticas";
            this.estadisticas.Size = new System.Drawing.Size(79, 20);
            this.estadisticas.Text = "Estadisticas";
            // 
            // totalDeVacunaciones
            // 
            this.totalDeVacunaciones.Name = "totalDeVacunaciones";
            this.totalDeVacunaciones.Size = new System.Drawing.Size(190, 22);
            this.totalDeVacunaciones.Text = "Total de Vacunaciones";
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesion.Text = "Cerrar Sesiòn";
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // PrincipalSilaisUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalSilaisUnidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalSilaisUnidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrincipalSilaisUnidades_FormClosed);
            this.Load += new System.EventHandler(this.PrincipalSilaisUnidades_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jornadas;
        private System.Windows.Forms.ToolStripMenuItem usuarios;
        private System.Windows.Forms.ToolStripMenuItem unidades;
        private System.Windows.Forms.ToolStripMenuItem barrios;
        private System.Windows.Forms.ToolStripMenuItem pacientes;
        private System.Windows.Forms.ToolStripMenuItem vacunacion;
        private System.Windows.Forms.ToolStripMenuItem agregarJornadas;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem agregarUnidadDeVacunaciòn;
        private System.Windows.Forms.ToolStripMenuItem agregarBarrio;
        private System.Windows.Forms.ToolStripMenuItem agregarPaciente;
        private System.Windows.Forms.ToolStripMenuItem visualizarPacientes;
        private System.Windows.Forms.ToolStripMenuItem agregarVacunaciòn;
        private System.Windows.Forms.ToolStripMenuItem visualizarVacunaciòn;
        private System.Windows.Forms.ToolStripMenuItem lotes;
        private System.Windows.Forms.ToolStripMenuItem registrarlote;
        private System.Windows.Forms.ToolStripMenuItem distribuirLoteASilais;
        private System.Windows.Forms.ToolStripMenuItem distribuirLoteAUnidades;
        private System.Windows.Forms.ToolStripMenuItem datosLotes;
        private System.Windows.Forms.ToolStripMenuItem datosLotesEnSILAIS;
        private System.Windows.Forms.ToolStripMenuItem datosLotesEnUnidades;
        private System.Windows.Forms.ToolStripMenuItem vacunas;
        private System.Windows.Forms.ToolStripMenuItem agregarVacunas;
        private System.Windows.Forms.ToolStripMenuItem estadisticas;
        private System.Windows.Forms.ToolStripMenuItem totalDeVacunaciones;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesion;
    }
}