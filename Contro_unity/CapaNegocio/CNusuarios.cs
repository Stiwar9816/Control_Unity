using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
    public class CNusuarios
    {
        //Encapsulacion de las variables
        private CNusuarios objDato = new CNusuarios(); //Instaciamos la capa de datos de usuarios
        //Variables
        private String _cc_user;
        private String _password_user;

        //Metodos GET y SET para el manejo de las variables

        public String cc_user
        {
            set { _cc_user = value; }
            get { return _cc_user; }
        }

        public String password_user
        {
            set { _password_user = value; }
            get { return _password_user; }
        }
        
        //Construcutor
        public CNusuarios() { }

        //Metodos o Funciones

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.iniciarSesion(cc_user, password_user);
            return Loguear;
        }

        private SqlDataReader iniciarSesion(string cc_user, string password_user)
        {
            throw new NotImplementedException();
        }
    } 
}
