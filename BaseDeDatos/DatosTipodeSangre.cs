using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Entidades;
using Oracle.ManagedDataAccess.Client;

namespace BaseDeDatos
{
    public class DatosTipodeSangre
    {
        Conexion con = new Conexion();
        OracleDataAdapter adaptador = new OracleDataAdapter();

        public List<TipodeSangre> ObtenerTiposDeSangre()
        {
            try
            {
                var list = new List<TipodeSangre>();
                OracleCommand comandoPacientes = new OracleCommand();
                con.AbrirConexion();

                comandoPacientes.CommandText = "select * from Tipos_Sangres";
                comandoPacientes.Connection = con.conexion;
                var dataReader = comandoPacientes.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        TipodeSangre tipo_sangre = Mapeador(dataReader);
                        list.Add(tipo_sangre);
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
        private TipodeSangre Mapeador(OracleDataReader reader)
        {
            if (!reader.HasRows) return null;
            {
                TipodeSangre tipo = new TipodeSangre();
                tipo.Id = (string)reader["ID_SANGRE"];
                tipo.Nombre = (string)reader["NOMBRE"];
              
                return tipo;
            }
        }
        public bool InsertarTiposSangre(TipodeSangre tipo)
        {
            try
            {
                OracleCommand comandoTipo = new OracleCommand();

                con.AbrirConexion();
                comandoTipo.CommandText = "insertarTipoSangre";
                comandoTipo.Connection = con.conexion;
                comandoTipo.CommandType = CommandType.StoredProcedure;
                comandoTipo.Parameters.Add("Id_tipo",OracleDbType.Varchar2).Value = tipo.Id;
                comandoTipo.Parameters.Add("Nombre",OracleDbType.Varchar2).Value = tipo.Nombre;

                comandoTipo.ExecuteNonQuery();
                con.CerrarConexion();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ActualizarTiposSangre(TipodeSangre tipo)
        {
            try
            {
                OracleCommand comandoActualizar = new OracleCommand();

                con.AbrirConexion();

                comandoActualizar.CommandText = "actualizarTipoSangre";
                comandoActualizar.Connection = con.conexion;
                comandoActualizar.CommandType = CommandType.StoredProcedure;
                comandoActualizar.Parameters.Add("Id_tipo",OracleDbType.Varchar2).Value = tipo.Id;
                comandoActualizar.Parameters.Add("Nombre",OracleDbType.Varchar2).Value = tipo.Nombre;
                comandoActualizar.ExecuteNonQuery();

                con.CerrarConexion();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarTipoSangre(string id)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
