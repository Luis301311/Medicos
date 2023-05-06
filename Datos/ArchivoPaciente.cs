using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArchivoPaciente:Archivo
    {
        public ArchivoPaciente(string ruta) : base(ruta)
        {
        }


        public Paciente Mapeador(string linea)
        {
            var enlace = new Paciente();
            string[] aux = linea.Split(';');

            enlace.Id = int.Parse(aux[0]);
            enlace.PrimerNombre = aux[1];
            enlace.SegundoNombre = aux[2];
            enlace.PrimerApellido = aux[3];
            enlace.SegundoApellido = aux[4];
            enlace.Edad = int.Parse(aux[5]);
            enlace.FechaNacimiento = DateTime.Parse(aux[6]);
            enlace.Telefono = aux[7];
            enlace.Direccion = aux[8];
            enlace.Ocupacion = aux[9];
            enlace.Correo = aux[10];
            enlace.Regimen = aux[11];
            enlace.Nacionalidad = aux[12];
            enlace.EstadoCivil = aux[13];
            enlace.NivelEducativo = aux[14];

            return enlace;
        }

        public List<Paciente> Leer()
        {
            var lista = new List<Paciente>();
            try
            {
                var sr = new StreamReader(ruta);

                while (!sr.EndOfStream)
                {
                    lista.Add(Mapeador(sr.ReadLine()));
                }

                sr.Close();
                return lista;
            }
            catch (Exception) { return null; }

        }


        public bool Eliminar(List<Paciente> lista)
        {
            string rutaTemp = "Temp.txt";
            var sw = new StreamWriter(rutaTemp);
            foreach (var e in lista)
            {
                sw.WriteLine(e.ToString());
            }
            sw.Close();

            File.Delete(ruta);
            File.Move(rutaTemp, ruta);
            return true;
        }
       
    }
}
