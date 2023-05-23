using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace BaseDeDatos
{
    public class Conexion
    {
        public  OracleConnection conexion = new OracleConnection("DATA SOURCE = localhost:1521/xepdb1;User Id = Miguel ;Password = miguelmeza28");
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
