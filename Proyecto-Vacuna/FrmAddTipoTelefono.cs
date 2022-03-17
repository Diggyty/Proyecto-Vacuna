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
    public partial class FrmAddTipoTelefono : Form
    {
        clsLogicaTipoTelefono AddTTelefonos = new clsLogicaTipoTelefono();
        string mensaje = "";
        public FrmAddTipoTelefono()
        {
            InitializeComponent();
        }

        void AgregarTipoTelefono()
        {
            //Llmar al metodo de agregar en logica
            string mensaje;

            clsLogicaTipoTelefono AddTel = new clsLogicaTipoTelefono();

            mensaje = AddTel.AgregarTipoTelefonos(TxtTipoTelefono.Text);
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Boolean validarTextbox()
        {
            //Codigo para validar la entrada de texto
            if (TxtTipoTelefono.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void FrmAddTipoTelefono_Load(object sender, EventArgs e)
        {
            loadTipoTelefono("");
        }

        private void TxtBuscarTelefono_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarTelefono.Text == "")
            {
                try
                {
                    DgvMostrarT.Columns.Clear();
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.ToString());
                }
            }
            else
            {
                
                loadTipoTelefono(TxtBuscarTelefono.Text);
                
            }
        }

        void loadTipoTelefono(string x)
        {
            clsLogicaTipoTelefono Add = new clsLogicaTipoTelefono();
            //DgvMostrarT.DataSource = Add.ListarTipoTelefonos(x);
            DgvMostrarT.DataSource = AddTTelefonos.datosrecib(x);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (validarTextbox())
            {
                AgregarTipoTelefono();
            }
            else
            {
                MessageBox.Show("No supero la validacion");
            }
        }


    }
}
