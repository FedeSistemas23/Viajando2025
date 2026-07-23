using CapaNegocio;
using CapaNegocio.CN_Password;
using CapaServicios;
using CapaSesion;
using interfazLogin;
using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmEditarPassword : Form
    {

        FrmPreguntasSeguridad SegPass = new FrmPreguntasSeguridad();
        FrmLogin1 log = new FrmLogin1();

        Usuario obj;
        string Aleatorio;
        public string contraseña;

        public FrmEditarPassword()
        {
            InitializeComponent();
            btnCambiar.Enabled = false;

        }
        public FrmEditarPassword(string aleatorio, Usuario usuario)
        {
            InitializeComponent();
            Aleatorio = aleatorio;
            obj = usuario;
            btnCambiar.Enabled = false;

        }

        public FrmEditarPassword(Usuario usuario)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidarPass.MasterValidarPass(txtPass.Text);
            ckbMinimo.Checked = Validar8.V8caracteres(txtPass.Text);
            ckbMinuscula.Checked = ValidarMinus.Vminus(txtPass.Text);
            ckbMayuscula.Checked = ValidarMayus.Vmayus(txtPass.Text);
            ckbEspecial.Checked = ValidarEspecial.Vespecial(txtPass.Text);
            ckbNumero.Checked = ValidarDigito.Vdigito(txtPass.Text);
            btnCambiar.Enabled = ValidarPass.MasterValidarPass(txtPass.Text);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            contraseña = txtPasswordAnterior.Text;
            if (contraseña == CS_UsuarioEnSesion.password)
            {
                btnCambiar.Enabled = true;
            }
            else { btnCambiar.Enabled = false; }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtRepetir.Text == txtPass.Text)
                btnCambiar.Enabled = true;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int usuario = obj.IdUsuario;
            //pass es la contraseña vieja generada
            string aleatorio = txtPasswordAnterior.Text + usuario;
            string hasheoaleatorio = Seguridad.SHA256(aleatorio);
           // bool yaexiste = BuscadorDeCotraseñas.BuscarContraseñaAnteriorL(txtPasswordAnterior.Text);
            if (txtPasswordAnterior.Text == Aleatorio /*|| yaexiste*/)
            {
                CN_Password objPassword = new CN_Password();
                //string pass = CS_Usuario.password;
                string newpass = txtPass.Text;
                string concatenados = newpass + usuario;
                string jasheo = Seguridad.SHA256(concatenados);
                try
                {
                    /*if (hasheoaleatorio == pass contraseña == CS_UsuarioEnSesion.password )*/
                    {
                        if (ValidarPass.MasterValidarPass(newpass) == true)//&& newpass==txtRepetir.Text) esto es una validacion extra de txtRepetir
                        {
                            if (newpass == txtRepetir.Text)
                            {
                                bool resultado=objPassword.Editar(jasheo, usuario, out mensaje);
                                lblError.Text = "La contraseña se ha cambiado con exito.";
                                log.ShowDialog();
                                this.Dispose();

                            }
                            else
                            {
                                lblError.Text = "Las nuevas contraseñas no coinciden.Reingrese las contraseñas.";
                                txtPass.Focus();
                            }
                        }
                        else
                        {
                            lblError.Text = "Todavia no cumple con los requisitos de seguridad";
                        }
                    }
                    /*else
                    {
                        lblError.Text = "La contraseña anterior no es la correcta";
                    }*/

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("la contraseña amterior no es la correcta");
                txtPasswordAnterior.Focus();
                    
            }
        }

            private void FrmEditarPassword_Load(object sender, EventArgs e)
            {
                btnCambiar.Enabled = false;
            }
        
    } 
}
