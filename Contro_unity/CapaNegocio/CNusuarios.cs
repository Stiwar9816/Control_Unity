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
        private string _cc_user;
        private string _pass_user;

        //Metodos GET y SET para el manejo de las variables

        public string cc_user
        {
            set {
                if(value == "Usuario") { _cc_user = "Ingrese su usuario"; }

                else { _cc_user = value; }

            }
            get { return _cc_user; }
        }

        public string pass_user
        {
            set { _pass_user = value; }
            get { return _pass_user; }
        }
        
        //Construcutor
        public CNusuarios() { }

        //Metodos o Funciones

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.IniciarSesion(cc_user,pass_user);
            return Loguear;
        }

        private SqlDataReader IniciarSesion(string cc_user, string pass_user)
        {
            throw new NotImplementedException();
        }
    } 
}
