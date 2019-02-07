﻿using Contro_unity.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contro_unity
{
    public partial class MenuInventario : Form
    {
        Conexion con = new Conexion();

        public MenuInventario()
        {
            InitializeComponent();
        }

        private void privilegio_user()
        {
            //desabilitar boton
            if (Program.Rol != "Administrador")
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.implements' Puede moverla o quitarla según sea necesario.
            this.implementsTableAdapter.Fill(this.control_unityDataSet.implements);
            privilegio_user();
            txtCod_Serie.Enabled = false;
            txtNombre.Enabled = false;
            txtStock.Enabled = false;
            txtMarca.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtCod_Serie.Enabled = true;
            txtNombre.Enabled = true;
            txtStock.Enabled = true;
            txtMarca.Enabled = true;
            txtDescripcion.Enabled = true;
            btnConfirmarAgregar.Visible = true;
        }

        private void Ingresar_Inventario()
        {
            if (btnAgregar.Enabled == true)
            {
                if (btnAgregar.Enabled == true)
                {
                    //var Implemento = new Clases.implemento(txtCod_Serie.Text,txtNombre.Text,txtFecha.Text,Convert.ToInt32(txtStock.Value),txtMarca.Text,txtDescripcion.Text);
                    //Implemento.Registrar();
                    this.implementsTableAdapter.Fill(this.control_unityDataSet.implements);
                    txtCod_Serie.Text = "";
                    txtNombre.Text = "";
                    txtStock.Value = 0;
                    //txtFecha.Text = "";
                    txtMarca.Text = "";
                    txtDescripcion.Text = "";

                }
                else
                {
                    MessageBox.Show("Los Campo de textos no estan habilitados, Por favor presione agregar e intente de nuevo");
                }
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCod_Serie.Enabled = true;
            txtNombre.Enabled = true;
            txtStock.Enabled = true;
            txtMarca.Enabled = true;
            txtDescripcion.Enabled = true;
            btnConfirmarEditar.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCod_Serie.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtStock.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                txtMarca.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
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
                var DeleteImple = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var implemento = new Clases.implemento();
                implemento.Eliminar(DeleteImple);
                MessageBox.Show("Elimando Correctamente");
                this.implementsTableAdapter.Fill(this.control_unityDataSet.implements);
                txtCod_Serie.Text = "";
                txtNombre.Text = "";
                txtStock.Value = 0;
                txtMarca.Text = "";
                txtDescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
