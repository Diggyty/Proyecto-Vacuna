using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class clsLogicaUnidadVacunacion
    {
        public DataTable cmbMunicipios()
        {
            clsDatosUnidadVacunacion x = new clsDatosUnidadVacunacion();
            String sql = "SELECT id_municipios,CONCAT_WS('-',nombre_municipio) AS MunicipioDato FROM municipios";
            return x.LlenarCmb(sql);

        }

        public DataTable cmbSilais()
        {
            clsDatosUnidadVacunacion x = new clsDatosUnidadVacunacion();
            String sql = "SELECT id_silais,CONCAT_WS('-',nombre_silais) AS DatosSilais FROM silais";
            return x.LlenarCmb(sql);
        }

        public DataTable ListarUnidades(String x)
        {
            String sql = "Select * FROM unidad_vacunacion where unidad_vacunacion.nombre_unidad LIKE '%" + x + "%' ";
            Datos.clsDatosUnidadVacunacion Lista = new Datos.clsDatosUnidadVacunacion();
            DataTable DT = new DataTable();

            DT = Lista.listarUnidades(sql);

            return DT;

        }
        /*
        public DataTable GridListarPaquetes(String condicion)
        {
            clsDatosOrdenEntrega orden = new clsDatosOrdenEntrega();

            return orden.ListaPaquetesGrid(condicion);
        }*/

        public string guardarUnidadVacunacion( int Silais, int Municipio, String Nombre, string Sector, String Barrio, String Direccion)
        {

            String respuesta;
            int i;
            clsDatosUnidadVacunacion Guardar = new clsDatosUnidadVacunacion();
            i = Guardar.AgregarUnidadVacunacion( Silais, Municipio, Nombre, Sector, Barrio ,Direccion);

            if (i == 3)
            {
                respuesta = "Unidad Guardada";
            }
            else
            {
                respuesta = "Error al guardar";
            }
            return respuesta;

        }

        /*public DataTable mostrarPaquetes(string condicion)
        {
            clsDatosUnidadVacunacion x = new clsDatosUnidadVacunacion();
            String sql = "SELECT * FROM vistaordenentrega WHERE " + condicion;----PARA MOSTRAR LAS UNIDADES DE VACUNACION

            return x.LlenarDgvDepartamentos(sql);
        }*/
    }
}
