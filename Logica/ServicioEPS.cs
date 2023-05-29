using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using BaseDeDatos;

namespace Logica
{
    public class ServicioEPS : InterfazHospital<Eps>
    {
        DatosEPS datos = new DatosEPS();
        public bool Add(Eps persona)
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

        public List<Eps> GetAll()
        {
            return datos.ObtenerEps();
        }

        public List<Eps> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Eps id)
        {
            throw new NotImplementedException();
        }
    }
}
