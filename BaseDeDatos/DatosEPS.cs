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
    public class DatosEPS
    {
        Conexion con = new Conexion();

        public List<Eps> ObtenerEps()
        {
            try
            {
                var list = new List<Eps>();
                OracleCommand comandoEps = new OracleCommand();
                con.AbrirConexion();

                comandoEps.CommandText = "select * from v_eps";
                comandoEps.Connection = con.conexion;
                var dataReader = comandoEps.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Eps eps = Mapeador(dataReader);
                        list.Add(eps);
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
        private Eps Mapeador(OracleDataReader reader)
        {
            if (!reader.HasRows) return null;
            {
                Eps eps = new Eps();
                eps.Id = (string)reader["ID"].ToString();
                eps.Nombre = (string)reader["NOMBRE"];

                return eps;
            }
        }
    }
}
