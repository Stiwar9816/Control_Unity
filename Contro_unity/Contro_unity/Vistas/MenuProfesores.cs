﻿using System;
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


            var profesor = new Clases.profesor();
            //Agregar Profesor si los textBox estan habilitados

            
            if (btnAgregar.Enabled == true)
            {
                if (txtCC.Text.Equals(""))
                {
                    txtCC.Focus();
                    MessageBox.Show("El campo de la identificacion esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtFullName.Text.Equals(""))
                {
                    txtFullName.Focus();
                    MessageBox.Show("El campo nombre esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPrograma.Text.Equals(""))
                {
                    txtPrograma.Focus();
                    MessageBox.Show("El campo programa esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var Profesor = new Clases.profesor(Convert.ToInt32(txtCC.Text), txtFullName.Text, txtPrograma.Text);
                    int ultimo_id = Profesor.Registrar();
                    teacherTableAdapter.Fill(this.control_unityDataSet.teacher);
                    txtCC.Text = "";
                    txtFullName.Text = "";
                    txtPrograma.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Los Campo de textos no estan habilitados, Por favor seleccione una opcion e intente de nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
            txtCC.Enabled = false;
            txtFullName.Enabled = true;
            txtPrograma.Enabled = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                txtCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtFullName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrograma.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                
                
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var DeletePro = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var profesor = new Clases.profesor();
                profesor.Eliminar(Convert.ToInt32(DeletePro));
                teacherTableAdapter.Fill(this.control_unityDataSet.teacher);
                MessageBox.Show("Elimando Correctamente");
            } else
            {
                MessageBox.Show("Selecciones una fila");
            }
        }
    }
}