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
        private CDConexion Conexion = new CDConexion();
        private SqlDataReader leer;
        
        public SqlDataReader iniciarSesion(string user, string pass){
            string sql = "select from user where cc_user ='"+user+ "' and password_user='"+pass+"'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
