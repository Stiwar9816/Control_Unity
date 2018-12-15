using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contro_unity.Clases
{
    class user:Funciones
    {
        //PRODIEDADES DE LA CLASE
        public int Id_user { get; set; }
        public int Cc_user { get; set; }
        public string Nom_user { get; set; }
        public string Password_user { get; set; }
        public string Email_user { get; set; }
        public string Datetime_user { get; set; }
        public string Rol_user { get; set; }
        public int Privilege_user { get; set; }

        public user() { }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public user(int _cc_user, string _nom_user, string _password_user, string _email_user, string _datetime_user, string _rol_user, int _privilege_user)
        {
            this.Cc_user = _cc_user;
            this.Nom_user = _nom_user;
            this.Password_user = _password_user;
            this.Email_user = _email_user;
            this.Datetime_user = _datetime_user;
            this.Rol_user = _rol_user;
            this.Privilege_user = _privilege_user;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ACTUALIZAR
        public user(int _cc_user, string _nom_user, string _password_user, string _email_user, string _datetime_user, string _rol_user, int _privilege_user,int _id_user)
        {
            this.Cc_user = _cc_user;
            this.Nom_user = _nom_user;
            this.Password_user = _password_user;
            this.Email_user = _email_user;
            this.Datetime_user = _datetime_user;
            this.Rol_user = _rol_user;
            this.Privilege_user = _privilege_user;
            this.Id_user = _id_user;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ELMINAR
        public user(int _cc_user)
        {
            this.Cc_user = _cc_user;

        }

        public int Registrar()
        {
            throw new NotImplementedException();
        }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }
    }

}
