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

namespace Proyect_vacuna
{
    public partial class FrmAgregarPaciente : Form
    {
        bool vacioR, vacioD, focoD = false, vacio = false;
        int contR = 0, contD = 0;

        private void CmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreD_TextChanged(object sender, EventArgs e)
        {

        }

        public FrmAgregarPacientee()
        {
            InitializeComponent();
        }

        private void GroupBoxDatospaciente_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgregarPaciente_Load(object sender, EventArgs e)
        {

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
                    if (TxtCedulaD.Text == String.Empty && TxtNombreD.Text == String.Empty &&
               TxtApellidoD.Text == String.Empty)
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

            void GuardarPaciente()
            {
                //Enviar datos a la capa logica
                String msg;
                clsLogicaPaciente paciente = new clsLogicaPaciente();
                msg = paciente.guardarPaciente(TxtCedulaD.Text, TxtNombreD.Text, TxtApellidoD.Text, CmbSexo.Text, FechaNac.Text, TxtDireccion.Text, TxtTelefono.Text);

                MessageBox.Show(msg, "Resultado Agregar Vacuna");
            }
        }
    }
}
