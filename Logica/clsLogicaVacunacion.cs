using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos; 

namespace Logica
{
    public class clsLogicaVacunacion
    {

        public DataTable CbxPaciente()
        {
            clsDatosVacunacion x = new clsDatosVacunacion();
            String sql = "SELECT id_paciente,CONCAT_WS(' - ',nombre_personas,apellido_personas) AS PacienteDatos FROM personas,paciente WHERE personas.cedula = paciente.cedula;";
            return x.LlenarCmb(sql);
        }

        public DataTable edadPersona(String x)
        {
            String sql = "SELECT paciente.fecha_nacimiento FROM paciente WHERE paciente.cedula = '" + x +"'";
            Console.WriteLine("\n\n\n\n" + sql);
            Datos.clsDatosVacunacion Lista = new Datos.clsDatosVacunacion();
            DataTable DT;

            DT = Lista.LlenarCmb(sql);

            return DT;
        }


        public DataTable ListarPersonas(String x)
        {
            String sql = "Select * FROM VistaPersonasRegistradas where VistaPersonasRegistradas.cedula LIKE '%" + x + "%' ";
            Datos.clsDatosVacunacion Lista = new Datos.clsDatosVacunacion();
            DataTable DT = new DataTable();

            DT = Lista.LlenarCmb(sql);

            return DT;
        }

        public DataTable ListarDistribucionUnidad(String x)
        {
            String sql = "Select * FROM vistavacunasunidades where vistavacunasunidades.id_lote LIKE '%" + x + "%' ";
            Datos.clsDatosVacunacion Lista = new Datos.clsDatosVacunacion();
            DataTable DT = new DataTable();

            DT = Lista.LlenarCmb(sql);

            return DT;
        }

        public DataTable ListarJornadas(String x)
        {
            String sql = "Select * FROM jornada_vacunacion where jornada_vacunacion.id_jornada LIKE '%" + x + "%' ";
            Datos.clsDatosVacunacion Lista = new Datos.clsDatosVacunacion();
            DataTable DT = new DataTable();

            DT = Lista.LlenarCmb(sql);

            return DT;
        }

        public DataTable CbxUnidadVacunacion()
        {
            clsDatosVacunacion x = new clsDatosVacunacion();
            String sql = "SELECT id_unidad,CONCAT_WS(' - ',nombre_unidad,barrio) AS DatoUnidad FROM unidad_vacunacion";
            return x.LlenarCmb(sql);
        }

        public DataTable CbxVacuna()
        {
            clsDatosVacunacion x = new clsDatosVacunacion();
            String sql = "SELECT id_vacuna,CONCAT_WS(' - ',nombre_vacuna,desarrollador) AS DatoVacuna FROM vacuna";
            return x.LlenarCmb(sql);
        }

        public DataTable CbxLote()
        {
            clsDatosVacunacion x = new clsDatosVacunacion();
            String sql = "SELECT id_lote,CONCAT_WS('-',id_lote,fecha_entrada) AS DatoLote FROM lote";
            return x.LlenarCmb(sql);
        }

        public DataTable CbxSupervisor()
        {
            clsDatosVacunacion x = new clsDatosVacunacion();
            String sql = "SELECT id_supervisor,CONCAT_WS('-',id_supervisor) AS DatoSupervisor FROM supervisor";
            return x.LlenarCmb(sql);
        }

        public DataTable CbxVacunador()
        {
            clsDatosVacunacion x = new clsDatosVacunacion();
            String sql = "SELECT id_vacunador,CONCAT_WS('-',id_vacunador) AS DatoVacunador FROM vacunador";
            return x.LlenarCmb(sql);
        }


        /*
        public DataTable ListarLotes(String x)
        {
            String sql = "Select * FROM lote where lote.fecha_entrada LIKE '%" + x + "%' ";
            Datos.clsDatosLote Lista = new Datos.clsDatosLote();
            DataTable DT = new DataTable();

            DT = Lista.listarLotes(sql);

            return DT;

        }*/
        public string guardarVacunacion(int pPaciente, int pUnidad,int pVacuna, int plote, String pEstrategia, int pDosisAplicada, String pFechaVac, String pFechaSegundaD, String pEdadVacunacion, int pJornada, int pVacunador,int pSupervisor)
        {//agregar que vacuna va
            String respuesta;
            int i;
            clsDatosVacunacion vacunacion = new clsDatosVacunacion();
            i = vacunacion.Agregar_vacunacion(pPaciente, pUnidad, pVacuna, plote, pEstrategia ,pDosisAplicada, pFechaVac, pFechaSegundaD, pEdadVacunacion, pJornada, pVacunador, pSupervisor);

            if (i == 0)
            {
                respuesta = "A ocurrido un error";
            }
            else if (i == 10)
            {
                respuesta = "Esta vacunacion ya fue registrada";
            }
            else if (i == 9)
            {
                respuesta = "Valor guardado";
            }
            else
            {
                respuesta = Convert.ToString(i);
            }
            return respuesta;
        }

        
    }
}
