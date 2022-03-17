using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //vinculo de Mysql
using System.Data;

namespace Datos
{
    public class clsDatosTipoTelefono
    {
        clsDatosConexion conex = new clsDatosConexion();
        public int AgregarTipoTelefonos(String descripcion_tel)
        {
            //Gestion por parte de PA
            MySqlCommand CM = new MySqlCommand();

            try
            {
                MySqlParameter x;
                conex.conectar2.Open();

                CM.Connection = conex.conectar2;
                CM.CommandType = CommandType.StoredProcedure;
                CM.CommandText = "AgregarTipoTelefonos";

                //Los parametros que envio
                CM.Parameters.AddWithValue("pdescripciontel", descripcion_tel);
                CM.Parameters["pdescripciontel"].Direction = ParameterDirection.Input;

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
        //El metodo Data table es útil para guardar información tabulada
        public DataTable ListarTelefonos(String sql)
        {
            DataTable dat = new DataTable(); // Objeto del metodo DataTable
            clsDatosMetodosGlobales MG = new clsDatosMetodosGlobales();

            dat = MG.bdd_consultas(sql);

            return dat;   //Retornamos el tipo de dato DataTable
        }
    }
}
