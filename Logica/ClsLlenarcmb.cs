using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class ClsLlenarcmb
    {

       public DataTable CmbElegirSilais()
        {

            String sql2 = "SELECT id_silais, nombre_silais FROM silais";
            ClsLogicaConsulta consulta = new ClsLogicaConsulta();
            return consulta.ConsultaTab(sql2);

        }

        public DataTable CmbElegirUnidad()
        {

            String sql2 = "SELECT id_unidad, nombre_unidad FROM unidad_vacunacion";
            ClsLogicaConsulta consulta = new ClsLogicaConsulta();
            return consulta.ConsultaTab(sql2);

        }

       public DataTable CmbElegirSilais2()
        {

            String sql2 = "SELECT id_unidad, nombre_unidad FROM unidad_vacunacion";
            ClsLogicaConsulta consulta = new ClsLogicaConsulta();
            return consulta.ConsultaTab(sql2);
        }

        public DataTable BuscarhistorialV()
        {

            String sql2 = "SELECT id_vacuna, nombre_vacuna FROM infovacu";
            ClsLogicaConsulta consulta = new ClsLogicaConsulta();
            return consulta.ConsultaTab(sql2);

        }

        public DataTable BuscarSilaisLotes()
        {

            String sql2 = "SELECT id_silais, nombre_silais FROM silais";
            ClsLogicaConsulta consulta = new ClsLogicaConsulta();
            return consulta.ConsultaTab(sql2);

        }
        
    }

}