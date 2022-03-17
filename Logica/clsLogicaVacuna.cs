using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Logica
{
    public class clsLogicaVacuna
    {
        public string guardarVacuna(String NombreVac, String Desarrollador, String NDosis, String TiempoAlma, String NivelEfectividad,String CondicionesAlma,string procedencia)
        {
            clsDatosVacuna Guardar = new clsDatosVacuna();

            string mensaje;
            mensaje = Guardar.AgregarVacuna(NombreVac, Desarrollador, NDosis, TiempoAlma, NivelEfectividad, CondicionesAlma, procedencia);
            
            if (mensaje == "0")
            {
                mensaje = "Ocurrio un error";
            }
             else if (mensaje == "7")
            {
                mensaje = "La vacuna ya esta registrada";
            }
            else if (mensaje == "8")
            {
                mensaje = "Vacuna Guardada";
            }
            else
            {
                mensaje = "Error no determinado";
            }
            return mensaje;
             
        }
      
        public DataTable ListarVacuna(String x)
        {
            String sql = "Select * FROM vacuna where vacuna.nombre_vacuna LIKE '%" + x + "%' ";
            Datos.clsDatosVacuna Lista = new Datos.clsDatosVacuna();
            DataTable DT = new DataTable();

            DT = Lista.listarVacuna(sql);

            return DT;

        }


        public void eliminarVacuna(int id_vacuna)
        {
            String sql = "DELETE FROM vacuna where vacuna.id_vacuna=id_vacuna";
            Datos.clsDatosVacuna Lista = new Datos.clsDatosVacuna();
            Lista.listarVacuna(sql);

            

            

        }
        /*public DataTable mostrarVacunas(string condicion)
        {
            clsDatosVacuna x = new clsDatosVacuna();
            String sql = "SELECT * FROM vistavacuna WHERE " + condicion;

            return x.LlenarDgv/correspondiente/(sql);
        }*/
    }
}
