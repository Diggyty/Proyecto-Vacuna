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
            validarcedula();
        }

        Boolean validarcedula()
        {
            if (TxtCedulaP.Text.Length == 16)
            {
                for (int i = 0; i < 16; i++)
                {
                    char c = TxtCedulaP.Text.ToCharArray()[i];
                    if (i == 15)
                    {
                        if (!char.IsLetter(c))
                        {
                            return false;
                        }
                    }
                    else if (i == 3 || i == 10)
                    {
                        if (c != '-')
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!char.IsNumber(c))
                        {
                            return false;
                        }
                    }
                }

                if (Convert.ToInt32(TxtCedulaP.Text.Substring(4, 2)) > 0 && Convert.ToInt32(TxtCedulaP.Text.Substring(4, 2)) <= 31 && Convert.ToInt32(TxtCedulaP.Text.Substring(6, 2)) > 0 && Convert.ToInt32(TxtCedulaP.Text.Substring(6, 2)) <= 12 && Convert.ToInt32(TxtCedulaP.Text.Substring(6, 2)) > 0 && Convert.ToInt32(TxtCedulaP.Text.Substring(6, 2)) <= 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
         void Btnregistropaciente_Click(object sender, EventArgs e)
         {
           if(RbtnMayorE.Checked == true)
            {
                // Enviar datos a la capa logica
                String msg;
                string fecha;
                int muni;
                muni = CbxMunicipio.SelectedIndex;
                muni = muni + 1;
                fecha = FechaNac.Value.ToString("yyyy/MM/dd");
                clsLogicaPaciente paciente = new clsLogicaPaciente();
                msg = paciente.AgregarPaciente(TxtCedulaP.Text, TxtNombreD.Text, TxtApellidoD.Text, CmbSexo.Text, fecha, TxtDireccion.Text, TxtTelefono.Text, muni);

                MessageBox.Show(msg, "Resultado Agregar paciente ");
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de paciente");
            }

           if(RbtnMenorE.Checked == true)
            {
                // Enviar datos a la capa logica
                String msg;
                string fecha;
                int muni;
                muni = CbxMunicipio.SelectedIndex;
                muni = muni + 1;
                fecha = FechaNac.Value.ToString("yyyy/MM/dd");
                clsLogicaPaciente paciente = new clsLogicaPaciente();
                msg = paciente.AgregarPacienteM(TxtNombreD.Text, TxtApellidoD.Text, CmbSexo.Text, fecha, TxtDireccion.Text, muni, TxtIdentificador.Text);

                MessageBox.Show(msg, "Resultado Agregar paciente ");
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de paciente");
            }

         }

        private void dgvmostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void cmbMunicipios()
        {
            clsLogicaPaciente x = new clsLogicaPaciente();
            CbxMunicipio.DataSource = x.cmbMunicipios();
            CbxMunicipio.DisplayMember = "MunicipioDato";
            try
            {
                CbxMunicipio.ValueMember = "id_municipios";
            }
            catch (Exception)
            {

                //throw;
            }
            
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

        void GenerarIdentificador()
        {
            Random random = new Random();
            int numero = random.Next(1, 9000000);
            TxtIdentificador.Text = Convert.ToString(numero);
        }

        private void FrmAgregarPaciente_Load(object sender, EventArgs e)
        {
            cmbMunicipios();
            loadpaciente("" );
            loadpersonas("");
            ActivarFormarDate2();
            GenerarIdentificador();
        }

        void ActivarMenorE()
        {
            TxtIdentificador.Visible = true;
            LblIdentificador.Visible = true;
            TxtCedulaP.Enabled = false;
            TxtTelefono.Enabled = false;
        }

        private void RbtnMenorE_CheckedChanged(object sender, EventArgs e)
        {
            ActivarMenorE();
            if (TxtCedulaP.Text  != "" || TxtNombreD.Text != "" || TxtApellidoD.Text !="" || TxtTelefono.Text != "")
            {
                DialogResult result = MessageBox.Show("¿Se eliminará el registro en proceso, estás seguro de hacerlo?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    ActivarMenorE();
                    Delete();
                }
                else if (result == DialogResult.Cancel)
                {

                }
            }
            
        }

        void Delete()
        {
            TxtCedulaP.Text = "";
            TxtNombreD.Text = "";
            TxtApellidoD.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
            TxtIdentificador.Text = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        void ActivarMayorE()
        {
            TxtIdentificador.Visible = false;
            LblIdentificador.Visible = false;
            TxtCedulaP.Enabled = true;
            TxtTelefono.Enabled = true;
        }

        private void TxtNombreD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtApellidoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void RbtnMayorE_CheckedChanged(object sender, EventArgs e)
        {
            ActivarMayorE();
            if (TxtCedulaP.Text != "" || TxtNombreD.Text != "" || TxtApellidoD.Text != "" || TxtTelefono.Text != "")
            {
                DialogResult result = MessageBox.Show("¿Se eliminará el registro en proceso, estás seguro de hacerlo?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    ActivarMayorE();
                    Delete();
                }
                else if (result == DialogResult.Cancel)
                {

                }
            }
        }

        void ActivarFormarDate2()
        {

            FechaNac.MaxDate = DateTime.Now.AddDays(0);
            FechaNac.MinDate = DateTime.Today.AddDays(-36000);
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

                    if (TxtCedulaP.Text == String.Empty && TxtNombreD.Text == String.Empty && TxtApellidoD.Text == String.Empty)
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
