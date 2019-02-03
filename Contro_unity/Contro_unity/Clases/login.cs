using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Contro_unity.Clases
{
    class login
    {
        Conexion con = new Conexion();
        private SqlDataReader leer;

        public SqlDataReader IniciarSesion(string user, string pass)
        {
            //string Sql = "SELECT * FROM users WHERE cc_user ='" + user + "' AND password_user ='" + pass+"'";
             
            SqlCommand cmd = new SqlCommand("SPIniciarSesion", con.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario",user);
            cmd.Parameters.AddWithValue("@Password",pass);
            leer = cmd.ExecuteReader();
            return leer;
        }

        private string _User;
        private string _pass;

        public string Usuario {
            set { if (value == "Usuario") { _User = "Ingrese su usuario";} else {_User = value;} }
            get { return _User;}
        }
        public string Contraseña {
            set { if (value == "Contraseña") { _pass = "Ingrese su contraseña"; } else { _pass = value; } }
            get { return _pass; }
        }


        public login(){ }

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = IniciarSesion(Usuario,Contraseña);
            return Loguear;
        }



    }
}
