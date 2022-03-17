using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Collections;

namespace Logica
{
    public class ClsLogicaConsulta
    {

      clsDatosConsulta c = new clsDatosConsulta();
      ArrayList arr = new ArrayList();
      DataTable dt = new DataTable();

        public DataTable ConsultaTab(string sql)
        {

           DataTable tab = new DataTable();
           tab = c.Consulta(sql);
           return tab;

        } 
    }
}
