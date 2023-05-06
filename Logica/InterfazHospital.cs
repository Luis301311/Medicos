using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface InterfazHospital<Z>
    {
        List<Z> GetByAll();
        bool Add(Z persona);
        bool Exist(int id);
        bool Delete(int id);
        bool Update(Z id);
        List<Z> GetByName(string name);
    }
}
