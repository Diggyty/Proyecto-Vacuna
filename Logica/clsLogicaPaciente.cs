using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class clsLogicaPaciente
    {
        clsDatosPaciente anadirPaciente = new clsDatosPaciente();

        public string AgregarPaciente( String Cedula, String Nombre, String Apellido, String Sexo, String fecha_nacimiento, String Direccion,  string NumeroTelefono, int municipio)
        {
            
            String mensaje;
            string i;


            i = anadirPaciente.RegistrarPaciente( Cedula, Nombre, Apellido, Sexo, fecha_nacimiento, Direccion, NumeroTelefono, municipio);

            if (i == "0")
            {
                mensaje = "Error no determinado";
            }
            else if (i == "12")
            {
                mensaje = "No esta disponible ";
            }
            else if (i == "9")
            {
                 mensaje = "Se agrego Correctamente";
            }
            else
            {
                mensaje = Convert.ToString(i);
            }
            return mensaje;

        }
        public string AgregarPacienteM(String pNombre, String pApellido, String psexo, String pfecha_nacimiento, String pDireccion, int municipios, string pIdentificador)
        {

            String mensaje;
            string i;


            i = anadirPaciente.RegistrarPacienteM(pNombre,pApellido,psexo, pfecha_nacimiento,pDireccion,municipios,pIdentificador);

            if (i == "0")
            {
                mensaje = "Error no determinado";
            }
            else if (i == "12")
            {
                mensaje = "No se puedo agregar correctamente";
            }
            else if (i == "9")
            {
                mensaje = "Se agrego Correctamente";
            }
            else
            {
                mensaje = Convert.ToString(i);
            }
            return mensaje;

        }

        public DataTable GridListarPacientes(String condicion)
        {
            String sql = " select * form paciente where paciente.cedul LIKE '%" + condicion + "%'";
            Datos.clsDatosPaciente lista = new Datos.clsDatosPaciente();
            return lista.ListaPacientes(condicion);
            DataTable DT = new DataTable();
            return DT;
                
            
        }

        public DataTable cmbMunicipios()
        {
            clsDatosPaciente x = new clsDatosPaciente();
            String sql = "SELECT id_municipios,CONCAT_WS('-',nombre_municipio) AS MunicipioDato FROM municipios";
            return x.LlenarCmb(sql);

        }
        public DataTable listarPersonas(String x)
        {
            String sql = " Select * from personas where personas.cedula LIKE '%" + x + "%'";
            Datos.clsDatosPaciente lista = new Datos.clsDatosPaciente();
            return lista.Listarpersonas(x);
            DataTable DT = new DataTable();
            return DT;
        }

    }
}
