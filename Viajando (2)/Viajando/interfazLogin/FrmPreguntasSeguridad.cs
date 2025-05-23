﻿using CapaNegocio;
using CapaServicios;
using CapaSesion;
using interfazPpal;
using System;
using System.Windows.Forms;

namespace interfazLogin
{
    public partial class FrmPreguntasSeguridad : Form
    {
        CN_UsuarioEnSesion usuario = new CN_UsuarioEnSesion();
        
        CN_TraerPreguntasYRespuestas pregYresp = new CN_TraerPreguntasYRespuestas();
        CN_EditarPassword editarPass = new CN_EditarPassword();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = CS_UsuarioEnSesion.Id_Usuario;
            CN_ValidarUsuario validarUsuario = new CN_ValidarUsuario();
            bool existe = validarUsuario.ValidarNombreUsuarioL(txtUsuario.Text);
            if (!existe)
            {
                lblNoexisteUsuario.Text = "El usuario no existe. Ingrese el usuario correcto";
            }
            else
            {
                panelPreguntas.Visible = true;
                pregYresp.TraerPreguntas();
                lblpregunta1.Text = CS_PregRespSeg.Pregunta1;
                lblpregunta2.Text = CS_PregRespSeg.Pregunta2;
                lblpregunta3.Text = CS_PregRespSeg.Pregunta3;
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
            if (CS_PregRespSeg.Respuesta1 == txtRespuesta1.Text && CS_PregRespSeg.Respuesta2 == txtRespuesta2.Text && CS_PregRespSeg.Respuesta3 == txtRespuesta3.Text)
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
