using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico:Persona
    {

        public Medico() { }
        public Medico(int Id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int edad, string especialidad, string correo,
            string telefono, int aniosExperiencia) : base(Id,primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, correo, edad)
        {

            Especialidad = especialidad;
            AniosExperiencia = aniosExperiencia;
        }

      
        public override string ToString()
        {
            return $"{Id};{PrimerNombre};{SegundoNombre};{PrimerApellido};{SegundoApellido};{Edad};{Telefono};{Correo};{Especialidad};{AniosExperiencia}";
        }

        public string Especialidad { get; set; }

        public int AniosExperiencia { get; set; }

    }
}

