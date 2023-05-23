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

        public DataTable MostrarPacientes()
        {     
            tabla = enlacePaciente.MostrarPacientes();
            return tabla;
        }

        public ServicioPaciente()
        {
            pacientes = new List<Paciente>();
        }

        //public int BuscarPorNombre(string name)
        //{
            
        //}

        public bool Add(Paciente enlace)
        {
            enlacePaciente.InsertarPaciente(enlace);
            return true;
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

            if (pacientes == null) return null;

            return pacientes;
        }

        public List<Paciente> GetByName(string name)
        {
            var lista =new List<Paciente>();

            foreach( var item in GetByAll())
            {
                if(item.PrimerNombre.ToLower().Contains(name.ToLower()))
                {
                    lista.Add(item);
                }
            }

            if (lista.Count == 0) return null;
            return lista;
        }

        public bool Update(Paciente paciente)
        {
            enlacePaciente.ActualizarPacinete(paciente);
            return true;
        }
       
    }
}
