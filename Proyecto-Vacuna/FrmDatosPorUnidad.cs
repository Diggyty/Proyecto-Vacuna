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
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Vacuna
{
    public partial class FrmDatosPorUnidad : Form
    {
  
        public FrmDatosPorUnidad()
        {
            InitializeComponent();
          
        }

        ClsLlenarcmb fill = new ClsLlenarcmb();

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



        public void FiltrarGrid()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();
            String query = "SELECT * FROM vistaestadisticaunidades where nombre_silais = '" + cmbBuscarSilais.Text + "' and nombre_unidad ='" + cmbBuscarUnidad +"'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gvCantidades.DataSource = ds.Tables[0];
            conexion.conectar2.Close();

        }

        public void FiltrarSilais()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();
            String query = "SELECT * FROM vistaestadisticaunidades where nombre_silais = '" + cmbBuscarSilais.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gvCantidades.DataSource = ds.Tables[0];
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
            gvCantidades.DataSource = ds.Tables[0];
            conexion.conectar2.Close();

        }



        public void FrmDatosPorUnidad_Load(object sender, EventArgs e)
        {
            CmbElegirSilais();
            CmbElegirUnidad();
            FiltrarGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        public void CmbElegirSilais()
        {

           cmbBuscarSilais.DataSource = fill.CmbElegirSilais();
           cmbBuscarSilais.DisplayMember = "nombre_silais";
           cmbBuscarSilais.ValueMember = "id_silais";

        }

        public void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCargarChart_Click(object sender, EventArgs e)
        {

           /* chart1.Series[0].Points.Clear();

            Console.WriteLine(guna2DataGridView1.Rows.Count);
            Console.WriteLine("nombre_vacuna" + guna2DataGridView1.Rows[0].Cells[0].Value);
            Console.WriteLine("cantidad" + guna2DataGridView1.Rows[0].Cells[1].Value);
            double x = 0;
            double y = 0; 

            for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++) 
            {

                x = double.Parse(guna2DataGridView1.Rows[i].Cells[0].Value.ToString());
                y = double.Parse(guna2DataGridView1.Rows[i].Cells[1].Value.ToString());

                chart1.Series[0].Points.AddXY(x, y);  

            }
           
           */

        }

        public void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public void CmbElegirUnidad()
        {

            cmbBuscarUnidad.DataSource = fill.CmbElegirUnidad();
            cmbBuscarUnidad.DisplayMember = "nombre_unidad";
            cmbBuscarUnidad.ValueMember = "id_unidad";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FiltrarSilais();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FiltrarGrid();
        }

        private void cmbBuscarUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void cmbBuscarSilais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

          /* Console.WriteLine(e.FormattedValue.ToString());
            if(e.FormattedValue.ToString().Length>0)
            {

                //validar creo
                try
                {

                    double input = double.Parse(e.FormattedValue.ToString());

                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    MessageBox.Show("yo creo que no se pudo\n." + ex.Message);
                    e.Cancel = true;

                }

            }

          */

        }


    }
  
}


