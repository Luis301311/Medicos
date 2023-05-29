using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta:Persona
    {
        Consulta() { }

        public int IdDescripcion { get; set; }
        public string ValoracionMedica { get; set; }
        public DateTime FechaValoracion { get; set; }
        public string Medicamentos { get; set; }
    }
}
