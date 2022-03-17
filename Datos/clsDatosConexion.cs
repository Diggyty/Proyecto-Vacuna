using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class clsDatosConexion
    {
        static string host = "127.0.0.1";
        static string usuario = "root";
        static string clave = "root";
        static string BasedeDatos = "proyecto vacuna";

        public MySqlConnection conectar2 = new MySqlConnection("datasource=" + host + ";username=" + usuario + ";password=" + clave + ";database=" + BasedeDatos);

        public MySqlConnection AbrirConexion()
        {
            if (conectar2.State == ConnectionState.Closed)
                conectar2.Open();
            return conectar2;
        }

        public MySqlConnection CerrarConexion()
        {
            if (conectar2.State == ConnectionState.Open)
                conectar2.Close();
            return conectar2;
        }

    }
}
