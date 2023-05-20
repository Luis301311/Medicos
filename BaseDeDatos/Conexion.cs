using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BaseDeDatos
{
    public class Conexion
    {
        private SqlConnection Conectar = new SqlConnection("SERVER=.\\SQLEXPRESS;DATABASE=PROYECTO; integrated security = true");

        public SqlConnection AbrirConexion()
        {
            if(Conectar.State == ConnectionState.Closed)
            {
                Conectar.Open();
            }
            return Conectar;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conectar.State == ConnectionState.Open)
            {
                Conectar.Close();
            }
            return Conectar;
        }
    }
}
