using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class clsLogicaLote
    {
        public DataTable cmbVacunas()
        {
            clsDatosLote x = new clsDatosLote();
            String sql = "SELECT id_vacuna,CONCAT_WS('-',nombre_vacuna,desarrollador) AS DatosVacuna FROM vacuna";
            return x.LlenarCmb(sql);
        }
        public DataTable cmbSilais()
        {
            clsDatosLote x = new clsDatosLote();
            String sql = "SELECT id_silais,CONCAT_WS('-',nombre_silais,id_direccion) AS DatosSilais FROM silais";
            return x.LlenarCmb(sql);
        }

        public DataTable cmbUnidades(int idSilais)
        {

            clsDatosLote x = new clsDatosLote();
            String sql = "SELECT id_unidad,nombre_unidad AS DatosUnidades FROM unidad_vacunacion WHERE unidad_vacunacion.id_silais = " + idSilais;
            return x.LlenarCmb(sql);

        }

        public DataTable cmbnV()
        {
            clsDatosLote x = new clsDatosLote();
            String sql = "SELECT id__vacuna,CONCAT_WS('-',nombre_vacuna) AS DatosVacuna FROM vacuna";
            return x.LlenarCmb(sql);
        }

        public DataTable ListarLotes(String x)
        {
            String sql = "Select * FROM vistalote where vistalote.fecha_entrada LIKE '%" + x + "%' ";
            Datos.clsDatosLote Lista = new Datos.clsDatosLote();
            DataTable DT = new DataTable();

            DT = Lista.listarLotes(sql);

            return DT;

        }

        public DataTable ListarDistribucionUnidades(String x)
        {
            String sql = "Select * FROM vistadistribucion where vistadistribucion.id_lote LIKE '%" + x + "%' ";
            Datos.clsDatosLote Lista = new Datos.clsDatosLote();
            DataTable DT = new DataTable();

            DT = Lista.listarLotes(sql);

            return DT;

        }

        public String guardarLote(int Vacuna, int Silais, String FechaEntrada, int Unidades, String FechaVencimiento)
        {
            String mensaje;
            int i;
            clsDatosLote Guardar = new clsDatosLote();
            i = Guardar.AgregarLote(Vacuna, Silais, FechaEntrada, Unidades,  FechaVencimiento);

            if (i == 0)
            {
                mensaje = "error no determinado";
            }
            else if   (i == 8)
    {
                mensaje = " lote ya existe ";
    }
            else if (i == 10)
            {
                mensaje = "lote guardado ";
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

