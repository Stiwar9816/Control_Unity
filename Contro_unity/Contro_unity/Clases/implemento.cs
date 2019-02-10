﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contro_unity.Clases
{
    class implemento:Funciones
    {
        Conexion con = new Conexion();
        //PRODIEDADES DE LA CLASE
        public int Id_implements { get; set; }
        public string Cod_serie { get; set; }
        public string Nom_implements { get; set; }
        public string Datetime_register_implements { get; set; }
        public int Stock_implements { get; set; }
        public string Brand { get; set; }
        public string Description_implements { get; set; }

        public implemento() { }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public implemento(string _cod_serie, string _nom_implements,string _datetime_register_implements,int _stock, string _brand, string _description_implements)
        {
            this.Cod_serie = _cod_serie;
            this.Nom_implements = _nom_implements;
            this.Datetime_register_implements = _datetime_register_implements;
            this.Stock_implements = _stock;
            this.Brand = _brand;
            this.Description_implements = _description_implements;
        }

        public int Registrar()
        {
            int ultimo_id = 0;
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTRAR_INVENTARIO", con.Con))
                {
                    cmd.Parameters.AddWithValue("@cod_serie", this.Cod_serie);
                    cmd.Parameters.AddWithValue("@nom_implements", this.Nom_implements);
                    cmd.Parameters.AddWithValue("@datetime_register_implements", this.Datetime_register_implements);
                    cmd.Parameters.AddWithValue("@stock_implements", this.Stock_implements);
                    cmd.Parameters.AddWithValue("@brand", this.Brand);
                    cmd.Parameters.AddWithValue("@description_implements", this.Description_implements);
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
                MessageBox.Show(e.ToString());
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

        public void Editar(int Id_implements, string cod_serie, string nom_implements,string datetime_register_implements, int stock_implements, string brand, string description_implements)
        {
            con.Con.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITAR_IMPLEMENTO", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_implements", con.Con);
            cmd.Parameters.AddWithValue("@cod_serie", con.Con);
            cmd.Parameters.AddWithValue("@nom_implements", con.Con);
            cmd.Parameters.AddWithValue("@datetime_register_implements", con.Con);
            cmd.Parameters.AddWithValue("@stock_implements", con.Con);
            cmd.Parameters.AddWithValue("@brand", con.Con);
            cmd.Parameters.AddWithValue("@description_implements", con.Con);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void Eliminar(string Cod_serie)
        {
            con.Con.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_IMPLEMENTO", con.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod_serie", Cod_serie);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void Buscar(DataGridView dtg, string Filter)
        {
            con.Con.Open();
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_IMPLEMENTO", con.Con);
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
