using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArchivoConsulta:Archivo
    {
        public ArchivoConsulta(string ruta) : base(ruta)
        {
        }


        public Consulta Mapeador(string linea)
        {
            var enlace = new Consulta();
            string[] aux = linea.Split(';');

            enlace.Id = int.Parse(aux[0]);
            enlace.ValoracionMedica = aux[1];
            enlace.Medicamentos = aux[2];
            enlace.FechaValoracion = DateTime.Parse(aux[3]);

            return enlace;

    }

        public List<Consulta> Leer()
        {
            var lista = new List<Consulta>();
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


        public bool Eliminar(List<Consulta> lista)
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
