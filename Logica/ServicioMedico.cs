using BaseDeDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioMedico : InterfazHospital<Medico>
    {
        List<Medico> medicos = new List<Medico>();
        DatosMedico DatosMedico = new DatosMedico();

        public ServicioMedico()
        {
            medicos = new List<Medico>();
        }

        private List<Medico> TableToList()
        {
            try
            {
                DataTable tabla = new DataTable();
                List<Medico> lista = new List<Medico> ();

                tabla = DatosMedico.ObtenerMedicos();

                foreach(DataRow fila in tabla.Rows)
                {
                    Medico medico = new Medico();

                    medico.Id = fila["cedula_medico"].ToString();
                    medico.PrimerNombre = fila["primer_nombre"].ToString();
                    medico.SegundoNombre = fila["segundo_nombre"].ToString();
                    medico.PrimerApellido = fila["primer_apellido"].ToString();
                    medico.SegundoApellido = fila["segundo_apellido"].ToString();
                    medico.FechaNacimiento = Convert.ToDateTime(fila["fecha_nacimiento"]);
                    medico.Telefono = fila["telefono"].ToString();
                    medico.Correo = fila["email"].ToString();
                    medico.Especialidad = fila["especialidad"].ToString();
                    medico.Nacionalidad = fila["ciudad"].ToString();
                    medico.FechaGraduado = Convert.ToDateTime(fila["fecha_graduado"]);

                    lista.Add(medico);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
}
        public List<Medico> GetAll()
        { 
            medicos = TableToList();
            return medicos;
        }
        public List<Medico> GetByName(string name)
        {
            var lista = new List<Medico>(); 
            foreach(var item in GetAll())
            {
                if(item.PrimerNombre.ToUpper().Contains(name.ToUpper()))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }
        public bool Exist(string id)
        {
            if (GetAll() != null)
            {
                foreach (var item in GetAll())
                {
                    if (item.Id == id) return true;
                }
            }
            return false;
        }
        public bool Add(Medico medico)
        {
            if (Exist(medico.Id)==true || medico==null) return false;
            return DatosMedico.InsertarMedico(medico);
        }
        public bool Update(Medico medico)
        {
            if(Exist(medico.Id) == true)
            {
                return DatosMedico.ActualizarMedico(medico);
            }
            return false;
        }
        public bool Delete(string id)
        {
            if (Exist(id) == false) return false;
            return DatosMedico.EliminarMedico(id.ToString());
        }
    }
}
