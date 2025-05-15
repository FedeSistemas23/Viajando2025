using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
using CapaNegocio.CN_Usuario;
using CapaServicios;
using CapaSesion;


namespace interfazPpal.Frm_Usuarios
{
    public partial class frm_AltaUsuario : Form
    {
        List<CS_AtributosUsuario> listaUsuariosCS = new List<CS_AtributosUsuario>();
        CN_MostrarDatosUsuario usuario = new CN_MostrarDatosUsuario();

        public frm_AltaUsuario()
        {
            InitializeComponent();
        }

        private void frm_AltaUsuario_Load(object sender, EventArgs e)
        {
           // usuario.MostrarDatosDGV();
            dgvDatosUsuario.DataSource = null;
            dgvDatosUsuario.DataSource = usuario.MostrarDatosDGV();

        }

        private void chbDesbloqueoAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ckbNumRerva_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void clbPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CN_Alta_Usuario AltaUsuario = new CN_Alta_Usuario();
            string pass = Aleatorios.Armar();
            string concatenados = pass + txtUsuario.Text;

            try
            {
                ArmarMail.Preparar(txtUsuario.Text, txtEmail.Text, pass);
                string hasheo = Seguridad.SHA256(concatenados);


                CS_AtributosUsuario NuevoUsuario = new CS_AtributosUsuario()
                {
                    Username = txtUsuario.Text,
                    password = hasheo,
                    Digito = CreaDigitoVerificador.Calcular(hasheo),
                    Nombre = txtNombre.Text,
                    Email = txtEmail.Text,
                    Apellidos = txt_Apellido.Text,
                    TipoDocumento = txtTipoDocumento.Text,
                    NumDocumento = txtNumeroDocumento.Text,
                    Telefono = txtTelefono.Text,
                    Celular = txtCelular.Text
                };

                AltaUsuario.AñadirAtributos(NuevoUsuario);
                listaUsuariosCS.Add(NuevoUsuario);
                usuario.MostrarDatosDGV();
                dgvDatosUsuario.DataSource = null;
                dgvDatosUsuario.DataSource = usuario.MostrarDatosDGV();
                Console.WriteLine(NuevoUsuario.Nombre);

                foreach (var item in listaUsuariosCS) Console.WriteLine(item);
                MessageBox.Show("Se ha enviado la 1° contraseña al E-mail.");
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            /*Calle = txtCalle.Text,
            NumCalle = Convert.ToInt32(txtNumeroCalle.Text),
            Localidad = txtNombre.Text,
            Partido = txtPartido.Text,
           /* Provincia = cmbProvincia.Text,
            //pais = txtPais.Text,
            Familia = cmbFamilias.Text,
            intentos = Convert.ToInt32(npdIntentos.Value), // Usar Value para obtener el valor numérico de NumericUpDown.
            VencePass = Convert.ToInt32(npdVenceCada.Value),
            AvisarVencimientoPassword = Convert.ToBoolean(ckbAvisarVencimiento.Checked),
            ContraseñasAnteriores = Convert.ToBoolean(chbContraseñasAnteriores.Checked),
            Minuscula = Convert.ToBoolean(ckbMinuscula.Checked),
            Mayuscula = Convert.ToBoolean(ckbMayuscula.Checked),
            Numeros = Convert.ToBoolnun(ckbNumero.Checked),
            CaracterEspecial = Convert.ToBoolean(ckbEspecial.Checked),
            Minimo8Caracteres = Convert.ToBoolean(ckbMinimo.Checked),
            RealizarPreguntasSeguridad = Convert.ToBoolean(ckbRealizarPreguntasSeguridad.Checked),
            Autenticacion2pasos = Convert.ToBoolean(ckbAutenticacion2FA.Checked),
            Bloqueado = Convert.ToBoolean(chbBloqueado.Checked),
            BloqueadoHasta = Convert.ToInt32(npdBloqueadoPorDias.Value),
            UsuarioTemporal = Convert.ToBoolean(ckbUsuarioTemporal.Checked),
            VenceUsuario = Convert.ToInt32(npdVenceUsuario.Value),
            VencenPermisos = Convert.ToInt32(npdVencePermisos.Value),*/

            // Console.WriteLine(NuevoUsuario.Nombre);
            /*
            foreach (string permisos in clbPermisos.CheckedItems)
            {
                NuevoUsuario.Permisos.Add(permisos);
            }
            AltaUsuario.AñadirAtributos(NuevoUsuario);

            MessageBox.Show("Se ha enviado la 1° contraseña al E-mail.");
            txtUsuario.Focus();*/


        }



        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void ckbFechaRegreso_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbApellido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbFechaReserva_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbDestino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbFechaSalida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            var usuarioFiltrado = listaUsuariosCS.Where(u =>
            string.IsNullOrEmpty(nombre) || u.Nombre.Contains(nombre)).ToList();
        }
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button21_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button21_MouseHover(object sender, EventArgs e)
        {
        }

        private void txtguardar_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnGuardar(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Calle_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chbDesbloqueoAuto_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void txtLocalidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvDatosUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDatosUsuario.DataSource = null;
            dgvDatosUsuario.Rows.Clear();
        }
    }
}
