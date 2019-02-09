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
        public string Pass_user { get; set; }
        public string Email_user { get; set; }
        public string Datetime_register { get; set; }
        public string Rol_user { get; set; }
        public user() { }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public user(int _cc_user, string _nom_user, string _pass_user, string _email_user, string _datetime_register, string _rol_user)
        {
            this.Cc_user = _cc_user;
            this.Nom_user = _nom_user;
            this.Pass_user = _pass_user;
            this.Email_user = _email_user;
            this.Datetime_register = _datetime_register;
            this.Rol_user = _rol_user;
        }

        public int Registrar()
        {
            int ultimo_id = 0;
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTRAR_USUARIO", con.Con))
                {
                    cmd.Parameters.AddWithValue("@cc_user", this.Cc_user);
                    cmd.Parameters.AddWithValue("@nom_user", this.Nom_user);
                    cmd.Parameters.AddWithValue("@pass_user", this.Pass_user);
                    cmd.Parameters.AddWithValue("@email_user", this.Email_user);
                    cmd.Parameters.AddWithValue("@datetime_register", this.Datetime_register);
                    cmd.Parameters.AddWithValue("@rol_user", this.Rol_user);
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

        public void Editar(int Cc_user, string Nom_user,string Pass_user ,string Email_user,string datetime_register, string Rol_user)
        {
            con.Con.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITAR_USUARIO", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cc_user", Cc_user);
            cmd.Parameters.AddWithValue("@nom_user", Nom_user);
            cmd.Parameters.AddWithValue("@pass_user", Pass_user);
            cmd.Parameters.AddWithValue("@email_user", Email_user);
            cmd.Parameters.AddWithValue("@datetime_register", datetime_register);
            cmd.Parameters.AddWithValue("@rol_user", Rol_user);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Eliminar(int Cc_user)
        {
            con.Con.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_USUARIO", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cc_user", Cc_user);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }

}
