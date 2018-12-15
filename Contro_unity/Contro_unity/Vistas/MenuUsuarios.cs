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
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'control_unityDataSet.users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter.Fill(this.control_unityDataSet.users);

        }
    }
}
