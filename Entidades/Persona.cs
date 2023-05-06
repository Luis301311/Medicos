using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {


        public Persona(int id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono)
        {
            Id = id;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Telefono = telefono;
        }

        public Persona(int id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, string correo, int edad)
        {
            Id = id;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Telefono = telefono;
            Correo = correo;
            Edad = edad;
        }

        public Persona()
        {
        }

        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int Edad { get; set; }


    }
}
