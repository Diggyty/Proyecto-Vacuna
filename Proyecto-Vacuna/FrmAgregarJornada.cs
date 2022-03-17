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
    public partial class FrmAgregarJornada : Form
    {

        clsDatosMetodosGlobales MD = new clsDatosMetodosGlobales();

        public FrmAgregarJornada()
        {
            InitializeComponent();
            Limitar();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgregarJornada_Load(object sender, EventArgs e)
        {

        }

        void GuardarJornada()
        {
            //Enviar datos a la capa logica
            String msg, fechaInicio, FechaCierre;
            clsLogicaJornada vacuna = new clsLogicaJornada();
            fechaInicio = fechainicio.Value.ToString("yyy/MM/dd");
            FechaCierre = fechacierre.Value.ToString("yyy/MM/dd");
            msg = vacuna.guardarJornada(txtnombre.Text, txtdescripcion.Text, fechaInicio, FechaCierre);

            MessageBox.Show(msg, "Resultado Agregar Jornada");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GuardarJornada();

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
        public void Limitar()
        {
            fechainicio.MaxDate = DateTime.Now;
            

            fechacierre.MaxDate = DateTime.Today.AddDays(-5);
            
            }

            private void FrmAgregarJornada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Delete()
        {
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            fechainicio.Text = "";
            fechacierre.Text = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
