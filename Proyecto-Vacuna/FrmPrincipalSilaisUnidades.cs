using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Vacuna
{
    public partial class FrmPrincipalSilaisUnidades : Form
    {
        int tipoUsuario;
        public FrmPrincipalSilaisUnidades()
        {
            InitializeComponent();
            tipoUsuario = clsSession.id_tipoUsuario;

            if (tipoUsuario == 1)
            {
                this.registrarlote.Visible = true;
                this.usuarios.Visible = true;
                this.unidades.Visible = true;
                this.estadisticas.Visible = true;
                this.distribuirLoteASilais.Visible = true;
                this.vacunas.Visible = true;
                this.agregarVacunas.Visible = true;
                this.pacientes.Visible = true;
                this.agregarPaciente.Visible = true;
                this.distribuirLoteAUnidades.Visible = false;
                this.datosLotesEnUnidades.Visible = false;
                this.jornadas.Visible = false;
                this.agregarUnidadDeVacunaciòn.Visible = false;

            }
            else if (tipoUsuario == 2)
            {

                
                this.distribuirLoteAUnidades.Visible = true;
                this.distribuirLoteASilais.Visible = true;
                this.datosLotesEnUnidades.Visible = true;
                this.agregarJornadas.Visible = true;
                this.usuarios.Visible = true;
                this.agregarUnidadDeVacunaciòn.Visible = true;
                this.pacientes.Visible = true;
                this.agregarUsuarios.Visible = true;
                this.vacunas.Visible = false;
                this.estadisticas.Visible = false;
                this.agregarPaciente.Visible = false;
                this.vacunacion.Visible = true;
                this.agregarVacunaciòn.Visible = false;
                this.registrarlote.Visible = false;

            }

            else if (tipoUsuario == 3)
            {
                this.registrarlote.Visible = false;
                this.usuarios.Visible = true;
                this.unidades.Visible = false;
                this.estadisticas.Visible = false;
                this.distribuirLoteASilais.Visible = false;
                this.vacunas.Visible = false;
                this.pacientes.Visible = true;
                this.agregarPaciente.Visible = true;
                 this.distribuirLoteAUnidades.Visible = true;
                this.datosLotesEnUnidades.Visible = true;
                this.jornadas.Visible = false;
                this.vacunacion.Visible = false;
                this.agregarVacunaciòn.Visible = false;
                this.agregarUnidadDeVacunaciòn.Visible = false;

            }

            else
            {
                this.lotes.Visible = false;
                this.vacunas.Visible = false;
                this.jornadas.Visible = false;
                this.estadisticas.Visible = false;
                this.usuarios.Visible = false;
                this.unidades.Visible = false;
                this.pacientes.Visible = false;
                this.estadisticas.Visible = false;
                this.pacientes.Visible = true;
                this.vacunacion.Visible = true;

            }
        }
    

        private void lotes_Click(object sender, EventArgs e)
        {

        }

        private void jornadas_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmLogin login = new FrmLogin();
            login.Visible = true;
        }

        private void usuarios_Click(object sender, EventArgs e)
        {

        }

        private void agregarUsuarios_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario agregarUsuario = new FrmAgregarUsuario();
            agregarUsuario.Visible = true;
        }

        private void FrmPrincipalSilaisUnidades_Load(object sender, EventArgs e)
        {

        }

        private void registrarlote_Click(object sender, EventArgs e)
        {
            FrmAgregarLote agregarLote = new FrmAgregarLote();
            agregarLote.Visible = true;
        }

        private void agregarVacunas_Click(object sender, EventArgs e)
        {
            FrmAgregarVacuna agregarVacuna = new FrmAgregarVacuna();
        }

        private void agregarJornadas_Click(object sender, EventArgs e)
        {
            FrmAgregarJornada agregarJornada = new FrmAgregarJornada();
            agregarJornada.Visible = true;
        }

        private void totalDeVacunaciones_Click(object sender, EventArgs e)
        {
            FrmGenerarInforme informe = new FrmGenerarInforme();
            informe.Visible = true;
        }

        private void agregarUnidadDeVacunaciòn_Click(object sender, EventArgs e)
        {
            FrmAgregarUnidadVacunacion centrosalud = new FrmAgregarUnidadVacunacion();
            centrosalud.Visible = true;
        }

        private void agregarPaciente_Click(object sender, EventArgs e)
        {
            FrmAgregarPaciente Paciente = new FrmAgregarPaciente();
            Paciente.Visible = true;
        }

        private void agregarVacunaciòn_Click(object sender, EventArgs e)
        {
            FrmAgregarVacunacion vacunacion = new FrmAgregarVacunacion();
            vacunacion.Visible = true;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vacunas_Click(object sender, EventArgs e)
        {
            FrmAgregarVacuna vacunacion = new FrmAgregarVacuna();
            vacunacion.Visible = true;
        }

        private void distribuirLoteASilais_Click(object sender, EventArgs e)
        {
            FrmDistribucionSilais frm = new FrmDistribucionSilais();
            frm.Visible = true;
        }

        private void distribuirLoteAUnidades_Click(object sender, EventArgs e)
        {
            FrmDistribucion frm = new FrmDistribucion();
            frm.Visible = true;
        }

        private void datosLotesEnUnidades_Click(object sender, EventArgs e)
        {
            FrmDatosDeUnidades datoslu = new FrmDatosDeUnidades();
            datoslu.Visible = true;
        }

        private void datosLotes_Click(object sender, EventArgs e)
        {

        }

        private void agregarBarrio_Click(object sender, EventArgs e)
        {

        }

        private void datosLotesEnSILAIS_Click(object sender, EventArgs e)
        {

        }
    }
}
