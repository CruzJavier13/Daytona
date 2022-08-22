using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaDato;

namespace Deytona
{
    public partial class Login : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Sesion sesion = new Sesion();
        
        public Login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_salir_MouseHover(object sender, EventArgs e)
        {
            btn_salir.Size = new Size(38,38);
        }

        private void btn_salir_MouseLeave(object sender, EventArgs e)
        {
            btn_salir.Size = new Size(35, 35);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //para poder arrastrar el formulario sin bordes

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            //para poder arrastrar el formulario sin bordes

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            //MenuDaytona Daytona = new MenuDaytona();
            //this.Hide();
            //Daytona.Show();
            //usuario_encontrado = userMode.usuario();
            sesion.USUARIO = txt_usuario.Text;
            sesion.CONTRASENA = txt_passw.Text;
            DataTable table = sesion.IniciarSesion(txt_usuario.Text, txt_passw.Text);

            if (table.Rows.Count != 0)
            {
                Bienvenida bienvenida = new Bienvenida();
                this.Hide();
                bienvenida.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Error");
            }


        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chkMostrarContrasena_CheckStateChanged(object sender, EventArgs e)
        {
            if (txt_passw.Text == "Contraseña")
            {
                chkMostrarContrasena.Enabled = false;
                txt_passw.UseSystemPasswordChar = false;
            }
            else
            {
                chkMostrarContrasena.Enabled = true;
                txt_passw.UseSystemPasswordChar = true;

                if (chkMostrarContrasena.Checked)
                    txt_passw.UseSystemPasswordChar = false;
                else
                    txt_passw.UseSystemPasswordChar = true;
            }
            // if (txtContrasena.Text != "Contraseña")
            //    chkMostrarContrasena.Enabled = true;
        }
        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO")
                txt_usuario.Text = "";
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
                txt_usuario.Text = "USUARIO";
        }
        private void txt_passw_Leave(object sender, EventArgs e)
        {
            if (txt_passw.Text == string.Empty)
            {
                txt_passw.Text = "CONTRASEÑA";
                txt_passw.UseSystemPasswordChar = false;
            }
        }

        private void txt_passw_Click(object sender, EventArgs e)
        {
            if (txt_passw.Text == "CONTRASEÑA")
            {
                txt_passw.Text = "";
                txt_passw.UseSystemPasswordChar = true;
            }
        }
    }
}
