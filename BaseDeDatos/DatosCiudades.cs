using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Entidades;
using Oracle.ManagedDataAccess.Client;

namespace BaseDeDatos
{
    public class DatosCiudades
    {
        Conexion con = new Conexion();
        public List<Ciudad> ObtenerCiudades()
        {
            try
            {
                var list = new List<Ciudad>();
                OracleCommand comandoCiudad = new OracleCommand();
                con.AbrirConexion();

                comandoCiudad.CommandText = "select * from v_ciudades";
                comandoCiudad.Connection = con.conexion;
                var dataReader = comandoCiudad.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Ciudad ciudad = Mapeador(dataReader);
                        list.Add(ciudad);
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
        private Ciudad Mapeador(OracleDataReader reader)
        {
            try
            {
                if (!reader.HasRows) return null;
                {
                    Ciudad ciudad = new Ciudad();
                    ciudad.Id_cuidad = (string)reader["ID"];
                    ciudad.Nombre = (string)reader["NOMBRE"];
                    ciudad.Id_Departamento = (string)reader["DEPARTAMENTO"];

                    return ciudad;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool ActualizarCiudades(Ciudad ciudad)
        {
            try
            {
                OracleCommand comandoActualizar = new OracleCommand();

                con.AbrirConexion();

                comandoActualizar.CommandText = "ActualizarCiudades";
                comandoActualizar.Connection = con.conexion;
                comandoActualizar.CommandType = CommandType.StoredProcedure;
                comandoActualizar.Parameters.Add("id_ciudad", OracleDbType.Varchar2).Value = ciudad.Id_cuidad;
                comandoActualizar.Parameters.Add("Nombre_ciudad", OracleDbType.Varchar2).Value = ciudad.Nombre;
                comandoActualizar.Parameters.Add("id_departamento", OracleDbType.Varchar2).Value = ciudad.Id_Departamento;

                comandoActualizar.ExecuteNonQuery();

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
        public bool EliminarCiudades(string id)
        {
            try
            {
                OracleCommand comandoEliminar = new OracleCommand();

                con.AbrirConexion();

                comandoEliminar.CommandText = "EliminarCiudad";
                comandoEliminar.Connection = con.conexion;
                comandoEliminar.CommandType = CommandType.StoredProcedure;
                comandoEliminar.Parameters.Add("id_Eliminar", OracleDbType.Varchar2).Value = id;
                comandoEliminar.ExecuteNonQuery ();

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
        public bool InsertarCiudades(Ciudad ciudad)
        {
            try
            {
                OracleCommand comandoInsertar = new OracleCommand();

                con.AbrirConexion();

                comandoInsertar.CommandText = "InsertarCiudad";
                comandoInsertar.Connection = con.conexion;
                comandoInsertar.CommandType = CommandType.StoredProcedure;
                comandoInsertar.Parameters.Add("id_new_ciudad", OracleDbType.Varchar2).Value = ciudad.Id_cuidad;
                comandoInsertar.Parameters.Add("new_nombre", OracleDbType.Varchar2).Value = ciudad.Nombre;
                comandoInsertar.Parameters.Add("new_departamento", OracleDbType.Varchar2).Value = ciudad.Id_Departamento;
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
    }
}
