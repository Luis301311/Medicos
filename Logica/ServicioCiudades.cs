using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using BaseDeDatos;

namespace Logica
{
    public class ServicioCiudades : InterfazHospital<Ciudad>
    {
        DatosCiudades datos = new DatosCiudades();
        public bool Add(Ciudad persona)
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

        public List<Ciudad> GetAll()
        {
            return datos.ObtenerCiudades();
        }

        public List<Ciudad> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ciudad id)
        {
            throw new NotImplementedException();
        }
    }
}
