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
    public partial class FrmAgregarPaciente : Form
    {
        bool vacioR, vacioD, focoR, focoD = false, vacio = false, lleno = true;
        int contR = 0, contD = 0;

        private void GbxAddPaciente_Click(object sender, EventArgs e)
        {
                                      
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCedulaD_TextChanged(object sender, EventArgs e)
        {

        }

         void Btnregistropaciente_Click(object sender, EventArgs e)
         {
            // Enviar datos a la capa logica
            String msg;
            string fecha;
            int muni;
            muni = CbxMunicipio.SelectedIndex;
            muni = muni + 1;
            fecha = FechaNac.Value.ToString("yyyy/MM/dd");
            clsLogicaPaciente paciente = new clsLogicaPaciente();
            msg = paciente.AgregarPaciente(TxtCedulaD.Text, TxtNombreD.Text, TxtApellidoD.Text, CmbSexo.Text, fecha, TxtDireccion.Text, TxtTelefono.Text, muni);

            MessageBox.Show(msg, "Resultado Agregar paciente ");


         }

        private void dgvmostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void cmbMunicipios()
        {
            clsLogicaPaciente x = new clsLogicaPaciente();
            CbxMunicipio.DataSource = x.cmbMunicipios();
            CbxMunicipio.DisplayMember = "MunicipioDato";
            CbxMunicipio.ValueMember = "id_municipios";
        }

        private void LblDatosPersonales_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            loadpersonas("");
        }

        public FrmAgregarPaciente()
        {
            InitializeComponent();
        }

        private void FrmAgregarPaciente_Load(object sender, EventArgs e)
        {
            cmbMunicipios();
            loadpaciente("" );
            loadpersonas("");
        }

        void loadpaciente(string x )
        {
           clsLogicaPaciente load = new clsLogicaPaciente();
           dgvmostrar.DataSource = load.GridListarPacientes(x);
           dgvmostrar.Columns[0].Visible = false;
           dgvmostrar.Columns[1].Visible =true;
        }

        void loadpersonas(string x)
        {
            clsLogicaPaciente load = new clsLogicaPaciente();
            dgvmostrar.DataSource = load.listarPersonas(x);
            dgvmostrar.Columns[0].Visible = false;
            dgvmostrar.Columns[1].Visible = true;
        }


        //METODOS PARA VALIADAR SI LOS TXT ESTAN VACIOS O LLENOS
        private void validarR(Control formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {

                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                    contR = 1;


                }
                else
                {
                    vacio = false;
                    contR = 0;
                }
            }

            if (vacio == true)
            {
                //MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje.
                vacioR = true;

            }

            if (vacio == false)
            {
                vacioR = false;
                contR = 0;
            }
            vacio = false; // Devolvemos el valor original a nuestra variable.
                           // vacioR = false;
        }

        private void validarD(Control formulario)
        {

            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {

                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {

                    if (TxtCedulaD.Text == String.Empty && TxtNombreD.Text == String.Empty && TxtApellidoD.Text == String.Empty)
                    {
                        vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                        contD = 1;
                    }

                    else
                    {
                        vacio = false;
                    }
                }
            }

            if (vacio == true)
            {
                //MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje.
                vacioD = true;

            }

            if (vacio == false)
            {
                vacioD = false;

                contD = 0;
            }

            vacio = false; // Devolvemos el valor original a nuestra variable.
                           // vacioD = false;
        }
    }
}
