using BaseDeDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public  class ServicioTipoDeSangre : InterfazHospital<TipodeSangre>
    {
        List<Paciente> pacientes = null;
        //ArchivoPaciente archivo = new ArchivoPaciente("Paciente.txt");
        DatosPacientes enlacePaciente = new DatosPacientes();
       // DataTable tabla = new DataTable();

        public bool Add(TipodeSangre persona)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipodeSangre> GetByAll()
        {
           return new BaseDeDatos.DatosTipodeSangre().ObtenerTiposDeSangre();
        }

        public List<TipodeSangre> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(TipodeSangre id)
        {
            throw new NotImplementedException();
        }
    }
}
