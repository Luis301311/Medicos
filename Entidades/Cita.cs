using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {

        public Cita()
        {
        }
        public int Id_cita { get; set; }
        public DateTime Fecha_cita { get; set; }
        public DateTime Duracion { get; set; }
        public string Cedula_medico { get; set;}
        public string Cedula_paciente { get; set; }
        public int Id_estado { get; set; }
        public string Id_consulta { get; set; }
        public int Activo { get; set; }

        public Cita(int id_cita, DateTime fecha_cita, DateTime duracion, string cedula_medico, string cedula_paciente, int id_estado, string id_consulta, int activo)
        {
            Id_cita = id_cita;
            Fecha_cita = fecha_cita;
            Duracion = duracion;
            Cedula_medico = cedula_medico;
            Cedula_paciente = cedula_paciente;
            Id_estado = id_estado;
            Id_consulta = id_consulta;
            Activo = activo;
        }
    }
}
