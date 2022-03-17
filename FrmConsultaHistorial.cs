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
using Logica;
using Datos;
namespace Proyecto_Vacuna
{
    public partial class FrmConsultaHistorial : Form
    {
        clsDatosMetodosGlobales MD = new clsDatosMetodosGlobales();
        public FrmConsultaHistorial()
        {
            InitializeComponent();
        }
        ClsLlenarcmb fill = new ClsLlenarcmb();

      
        public void FiltrarGrid2()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();
            String query = "SELECT * FROM infovacu where nombre_silais = '" + cmbBSilais.Text + "' and nombre_vacuna='" + cmbB.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvHistorial.DataSource = ds.Tables[0];
            conexion.conectar2.Close();

        }

        public void FiltrarSilais2()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();
            String query = "SELECT * FROM infovacu where nombre_silais = '" + cmbBSilais.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvHistorial.DataSource = ds.Tables[0];
            conexion.conectar2.Close();

        }
        
        public void CmbElegirSilaisV()
        {

            cmbBSilais.DataSource = fill.CmbElegirSilais();
            cmbBSilais.DisplayMember = "nombre_silais";
            cmbBSilais.ValueMember = "id_silais";

        }
        public void CmbB()
        {

            cmbB.DataSource = fill.BuscarhistorialV();
            cmbB.DisplayMember = "nombre_vacuna";
            cmbB.ValueMember = "id_vacuna"; 

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = MD.bdd_consultas("SELECT vshistorialperson.id_vacunacion AS ID, vshistorialperson.nombre_personas AS NOMBRE, vshistorialperson.nombre_vacuna AS VACUNA , vshistorialperson.dosis_aplicada AS DOSIS, vshistorialperson.fecha_vacunacion AS FECHA , vshistorialperson.nombre_unidad AS UNIDAD , vshistorialperson.id_lote AS LOTE FROM vshistorialperson WHERE vshistorialperson.nombre_vacuna LIKE '%" + TxtNomVacuna.Text + "%' ");
        }

        private void FrmConsultaHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.DataSource = MD.bdd_consultas("SELECT vshistorialperson.id_vacunacion AS ID, vshistorialperson.nombre_personas AS NOMBRE, vshistorialperson.nombre_vacuna AS VACUNA , vshistorialperson.dosis_aplicada AS DOSIS, vshistorialperson.fecha_vacunacion AS FECHA , vshistorialperson.nombre_unidad AS UNIDAD , vshistorialperson.id_lote AS LOTE FROM vshistorialperson WHERE vshistorialperson.nombre_vacuna LIKE '%%' ");
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHistorial_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmAgregarVacuna();
            formulario.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomVacuna_Click(object sender, EventArgs e)
        {

        }

        private void cmbBuscarSilais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmGenerarInforme();
            formulario.Show();
        }

        private void guna2Group_Click(object sender, EventArgs e)
        {

        }

        private void dgvHistorial_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            CmbElegirSilaisV();
            CmbB();
            FiltrarGrid2();
           
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            FiltrarSilais2();
        }

        private void TxtNomVacuna_Click_1(object sender, EventArgs e)
        {
            FiltrarSilais2();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Form formulario = new FrmAgregarVacuna();
            formulario.Show();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            Form formulario = new FrmGenerarInforme();
            formulario.Show();
        }

        private void cmbB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsultaHistorial_Load_1(object sender, EventArgs e)
        {

        }
    }
}
