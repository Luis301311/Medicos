using System;
using System.Collections.Generic;
using Entidades;
using BaseDeDatos;
using System.Data;
using System.Linq;

namespace Logica
{
    public class ServicioPaciente : InterfazHospital<Paciente>
    {
        List<Paciente> ListaPacientes = new List<Paciente>();
        DatosPacientes enlacePaciente = new DatosPacientes();
        DataTable tabla = new DataTable();

        public ServicioPaciente()
        {
            ListaPacientes = new List<Paciente>();
        }
        public bool Add(Paciente enlace)
        {
            if (Exist(enlace.Id) == false)
            {
                enlacePaciente.InsertarPaciente(enlace);
                return true;
            }
            return false;
        }
        public bool Delete(string id)
        {
            if (Exist(id) == false) return false;
            return enlacePaciente.EliminarPaciente(id.ToString());
        }
        public bool Exist(string id)
        {
            if (GetAll() != null)
            {
                foreach (var item in GetAll())
                {
                    if (item.Id == id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public List<Paciente> GetAll()
        {
            ListaPacientes.Clear();
            ListaPacientes= TableToList();
            
            return ListaPacientes;
        }
        public bool Update(Paciente paciente)
        {
            if(paciente != null && Exist(paciente.Id)==true) return enlacePaciente.ActualizarPacinete(paciente);
            return false;
        }
        public List<Paciente> TableToList()
        {
            try
            {
                DataTable tablaPaciente = new DataTable();
                tablaPaciente = enlacePaciente.ObtenerTablaPacientes();

                foreach(DataRow fila in  tablaPaciente.Rows)
                {
                    Paciente paciente = new Paciente();

                    paciente.Id = fila["cedula_paciente"].ToString();
                    paciente.PrimerNombre = fila["primer_nombre"].ToString();
                    paciente.SegundoNombre = fila["segundo_nombre"].ToString();
                    paciente.PrimerApellido = fila["primer_apellido"].ToString();
                    paciente.SegundoApellido = fila["segundo_apellido"].ToString();
                    paciente.FechaNacimiento = Convert.ToDateTime(fila["fecha_nacimiento"]);
                    paciente.Telefono = fila["telefono"].ToString();
                    paciente.Correo = fila["email"].ToString();
                    paciente.Direccion = fila["direccion"].ToString();
                    paciente.Nacionalidad = fila["ciudad"].ToString();
                    paciente.Tipo_Sangre = fila["tipo_sangre"].ToString();
                    paciente.Eps = fila["EPS"].ToString();
                
                    ListaPacientes.Add(paciente);
                }
                return ListaPacientes;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Paciente> GetByName(string name)
        {
            if(GetAll()!=null)
            {
                List<Paciente> ListaBusqueda = new List<Paciente>();

                foreach(var item in GetAll())
                {
                    if(item.PrimerNombre.ToUpper().Contains(name.ToUpper().Trim()))
                    {
                        ListaBusqueda.Add(item);
                    }
                }
                return ListaBusqueda;
            }
            return null;
        }
    }
}
