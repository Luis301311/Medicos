using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Entidades;
using Oracle.ManagedDataAccess.Client;

namespace BaseDeDatos
{
    public class DatosPacientes
    {
        Conexion con = new Conexion();
        OracleDataAdapter adaptador = new OracleDataAdapter();

        public DataTable ObtenerTablaPacientes()
        {
            OracleCommand comandoPaciente = new OracleCommand();
            DataTable TablaPaciente = new DataTable();
            con.AbrirConexion();

            comandoPaciente.CommandText = "obtenerPacientes";
            comandoPaciente.Connection = con.conexion;
            comandoPaciente.CommandType = CommandType.StoredProcedure;
            comandoPaciente.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            adaptador.SelectCommand = comandoPaciente;
            adaptador.Fill(TablaPaciente);

            con.CerrarConexion();

            return TablaPaciente;
        }
        public bool InsertarPaciente(Paciente paciente)
        {
            try
            {
                OracleCommand comandoInsert = new OracleCommand();

                con.AbrirConexion();

                comandoInsert.CommandText = "insertarPacientes";
                comandoInsert.Connection = con.conexion;
                comandoInsert.CommandType = CommandType.StoredProcedure;
                comandoInsert.Parameters.Add("CED", OracleDbType.Varchar2).Value = paciente.Id.ToString();
                comandoInsert.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = paciente.PrimerNombre;
                comandoInsert.Parameters.Add("S_NOMBRE", OracleDbType.Varchar2).Value = paciente.SegundoNombre;
                comandoInsert.Parameters.Add("P_APELLIDO", OracleDbType.Varchar2).Value = paciente.PrimerApellido;
                comandoInsert.Parameters.Add("S_APELLIDO", OracleDbType.Varchar2).Value = paciente.SegundoApellido;
                comandoInsert.Parameters.Add("FECHA", OracleDbType.Date).Value = paciente.FechaNacimiento;
                comandoInsert.Parameters.Add("TEL", OracleDbType.Varchar2).Value = paciente.Telefono;
                comandoInsert.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = paciente.Correo;
                comandoInsert.Parameters.Add("DIRECCION", OracleDbType.Varchar2).Value = paciente.Direccion;
                comandoInsert.Parameters.Add("CIUDAD", OracleDbType.Varchar2).Value = paciente.Nacionalidad;
                comandoInsert.Parameters.Add("SANGRE", OracleDbType.Varchar2).Value = paciente.Tipo_Sangre;
                comandoInsert.Parameters.Add("EPS", OracleDbType.Varchar2).Value = paciente.Eps;

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
        public bool ActualizarPacinete(Paciente paciente)
        {
            try
            {
                OracleCommand comandoUpdate = new OracleCommand();

                con.AbrirConexion();
                comandoUpdate.CommandText = "actualizarPaciente";
                comandoUpdate.Connection = con.conexion;
                comandoUpdate.CommandType = CommandType.StoredProcedure;
                comandoUpdate.Parameters.Add("ced", OracleDbType.Varchar2).Value = paciente.Id.ToString();
                comandoUpdate.Parameters.Add("p_nombre", OracleDbType.Varchar2).Value = paciente.PrimerNombre;
                comandoUpdate.Parameters.Add("s_nombre", OracleDbType.Varchar2).Value = paciente.SegundoNombre;
                comandoUpdate.Parameters.Add("p_apellido", OracleDbType.Varchar2).Value = paciente.PrimerApellido;
                comandoUpdate.Parameters.Add("s_apellido", OracleDbType.Varchar2).Value = paciente.SegundoApellido;
                comandoUpdate.Parameters.Add("fecha", OracleDbType.Date).Value = paciente.FechaNacimiento;
                comandoUpdate.Parameters.Add("tel", OracleDbType.Varchar2).Value = paciente.Telefono;
                comandoUpdate.Parameters.Add("email", OracleDbType.Varchar2).Value = paciente.Correo;
                comandoUpdate.Parameters.Add("direccion", OracleDbType.Varchar2).Value = paciente.Direccion;
                comandoUpdate.Parameters.Add("ciudad", OracleDbType.Varchar2).Value = paciente.Nacionalidad;
                comandoUpdate.Parameters.Add("sangre", OracleDbType.Varchar2).Value = paciente.Tipo_Sangre;
                comandoUpdate.Parameters.Add("eps", OracleDbType.Int16).Value = paciente.Eps;
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
        public bool EliminarPaciente(string cedula)
        {
            OracleCommand comandoEliminar = new OracleCommand();

            try
            {
                con.AbrirConexion();

                comandoEliminar.CommandText = "EliminarPaciente";
                comandoEliminar.Connection = con.conexion;
                comandoEliminar.CommandType = CommandType.StoredProcedure;

                comandoEliminar.Parameters.Add("cedula",OracleDbType.Varchar2).Value= cedula;
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
