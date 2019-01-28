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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNom_Salon.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void MenuSalones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.salons' Puede moverla o quitarla según sea necesario.
            this.salonsTableAdapter.Fill(this.control_unityDataSet.salons);
            txtNom_Salon.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

         

            var Salon = new Clases.salon();

            if(btnAgregar.Enabled == true)
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
                }
            }
            else 
            {
                MessageBox.Show("Los Campo de textos no estan habilitados, Por favor presione agregar e intente de neuvo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNom_Salon.Enabled = true;
            txtDescripcion.Enabled = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtNom_Salon.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
