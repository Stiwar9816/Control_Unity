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
            if(btnAgregar.Enabled == true)
            {
                MessageBox.Show(con.insertar_salon(txtNom_Salon.Text,txtDescripcion.Text));
                this.salonsTableAdapter.Fill(this.control_unityDataSet.salons);
                txtNom_Salon.Text = "";
                txtDescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("Los Campo de textos no estan habilitados, Por favor presione agregar e intente de neuvo");
            }
        }
    }
}
