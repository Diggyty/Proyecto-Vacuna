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
using Microsoft.Reporting.WinForms;

namespace Proyecto_Vacuna
{
    public partial class FrmGenerarInforme : Form
    {

       
        public FrmGenerarInforme()
        {
            InitializeComponent();
          
        }

        private void FrmDatosPorUnidad_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void licensing1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; user id = root; password = root; persistsecurityinfo = True; database = proyecto-vacunaulti");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from vistavacunaciones", conexion);
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}


