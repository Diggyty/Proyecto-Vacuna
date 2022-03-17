using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class clsLogicaTipoTelefono
    {
        clsDatosTipoTelefono AddTTelefonos = new clsDatosTipoTelefono();

        public string AgregarTipoTelefonos(String decripcion_tel)
        {
            String respuesta;
            int i;

            i = AddTTelefonos.AgregarTipoTelefonos(decripcion_tel);

            if (i == 0)
            {
                respuesta = "Ocurrio un error";
            }
            else if (i == 13)
            {
                respuesta = "El valor ya existe";
            }
            else if (i == 7)
            {
                respuesta = "Valor guardado";
            }
            else
            {
                respuesta = "Error no determinado";
            }
            return respuesta;
        }
        public DataTable datosrecib(String x)
        {
            string sql = "SELECT * from tipo_telefonos WHERE tipo_telefonos.descripcion LIKE '%" + x + "%'";
            //  string sql = "SELECT * from tipo_camiones";
            DataTable DT = new DataTable();
            DT = AddTTelefonos.ListarTelefonos(sql);

            return DT;
        }
    }
}
