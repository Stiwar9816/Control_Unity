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
    class profesor:Funciones
    {
        Conexion con = new Conexion();
        
        //PRODIEDADES DE LA CLASE
        public int Id_teacher { get; set; }
        public int Cc_teacher { get; set; }
        public string Nom_teacher { get; set; }
        public string Program_teacher { get; set; }

        public profesor() { }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public profesor(int _cc_teacher,string _nom_teacher, string _program_teacher)
        {
            this.Cc_teacher = _cc_teacher;
            this.Nom_teacher = _nom_teacher;
            this.Program_teacher = _program_teacher;
        }

        //ACCIONES
        public int Registrar()
        {
            int ultimo_id = 0;
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTAR_PROFESOR",con.Con))
                {
                    cmd.Parameters.AddWithValue("@cc_teacher", this.Cc_teacher);
                    cmd.Parameters.AddWithValue("@nom_teacher", this.Nom_teacher);
                    cmd.Parameters.AddWithValue("@program_teacher", this.Program_teacher);
                    cmd.Parameters.AddWithValue("@ultimo_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Con.Open();
                    cmd.ExecuteNonQuery();
                    ultimo_id = Convert.ToInt32( cmd.Parameters["@ultimo_id"].Value.ToString());
                    con.Con.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se ´pudo registrar", e.Message);
                return ultimo_id;
            }
            finally
            {
                if(con.Con.State == ConnectionState.Open)
                {
                    con.Con.Close();
                }


            }
            return ultimo_id;
        }

        public void Eliminar(int Cc_teacher)
        {
            con.Con.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PROFESOR", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cc_teacher", Cc_teacher);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Editar(string nom_teacher, string program_teacher, int cc_teacher)
        {
           
            con.Con.Open();
            var cmd = new SqlCommand("SP_EDITAR_PROFESOR", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cc_teacher", cc_teacher);
            cmd.Parameters.AddWithValue("@nom_teacher", nom_teacher);
            cmd.Parameters.AddWithValue("@program_teacher", program_teacher);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear(); 
        }
        public void Buscar(DataGridView dtg, string Filter)
        {
            con.Con.Open();
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_PROFESOR", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@filtro", SqlDbType.VarChar, 200).Value = Filter;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtg.DataSource = dt;
        }
    }
}
