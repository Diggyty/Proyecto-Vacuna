using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class clsDatosMetodosGlobales
    {

        clsDatosConexion conex = new clsDatosConexion();

        public DataTable bdd_consultas(String sql)
        {
            DataTable DT = new DataTable();
            try
            {
                MySqlCommand CM = new MySqlCommand(sql, conex.conectar2);
                MySqlDataAdapter DA = new MySqlDataAdapter(CM);// Modifica la estrucutura de los datos para poder llevarlos al DataTable
                DA.Fill(DT);// rellena la variable datatable

            }
            catch (MySqlException e)
            {


                Console.WriteLine(e.ToString());
                //throw;
            }
            finally
            {
                conex.conectar2.Close();
            }

            return DT;
        }
    }
}
