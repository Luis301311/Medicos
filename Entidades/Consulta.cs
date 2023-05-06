using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta:Persona
    {
        public Consulta() { }

        public Consulta(int idDescripcion, string valoracionMedica, DateTime fechaValoracion,
        string medicamentos, int idPaciente, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefonoPaciente)
        : base(idPaciente,primerNombre, segundoNombre, primerApellido, segundoApellido,telefonoPaciente)
        {
            IdDescripcion = idDescripcion;
            ValoracionMedica = valoracionMedica;
            FechaValoracion = fechaValoracion;
            Medicamentos = medicamentos;
        }

        public int IdDescripcion { get; set; }
        public string ValoracionMedica { get; set; }
        public DateTime FechaValoracion { get; set; }
        public string Medicamentos { get; set; }
    }
}
