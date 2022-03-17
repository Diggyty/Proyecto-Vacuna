using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class clsDatosConsulta
    {

        clsDatosConexion conexion = new clsDatosConexion();

         public DataTable Consulta(string sql)
        {
            MySqlDataReader leer;
            DataTable tabla = new DataTable();
            MySqlCommand comando = new MySqlCommand();

            conexion.conectar2.Open();
            tabla.Clear();
            comando.Connection = conexion.conectar2;
            comando.CommandText = sql;
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.conectar2.Close();
            return tabla;
            

        }


    }
}
