using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class clsDatosPaciente
    {
        clsDatosConexion conex = new clsDatosConexion();
        MySqlCommand CM = new MySqlCommand();

        public string RegistrarPaciente(String pCedula, String pNombre, String pApellido, String psexo, String pfecha_nacimiento, String pDireccion, string pNumeroTelefono, int municipios)
        {
            //Gestion por medio de PA

            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "agregar_personas";

                //Los parametros que envio


                CM.Parameters.AddWithValue("pcedula", pCedula);
                CM.Parameters["pcedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pnombre_personas", pNombre);
                CM.Parameters["pnombre_personas"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("papellido_personas", pApellido);
                CM.Parameters["papellido_personas"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pid_telefono", pNumeroTelefono);
                CM.Parameters["pid_telefono"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("psexo", psexo);
                CM.Parameters["psexo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pfecha_nacimiento", pfecha_nacimiento);
                CM.Parameters["pfecha_nacimiento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pid_direccion", pDireccion);
                CM.Parameters["pid_direccion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pid_municipio", municipios);
                CM.Parameters["pid_municipio"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("pmsj", "");
                CM.Parameters["pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();//Nos ejecuta todo el codigo con relacion al proceso de almacenado en Mysql

                return Convert.ToString(x.Value);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return "error";

            }
            finally
            {
                conex.conectar2.Close();
            }


        }
        public string RegistrarPacienteM(String pNombre, String pApellido, String psexo, String pfecha_nacimiento, String pDireccion,int municipios, string pIdentificador)
        {
            //Gestion por medio de PA

            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarPacientesM";

                //Los parametros que envio


                //CM.Parameters.AddWithValue("pcedula", pCedula);
                //CM.Parameters["pcedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pnombre_personas", pNombre);
                CM.Parameters["pnombre_personas"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("papellido_personas", pApellido);
                CM.Parameters["papellido_personas"].Direction = ParameterDirection.Input;

                //CM.Parameters.AddWithValue("pid_telefono", pNumeroTelefono);
                //CM.Parameters["pid_telefono"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("psexo", psexo);
                CM.Parameters["psexo"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pfecha_nacimiento", pfecha_nacimiento);
                CM.Parameters["pfecha_nacimiento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pid_direccion", pDireccion);
                CM.Parameters["pid_direccion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pid_municipio", municipios);
                CM.Parameters["pid_municipio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pIdentificador", pIdentificador);
                CM.Parameters["pIdentificador"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("pmsj", "");
                CM.Parameters["pmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();//Nos ejecuta todo el codigo con relacion al proceso de almacenado en Mysql

                return Convert.ToString(x.Value);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return Convert.ToString(e);

            }
            finally
            {
                conex.conectar2.Close();
            }


        }
        public DataTable ListaPacientes(String condicion)
        {
            clsDatosMetodosGlobales dgv = new clsDatosMetodosGlobales();
            String sql = "SELECT * FROM paciente WHERE paciente.cedula LIKE '%" + condicion + "%'";
            //Select COUNT(*) into m from paciente where paciente.cedula = pcedula;

            return dgv.bdd_consultas(sql);
        }

        public DataTable LlenarCmb(String sql)
        {
            clsDatosMetodosGlobales cmb = new clsDatosMetodosGlobales();
            return cmb.bdd_consultas(sql);
        } 
        public DataTable Listarpersonas(String x)
        {
            clsDatosMetodosGlobales dgv = new clsDatosMetodosGlobales();                                                                                                                                                                                               
            String sql = "Select * from personas where personas.cedula LIKE '%" + x + "%'";
            //Select COUNT(*) into m from paciente where paciente.cedula = pcedula;

            return dgv.bdd_consultas(sql);
        }
    }
}
