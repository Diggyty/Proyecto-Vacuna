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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void GbxRegistro_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario();
            usuario.Usuario1 = TxtUsername.Text;
            usuario.Nombre = txtnombre.Text;
            usuario.Password = TxtPass.Text;
            usuario.ConPassword = TxtConfirmPass.Text;

            try
            {

                clsControl control = new clsControl();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length < 0)
                {
                    MessageBox.Show(respuesta, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario Registrado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }

        private void TxtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetrasONumeros(e);
        }
    }
}
