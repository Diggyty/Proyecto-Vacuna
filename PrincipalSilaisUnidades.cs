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
    public partial class PrincipalSilaisUnidades : Form
    {

        int tipoUsuario;


        public PrincipalSilaisUnidades()
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
                this.datosLotes.Visible = true;
                this.datosLotesEnSILAIS.Visible = true;
                this.vacunas.Visible = true;
                this.pacientes.Visible = true;
                this.agregarPaciente.Visible = true;
                this.barrios.Visible = true;
                this.distribuirLoteAUnidades.Visible = false;
                this.datosLotesEnUnidades.Visible = false;
                this.jornadas.Visible = false;
                this.agregarUnidadDeVacunaciòn.Visible = false;

            }
            else if (tipoUsuario == 2)
            {

                this.distribuirLoteAUnidades.Visible = true;
                this.datosLotesEnSILAIS.Visible = true;
                this.datosLotes.Visible = false;
                this.distribuirLoteASilais.Visible = false;
                this.datosLotesEnUnidades.Visible = true;
                this.agregarJornadas.Visible = true;
                this.usuarios.Visible = true;
                this.agregarUnidadDeVacunaciòn.Visible = true;
                this.pacientes.Visible = true;
                this.agregarUsuarios.Visible = true;
                this.vacunas.Visible = false;
                this.estadisticas.Visible = false;
                this.agregarPaciente.Visible = false;
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
                this.datosLotes.Visible = false;
                this.datosLotesEnSILAIS.Visible = false;
                this.vacunas.Visible = false;
                this.pacientes.Visible = false;
                this.agregarPaciente.Visible = true;
                this.barrios.Visible = true;
                this.distribuirLoteAUnidades.Visible = false;
                this.datosLotesEnUnidades.Visible = true;
                this.jornadas.Visible = false;
                this.agregarUnidadDeVacunaciòn.Visible = false;

            }

            else 
            {
                this.lotes.Visible = false;
                this.barrios.Visible = false;
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

        private void distribuirLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unidadDeVacunaciònToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalSilaisUnidades_Load(object sender, EventArgs e)
        {

        }

        private void agregarUsuarios_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario agregarUsuario = new FrmAgregarUsuario();
            agregarUsuario.Visible = true;
        }

      
        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmLogin login = new FrmLogin();
            login.Visible = true;

            clsSession session = new clsSession();
        }

        private void PrincipalSilaisUnidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

    }
}
