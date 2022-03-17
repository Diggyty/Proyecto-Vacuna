using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //vinculo de Mysql
using System.Data;

namespace Datos
{
    public class clsDatosVacunacion
    {
        clsDatosConexion conex = new clsDatosConexion();
        //Gestion por parte de PA
        MySqlCommand CM = new MySqlCommand();
        public int Agregar_vacunacion(int pPaciente, int pUnidad, int pVacuna, int plote, String pEstrategia, int pDosisAplicada, String pFechaVac, String pFechaSegosis, String pEdadVacunacion, int pJornada, int pVacunador, int pSupervisor)
        {
           
            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "Agregar_vacunacion";

                //Los parametros que envio
                CM.Parameters.AddWithValue("pPaciente", pPaciente);
                CM.Parameters["pPaciente"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pUnidad", pUnidad);
                CM.Parameters["pUnidad"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pVacuna", pVacuna);
                CM.Parameters["pVacuna"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("plote", plote);
                CM.Parameters["plote"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pEstrategia", pEstrategia);
                CM.Parameters["pEstrategia"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pDosisAplicada", pDosisAplicada);
                CM.Parameters["pDosisAplicada"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pfecha_vacunacion", pFechaVac);
                CM.Parameters["pfecha_vacunacion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pfecha_segundadosis", pFechaSegosis);
                CM.Parameters["pfecha_segundadosis"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pEdadVacunacion", pEdadVacunacion);
                CM.Parameters["pEdadVacunacion"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pJornada", pJornada);
                CM.Parameters["pJornada"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pVacunador", pVacunador);
                CM.Parameters["pVacunador"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pSupervisor", pSupervisor);
                CM.Parameters["pSupervisor"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("PMSJ", "");
                CM.Parameters["PMSJ"].Direction = ParameterDirection.Output;

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

        public DataTable LlenarCmb(String sql)
        {
            DataTable DT = new DataTable();
            clsDatosMetodosGlobales cmb = new clsDatosMetodosGlobales();
            DT =  cmb.bdd_consultas(sql);
            return DT;
        }

       
    }
}
