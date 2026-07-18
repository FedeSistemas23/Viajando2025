using interfazLogin.Presentacion;
using interfazPpal;
using Loggin;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using CapaNegocio;
using CapaSesion;

namespace interfazLogin
{
    public partial class FrmLogin1 : Form
    {
        MenuPpal menu1 = new MenuPpal();
        CN_GuardaRespuestas guardaRespuestas;
        //CN_ValidarUsuario validarusuario = new CN_ValidarUsuario();
        CN_UsuarioEnSesion usuario;

        string Aleatorio;
        public FrmLogin1()
        {
            InitializeComponent();
        }
        public FrmLogin1(string aleatorio)
        {
            InitializeComponent();
            Aleatorio = aleatorio;

            usuario = new CN_UsuarioEnSesion();
            guardaRespuestas = new CN_GuardaRespuestas();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ej.: ejemplo@gmail.com")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ej.: ejemplo@gmail.com";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
          
            CN_ValidarUsuario obj = new CN_ValidarUsuario();

            string mensaje;

            if (txtUsuario.Text != "Ej.: ejemplo@gmail.com")
            {
                if (txtPass.Text != "Contraseña")
                {
                    Usuario usuario = new Usuario
                    {
                        Username = txtUsuario.Text,
                        Password = txtPass.Text
                    };

                    if (obj.Login(usuario, out mensaje))
                    {
                        if (usuario.DebeCambiarPassword)
                        {
                            FrmEditarPassword form = new FrmEditarPassword(usuario);
                            form.ShowDialog();
                            return;
                        }

                        this.Hide();
                        bienvenida saludo = new bienvenida();
                        saludo.ShowDialog();
                        menu1.Show();
                    }
                    else
                    {
                        MessageBox.Show(mensaje,
                                        "Login",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una contraseña válida.",
                                    "Login",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario válido.",
                                "Login",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        private void lnkOlvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPreguntasSeguridad preguntas = new FrmPreguntasSeguridad();
            this.Hide();
            preguntas.Show();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            btnIngresar.Enabled = true;
        }
    }
}

