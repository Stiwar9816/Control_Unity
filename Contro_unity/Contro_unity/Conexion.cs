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
        public Conexion()
        {
            try
            {
                SqlCon = new SqlConnection("Data Source=DESKTOP-S7URQ0I\\SQLEXPRESS;Initial Catalog=control_unity;Integrated Security=True");
                SqlCon.Open();
                //MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No Se conecto con la BD: "+Ex.ToString());
            }
        }

        //CONSULTAS PARA EL MENU SALONES

        //Agregar Profesores
        public string insertar_profesores(long CC, string nombre, string programa)
        {
            string resultado = "Se Agrego Correctamente";

            try
            {
                SqlCom = new SqlCommand("insert into teacher (cc_teacher,nom_teacher,program_teacher) values ("+CC+",'"+nombre+"','"+programa+"')",SqlCon);
                SqlCom.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                resultado = "No se Registro Correctamente: " + Ex.ToString();
            }

            return resultado;
        }

         //Validacion de registros de salones
        public int validar_profesor(int CC)
        {
            int resultado = 0;
            //Convert.ToString(contador);

            try
            {
                SqlCom = new SqlCommand("select from * teacher where cc_teacher= " +CC+ "" , SqlCon);
                SqlDr = SqlCom.ExecuteReader();
                while (SqlDr.Read())
                {
                    resultado++;
                }
                SqlDr.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se puedo agregar, Ya existe este salon:"+Ex.ToString());
            }

            return resultado;
        }



        //Consultas Salones

        public string insertar_salon(string nombre, string descripcion)
        {
            string resultado = "Se agrego correctamente";

            try
            {
                SqlCom = new SqlCommand("insert into salons (nom_salon,description_salon) values ('"+nombre+"','"+descripcion+"')",SqlCon);
                SqlCom.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                resultado = "No se registro correctamente: " + Ex.ToString();
            }
            return resultado;
        }




        //Consultas Inventario

        public string insertar_inventario(string cod_serie, string nombre, decimal stock, string marca, string descripcion)
        {
            string resultado = "Se agrego correctamente";

            try
            {
                SqlCom = new SqlCommand("insert into implements (cod_serie,nom_implements,stock_implements,brand,description_implements) values ('" + cod_serie + "','" + nombre + "', "+stock+", '"+marca+"','"+descripcion+"')", SqlCon);
                SqlCom.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                resultado = "No se registro correctamente: " + Ex.ToString();
            }
            return resultado;
        }
    }
}
