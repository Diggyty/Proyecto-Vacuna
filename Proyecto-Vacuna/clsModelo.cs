using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;

namespace Proyecto_Vacuna
{
    class clsModelo
    {

        public int registro(clsUsuario usuario)
        {

            clsDatosConexion conex = new clsDatosConexion();
            conex.conectar2.Open(); 

            String sql = "INSERT INTO usuarios (usuario,password,nombre,id_tipoUsuario)" +
                "VALUES(@usuario, @password, @nombre, @id_tipoUsuario)";
            MySqlCommand comando = new MySqlCommand(sql, conex.conectar2);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario1);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@id_tipoUsuario", 2);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }

        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;


            clsDatosConexion conex = new clsDatosConexion();
            conex.conectar2.Open();

            String sql = "SELECT id_usuario FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conex.conectar2);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public clsUsuario validacion(string usuario)
        {
            MySqlDataReader reader;


            clsDatosConexion conex = new clsDatosConexion();
            conex.conectar2.Open();

            String sql = "SELECT id_usuario, password, nombre, id_tipoUsuario FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conex.conectar2);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            clsUsuario usr = null;

            while (reader.Read())
            {
                usr = new clsUsuario();

                usr.Id = int.Parse(reader["id_usuario"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Id_tpo = int.Parse(reader["id_tipoUsuario"].ToString());
                return usr;

            }
            return usr;

            /* if (reader.HasRows)
             {
                 return true;
             }
             else
             {
                 return false;
             }*/
        }
    }
}
