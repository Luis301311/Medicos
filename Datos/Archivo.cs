using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        protected string ruta = "Personas.txt";

        public Archivo() { }

        public Archivo(string ruta)
        {
            this.ruta = ruta;
        }

        public string Guardar(Persona enlace)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(enlace.ToString());
                sw.Close();

                return $"Guardado exitosamente.";

            }
            catch (Exception e)//TODO
            {
                return $"Error al guardar" + e.Message;
            }
        }
    }
}
