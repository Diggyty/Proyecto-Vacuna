using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Proyecto_Vacuna
{
    public partial class FrmAgregarVacuna : Form
    {
        
        public FrmAgregarVacuna()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarVacuna();

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void FrmAgregarVacuna_Load(object sender, EventArgs e)
        {
            loadVacuna("");
        }
        
        void loadVacuna(string x)
        {
            clsLogicaVacuna Load = new clsLogicaVacuna();
            dgvVacuna.DataSource = Load.ListarVacuna(x);
        }


        void GuardarVacuna()
        {
            //Enviar datos a la capa logica
            String msg;
            clsLogicaVacuna vacuna = new clsLogicaVacuna();
            msg = vacuna.guardarVacuna(TxtNombreVac.Text, TxtDesarrollador.Text, TxtnDosis.Text, TxtTiempoAlma.Text, TxtNivelEfect.Text, TxtCondiciones.Text, TxtProcedencia.Text);

            MessageBox.Show(msg, "Resultado Agregar Vacuna");
            
        }
      
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }
 
        private void dgvVacuna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

 
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
        }
        public void eliminar(int id_vacuna)
        {
         
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvVacuna_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvVacuna_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            loadVacuna("");
        }

        private void TxtNombreVac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else { 
                e.Handled = true;
            }
        }
    }
}
