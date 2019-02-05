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
using System.Data.SqlClient;
using Contro_unity.Vistas;

namespace Contro_unity
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Desea salir de la aplicación?", "Control Unity", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //
            }
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtuser_Enter_1(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave_1(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter_1(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.isPassword = true;
            }
        }

        private void txtpass_Leave_1(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.DimGray;
                txtpass.isPassword = false;
            }
        }



        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarPass frmRecuPass = new RecuperarPass();
            frmRecuPass.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loguearse = new Clases.login();
            SqlDataReader Loguear;
            loguearse.Usuario = txtuser.Text;
            loguearse.Contraseña = txtpass.Text;

            if(loguearse.Usuario == txtuser.Text) {

                lblErrorUser.Visible = false;
                lblErrorLogin.Visible = false;

                if(loguearse.Contraseña == txtpass.Text) {
                    lblErrorLogin.Visible = false;
                    lblErrorPass.Visible = false;
                    Loguear = loguearse.IniciarSesion();
                        if (Loguear.Read() == true)
                        {
                            this.Hide();
                            MenuPrincipal frmPrincipal = new MenuPrincipal();
                            Program.Rol = Loguear["rol_user"].ToString();
                            Program.nom_user = Loguear["nom_user"].ToString();
                            frmPrincipal.Show();

                        }else{
                            lblErrorLogin.Text = "Usuario o contraseña incorrectos, intenta nuevamente";
                            lblErrorLogin.Visible = true;
                            txtpass.Text = "";
                            txtpass_Leave_1(null, e);
                            txtuser.Focus();
                        }
                            }else {                                
                                { lblErrorPass.Text = loguearse.Contraseña;
                                    lblErrorPass.Visible = true;
                                    lblErrorUser.Visible = false;
                                    lblErrorLogin.Visible = false;
                                }
                            }
                        }
                            else{
                                {
                                    lblErrorUser.Text = loguearse.Usuario;
                                    lblErrorUser.Visible = true;
                                    lblErrorPass.Visible = false;
                                    lblErrorLogin.Visible = false;
                                }
                        }
           }
        }
    }


