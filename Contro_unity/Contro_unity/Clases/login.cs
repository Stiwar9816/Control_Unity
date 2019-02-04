using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Contro_unity.Clases
{
    class login
    {
        Conexion con = new Conexion();
        private SqlDataReader leer;
        private string email, nombre, contraseña, mensaje;
        private SqlCommand cmd = new SqlCommand();

        private string RecuperarContraseña(string cc_user)
        {
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SELECT * FROM users WHERE cc_user=" + cc_user;
            leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                email = leer["email_user"].ToString();
                nombre = leer["nom_user"].ToString();
                contraseña = leer["password_user"].ToString();
                //EMAIL
                EnviarEmail();
                mensaje = "Estimado(a) " + nombre + ", se ha enviado su contraseña a su correo: " + email + " por favor verifique en su buzon de entrada";
                leer.Close();
            }
            else
            {
                mensaje = "No Existen datos del usuario solicitado, por favor verifique los datos ingresados";
            }

            return mensaje;
        }

        private void EnviarEmail()
        {
            //CORREO
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("casprilla@miuniclaretiana.edu.co");
            correo.To.Add(email);
            correo.Subject=("RECUPERACIÓN DE CONTRASEÑA - CONTROL UNITY");
            correo.Body = "Hola "+nombre+" usted solicito recuperar su contraseña de control unity.\n Su contraseña es: "+contraseña+".\n Se recomienda cambiarla al ingresar nuevamente al sistema." ;
            correo.Priority = MailPriority.High;
            //SMTP
            SmtpClient ServerMail = new SmtpClient();
            ServerMail.Credentials = new NetworkCredential("casprilla@miuniclaretiana.edu.co", "Csam1098");
            ServerMail.Host = "smtp.gmail.com";
            ServerMail.Port = 587;
            ServerMail.EnableSsl = true;

            try
            {
                ServerMail.Send(correo);
            }
            catch (Exception ex)
            {
                correo.Dispose();
            }
        }


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

        public string RecuPass(string cc_user)
        {
            string mensaje;
            mensaje = RecuperarContraseña(cc_user);
            return mensaje;
        }

    }
}
