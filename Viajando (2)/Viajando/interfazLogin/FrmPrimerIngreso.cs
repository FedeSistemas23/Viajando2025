using CapaNegocio;
using CapaSesion;
using interfazPpal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaServicios;


namespace interfazLogin
{
    public partial class FrmPrimerIngreso : Form
    {        
        Usuario usuario = new Usuario();
        CN_GuardaRespuestas guardarrespuestas = 
        CN_GuardarPrimerIngreso primerIngreso = new CN_GuardarPrimerIngreso();
        
     
        public FrmPrimerIngreso()
        {
            InitializeComponent();
        }

        private void PrimerIngreso_Load(object sender, EventArgs e)
        {
            //btnEnviar.Enabled = false;          
            //FrmEditarPassword cambioContraseña = new FrmEditarPassword();
            
            PreguntasSeguridad[] preguntasAleatoriasPrimerIngreso = new CN_PreguntasSeguridadPrimerIngreso().PreguntasAleatorias();
            for (int i = 0; i < 1; i++)
            {
                lblPregunta1.Text = preguntasAleatoriasPrimerIngreso[0].ToString();
                lblPregunta2.Text = preguntasAleatoriasPrimerIngreso[1].ToString();
                lblPregunta3.Text = preguntasAleatoriasPrimerIngreso[2].ToString();
            }            
        }
        public void Txtvacios(string txtRespuesta1, string txtRespuesta2, string txtRespuesta3)
        {
            if (txtRespuesta1 != "" & txtRespuesta2 != "" & txtRespuesta3!="")
            {
                btnEnviar.Enabled = true;
            }
            else
            {
               btnEnviar.Enabled = false;
            }
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Obtener las preguntas aleatorias que se mostraron al usuario
            PreguntasSeguridad[] preguntasAleatoriasPrimerIngreso = new CN_PreguntasSeguridadPrimerIngreso().PreguntasAleatorias();

            List <Respuestas> respuestas = new List<Respuestas>()
            {
                new Respuestas
                {
                    IdUsuario = usuario.IdUsuario,
                    IdPregunta = preguntasAleatoriasPrimerIngreso[0].IdPregunta,
                    Respuesta = txtRespuesta1.Text,
                },
                new Respuestas
                {
                    IdUsuario = usuario.IdUsuario,
                    IdPregunta = preguntasAleatoriasPrimerIngreso[1].IdPregunta,
                    Respuesta = txtRespuesta2.Text, 
                },
                new Respuestas
                {
                    IdUsuario = usuario.IdUsuario,
                    IdPregunta = preguntasAleatoriasPrimerIngreso[2].IdPregunta,
                    Respuesta = txtRespuesta3.Text,
                }
            };

            // Aquí deberías pasar el arreglo de respuestas a tu método de guardado si es necesario
            bool guardadoExitoso = new CN_GuardaRespuestas().GuardarRespuestas(respuestas, out mensaje);

            DateTime PrimerIngreso = DateTime.Now;
            primerIngreso.GuardarPrimerIngreso(PrimerIngreso);
            this.Close();
            cambioContraseña.Show();
        }
        
        private void txtRespuesta3_TextChanged(object sender, EventArgs e)
        {
            Txtvacios (txtRespuesta1.Text, txtRespuesta2.Text, txtRespuesta3.Text);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin1 frm = new FrmLogin1();
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin1 frm = new FrmLogin1();
            frm.ShowDialog();
        }
    }
}
