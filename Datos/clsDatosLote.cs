using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace Datos
{
    public class clsDatosLote
    {
        clsDatosConexion conex = new clsDatosConexion();
        MySqlCommand CM = new MySqlCommand();

        public DataTable LlenarCmb(String sql)
        {
            clsDatosMetodosGlobales cmb = new clsDatosMetodosGlobales();
            return cmb.bdd_consultas(sql);
        }

        public int AgregarLote(int PVacuna, int PSilais, String PFechaEntrada, int PUnidades, String PFechaVencimiento)
        {
            //Gestion por medio de PA
           
            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "agregar_lote";

                //Los parametros enviados

                CM.Parameters.AddWithValue("pId_vacuna", PVacuna);
                CM.Parameters["pId_vacuna"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pId_silais", PSilais);
                CM.Parameters["pId_silais"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pFecha_entrada", PFechaEntrada);
                CM.Parameters["pFecha_entrada"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pCantidad", PUnidades);
                CM.Parameters["pCantidad"].Direction = ParameterDirection.Input;

               
                CM.Parameters.AddWithValue("pFecha_vencimiento", PFechaVencimiento);
                CM.Parameters["pFecha_vencimiento"].Direction = ParameterDirection.Input;


                x = CM.Parameters.AddWithValue("ppmsj", "");
                CM.Parameters["ppmsj"].Direction = ParameterDirection.Output;

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

        // Consultar lista de :lotes
        public DataTable listarLotes(String sql)
        {
            DataTable DT = new DataTable();
            clsDatosMetodosGlobales MD = new clsDatosMetodosGlobales();
            DT = MD.bdd_consultas(sql);

            return DT;
        }
    }
}

