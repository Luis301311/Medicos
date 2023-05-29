using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface InterfazHospital<Z>
    {
        List<Z> GetAll();
        bool Add(Z persona);
        bool Exist(string id);
        bool Delete(string id);
        bool Update(Z id);
        List<Z> GetByName(string name);
    }
}
