using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioConsulta : InterfazHospital<Consulta>
    {
        List<Consulta> consultas = null;
        //ArchivoConsulta archivo = new ArchivoConsulta("Consulta.txt");

        public ServicioConsulta()
        {
            consultas = new List<Consulta>();
        }

        public bool Add(Consulta enlace)
        {
            try
            {
                if (enlace == null)
                {
                    return false;
                }
                else if (Exist(enlace.Id) == false)
                {
                   // archivo.Guardar(enlace);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            var lista = new List<Consulta>();

            foreach (var item in GetAll())
            {
                if (item.Id != id)
                {
                    lista.Add(item);
                }
            }
            return true;//archivo.Eliminar(lista);
        }

        public bool Exist(string id)
        {
            foreach (var item in GetAll())
            {
                if (item.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Consulta> GetAll()
        {
            //consultas = archivo.Leer();

            if (consultas == null) return null;

            return consultas;
        }

        public List<Consulta> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> TableToList(DataTable tabla)
        {
            throw new NotImplementedException();
        }

        public bool Update(Consulta id)
        {
            throw new NotImplementedException();
        }
    }
}
