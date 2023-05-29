using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Entidades;
using Oracle.ManagedDataAccess.Client;


namespace BaseDeDatos
{
    public class DatosEspecialidad
    {
        Conexion con = new Conexion();
        public List<Especialidad> ObtenerEspecialidades()
        {
            try
            {
                var list = new List<Especialidad>();
                OracleCommand comandoEspecialidad = new OracleCommand();
                con.AbrirConexion();

                comandoEspecialidad.CommandText = "select * from v_especialidades";
                comandoEspecialidad.Connection = con.conexion;
                var dataReader = comandoEspecialidad.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Especialidad espe = Mapeador(dataReader);
                        list.Add(espe);
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
        private Especialidad Mapeador(OracleDataReader reader)
        {
            if (!reader.HasRows) return null;
            {
                Especialidad espe = new Especialidad();
                espe.Id = (string)reader["ID_ESPECIALIDAD"];
                espe.Nombre = (string)reader["NOMBRE"];

                return espe;
            }
        }
    }
}
