using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BaseDeDatos
{
    public class DatosPacientes
    {
        private Conexion conn = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();




        public DataTable Mostrar()
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "SELECT * FROM pacientes";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conn.CerrarConexion();

            return tabla;
        }

        public void Insertar(Paciente paciente)
        {
            comando.Connection = conn.AbrirConexion();
            comando.CommandText = "INSERT INTO pacientes VALUES(@ID," +
                                                               "@P_NOMBRE," +
                                                               "@S_NOMBRE," +
                                                               "@P_APELLIDO," +
                                                               "@S_APELLIDO," +
                                                               "@EDAD," +
                                                               "@FECHA," +
                                                               "@TELEFONO," +
                                                               "@CORREO," +
                                                               "@OCUPACION," +
                                                               "@DIRECCION," +
                                                               "@REGIMEN," +
                                                               "@NACIONALIDAD," +
                                                               "@ESTADO," +
                                                               "@NIVEL)";

            comando.Parameters.Add("@ID", SqlDbType.Int).Value = paciente.Id;
            comando.Parameters.Add("@P_NOMBRE", SqlDbType.VarChar).Value = paciente.PrimerNombre;
            comando.Parameters.Add("@S_NOMBRE", SqlDbType.VarChar).Value = paciente.SegundoNombre;
            comando.Parameters.Add("@P_APELLIDO", SqlDbType.VarChar).Value = paciente.PrimerApellido;
            comando.Parameters.Add("@S_APELLIDO", SqlDbType.VarChar).Value = paciente.SegundoApellido;
            comando.Parameters.Add("@EDAD", SqlDbType.Int).Value = paciente.Edad;
            comando.Parameters.Add("@FECHA", SqlDbType.Date).Value = paciente.FechaNacimiento;
            comando.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = paciente.Telefono;
            comando.Parameters.Add("@CORREO", SqlDbType.VarChar).Value = paciente.Correo;
            comando.Parameters.Add("@OCUPACION", SqlDbType.VarChar).Value = paciente.Ocupacion;
            comando.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = paciente.Direccion;
            comando.Parameters.Add("@REGIMEN", SqlDbType.VarChar).Value = paciente.Regimen;
            comando.Parameters.Add("@NACIONALIDAD", SqlDbType.VarChar).Value = paciente.Nacionalidad;
            comando.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = paciente.EstadoCivil;
            comando.Parameters.Add("@NIVEL", SqlDbType.VarChar).Value = paciente.NivelEducativo;
            comando.ExecuteNonQuery();
        }
    }
}
