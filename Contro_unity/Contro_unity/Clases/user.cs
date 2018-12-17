using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Contro_unity.Clases
{
    class user:Funciones
    {
        Conexion con = new Conexion();
        //PRODIEDADES DE LA CLASE
        public int Id_user { get; set; }
        public int Cc_user { get; set; }
        public string Nom_user { get; set; }
        public string Password_user { get; set; }
        public string Email_user { get; set; }
        public DateTime Datetime_user { get; set; }
        public string Rol_user { get; set; }
        public int Privilege_user { get; set; }

        public user() { }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public user(int _cc_user, string _nom_user, string _password_user, string _email_user, DateTime _datetime_user, string _rol_user, int _privilege_user)
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
        public user(int _cc_user, string _nom_user, string _password_user, string _email_user, DateTime _datetime_user, string _rol_user, int _privilege_user,int _id_user)
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
            int ultimo_id = 0;
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTAR_USUARIO1", con.Con))
                {
                    cmd.Parameters.AddWithValue("@cc_user", this.Cc_user);
                    cmd.Parameters.AddWithValue("@nom_user", this.Nom_user);
                    cmd.Parameters.AddWithValue("@password_user", this.Password_user);
                    cmd.Parameters.AddWithValue("@email_user", this.Email_user);
                    cmd.Parameters.AddWithValue("@datetime_user", this.Datetime_user);
                    cmd.Parameters.AddWithValue("@rol_user", this.Rol_user);
                    cmd.Parameters.AddWithValue("@privilege_user", this.Privilege_user);
                    cmd.Parameters.AddWithValue("@ultimo_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Con.Open();
                    cmd.ExecuteNonQuery();
                    ultimo_id = Convert.ToInt32(cmd.Parameters["@ultimo_id"].Value.ToString());
                    con.Con.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se pudo registrar", e.Message);
                return ultimo_id;
            }
            finally
            {
                if (con.Con.State == ConnectionState.Open)
                {
                    con.Con.Close();
                }


            }
            return ultimo_id;
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
