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
        public MenuInventario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AggInventario AggInventario = new AggInventario();
            AggInventario.Show();
        }

        private void btnEditInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditInventario EditInventario = new EditInventario();
            EditInventario.Show();
        }
    }
}
