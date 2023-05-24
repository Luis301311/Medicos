using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using BaseDeDatos;
using System.Data;

namespace Logica
{
    public class ServicioPaciente : InterfazHospital<Paciente>
    {
        List<Paciente> pacientes = null;
        //ArchivoPaciente archivo = new ArchivoPaciente("Paciente.txt");
        DatosPacientes enlacePaciente = new DatosPacientes();
        DataTable tabla = new DataTable();

        public DataTable TablaPacientes()
        {
            return enlacePaciente.ObtenerTablaPacientes();
        }

        public ServicioPaciente()
        {
            pacientes = new List<Paciente>();
        }

        public bool Add(Paciente enlace)
        {
            if (Exist(enlace.Id) == false)
            {
                enlacePaciente.InsertarPaciente(enlace);
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            
            var lista = new List<Paciente>();

            foreach(var item in GetByAll())
            {
                if(item.Id != id)
                {
                    lista.Add(item);
                }
            }
            return true;
        }

        public bool Exist(int id)
        {
            if (GetByAll() != null)
            {
                foreach (var item in GetByAll())
                {
                    if (item.Id == id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Paciente> GetByAll()
        {
            // pacientes=archivo.Leer();

            var lista = enlacePaciente.ObtenerLista();
            return lista;
        }

        public DataTable GetByName(string cedula)
        {
            return enlacePaciente.ObtenerCedula(cedula);
        }

        public bool Update(Paciente paciente)
        {
            return enlacePaciente.ActualizarPacinete(paciente);

        }
       
        public DataTable ObtenerC()
        {
            return enlacePaciente.ObtenerCiudades();
        }

        public DataTable ObtenerT()
        {
            return enlacePaciente.ObtenerTiposSangre();
        }

        List<Paciente> InterfazHospital<Paciente>.GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
