using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Logica
{
    public class clsLogicaDepartamento
    {
        clsDatosDepartamento AddDepartamento = new clsDatosDepartamento();
        public string AgregarDepartamentos(String nombre_departamento)
        {
            String respuesta;
            int i;

            i = AddDepartamento.AgregarDepartamentos(nombre_departamento);

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
            string sql = "SELECT * from departamentos WHERE departamentos.nombre_departamento LIKE '%" + x + "%'";
            //  string sql = "SELECT * from tipo_camiones";
            DataTable DT = new DataTable();
            DT = AddDepartamento.datos(sql);

            return DT;
        }
    }
}
