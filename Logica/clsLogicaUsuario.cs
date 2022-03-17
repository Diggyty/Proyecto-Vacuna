using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
namespace Logica
{
    public class clsLogicaUsuario
    {
        public String loguear(String usuario, String clave)
        {
            clsDatosUsuario x = new clsDatosUsuario();
            String resp;

            resp = x.login(usuario, clave);

            //evaluar resultado
            if (resp == "OK")
            {
                return "Iniciar";
            }
            else if (resp == "DSBL")
            {
                return "Desabilitada";
            }
            else if (resp == "NO")
            {
                return "No Encontrado";
            }
            else

                return "Error";
        }
    }
}
