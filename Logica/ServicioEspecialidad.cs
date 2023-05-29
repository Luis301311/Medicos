using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using BaseDeDatos;

namespace Logica
{
    public class ServicioEspecialidad : InterfazHospital<Especialidad>
    {
        DatosEspecialidad datos = new DatosEspecialidad();
        public bool Add(Especialidad persona)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(string id)
        {
            throw new NotImplementedException();
        }

        public List<Especialidad> GetAll()
        {
            return datos.ObtenerEspecialidades();
        }

        public List<Especialidad> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Especialidad id)
        {
            throw new NotImplementedException();
        }
    }
}
