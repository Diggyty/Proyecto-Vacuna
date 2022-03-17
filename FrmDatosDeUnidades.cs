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
using Datos;
using MySql.Data.MySqlClient;

namespace Proyecto_Vacuna
{
    public partial class FrmDatosDeUnidades : Form
    {
        public FrmDatosDeUnidades()
        {
            InitializeComponent();
        }

        ClsLlenarcmb fill = new ClsLlenarcmb();

        private void FrmDatosDeUnidades_Load(object sender, EventArgs e)
        {
            CmbElegirSilais();
            CmbElegirUnidad();
            FiltrarGrid();
        }

        public void FiltrarGrid()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM vistavacunasunidades where nombre_silais = '" + cmbBuscarSilais.Text + "' and nombre_unidad ='" + cmbBuscarUnidad.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gvCantidades.DataSource = ds.Tables[0];
        } 

        public void cargarunidad (string id_silais)
        {
            clsDatosConexion conexion = new clsDatosConexion();
            MySqlCommand cmd = new MySqlCommand("Select id_unidad, nombre_unidad FROM unidad_vacunacion WHERE id_silais = @id_silais", conexion.conectar2);
            cmd.Parameters.AddWithValue("id_silais", id_silais);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbBuscarUnidad.ValueMember = "id_unidad";
            cmbBuscarUnidad.DisplayMember = "nombre_unidad";
            cmbBuscarUnidad.DataSource = dt;
        }
        
        public void FiltrarSilais()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM vistavacunasunidades where nombre_silais = '" + cmbBuscarSilais.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gvCantidades.DataSource = ds.Tables[0];
        } 

        public void RefrescarGrid()
        {
            clsDatosConexion conexion = new clsDatosConexion();
            String query = "SELECT * FROM vistavacunasunidades";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion.conectar2);
            MySqlCommandBuilder Comando = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gvCantidades.DataSource = ds.Tables[0];
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FiltrarSilais();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FiltrarGrid();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void cmbBuscarSilais_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cmbBuscarSilais.SelectedValue.ToString() != null)
            {
                string id_silais = cmbBuscarSilais.SelectedValue.ToString();
                cargarunidad(id_silais);
            }


        }

        public void CmbElegirSilais()
        {
            cmbBuscarSilais.DataSource = fill.CmbElegirSilais();
            cmbBuscarSilais.DisplayMember = "nombre_silais";
            cmbBuscarSilais.ValueMember = "id_silais";
        }

        private void cmbBuscarUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CmbElegirUnidad()
        {
            cmbBuscarUnidad.DataSource = fill.CmbElegirUnidad();
            cmbBuscarUnidad.DisplayMember = "nombre_unidad";
            cmbBuscarUnidad.ValueMember = "id_unidad";
        }


    }



}
