using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Logica;
using Datos;

namespace Proyecto_Vacuna
{


    public partial class FrmAgregarVacunacion : Form
    {


        public FrmAgregarVacunacion()
        {
            InitializeComponent();
        }

        public void FiltrarPaciente()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM vistapersonasregistradas where id_paciente = '" + txtidpaciente.Text + "' or  nombre_personas = '" + txtnombrepaciente.Text + "' or apellido_personas = '" + txtapellidospaciente + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            mostrarpaciente.DataSource = ds.Tables[0];
        }

       


        void cmbUnidadVacunacion()
        {
            clsLogicaVacunacion x = new clsLogicaVacunacion();
            cmbbuscarunidad.DataSource = x.CbxUnidadVacunacion();
            cmbbuscarunidad.DisplayMember = "DatoUnidad";
            cmbbuscarunidad.ValueMember = "id_unidad";
        }

        void cmbVacuna()
        {
            clsLogicaVacunacion x = new clsLogicaVacunacion();
            cmbbuscarvacuna.DataSource = x.CbxVacuna();
            cmbbuscarvacuna.DisplayMember = "DatoVacuna";
            cmbbuscarvacuna.ValueMember = "id_vacuna";
        }

       /* void cmbLote()
        {
            clsLogicaVacunacion x = new clsLogicaVacunacion();
            CbxLote.DataSource = x.CbxLote();
            CbxLote.DisplayMember = "DatoLote";
            CbxLote.ValueMember = "id_lote";
        } */

        void cmbSupervisor()
        {
            clsLogicaVacunacion x = new clsLogicaVacunacion();
            CbxSupervisor.DataSource = x.CbxSupervisor();
            CbxSupervisor.DisplayMember = "DatoSupervisor";
            CbxSupervisor.ValueMember = "id_supervisor";
        }

        void cmbVacunador()
        {
            clsLogicaVacunacion x = new clsLogicaVacunacion();
            CbxVacunador.DataSource = x.CbxVacunador();
            CbxVacunador.DisplayMember = "DatoVacunador";
            CbxVacunador.ValueMember = "id_vacunador";
        }


        private void LblfechaNacP_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgregarVacunacion_Load(object sender, EventArgs e)
        {
            //agregar dgv de vacunaciones hechas
            loadgrid("");
            loadJornadas("");
            loadDistribucionUnidad("");
            cmbUnidadVacunacion();
            cmbVacuna();
            cmbVacunador();
            cmbSupervisor();
        }

        void loadDistribucionUnidad(String x)
        {
            clsLogicaVacunacion Load = new clsLogicaVacunacion();
            mostrarlotes.DataSource = Load.ListarDistribucionUnidad(x);
        }

        
        void loadJornadas(String x)
        {
            clsLogicaVacunacion Load = new clsLogicaVacunacion();
            mostrarjornadas.DataSource = Load.ListarJornadas(x);
        }

        private void BtnAddSupervisor_Click(object sender, EventArgs e)
        {

        }

        private void CbxUnidadVacunacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxVacuna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GbxPersonal_Click(object sender, EventArgs e)
        {

        }

        private void CbxNombrePaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxLote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CbxVacuna_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarVacunacion();
        }

        private void GuardarVacunacion()
        {
           
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Enviar datos a la capa logica y agregar que vacuna es
            string msg, fechavac, fechasegDosis;
            clsLogicaVacunacion agregarvacunacion = new clsLogicaVacunacion();
            int cmbPaciente, cmbUnidadVacunacion, cmbVacuna, cmbLote, cmbDosis, cmbjornada, cmbVacunador, cmbSupervisor;
            cmbPaciente = Convert.ToInt32(txtCodigoPaciente.Text);
            cmbUnidadVacunacion = Convert.ToInt32(txtunidad.Text);
            cmbVacuna = Convert.ToInt32(txtvacuna.Text);
            cmbjornada = Convert.ToInt32(txtjornada.Text);
            cmbLote = Convert.ToInt32(txtlote.Text);
            cmbDosis = Convert.ToInt32(CbxDosisAplicada.SelectedValue);
            cmbSupervisor = Convert.ToInt32(CbxSupervisor.SelectedValue);
            cmbVacunador = Convert.ToInt32(CbxVacunador.SelectedValue);
            fechavac = FechaVacunacion.Value.ToString("yyy/MM/dd");
            fechasegDosis = FechaSegDosis.Value.ToString("yyy/MM/dd");
            msg = agregarvacunacion.guardarVacunacion(cmbPaciente, cmbUnidadVacunacion, cmbVacuna, cmbLote, TxtEstrategia.Text, cmbDosis, fechavac, fechasegDosis, TxtEdadVacunacion.Text, cmbjornada, cmbVacunador, cmbSupervisor);

            MessageBox.Show(msg, "Resultado Agregar Vacunacion");

        }

        void loadgrid(String x)
        {
            clsLogicaVacunacion Load = new clsLogicaVacunacion();
            mostrarpaciente.DataSource = Load.ListarPersonas(x);
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPaciente.Text = this.mostrarpaciente.CurrentRow.Cells[0].Value.ToString();

        }

        private void CbxNomPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FiltrarPaciente();
        }

        private void TxtEdadVacunacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbxDosisAplicada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void mostrarlotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtunidad.Text = this.mostrarlotes.CurrentRow.Cells[3].Value.ToString();
            txtlote.Text = this.mostrarlotes.CurrentRow.Cells[1].Value.ToString();
            txtvacuna.Text = this.mostrarlotes.CurrentRow.Cells[6].Value.ToString();

        }

        private void mostrarjornadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtjornada.Text = this.mostrarjornadas.CurrentRow.Cells[0].Value.ToString();

        }
    }
}