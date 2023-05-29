using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {
        public Paciente() 
        { }

        public string Eps { get; set; }
        public string Direccion { get; set;}
        public string Tipo_Sangre { get; set; }

    }
}

