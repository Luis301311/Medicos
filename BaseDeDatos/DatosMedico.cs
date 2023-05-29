using Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class DatosMedico
    {
        Conexion con = new Conexion();

        public DataTable ObtenerMedicos()
        {
            try
            {
                OracleCommand comandoObtener = new OracleCommand();
                OracleDataAdapter adaptador = new OracleDataAdapter();
                DataTable dt = new DataTable();

                con.AbrirConexion();

                comandoObtener.CommandText = "obtenerMedicos";
                comandoObtener.Connection = con.conexion;
                comandoObtener.CommandType = CommandType.StoredProcedure;
                comandoObtener.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                adaptador.SelectCommand = comandoObtener;
                adaptador.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.CerrarConexion();
            }
        }
        public bool InsertarMedico(Medico medico)
        {
            try
            {
                OracleCommand comandoInsert = new OracleCommand();

                con.AbrirConexion();
                comandoInsert.CommandText = "InsertarMedicos";
                comandoInsert.Connection = con.conexion;
                comandoInsert.CommandType = CommandType.StoredProcedure;
                comandoInsert.Parameters.Add("ced", OracleDbType.Varchar2).Value = medico.Id.ToString();
                comandoInsert.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = medico.PrimerNombre;
                comandoInsert.Parameters.Add("s_nombre", OracleDbType.Varchar2).Value = medico.SegundoNombre;
                comandoInsert.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = medico.PrimerApellido;
                comandoInsert.Parameters.Add("s_apellido", OracleDbType.Varchar2).Value = medico.SegundoApellido;
                comandoInsert.Parameters.Add("fecha_naci", OracleDbType.Date).Value = medico.FechaNacimiento;
                comandoInsert.Parameters.Add("tel", OracleDbType.Varchar2).Value = medico.Telefono;
                comandoInsert.Parameters.Add("new_email", OracleDbType.Varchar2).Value = medico.Correo;
                comandoInsert.Parameters.Add("new_fecha_graduado", OracleDbType.Date).Value = medico.FechaGraduado;
                comandoInsert.Parameters.Add("mew_id_especialidad", OracleDbType.Varchar2).Value = medico.Especialidad;
                comandoInsert.Parameters.Add("new_id_ciudad", OracleDbType.Varchar2).Value = medico.Nacionalidad;
                comandoInsert.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.CerrarConexion();
            }
        }
        public bool ActualizarMedico(Medico medico)
        {
            try
            {
                OracleCommand comandoUpdate = new OracleCommand();

                con.AbrirConexion();
                comandoUpdate.CommandText = "actualizarMedicos";
                comandoUpdate.Connection = con.conexion;
                comandoUpdate.CommandType = CommandType.StoredProcedure;
                comandoUpdate.Parameters.Add("ced", OracleDbType.Varchar2).Value = medico.Id.ToString();
                comandoUpdate.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = medico.PrimerNombre;
                comandoUpdate.Parameters.Add("s_nombre", OracleDbType.Varchar2).Value = medico.SegundoNombre;
                comandoUpdate.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = medico.PrimerApellido;
                comandoUpdate.Parameters.Add("s_apellido", OracleDbType.Varchar2).Value = medico.SegundoApellido;
                comandoUpdate.Parameters.Add("fecha_naci", OracleDbType.Date).Value = medico.FechaNacimiento;
                comandoUpdate.Parameters.Add("tel", OracleDbType.Varchar2).Value = medico.Telefono;
                comandoUpdate.Parameters.Add("new_email", OracleDbType.Varchar2).Value = medico.Correo;
                comandoUpdate.Parameters.Add("new_fecha_graduado", OracleDbType.Date).Value = medico.FechaGraduado;
                comandoUpdate.Parameters.Add("mew_id_especialidad", OracleDbType.Varchar2).Value = medico.Especialidad;
                comandoUpdate.Parameters.Add("new_id_ciudad", OracleDbType.Varchar2).Value = medico.Nacionalidad;
                comandoUpdate.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.CerrarConexion();
            }
        }
        public bool EliminarMedico(string id)
        {
            try
            {
                OracleCommand comandoEliminar = new OracleCommand();

                con.AbrirConexion();

                comandoEliminar.CommandText = "EliminarMedico";
                comandoEliminar.Connection = con.conexion;
                comandoEliminar.CommandType = CommandType.StoredProcedure;
                comandoEliminar.Parameters.Add("id_eliminar", OracleDbType.Varchar2).Value = id;
                comandoEliminar.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.CerrarConexion();
            }
        }
    }
}
