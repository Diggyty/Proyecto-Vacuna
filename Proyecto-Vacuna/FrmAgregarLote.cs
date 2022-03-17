using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Datos;
using Logica;

namespace Proyecto_Vacuna
{
    public partial class FrmAgregarLote : Form
    {
        clsDatosMetodosGlobales MD = new clsDatosMetodosGlobales();

        public FrmAgregarLote()
        {
            InitializeComponent();
            Limitar();

        }

        public void Limitar()
        {
            FechaEntrada.MaxDate = DateTime.Now.Date;
            FechaEntrada.MinDate = DateTime.Today.AddDays(-7);

            FechaVencimiento.MaxDate = DateTime.Today.AddYears(2);
            FechaVencimiento.MinDate = DateTime.Today.AddDays(1);

        }

        ClsLlenarcmb fill = new ClsLlenarcmb();

        public void FiltrarVacuna()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM infovacu where nombre_vacuna = '" + cmbBusVa.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvLotes.DataSource = ds.Tables[0];
        }

        public void FiltrarSilais()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM infovacu where nombre_silais = '" + guna2ComboBox1.Text + "' or nombre_vacuna = '" + cmbBusVa.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvLotes.DataSource = ds.Tables[0];
        }

        void cmdVacunas()
        {
            clsLogicaLote x = new clsLogicaLote();
            CbxVacuna.DataSource = x.cmbVacunas();
            CbxVacuna.DisplayMember = "DatosVacuna";
            CbxVacuna.ValueMember = "id_vacuna";
        }

        void cmbSilais()
        {
            clsLogicaLote x = new clsLogicaLote();
            CbxSilais.DataSource = x.cmbSilais();
            CbxSilais.DisplayMember = "DatosSilais";
            CbxSilais.ValueMember = "id_silais";
        }

        private void FrmAgregarLote_Load(object sender, EventArgs e)
        {
            loadLotes("");
            cmdVacunas();
            cmbSilais();
            CmbElegirVacuna();
            CmbElegirSilais();
           
        }

        void loadLotes(String x)
        {
            clsLogicaLote Load = new clsLogicaLote();
            dgvLotes.DataSource = Load.ListarLotes(x);
        }

        private void GboxLote_Click(object sender, EventArgs e)
        {

        }

         void guna2Button1_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmAgregarVacuna();
            formulario.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // obtener
            string fechaEntrada,  DiaVenc, msg;
            int vacuna, silais, unidades;
            fechaEntrada = FechaEntrada.Value.ToString("yyyy/MM/dd");
            
            DiaVenc = FechaVencimiento.Value.ToString("yyyy/MM/dd");
            clsLogicaLote Lote = new clsLogicaLote();
            vacuna = Convert.ToInt32(CbxVacuna.SelectedValue);
            silais = Convert.ToInt32(CbxSilais.SelectedValue);
            unidades = Convert.ToInt32(TxtUnidades.Text);
            //Enviar datos a la capa logica
            msg = Lote.guardarLote(vacuna, silais, fechaEntrada, unidades, DiaVenc);

            MessageBox.Show(msg, "Resultado Agregar lote");
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            FiltrarVacuna();
        }

        private void cmbBusVa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvLotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void CbxVacuna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CmbElegirVacuna()
        {
            cmbBusVa.DataSource = fill.BuscarhistorialV();
            cmbBusVa.DisplayMember = "nombre_vacuna";
            cmbBusVa.ValueMember = "id_vacuna";
        }

        public void CmbElegirSilais()
        {
            guna2ComboBox1.DataSource = fill.BuscarSilaisLotes();
            guna2ComboBox1.DisplayMember = "nombre_silais";
            guna2ComboBox1.ValueMember = "id_silais";
        }

        private void CbxSilais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FiltrarSilais();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void TxtUnidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Delete();
        }

        void Delete()
        {
            TxtUnidades.Text = "";
            FechaEntrada.Text = "";
            CbxSilais.Text = "";
            FechaVencimiento.Text = "";
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FechaEntrada_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
            
    }
}
