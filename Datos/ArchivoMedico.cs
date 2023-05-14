using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArchivoMedico : Archivo
    {
        public ArchivoMedico(string ruta) : base(ruta)
        {
        }


        public Medico Mapeador(string linea)
        {
            var enlace = new Medico();
            string[] aux = linea.Split(';');

            enlace.Id = int.Parse(aux[0]);
            enlace.PrimerNombre = aux[1];
            enlace.SegundoNombre = aux[2];
            enlace.PrimerApellido = aux[3];
            enlace.SegundoApellido = aux[4];
            enlace.Edad = int.Parse(aux[5]);
            enlace.Telefono = aux[6];
            enlace.Correo = aux[7];
            enlace.AniosExperiencia= int.Parse(aux[8]);
            enlace.Especialidad= aux[9];
          
            return enlace;
        }

        public List<Medico> Leer()
        {
            var lista = new List<Medico>();
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

        public bool Eliminar(List<Medico> lista)
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


