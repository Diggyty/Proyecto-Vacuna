using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class clsDatosDistribucionUnidades
    {
        clsDatosConexion conex = new clsDatosConexion();
        MySqlCommand CM = new MySqlCommand();

        public int AgregarDistribucionUnidades(int PVacuna, int PLote, int PUnidad, int PSilais, int PCantidad3)
        {
            //Gestion por medio de PA

            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarDistribucionUnidades";

                //Los parametros enviados

                CM.Parameters.AddWithValue("pId_vacuna", PVacuna);
                CM.Parameters["pId_vacuna"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_lote", PLote);
                CM.Parameters["pId_lote"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_Unidad", PUnidad);
                CM.Parameters["pId_Unidad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_silais", PSilais);
                CM.Parameters["pId_silais"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pCantidad3", PCantidad3);
                CM.Parameters["pCantidad3"].Direction = ParameterDirection.Input;

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

