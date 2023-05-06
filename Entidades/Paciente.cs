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
        {
        }

        public Paciente(int id, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int edad, DateTime fechaNacimiento, string telefono, string correo,
                        string regimen, string nacionalidad, string estadoCivil, string nivelEducativo,
                        string direccion, string ocupacion)
                        : base (id, primerNombre, segundoNombre, primerApellido, segundoApellido, telefono,correo,edad)
        {
            Regimen = regimen;
            Nacionalidad = nacionalidad;
            EstadoCivil = estadoCivil;
            NivelEducativo = nivelEducativo;
            Direccion = direccion;
            Ocupacion = ocupacion;
            FechaNacimiento = fechaNacimiento;
        }

        public string Regimen { get; set; }
        public string Nacionalidad { get; set; }
        public string EstadoCivil { get; set; }
        public string NivelEducativo { get; set; }
        public string Direccion { get; set;}
        public string Ocupacion { get; set;}
       
        public DateTime FechaNacimiento { get; set; }

        public override string ToString()
        {
            return $"{Id};{PrimerNombre};{SegundoNombre};{PrimerApellido};{SegundoApellido};{Edad};{FechaNacimiento};{Telefono};{Direccion};{Ocupacion};{Correo};{Regimen};" +
                $"{Nacionalidad};{EstadoCivil};{NivelEducativo}";
        }
    }
}

