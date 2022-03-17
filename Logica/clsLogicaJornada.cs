using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class clsLogicaJornada
    {
       
       

        public String guardarJornada(String Nombre, String Descripcion, String FechaInicio, String FechaCierre)
        {
            String mensaje;
            int i;
            clsDatosJornada Guardar = new clsDatosJornada();
            i = Guardar.AgregarJornada(Nombre, Descripcion, FechaInicio, FechaCierre);

            if (i == 0)
            {
                mensaje = "auroraaaa";
            }
            else if   (i == 10)
    {
                mensaje = " Jornada ya existe ";
    }
            else if (i == 9)
            {
                mensaje = "Jornada guardada ";
            }
            else
            {
                mensaje = Convert.ToString(i);
            }

            return mensaje;

        }
        

        /*
        public DataTable mostrarLotes(string condicion)
        {
            CDatosOrdenEntrega x = new CDatosOrdenEntrega();
            String sql = "SELECT * FROM vistaordenentrega WHERE " + condicion;

            return x.LlenarDgvLotes(sql);  supongo que aun faltan funciones
        }
        */

    }
}

