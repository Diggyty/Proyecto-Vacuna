using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class clsDatosPersona
    {
        clsDatosConexion conex = new clsDatosConexion();

        public string AgregarPersona(String Cedula, String NombrePersona, String ApellidoPersona)
        {
            MySqlCommand CM = new MySqlCommand();

            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Agregar_Persona";

                CM.Parameters.AddWithValue("pcedula", Cedula);
                CM.Parameters["pcedula"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pnombre", NombrePersona);
                CM.Parameters["pnombre"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("papellido", ApellidoPersona);
                CM.Parameters["papellido"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("msg", "");
                CM.Parameters["msg"].Direction = ParameterDirection.Output;

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
        public DataTable datos(String sql)
        {
            DataTable datos = new DataTable();
            clsDatosMetodosGlobales MD = new clsDatosMetodosGlobales();
            //datos = MD.bddconsultas(sql);

            return datos;
        }
     
    }
}
