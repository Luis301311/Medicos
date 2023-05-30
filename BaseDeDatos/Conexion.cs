using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;



namespace BaseDeDatos
{
    public class Conexion
    {
        public  OracleConnection conexion = new OracleConnection("data source = LAPTOP-1N5NSQ43; initial catalog = ProyectoBDP3; Integrated Security=True ");
        public OracleConnection AbrirConexion()
        {
            conexion.Open();
            return conexion;
        }

        public OracleConnection CerrarConexion()
        {
            conexion.Close();
            return conexion;
        }
    }
}
