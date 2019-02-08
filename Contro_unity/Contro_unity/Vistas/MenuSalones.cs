using Contro_unity.Vistas;
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
    public partial class MenuSalones : Form
    {
        Conexion con = new Conexion();

        public MenuSalones()
        {
            InitializeComponent();
        }

        private void privilegio_user()
        {
            //desabilitar boton
            if (Program.Rol != "Administrador")
            {
                btnEliminar.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNom_Salon.Enabled = true;
            txtDescripcion.Enabled = true;
            btnConfirmarAgregar.Visible = true;
        }

        private void MenuSalones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.salons' Puede moverla o quitarla según sea necesario.
            this.salonsTableAdapter.Fill(this.control_unityDataSet.salons);
            privilegio_user();
            txtNom_Salon.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void Ingresar_salon()
        {
            var Salon = new Clases.salon();
            if (btnAgregar.Enabled == true)
            {
                if (txtNom_Salon.Text.Equals(""))
                {
                    txtNom_Salon.Focus();
                    MessageBox.Show("Completar nombre del salon", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtDescripcion.Text.Equals(""))
                {
                    txtDescripcion.Focus();
                    MessageBox.Show("Completar la descripcion del salon", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Salon = new Clases.salon(txtNom_Salon.Text, txtDescripcion.Text);
                    int ultimo_id = Salon.Registrar();
                    this.salonsTableAdapter.Fill(this.control_unityDataSet.salons);
                    txtNom_Salon.Text = "";
                    txtDescripcion.Text = "";
                    btnConfirmarAgregar.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Los Campo de textos no estan habilitados, Por favor presione agregar e intente de neuvo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Editar_Salon()
        {
            var salon = new Clases.salon();
            salon.Editar(Convert.ToInt32( txtID.Text), txtNom_Salon.Text, txtDescripcion.Text);
            salonsTableAdapter.Fill(this.control_unityDataSet.salons);
            MessageBox.Show("Actualizado Correctamente");
            txtID.Text = "";
            txtNom_Salon.Text = "";
            txtDescripcion.Text = "";
            btnConfirmarEditar.Visible = false;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNom_Salon.Enabled = true;
            txtDescripcion.Enabled = true;
            btnConfirmarEditar.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNom_Salon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
                var DeleteSalon = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var salon = new Clases.salon();
                salon.Eliminar(Convert.ToInt32(DeleteSalon));
                salonsTableAdapter.Fill(this.control_unityDataSet.salons);
                MessageBox.Show("Elimando Correctamente");
            }
            else
            {
                MessageBox.Show("Selecciones una fila");
            }
        }

        private void btnConfirmarAgregar_Click(object sender, EventArgs e)
        {
            Ingresar_salon();
        }

        private void btnConfirmarEditar_Click(object sender, EventArgs e)
        {
            Editar_Salon();
        }
    }
}
