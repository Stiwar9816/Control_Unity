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
        private CDconexion Conexion = new CDconexion();
        private SqlDataReader leer;

        public SqlDataReader IniciarSesion(string user, string pass)
        {
            
            SqlCommand comando = new SqlCommand("SPIniciarSesion",Conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", user);
            comando.Parameters.AddWithValue("@Password", pass);
            leer = comando.ExecuteReader();
            return leer;
        }
    }
}
