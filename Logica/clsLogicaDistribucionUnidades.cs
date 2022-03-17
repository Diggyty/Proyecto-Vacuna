using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class clsLogicaDistribucionUnidades
    {


        public String guardarLote(int Vacuna, int Lote, int Unidad, int Silais, int Cantidad3)
        {
            String mensaje;
            int i;
            clsDatosDistribucionUnidades Guardar = new clsDatosDistribucionUnidades();
            i = Guardar.AgregarDistribucionUnidades(Vacuna, Lote, Unidad, Silais, Cantidad3);

            if (i == 0)
            {
                mensaje = "Error no determinado.";
            }
            else if (i == 8)
            {                            
                mensaje = "Lote ya existe.";
            }
            else if (i == 10)
            {
                mensaje = "Lote guardado.";
            }
            else
            {
                mensaje = Convert.ToString(i);
            }

            return mensaje;

        }







        /*     public String guardarLote(int id_Vacuna, int id_Silais, int nombre_silais, int Cantidad, int id_Lote)
             {

                 String mensaje;
             int i;
             clsDatosLote Guardar = new clsDatosLote();
             i = Guardar.AgregarLote(Vacuna, Silais, FechaEntrada, Unidades, FechaAutorizacion, FechaVencimiento);





             } */

    }
}
