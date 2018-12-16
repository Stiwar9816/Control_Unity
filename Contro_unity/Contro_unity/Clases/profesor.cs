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

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ACTUALIZAR
        public profesor(int _cc_teacher, string _nom_teacher, string _program_teacher, int _id_teacher)
        {
            this.Cc_teacher = _cc_teacher;
            this.Nom_teacher = _nom_teacher;
            this.Program_teacher = _program_teacher;
            this.Id_teacher = _id_teacher;

        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ELMINAR
        public profesor(int _cc_teacher)
        {
            this.Cc_teacher = _cc_teacher;

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
