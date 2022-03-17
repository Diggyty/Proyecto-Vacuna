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
using System.Collections;

namespace Proyecto_Vacuna
{
    public partial class FrmEstadistica : Form
    {

       


        public FrmEstadistica()
        {
            InitializeComponent();
        }

        private void FrmEstadistica_Load(object sender, EventArgs e)
        {

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0017:Simplificar la inicialización de objetos", Justification = "<pendiente>")]
        public void Diagramasestadisticas()
        {

            clsDatosConexion conexion = new clsDatosConexion();
            conexion.conectar2.Open();
            MySqlCommand cmd;

            cmd = new MySqlCommand("DiagramaEsta", conexion.conectar2);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlParameter total = new MySqlParameter("TotalDosi", 0); total.Direction = ParameterDirection.Output;
            MySqlParameter cl = new MySqlParameter("CanLotes", 0); cl.Direction = ParameterDirection.Output;
            MySqlParameter cu = new MySqlParameter("CanUni", 0); cu.Direction = ParameterDirection.Output;
            MySqlParameter cp = new MySqlParameter("CanPaci", 0); cp.Direction = ParameterDirection.Output;
            MySqlParameter cv = new MySqlParameter("CanVacu", 0); cv.Direction = ParameterDirection.Output;
            MySqlParameter cs = new MySqlParameter("CanSilais", 0); cs.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(total);
            cmd.Parameters.Add(cl);
            cmd.Parameters.Add(cu);
            cmd.Parameters.Add(cp);
            cmd.Parameters.Add(cv);
            cmd.Parameters.Add(cs);
            cmd.ExecuteNonQuery();
            lblTotalDosis2.Text = cmd.Parameters["TotalDosi"].Value.ToString();
            conexion.conectar2.Close();
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void diagrama1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDosis2_Click(object sender, EventArgs e)
        {

        }
    }
}
