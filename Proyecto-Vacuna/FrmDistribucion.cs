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
    public partial class FrmDistribucion : Form
    {
        public FrmDistribucion()
        {
            InitializeComponent();
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
    }
}
