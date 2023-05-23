using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Entidades;


namespace BaseDeDatos
{
    public class DatosPacientes
    {
        Conexion con = new Conexion();
        DataTable tabla = new DataTable();
        OracleCommand comando = new OracleCommand();
        OracleDataAdapter adaptador = new OracleDataAdapter();

        public DataTable MostrarPacientes()
        {
            con.AbrirConexion();

            comando.CommandText = "obtenerPacientes";
            comando.Connection = con.conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("registros",OracleType.Cursor).Direction=ParameterDirection.Output;
            adaptador.SelectCommand = comando;
            adaptador.Fill(tabla);

            con.CerrarConexion();

            return tabla;
        }

        public void InsertarPaciente(Paciente paciente)
        {
            con.AbrirConexion();

            comando.CommandText = "insertarPacientes";
            comando.Connection = con.conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("ced", OracleType.VarChar).Value = paciente.Id.ToString();
            comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = paciente.PrimerNombre;
            comando.Parameters.Add("S_NOMBRE", OracleType.VarChar).Value = paciente.SegundoNombre;
            comando.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = paciente.PrimerApellido;
            comando.Parameters.Add("S_APELLIDO", OracleType.VarChar).Value = paciente.SegundoApellido;
            comando.Parameters.Add("FECHA", OracleType.DateTime).Value = paciente.FechaNacimiento;
            comando.Parameters.Add("TEL", OracleType.VarChar).Value = paciente.Telefono;
            comando.Parameters.Add("email", OracleType.VarChar).Value = paciente.Correo;
            comando.Parameters.Add("OCUPACION", OracleType.VarChar).Value = paciente.Ocupacion;
            comando.Parameters.Add("DIRECCION", OracleType.VarChar).Value = paciente.Direccion;
            comando.Parameters.Add("REGIMEN", OracleType.VarChar).Value = paciente.Regimen;
            comando.Parameters.Add("CIUDAD", OracleType.VarChar).Value = paciente.Nacionalidad;
            comando.Parameters.Add("ESTADO", OracleType.VarChar).Value = paciente.EstadoCivil;
            comando.Parameters.Add("NIVEL", OracleType.VarChar).Value = paciente.NivelEducativo;
            comando.Parameters.Add("SANGRE", OracleType.VarChar).Value = paciente.Tipo_Sangre;
            comando.ExecuteNonQuery();

            con.CerrarConexion();
        }

        public void ActualizarPacinete(Paciente paciente)
        {
            con.AbrirConexion();
            comando.CommandText = "ActualizarPaciente";
            comando.Connection = con.conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("ced", OracleType.VarChar).Value = paciente.Id.ToString();
            comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = paciente.PrimerNombre;
            comando.Parameters.Add("S_NOMBRE", OracleType.VarChar).Value = paciente.SegundoNombre;
            comando.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = paciente.PrimerApellido;
            comando.Parameters.Add("S_APELLIDO", OracleType.VarChar).Value = paciente.SegundoApellido;
            comando.Parameters.Add("FECHA", OracleType.DateTime).Value = paciente.FechaNacimiento;
            comando.Parameters.Add("TEL", OracleType.VarChar).Value = paciente.Telefono;
            comando.Parameters.Add("EMAIL", OracleType.VarChar).Value = paciente.Correo;
            comando.Parameters.Add("OCUPACION", OracleType.VarChar).Value = paciente.Ocupacion;
            comando.Parameters.Add("DIRECCION", OracleType.VarChar).Value = paciente.Direccion;
            comando.Parameters.Add("REGIMEN", OracleType.VarChar).Value = paciente.Regimen;
            comando.Parameters.Add("CIUDAD", OracleType.VarChar).Value = paciente.Nacionalidad;
            comando.Parameters.Add("ESTADO", OracleType.VarChar).Value = paciente.EstadoCivil;
            comando.Parameters.Add("NIVEL", OracleType.VarChar).Value = paciente.NivelEducativo;
            comando.Parameters.Add("SANGRE", OracleType.VarChar).Value = paciente.Tipo_Sangre;
            comando.ExecuteNonQuery();

            con.CerrarConexion();
        }




































        //Conexion conn = new Conexion();
        //OracleDataReader leer ;
        //DataTable tabla = new DataTable();
        //OracleCommand comando = new OracleCommand();

        //public DataTable Mostrar()
        //{
        //    comando.Connection = conn.AbrirConexion();
        //    comando.CommandText = "SELECT * FROM pacientes";
        //    leer = comando.ExecuteReader();
        //    tabla.Load(leer);
        //    conn.CerrarConexion();

        //    return tabla;
        //}

        //[System.Obsolete]
        //public void Insertar(Paciente paciente)
        //{
        //    OracleCommand comando = new OracleCommand();
        //    comando.Connection = conn.AbrirConexion();
        //    comando.CommandText = "INSERT INTO pacientes VALUES(:ID," +
        //                                                       ":P_NOMBRE," +
        //                                                       ":S_NOMBRE," +
        //                                                       ":P_APELLIDO," +
        //                                                       ":S_APELLIDO," +
        //                                                       ":FECHA," +
        //                                                       ":TELEFONO," +
        //                                                       ":CORREO," +
        //                                                       ":REGIMEN," +
        //                                                       ":ESTADO," +
        //                                                       ":DIRECCION," +
        //                                                       ":OCUPACION," +
        //                                                       ":NIVEL,"+
        //                                                       ":CIUDAD,"+
        //                                                       ":SANGRE)";



        //    comando.Parameters.Add("ID", OracleType.VarChar).Value = paciente.Id.ToString();
        //    comando.Parameters.Add("P_NOMBRE", OracleType.VarChar).Value = paciente.PrimerNombre;
        //    comando.Parameters.Add("S_NOMBRE", OracleType.VarChar).Value = paciente.SegundoNombre;
        //    comando.Parameters.Add("P_APELLIDO", OracleType.VarChar).Value = paciente.PrimerApellido;
        //    comando.Parameters.Add("S_APELLIDO", OracleType.VarChar).Value = paciente.SegundoApellido;
        //    comando.Parameters.Add("FECHA", OracleType.DateTime).Value = paciente.FechaNacimiento;
        //    comando.Parameters.Add("TELEFONO", OracleType.VarChar).Value = paciente.Telefono;
        //    comando.Parameters.Add("CORREO", OracleType.VarChar).Value = paciente.Correo;
        //    comando.Parameters.Add("OCUPACION", OracleType.VarChar).Value = paciente.Ocupacion;
        //    comando.Parameters.Add("DIRECCION", OracleType.VarChar).Value = paciente.Direccion;
        //    comando.Parameters.Add("REGIMEN", OracleType.VarChar).Value = paciente.Regimen;
        //    comando.Parameters.Add("CIUDAD", OracleType.VarChar).Value = paciente.Nacionalidad;
        //    comando.Parameters.Add("ESTADO", OracleType.VarChar).Value = paciente.EstadoCivil;
        //    comando.Parameters.Add("NIVEL", OracleType.VarChar).Value = paciente.NivelEducativo;
        //    comando.Parameters.Add("SANGRE", OracleType.VarChar).Value = paciente.Tipo_Sangre;
        //    comando.ExecuteNonQuery();
        //    comando.Connection  = conn.CerrarConexion();
        //}

        //public DataTable Actualizar(Paciente paciente) 
        //{
        //    conn.AbrirConexion();
        //    comando.CommandText = $"UPDATE PACIENTES SET PRIMER_NOMBRE = {paciente.PrimerNombre} WHERE ID = {paciente.Id}";
        //    leer = comando.ExecuteReader();
        //    tabla.Load(leer);
        //    conn.CerrarConexion();

        //    return tabla;
        //}
    }
}
