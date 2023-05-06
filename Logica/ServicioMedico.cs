using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioMedico : InterfazHospital<Medico>
    {
        List<Medico> medicos = null;
        ArchivoMedico archivo = new ArchivoMedico("Medicos.txt");

        public ServicioMedico()
        {
            medicos = new List<Medico>();
        }
        public bool Add(Medico enlace)
        {
            try
            {
                if (enlace == null)
                {
                    return false;
                }
                else if (Exist(enlace.Id) == false)
                {
                    archivo.GuardarPersona(enlace);
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
            var lista = new List<Medico>();

            foreach (var item in GetByAll())
            {
                if (item.Id != id)
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

        public List<Medico> GetByAll()
        {
            medicos = archivo.Leer();

            if (medicos == null) return null;

            return medicos;
        }

        public List<Medico> GetByName(string name)
        {
            var lista = new List<Medico>();

            foreach (var item in GetByAll())
            {
                if (item.PrimerNombre.ToLower().Contains(name.ToLower()))
                {
                    lista.Add(item);
                }
            }

            if (lista.Count == 0) return null;
            return lista;
        }

        public bool Update(Medico medico)
        {
            var listaActualizar = GetByAll();
            foreach (var item in listaActualizar)
            {
                if (item.Id == medico.Id)
                {
                    item.PrimerNombre = medico.PrimerNombre;
                    item.SegundoNombre = medico.SegundoNombre;
                    item.PrimerApellido = medico.PrimerApellido;
                    item.SegundoApellido = medico.SegundoApellido;
                    item.Edad = medico.Edad;
                    item.Correo = medico.Correo;
                    item.Telefono = medico.Telefono;
                    item.AniosExperiencia = medico.AniosExperiencia;
                    item.Especialidad = medico.Especialidad;
                }
            }
            archivo.Eliminar(listaActualizar);
            return true;
        }
    }
}
