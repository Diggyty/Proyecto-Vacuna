using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class clsLogicaPersona
    {
        clsDatosPersona AddPersona = new clsDatosPersona();

        public String guardarPersona(String Cedula, String NombrePersona, String ApellidoPersona)
        {
            string mensaje;
            mensaje = AddPersona.AgregarPersona(Cedula, NombrePersona, ApellidoPersona);


            //i = AddPersona.AgregarPersona(Cedula, NombrePersona, ApellidoPersona);  componener

            if (mensaje == "8")
            {
                mensaje = "Persona Guardada";
            }
            else
            {
                mensaje = "Error al guardar";
            }

            return mensaje;
        }

        public DataTable datos(String x)
        {
            String sql = "Select cedula AS Cedula, nombre AS Nombre, apellido AS Apellido FROM persona where " + x;
            clsDatosPersona Lista = new clsDatosPersona();
            DataTable DT = new DataTable();

            DT = AddPersona.datos(sql);
            //DT = Lista.listarNombre(sql);

            return DT;

        }
       
    }
}
