using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class clsDatosUnidadVacunacion
    {
        clsDatosConexion conex = new clsDatosConexion();
        MySqlCommand CM = new MySqlCommand();

        public DataTable LlenarCmb(String sql)
        {
            clsDatosMetodosGlobales cmb = new clsDatosMetodosGlobales();
            return cmb.bdd_consultas(sql);
        }

        public int AgregarUnidadVacunacion( int PSilais,int PMunicipio, String PNombreUnidad, String PSector, String PBarrio, String PDireccion)
        {
            //Gestion por medio de PA
            
            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "agregar_unidad_vacunacion";

                //Los parametros enviados
                CM.Parameters.AddWithValue("pid_silais", PSilais);
                CM.Parameters["pid_silais"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pid_municipio", PMunicipio);
                CM.Parameters["pid_municipio"].Direction = ParameterDirection.Input;
                
                CM.Parameters.AddWithValue("pnombreUni", PNombreUnidad);
                CM.Parameters["pnombreUni"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("psector", PSector);
                CM.Parameters["psector"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pbarrio", PBarrio);
                CM.Parameters["pbarrio"].Direction = ParameterDirection.Input;

                CM.Parameters.AddWithValue("pdireccion", PDireccion);
                CM.Parameters["pdireccion"].Direction = ParameterDirection.Input;

                x = CM.Parameters.AddWithValue("ppsmj", "");
                CM.Parameters["ppsmj"].Direction = ParameterDirection.Output;

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

        // Consultar lista de : unidades
        public DataTable listarUnidades(String sql)
        {
            DataTable DT = new DataTable();
            clsDatosMetodosGlobales MD = new clsDatosMetodosGlobales();
            DT = MD.bdd_consultas(sql);

            return DT;
        }
    }
}
