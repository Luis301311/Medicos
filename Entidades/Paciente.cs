using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {
        public Paciente() {}
        public string Regimen { get; set; }
        public string Nacionalidad { get; set; }
        public string EstadoCivil { get; set; }
        public string NivelEducativo { get; set; }
        public string Direccion { get; set;}
        public string Ocupacion { get; set;}
        public DateTime FechaNacimiento { get; set; }
        public string Tipo_Sangre { get; set; }

    }
}

