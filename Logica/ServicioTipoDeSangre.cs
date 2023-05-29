using BaseDeDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public  class ServicioTipoDeSangre : InterfazHospital<TipodeSangre>
    {
        DatosTipodeSangre DatosTipoSangre = new DatosTipodeSangre();

        public bool Add(TipodeSangre persona)
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

        public List<TipodeSangre> GetAll()
        {
           return DatosTipoSangre.ObtenerTiposDeSangre();
        }

        public List<TipodeSangre> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<TipodeSangre> TableToList(DataTable tabla)
        {
            throw new NotImplementedException();
        }

        public bool Update(TipodeSangre id)
        {
            throw new NotImplementedException();
        }
    }
}
