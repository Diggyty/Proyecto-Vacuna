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
    public partial class FrmAddDepartamento : Form
    {
        public FrmAddDepartamento()
        {
            InitializeComponent();
        }

        void AgregarDepartamento()
        {
            //Llmar al metodo de agregar en logica
            string mensaje;

            clsLogicaDepartamento AddDepartamento = new clsLogicaDepartamento();

            mensaje = AddDepartamento.AgregarDepartamentos(TxtDepartamentos.Text);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Boolean validarTextbox()
        {
            //Codigo para validar la entrada de texto
            if (TxtDepartamentos.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void FrmAddDepartamento_Load(object sender, EventArgs e)
        {
            loadDepartamento("");
        }

        void loadDepartamento(string x)
        {
            clsLogicaDepartamento Add = new clsLogicaDepartamento();
            DgvMostrar.DataSource = Add.datosrecib(x);

        }

        private void TxtBuscarDep_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarDep.Text == "")
            {
                try
                {
                    DgvMostrar.Columns.Clear();
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.ToString());
                }
            }
            else
            {

                loadDepartamento(TxtBuscarDep.Text);

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //boton clic agregar 
            if (validarTextbox())
            {
                AgregarDepartamento();
            }
            else
            {
                MessageBox.Show("No supero la validacion");
            }
        }

        private void GbxAgregarDepartamentos_Enter(object sender, EventArgs e)
        {

        }
    }
}
