using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //vinculo de Mysql
using System.Data;

namespace Datos
{
    public class clsDatosDepartamento
    {
        clsDatosConexion conex = new clsDatosConexion();

        public int AgregarDepartamentos(String nom_departamento)
        {
            //Gestion por parte de PA
            MySqlCommand CM = new MySqlCommand();

            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarDepartamentos";

                //Los parametros que envio
                CM.Parameters.AddWithValue("pnomdepartamento", nom_departamento);
                CM.Parameters["pnomdepartamento"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("pMsj", "");
                CM.Parameters["pMsj"].Direction = ParameterDirection.Output;

                CM.ExecuteNonQuery();//Nos ejecuta todo el codigo con relacion al proceso de almacenado en Mysql

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

        //El metodo Datatable es útil para guardar información tabulada
        public DataTable datos(String sql)
        {
            DataTable dat = new DataTable(); // Objeto del metodo DataTable

            try
            {
                MySqlCommand cm = new MySqlCommand(sql, conex.conectar2); // Representa una instrucción SQL para ejecutar en una base de datos MySQL

                MySqlDataAdapter DA = new MySqlDataAdapter(cm); // proporciona la comunicación entre elconjunto de datos y la base de datos SQL

                DA.Fill(dat); //Agrega o actualiza filas 

            }
            catch (MySqlException e)
            {

                Console.WriteLine(e.ToString());
            }
            finally
            {
                conex.conectar2.Close();
            }
            return dat;   //Retornamos el tipo de dato DataTable
        }
    }
}
