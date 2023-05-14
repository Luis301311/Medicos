using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class ServicioPaciente : InterfazHospital<Paciente>
    {
        List<Paciente> pacientes = null;
        ArchivoPaciente archivo = new ArchivoPaciente("Paciente.txt");


        public ServicioPaciente()
        {
            pacientes = new List<Paciente>();
        }

        //public int BuscarPorNombre(string name)
        //{
            
        //}

        public bool Add(Paciente enlace)
        {
            try
            {
                if (enlace == null)
                {
                    return false;
                }
                else if (Exist(enlace.Id) == false)
                {
                    archivo.Guardar(enlace);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
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
            return archivo.Eliminar(lista);
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
            pacientes=archivo.Leer();

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
            var listaActualizar = GetByAll();
            foreach (var item in listaActualizar)
            {
                if (item.Id == paciente.Id)
                {
                    item.PrimerNombre = paciente.PrimerNombre;
                    item.SegundoNombre = paciente.SegundoNombre;
                    item.PrimerApellido = paciente.PrimerApellido;
                    item.Edad= paciente.Edad;
                    item.Nacionalidad = paciente.Nacionalidad;
                    item.Ocupacion= paciente.Ocupacion;
                    item.Direccion= paciente.Direccion;
                    item.FechaNacimiento = paciente.FechaNacimiento;
                    item.Correo= paciente.Correo;
                    item.NivelEducativo=paciente.NivelEducativo;
                    item.EstadoCivil=paciente.EstadoCivil;
                    item.Regimen=paciente.Regimen;
                    item.Telefono=paciente.Telefono;
                    item.SegundoApellido=paciente.SegundoApellido;
                }
            }
            archivo.Eliminar(listaActualizar);
            return true;
        }
       
    }
}
