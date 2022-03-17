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
    public partial class FrmHistirialP : Form
    {
        public FrmHistirialP()
        {
            InitializeComponent();
        }
        public void fillChart()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();

            /* DataSet ds = new DataSet();
             MySqlDataAdapter adapt = new MySqlDataAdapter("Select cantidad,nombre_unidad,nombre_silais,nombre_vacuna from vistaestadisticaunidades", conexion.conectar2);
             adapt.Fill(ds);
             guna2DataGridView1.DataSource = ds.DefaultViewManager;
             chart1.DataSource = ds;
             //set the member of the chart data source used to data bind to the X-values of the series
             chart1.Series["Vacunas Disponibles"].XValueMember = "nombre_vacuna";
             //set the member columns of the chart data source used to data bind to the Y-values of the series
             chart1.Series["Vacunas Disponibles"].YValueMembers = "cantidad"; */

            conexion.conectar2.Close();
        }



        public void FiltrarHistorialP()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();
            String query = "SELECT * FROM vistaestadisticaunidades where nombre_silais = '" + cmbsi.Text + "' and nombre_vacuna ='" + TxtNomVacuna.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvHistorialP.DataSource = ds.Tables[0];
            conexion.conectar2.Close();

        }

        public void FiltrarSilais()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();
            String query = "SELECT * FROM vistaestadisticaunidades where nombre_silais = '" + cmbsi.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvHistorialP.DataSource = ds.Tables[0];
            conexion.conectar2.Close();

        }

        public void RefrescarGrid()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();
            String query = "SELECT * FROM vistaestadisticaunidades";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvHistorialP.DataSource = ds.Tables[0];
            conexion.conectar2.Close();

        }


        ClsLlenarcmb fill = new ClsLlenarcmb();

        public void FrmHistorialP_Load(object sender, EventArgs e)
        {

           CmbElegirSilais();
          
            FiltrarHistorialP();
            fillChart();

        }
        public void CmbElegirSilais()
        {

            cmbsi.DataSource = fill.CmbElegirSilais();
            cmbsi.DisplayMember = "nombre_silais";
            cmbsi.ValueMember = "id_silais";

        }
       


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmAgregarPaciente();
            formulario.Show();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBuscarSilais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FiltrarSilais();
        }

        private void TxtBuscarHistorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHistorialP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHistirialP_Load(object sender, EventArgs e)
        {

        }
    }
}
