using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Contro_unity
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnSlide_Click(object sender, EventArgs e)
        {
            
            if (menuVertical.Width == 200)
            {
                menuVertical.Width = 56;
            }
            else
                menuVertical.Width = 200;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicación?", "Control Unity", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
            else
            {
                //
            }

        }

        int LX, LY;
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = Location.X;
            LY = Location.Y;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            Location = new Point(LX, LY);
            Size = new Size(1224, 671);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object frmHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = frmHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:MM:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuInventario());
        }

        private void btnSalones_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuSalones());
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuReportes());
        }

        private void btnProfesores_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuProfesores());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuUsuarios());
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new MenuConfig());
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ReservasProfesores());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            txtRoluser.Text = Program.Rol;
            txtNombreuser.Text = Program.nom_user;
            privilegio_user();
        }

        private void privilegio_user()
        {
            //desabilitar boton
            if(Program.Rol != "Administrador")
            {                
                btnUsuarios.Visible = false;                
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cerrar Sesión?", "Control Unity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login frmlogin = new login();
                Hide();
                frmlogin.Show();
            }
            else
            {
                //
            }
        }
    }
}
