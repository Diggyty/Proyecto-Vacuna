using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proyecto_Vacuna
{
    class clsControl
    {

        public string ctrlRegistro(clsUsuario usuario)
        {

            clsModelo modelo = new clsModelo();
            String respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario1) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword)
                || string.IsNullOrEmpty(usuario.Nombre))
            {

                respuesta = "Debe llenar todos los campos";


            }
            else
            {
                if (usuario.Password == usuario.ConPassword)
                {

                    if (modelo.existeUsuario(usuario.Usuario1))
                    {

                        respuesta = "El usuario ya existe";

                    }
                    else
                    {

                        usuario.Password = generarSHA1(usuario.Password);
                        modelo.registro(usuario);

                    }

                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }

            return respuesta;

        }

        public string crtlLogin(string usuario, string password)
        {
            clsModelo modelo = new clsModelo();
            string respuesta = "";
            clsUsuario datosusuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                datosusuario = modelo.validacion(usuario);
                if (datosusuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosusuario.Password != generarSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no existen";
                    }
                    else
                    {
                        clsSession clsSession = new clsSession();
                        clsSession.id_usuario = datosusuario.Id;
                        clsSession.usuario = usuario;
                        clsSession.nombre = datosusuario.Nombre;
                        clsSession.id_tipoUsuario = datosusuario.Id_tpo;

                    }
                }
            }
            return respuesta;
        }

        private string generarSHA1(string cadena)
        {

            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }

                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();

        }


    }
}
