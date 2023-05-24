using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
    }
}
