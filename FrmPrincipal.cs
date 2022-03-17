
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
    public partial class FrmPrincipal : Form
    {

        int tipoUsuario;

        public FrmPrincipal()
        {
            InitializeComponent();

            tipoUsuario = clsSession.id_tipoUsuario;

            if (tipoUsuario == 1)
            {
                this.Btncalculadora.Visible = true;
                this.button15.Visible = true;
                this.button13.Visible = true;
                this.button6.Visible = true;
                this.button4.Visible = true;
                this.button3.Visible = true;
                this.button5.Visible = true;
                this.button1.Visible = true;
               

            }
            else
            {
                this.Btncalculadora.Visible = false;
                this.button15.Visible = false;
                this.button13.Visible = false;
                this.button6.Visible = false;
                this.button4.Visible = false;
                this.button3.Visible = false;
                this.button5.Visible = true;
                this.button1.Visible = true;

            }
        }

        public void hidesubmenu()
        {
            if (Pnsubmenucal.Visible == true)
            {
                Pnsubmenucal.Visible = false;
            }
            if (Pnsubmenuconfi.Visible == true)
            {
                Pnsubmenuconfi.Visible = false;
            }
        }

        private void Mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }

        private void Btncalculadora_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(Pnsubmenucal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmAgregarVacunacion());
            //your code
            hidesubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //your code
            ActivarFrm(new FrmAgregarLote());
            hidesubmenu();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmAgregarPaciente());
            //pendiente paciente
            //your code
            hidesubmenu();
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            //your code
            hidesubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //your code
            hidesubmenu();
        }

      
        

        private void Btnconfi_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(Pnsubmenuconfi);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //your code
            ActivarFrm(new FrmAgregarVacuna());
            hidesubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //your code
           
            hidesubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmAgregarUnidadVacunacion());
            //your code
            hidesubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

     
        private Form activarfrm = null;
        public void ActivarFrm(Form frmVarios)
        {
            if (activarfrm != null)
                activarfrm.Close();
            activarfrm = frmVarios;
            frmVarios.TopLevel = false;
            frmVarios.FormBorderStyle = FormBorderStyle.None;
            frmVarios.Dock = DockStyle.Fill;
            Pncontenedorsuper.Controls.Add(frmVarios);
            Pncontenedorsuper.Tag = frmVarios;
            frmVarios.BringToFront();
            frmVarios.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmAgregarUsuario());
        }

        private void Pncontenedorsuper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmConsultaHistorial());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void Pnbotonestop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmAgregarPaciente());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ActivarFrm(new FrmDatosDeUnidades());
        }

        private void Pnsubmenucal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            ActivarFrm(new FrmGenerarInforme());
        }

        private void Pnleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmHistorialP());
            hidesubmenu();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Pnclosemm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            ActivarFrm(new FrmAgregarPaciente());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ActivarFrm(new FrmGenerarInforme());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ActivarFrm(new FrmAgregarVacunacion());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmDistribucionSilais());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActivarFrm(new FrmDistribucion());

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            ActivarFrm(new FrmAgregarJornada());
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
