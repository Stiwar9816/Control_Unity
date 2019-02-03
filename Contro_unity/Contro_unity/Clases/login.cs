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
            string Sql = "SELECT * FROM users WHERE cc_user ='" + user + "' AND password_user ='" + pass+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = Sql;
            leer = cmd.ExecuteReader();
            return leer;
        }

        private string _User;
        private string _pass;

        public string Usuario {
            set { _User = value;}
            get { return _User;}
        }
        public string Contraseña {
            set { _pass = value; }
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
