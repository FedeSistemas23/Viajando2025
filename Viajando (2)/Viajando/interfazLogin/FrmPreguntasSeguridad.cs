using CapaNegocio;
using CapaSesion;
using interfazPpal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace interfazLogin
{
    public partial class FrmPreguntasSeguridad : Form
    {     
        FrmLogin1 form = new FrmLogin1();
       
        public FrmPreguntasSeguridad()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            form.ShowDialog();
        }

        private void btnEnviarUsuario_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            string username = txtUsuario.Text;
            
            CN_ValidarUsuario validarUsuario = new CN_ValidarUsuario();
            List <PreguntasSeguridad> lista = new CN_TraePreguntasSeguridad().TraerPreguntas(username, out mensaje);
            if (lista is null)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                panelPreguntas.Visible = true;               
                lblpregunta1.Text = lista[0].Pregunta;
                lblpregunta2.Text = lista[1].Pregunta;
                lblpregunta3.Text = lista[2].Pregunta;
                lblContestePreguntas.Visible = true;
                txtRespuesta1.Visible = true; txtRespuesta2.Visible = true; txtRespuesta3.Visible = true;
                btnEnviarRtas.Visible = true;
                btnEnviarRtas.Enabled = true;
            }    
        }


        private void btnVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            form.ShowDialog();
        }

        private void btnEnviarRtas_Click(object sender, EventArgs e)
        {
            // log= new FrmLogin1();
            FrmEditarPassword editarPassword = new FrmEditarPassword();
            if (CS_PregRespSeg.Respuesta1 == txtRespuesta1.Text && 
                CS_PregRespSeg.Respuesta2 == txtRespuesta2.Text && 
                CS_PregRespSeg.Respuesta3 == txtRespuesta3.Text)
            {

                string aleatorio = Aleatorios.Armar();
                CS_UsuarioEnSesion.password = aleatorio;
                string concatenados = aleatorio+CS_UsuarioEnSesion.Username;
                string hasheo2 = Seguridad.SHA256(concatenados);
                editarPass.EditarPassword(hasheo2, CS_UsuarioEnSesion.Username);
                ArmarMail.Preparar(CS_UsuarioEnSesion.Username, CS_UsuarioEnSesion.email, aleatorio);
                MessageBox.Show("Se ha enviado una contraseña ha su correo electronico. " +
                    "Debe Volver a iniciar sesion, e ingresar esa contraseña que fue enviada.");
                this.Close();
                FrmLogin1 frmLogin = new FrmLogin1(aleatorio);
                CS_UsuarioEnSesion.LimpiarUsuario();
                frmLogin.ShowDialog( );
                //editarPassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("Una de las respuestas no es correcta. Verifiquelas e ingreselas nuevamente");
                txtRespuesta1.Focus();
            }
        }
    }
}
