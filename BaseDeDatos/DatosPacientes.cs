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

        public List<Paciente> ObtenerLista()
        {
            try
            {
                var list = new List<Paciente>();
                OracleCommand comandoPacientes = new OracleCommand();
                con.AbrirConexion();

                comandoPacientes.CommandText = "select * from pacientes where activo = 1 order by cedula_paciente";
                comandoPacientes.Connection = con.conexion;
                var dataReader = comandoPacientes.ExecuteReader();

                if(dataReader.HasRows)
                {
                    while(dataReader.Read()) 
                    {
                        Paciente paciente = Mapeador(dataReader);
                        list.Add(paciente);
                    }
                }

                con.CerrarConexion();

                return list;
            }
            catch (Exception)
            {

                return null;
            }
        }
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
        public DataTable ObtenerCiudades()
        {
            OracleCommand comandoCiudades = new OracleCommand();
            DataTable TablaCiudades = new DataTable();
            con.AbrirConexion();

            comandoCiudades.CommandText = "obtenerCiudades";
            comandoCiudades.Connection = con.conexion;
            comandoCiudades.CommandType = CommandType.StoredProcedure;
            comandoCiudades.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            adaptador.SelectCommand= comandoCiudades;
            adaptador.Fill(TablaCiudades);

            con.CerrarConexion();

            return TablaCiudades;
        }
        public DataTable ObtenerTiposSangre()
        {
            OracleCommand comandoTipos = new OracleCommand();
            DataTable TablaTipoSangre = new DataTable();
            con.AbrirConexion();

            comandoTipos.CommandText = "ObtenerTipoSangre";
            comandoTipos.Connection = con.conexion;
            comandoTipos.CommandType = CommandType.StoredProcedure;
            comandoTipos.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            adaptador.SelectCommand = comandoTipos;
            adaptador.Fill(TablaTipoSangre);

            con.CerrarConexion();

            return TablaTipoSangre;
        }
        public void InsertarPaciente(Paciente paciente)
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
            comandoInsert.Parameters.Add("REGIMEN", OracleDbType.Varchar2).Value = paciente.Regimen;
            comandoInsert.Parameters.Add("ESTADO", OracleDbType.Varchar2).Value = paciente.EstadoCivil;
            comandoInsert.Parameters.Add("DIRECCION", OracleDbType.Varchar2).Value = paciente.Direccion;
            comandoInsert.Parameters.Add("OCUPACION", OracleDbType.Varchar2).Value = paciente.Ocupacion;
            comandoInsert.Parameters.Add("NIVEL", OracleDbType.Varchar2).Value = paciente.NivelEducativo;
            comandoInsert.Parameters.Add("CIUDAD", OracleDbType.Varchar2).Value = paciente.Nacionalidad;
            comandoInsert.Parameters.Add("SANGRE", OracleDbType.Varchar2).Value = paciente.Tipo_Sangre;

            comandoInsert.ExecuteNonQuery();

            con.CerrarConexion();
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
                comandoUpdate.Parameters.Add("regimen", OracleDbType.Varchar2).Value = paciente.Regimen;
                comandoUpdate.Parameters.Add("estado", OracleDbType.Varchar2).Value = paciente.EstadoCivil;
                comandoUpdate.Parameters.Add("direccion", OracleDbType.Varchar2).Value = paciente.Direccion;
                comandoUpdate.Parameters.Add("ocupacion", OracleDbType.Varchar2).Value = paciente.Ocupacion;
                comandoUpdate.Parameters.Add("nivel", OracleDbType.Varchar2).Value = paciente.NivelEducativo;
                comandoUpdate.Parameters.Add("ciudad", OracleDbType.Varchar2).Value = paciente.Nacionalidad;
                comandoUpdate.Parameters.Add("sangre", OracleDbType.Varchar2).Value = paciente.Tipo_Sangre;
                comandoUpdate.ExecuteNonQuery();
                con.CerrarConexion();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }
        public Paciente Mapeador(OracleDataReader reader)
        {
            if (!reader.HasRows) return null;
            {
                Paciente p = new Paciente();
                p.Id = int.Parse((string)reader["CEDULA_PACIENTE"]);
                p.PrimerNombre = (string)reader["PRIMER_NOMBRE"];
                p.SegundoNombre = (string)reader["SEGUNDO_NOMBRE"];
                p.PrimerApellido = (string)reader["PRIMER_APELLIDO"];
                p.SegundoApellido = (string)reader["SEGUNDO_APELLIDO"];
                p.PrimerNombre = (string)reader["PRIMER_NOMBRE"];
                p.FechaNacimiento = (DateTime)reader["FECHA_NACIMIENTO"];
                p.Telefono = (string)reader["TELEFONO"];
                p.Correo = (string)reader["EMAIL"];
                p.Regimen = (string)reader["REGIMEN"];
                p.EstadoCivil = (string)reader["ESTADOCIVIL"];
                p.Direccion = (string)reader["DIRECCION"];
                p.Ocupacion = (string)reader["OCUPACION"];
                p.NivelEducativo = (string)reader["ID_NIVELEDUCATIVO"];
                p.Nacionalidad = (string)reader["ID_CUIDAD"];
                p.Tipo_Sangre = (string)reader["ID_SANGRE"];

                return p;
            }
        }
        public DataTable ObtenerCedula(string cedu)
        {
            DataTable dt = new DataTable();
            OracleCommand comandoCedula = new OracleCommand();

            con.AbrirConexion();

            comandoCedula.CommandText = "obtenerCedula";
            comandoCedula.CommandType = CommandType.StoredProcedure;
            comandoCedula.Parameters.Add("cedula",OracleDbType.Varchar2).Value = cedu;
            comandoCedula.Parameters.Add("registros", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            adaptador.SelectCommand = comandoCedula;
            adaptador.Fill(dt);

            con.CerrarConexion();
            return dt;
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
                con.CerrarConexion();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
