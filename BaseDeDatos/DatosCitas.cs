using Entidades;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    internal class DatosCitas
    {
        Conexion con = new Conexion();
        public bool InsertarCita(Cita citamedica)
        {
            try
            {
                OracleCommand comandoInsertar = new OracleCommand();

                con.AbrirConexion();

                comandoInsertar.CommandText = "InsertarCita";
                comandoInsertar.Connection = con.conexion;
                comandoInsertar.CommandType = CommandType.StoredProcedure;
                comandoInsertar.Parameters.Add("id_new_cita", OracleDbType.Int32).Value = citamedica.Id_consulta;
                comandoInsertar.Parameters.Add("new_fecha_cita", OracleDbType.TimeStamp).Value = citamedica.Fecha_cita;
                comandoInsertar.Parameters.Add("new_duracion", OracleDbType.TimeStamp).Value = citamedica.Duracion;
                comandoInsertar.Parameters.Add("new_cedula_medico", OracleDbType.Varchar2).Value = citamedica.Cedula_medico;
                comandoInsertar.Parameters.Add("new_cedula_paciente", OracleDbType.Varchar2).Value = citamedica.Cedula_paciente;
                comandoInsertar.Parameters.Add("new_id_estado", OracleDbType.Int32).Value = citamedica.Id_estado;
                comandoInsertar.Parameters.Add("new_consulta", OracleDbType.Varchar2).Value = citamedica.Id_consulta;
                comandoInsertar.Parameters.Add("new_activo", OracleDbType.Int32).Value = citamedica.Activo;
                comandoInsertar.ExecuteNonQuery();

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
        public List<Cita> ObtenerCitas()
        {
            try
            {
                var list = new List<Cita>();
                OracleCommand comando = new OracleCommand();
                con.AbrirConexion();
                comando.CommandText = "select * from v_citas";
                comando.Connection = con.conexion;
                var dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {    
                        list.Add(Mapeador(dataReader));
                    }
                }
                return list;
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
        private Cita Mapeador(OracleDataReader reader)
        {
            try
            {
                if (!reader.HasRows) return null;
                {
                    Cita cita = new Cita();
                    cita.Id_cita = reader.GetInt32(0);
                    cita.Fecha_cita = reader.GetDateTime(1);
                    cita.Duracion = reader.GetDateTime(2);
                    cita.Cedula_medico = reader.GetString(3);
                    cita.Cedula_paciente = reader.GetString(4);
                    cita.Id_estado = reader.GetInt32(5);
                    cita.Id_consulta=reader.GetString(6);
                    cita.Activo = reader.GetInt32(7);
                    return cita;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
