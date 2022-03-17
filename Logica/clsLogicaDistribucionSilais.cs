using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class clsLogicaDistribucionSilais
    {


        public String guardarLote(int Vacuna, int Lote, int Silais, int Cantidad2)
        {
            String mensaje;
            int i;
            clsDatosDistribucionSilais Guardar = new clsDatosDistribucionSilais();
            i = Guardar.AgregarDistribucion(Vacuna, Lote, Silais, Cantidad2);

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
