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
    public partial class FrmDistribucion : Form
    {

        clsDatosMetodosGlobales MD = new clsDatosMetodosGlobales();

        public FrmDistribucion()
        {
            InitializeComponent();
        }

        ClsLlenarcmb fill = new ClsLlenarcmb();

        public void FiltrarVacuna()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM vistalote where nombre_vacuna = '" + cmbBuscarVacuna.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        public void FiltrarSilais()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM vistalote where nombre_silais = '" + cmbBuscarSilais.Text + "' or nombre_vacuna = '" + cmbBuscarVacuna.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        public void RefrescarData()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM vistalote";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        void cmbSilais()
        {
            clsLogicaLote x = new clsLogicaLote();
            cmbSilaisDestino.DataSource = x.cmbSilais();
            cmbSilaisDestino.DisplayMember = "DatosSilais";
            cmbSilaisDestino.ValueMember = "id_silais";
        } 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblNombreVac_Click(object sender, EventArgs e)
        {

        }

        private void CmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmDatosPorUnidad();
            formulario.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmDistribucion_Load(object sender, EventArgs e)
        {
            loadLotes("");
            CmbElegirSilais();
            CmbElegirVacuna();
            cmbSilais();
        }

        void loadLotes(String x)
        {
            clsLogicaLote Load = new clsLogicaLote();
            guna2DataGridView1.DataSource = Load.ListarLotes(x);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            TxtCodigo.Text = this.guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            TxtCodigoVacuna.Text = this.guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtCodigoSilais.Text = this.guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void cmbBuscarVacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBuscarSilais_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void CmbElegirVacuna()
        {
            cmbBuscarVacuna.DataSource = fill.BuscarhistorialV();
            cmbBuscarVacuna.DisplayMember = "nombre_vacuna";
            cmbBuscarVacuna.ValueMember = "id_vacuna";
        }

        public void CmbElegirSilais()
        {
            cmbBuscarSilais.DataSource = fill.BuscarSilaisLotes();
            cmbBuscarSilais.DisplayMember = "nombre_silais";
            cmbBuscarSilais.ValueMember = "id_silais";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FiltrarVacuna();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FiltrarSilais();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            RefrescarData();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            clsDatosConexion conexion = new clsDatosConexion();

            string insertar = " UPDATE L SET L.cantidad = L.cantidad - LS.cantidad FROM lote_silais LS INNER JOIN lote L ON (L.id_lote = LS.id_lote";
            MySqlCommand comando = new MySqlCommand(insertar, conexion.conectar2);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            // obtener
            string msg;
            int vacuna, lote, silais, cantidad2;
            clsLogicaDistribucion Lote = new clsLogicaDistribucion();
            silais = Convert.ToInt32(cmbSilaisDestino.SelectedValue);
            vacuna = Convert.ToInt32(TxtCodigoVacuna.Text);
            lote = Convert.ToInt32(TxtCodigo.Text);
            cantidad2 = Convert.ToInt32(guna2NumericUpDown1.Text);
            //Enviar datos a la capa logica
            msg = Lote.guardarLote(vacuna, lote, silais, cantidad2);

            MessageBox.Show(msg, "Resultado Agregar lote");

        }
    }
}
