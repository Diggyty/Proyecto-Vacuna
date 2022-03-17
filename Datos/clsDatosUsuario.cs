using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class clsDatosUsuario
    {
        public string login(String usuario, String clave)
        {
            clsDatosConexion conex = new clsDatosConexion();
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;

                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "LoguearUsuario";

                //Los parametros que envio
                CM.Parameters.AddWithValue("pUsuario", usuario);
                CM.Parameters["pUsuario"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pClave", clave);
                CM.Parameters["pClave"].Direction = ParameterDirection.Input;

            
                //Parametro de salida ddel PA
                x = CM.Parameters.AddWithValue("msg", "");
                CM.Parameters["msg"].Direction = ParameterDirection.Output;

                //Ejecutar la consulta
                CM.ExecuteNonQuery();

                return Convert.ToString(x.Value);

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return "Error";
            }
            finally
            {
                conex.conectar2.Close();
            }

        }
    }
}
