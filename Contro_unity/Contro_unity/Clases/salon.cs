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
    class salon:Funciones
    {
        Conexion con = new Conexion();
        //PRODIEDADES DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public int Id_salon { get; set; }
        public string Nom_salon { get; set; }
        public string Description_salon { get; set; }

        public salon() { }

        //CONSTRUCTOR DE LA CLASE
        //CONTRUCTOR PARA REGISTRAR
        public salon(string _nom_salon, string _description_salon)
        {
            this.Nom_salon = _nom_salon;
            this.Description_salon = _description_salon;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONTRUCTOR PARA ACTUALIZAR
        public salon(string _nom_salon, string _description_salon,int _id_salon)
        {
            this.Nom_salon = _nom_salon;
            this.Description_salon = _description_salon;
            this.Id_salon = _id_salon;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ELMINAR
        public salon(string _nom_salon)
        {
            this.Nom_salon = _nom_salon;

        }

        public int Registrar()
        {
            int ultimo_id = 0;
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTRAR_SALON", con.Con))
                {
                    cmd.Parameters.AddWithValue("@nom_salon", this.Nom_salon);
                    cmd.Parameters.AddWithValue("@description_salon", this.Description_salon);
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
        public int Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Editar(int Id_Salon, string Nom_salon, string Description_salon)
        {
            con.Con.Open();
            var cmd = new SqlCommand("SP_EDITAR_SALON", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_salon", Id_Salon);
            cmd.Parameters.AddWithValue("@nom_salon", Nom_salon);
            cmd.Parameters.AddWithValue("@description_salon", Description_salon);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void Eliminar(int Id_salon)
        {
            con.Con.Open();
            var cmd = new SqlCommand("SP_ELIMINAR_SALON", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_salon", Id_salon);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }


    }
}
