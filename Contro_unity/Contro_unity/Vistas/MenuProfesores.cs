using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contro_unity
{
    public partial class MenuProfesores : Form
    {
        Conexion con = new Conexion();

        public MenuProfesores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = true;
            txtFullName.Enabled = true;
            txtPrograma.Enabled = true;

            /*
            if (con.validar_profesor(Convert.ToInt32(txtCC.Text)) == 0)
            {
                MessageBox.Show(con.insertar_profesores(Convert.ToInt32(txtCC.Text), txtFullName.Text, txtPrograma.selectedValue));
            }
            else
            {
                MessageBox.Show("El profesor ya existe");
            }*/
        }

        private void MenuProfesores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.teacher' Puede moverla o quitarla según sea necesario.
            this.teacherTableAdapter.Fill(this.control_unityDataSet.teacher);
            txtCC.Enabled = false;
            txtFullName.Enabled = false;
            txtPrograma.Enabled = false;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Agregar Profesor si los textBox estan habilitados
            if (btnAgregar.Enabled == true)
            {
                MessageBox.Show(con.insertar_profesores(Convert.ToInt64(txtCC.Text), txtFullName.Text, txtPrograma.selectedValue));
                this.teacherTableAdapter.Fill(this.control_unityDataSet.teacher);
                txtCC.Text = "";
                txtFullName.Text = "";
                txtPrograma.Clear();
            }
            else
            {
                MessageBox.Show("Los Campo de textos no estan habilitados, Por favor seleccione una opcion e intente de neuvo");
            }

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            txtCC.Enabled = true;
            txtFullName.Enabled = true;
            txtPrograma.Enabled = true;
           
        }

    }
}
