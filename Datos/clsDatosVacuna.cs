using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class clsDatosVacuna
    {
        clsDatosConexion conex = new clsDatosConexion();

        //Metodo para listar  los elementos de la tabla vacuna 
        public string AgregarVacuna(String PNombrevacuna, String PDesarrollador, String PNDosis,
            String PTiempoAlmacenamiento,String PNivelEfectividad,String PCondicionesAlmacenamiento,String PProcedencia)
        {
            //Gestion por medio de PA
            MySqlCommand CM = new MySqlCommand();
            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "agregar_vacuna";

                //Los parametros que envio
                CM.Parameters.AddWithValue("pNombre_vacuna", PNombrevacuna);
                CM.Parameters["pNombre_vacuna"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pDesarrollador", PDesarrollador);
                CM.Parameters["pDesarrollador"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pNum_dosis", PNDosis);
                CM.Parameters["pNum_dosis"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pTiempo_almacenamiento", PTiempoAlmacenamiento);
                CM.Parameters["pTiempo_almacenamiento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pNivel_efectividad", PNivelEfectividad);
                CM.Parameters["pNivel_efectividad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pCondiciones_almacenamiento", PCondicionesAlmacenamiento);
                CM.Parameters["pCondiciones_almacenamiento"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pProcedencia", PProcedencia);
                CM.Parameters["pProcedencia"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("ppmsj", "");
                CM.Parameters["ppmsj"].Direction = ParameterDirection.Output;
                CM.ExecuteNonQuery();
                //Nos ejecuta todo el codigo con relacion al proceso de almacenado en Mysql

                return Convert.ToString(x.Value);
                //por aca anda el problema
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return "0";

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
        

        // Consultar lista de : tipos de camion
        public DataTable listarVacuna(String sql)
        {
            DataTable DT = new DataTable();
            clsDatosMetodosGlobales MD = new clsDatosMetodosGlobales();
            DT = MD.bdd_consultas(sql);

            return DT;
        }

    }
}

