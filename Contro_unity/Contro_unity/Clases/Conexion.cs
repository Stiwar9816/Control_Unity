using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;


namespace Contro_unity
{
    class Conexion
    {
        SqlConnection SqlCon;
        SqlCommand SqlCom;
        SqlDataReader SqlDr;
        SqlDataAdapter SqlDa;
        DataTable DaT;

        //Conexion a la BD
        public SqlConnection Con = new SqlConnection("Data Source=DELL-PC\\CONTROLSYSTEM;Initial Catalog=control_unity;Integrated Security=True");

       public SqlConnection AbrirConexion()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            return Con;
        }
        public SqlConnection CerrarConexion()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            return Con;
        }
    }
}

