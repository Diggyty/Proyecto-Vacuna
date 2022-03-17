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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string usuario = Txtusuario.Text;
            string password = TxtPass.Text;

            try
            {
                clsControl ctrl = new clsControl();
                string respuesta = ctrl.crtlLogin(usuario, password);
                if (respuesta.Length > 0)
                {

                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FrmPrincipalSilaisUnidades frm = new FrmPrincipalSilaisUnidades();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void Txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }
    }
}
