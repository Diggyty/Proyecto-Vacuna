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
    public partial class FrmAgregarUnidadVacunacion : Form
    {

        void cmbMunicipios()
        {
            clsLogicaUnidadVacunacion x = new clsLogicaUnidadVacunacion();
            CbxMunicipio.DataSource = x.cmbMunicipios();
            CbxMunicipio.DisplayMember = "MunicipioDato";
            CbxMunicipio.ValueMember = "id_municipios";
        }

        void cmbSilais()
        {
            clsLogicaUnidadVacunacion x = new clsLogicaUnidadVacunacion();
            CmbSilais.DataSource = x.cmbSilais();
            CmbSilais.DisplayMember = "DatosSilais";
            CmbSilais.ValueMember = "id_silais";
        }

        private void TxtDireccionUnida_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarUnidadVacunacion();
            loadUnidades("");
        }

        private void TxtSector_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBarrioLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        public FrmAgregarUnidadVacunacion()
        {
            InitializeComponent();
        }

        private void FrmAgregarUnidadVacunacion_Load(object sender, EventArgs e)
        {
            cmbMunicipios();
            cmbSilais();
            loadUnidades("");
        }

        void loadUnidades(String x)
        {
            clsLogicaUnidadVacunacion Load = new clsLogicaUnidadVacunacion();
            dgvUnidades.DataSource = Load.ListarUnidades(x);

            dgvUnidades.Columns[0].Visible = false;
            dgvUnidades.Columns[1].Visible = false;
        }


        void GuardarUnidadVacunacion()
        {
            //Enviar datos a la capa logica
            int Silais, Municipio;
            String msg;
            clsLogicaUnidadVacunacion unidadVacunacion = new clsLogicaUnidadVacunacion();
            Silais = Convert.ToInt32(CmbSilais.SelectedValue);
            Municipio = Convert.ToInt32(CbxMunicipio.SelectedValue);
            msg = unidadVacunacion.guardarUnidadVacunacion(Silais, Municipio, TxtNombreUnidad.Text, TxtSector.Text, TxtBarrioLocalidad.Text, TxtDireccionUnida.Text);

            MessageBox.Show(msg, "Resultado Agregar Unidad");
        }

        private void dgvUnidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadUnidades("");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtNombreUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtBarrioLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtDireccionUnida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Delete();
        }
        void Delete()
        {
            CbxMunicipio.Text = "";
            CmbSilais.Text = "";
            TxtBarrioLocalidad.Text = "";
            TxtNombreUnidad.Text = "";
            TxtSector.Text = "";
            TxtDireccionUnida.Text = "";
        }

    }
}
