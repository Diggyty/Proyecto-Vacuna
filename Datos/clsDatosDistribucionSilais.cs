using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class clsDatosDistribucionSilais
    {
        clsDatosConexion conex = new clsDatosConexion();
        MySqlCommand CM = new MySqlCommand();

        public int AgregarDistribucion(int PVacuna, int PLote, int PSilais, int PCantidad2)
        {
            //Gestion por medio de PA

            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarDistribucion";

                //Los parametros enviados

                CM.Parameters.AddWithValue("pId_vacuna", PVacuna);
                CM.Parameters["pId_vacuna"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_lote", PLote);
                CM.Parameters["pId_lote"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_silais", PSilais);
                CM.Parameters["pId_silais"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pCantidad2", PCantidad2);
                CM.Parameters["pCantidad2"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("ppmsj", "");
                CM.Parameters["ppmsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery(); //Nos ejecuta todo el codigo con relacion al proceso de almacenado en Mysql

                return Convert.ToInt32(x.Value.ToString());

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return 0;

            }
            finally
            {
                conex.conectar2.Close();
            }









        }
    }
}

