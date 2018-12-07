using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    
    public class CDlogin
    {
        private CDconexion conexion = new CDconexion();
        private SqlDataAdapter leer;

        public SqlDataAdapter IniciarSesion(string user, string pass)
        {
            string sql = "SELECT * FROM users WHERE cc_user=" + user + "AND password_user=" + pass;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
