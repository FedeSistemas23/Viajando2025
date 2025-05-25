using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaDatos.CD_EstadosUsuario;
using CapaNegocio;
using CapaNegocio.CN_Localidades;
using CapaNegocio.CN_Usuario;
using CapaServicios;
using CapaSesion;


namespace interfazPpal.Frm_Usuarios
{
    public partial class frm_AltaUsuario : Form
    {
        List<CN_Nuevo_Usuario> listaUsuariosCS = new List<CN_Nuevo_Usuario>();
        CN_MostrarDatosUsuario usuario = new CN_MostrarDatosUsuario();
        CN_ObtenerEstadosUsuario MostrarEstado = new CN_ObtenerEstadosUsuario();

        CN_TraerProvincias traerProvincias = new CN_TraerProvincias();
        CN_TraerLocalidades localidadesCN = new CN_TraerLocalidades();
        CN_TraerPartidos traerPartidos = new CN_TraerPartidos();

        List<CS_Localidades> listaLocalidadesCN = new List<CS_Localidades>();
        List<CS_Partidos> Listapartidos = new List<CS_Partidos>();
        List<CS_Provincias> listaProvincias = new List<CS_Provincias>();


        public frm_AltaUsuario()
        {
            InitializeComponent();
        }

        private void frm_AltaUsuario_Load(object sender, EventArgs e)
        {
            MostrarEstado.TraerEstadosCN();
            dgvDatosUsuario.RowHeadersVisible = false;
            listaUsuariosCS = usuario.MostrarDatosDGV();
            dgvDatosUsuario.DataSource = null;

            cmbPartido.Items.Clear();
            cmbPartido.Items.Add("Seleccione la Localidad");
            cmbPartido.SelectedIndex = 0;
            cmbPartido.SelectedIndexChanged += cmbPartido_SelectedIndexChanged;

            CargarEstadosEnComboBox();
            CargarLocalidades();
            cargarProvincias();
            CargarCmbPartido();



            //Partidos


            //cmbProvincia.DisplayMember = "Partido";
            //cmbProvincia.ValueMember = "Id";

            //  cmbProvincia.SelectedIndexChanged += cmbProvincia_SelectedIndexChanged;
            cmbPartido.SelectedIndexChanged += cmbPartido_SelectedIndexChanged;
            // cmbProvincia.SelectedIndexChanged += cmbProvincia_SelectedIndexChanged;





            var listaFiltrada = listaUsuariosCS.Select(u => new
            {
                u.Username,
                u.Nombre,
                u.Apellidos,
                u.Email,
                u.TipoDocumento,
                u.NumDocumento,
                u.Telefono,
                u.Celular,
                u.Provincia,
                u.Partido,
                u.Localidad,
                u.Calle,
                u.NumCalle,
                u.Comision,
                u.Estado
            }).ToList();

            dgvDatosUsuario.DataSource = listaFiltrada;

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


        public void muestraDatos()
        {
            var listaFiltrada = listaUsuariosCS.Select(u => new
            {
                u.Username,
                u.Nombre,
                u.Apellidos,
                u.Email,
                u.TipoDocumento,
                u.NumDocumento,
                u.Telefono,
                u.Celular,
                u.Comision,
                u.Estado
            }).ToList();

            dgvDatosUsuario.DataSource = listaFiltrada;
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


                CapaSesion.CN_Nuevo_Usuario NuevoUsuario = new CapaSesion.CN_Nuevo_Usuario()
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
                muestraDatos();
                CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
                limpiar.Limpiar(panelForm);

                MessageBox.Show("Se ha enviado la 1° contraseña al E-mail.");
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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

        public void cargarProvincias()
        {
            listaProvincias = traerProvincias.traerProvinciasCN().ToList();
            cmbProvincia.DataSource = listaProvincias.ToList();//traerProvincias.traerProvinciasCN().ToList();
            cmbProvincia.DisplayMember = "Provincia";
            //cmbPartido.ValueMember = "Id_Provincia";
            //cmbProvincia.Items.Add("Seleccione Provincia");
            //cmbPartido.SelectedIndex = 0;

            /*
                Listapartidos = traerPartidos.TraerPartidosCN().ToList();
            cmbPartido.DataSource = Listapartidos.ToList();
            cmbPartido.DisplayMember = "Partido";
            cmbPartido.ValueMember = "Id_Partido";
            cmbPartido.SelectedIndex = -1;*/

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cargarProvincias();
            //Hacer funcion que seleccione Provincias y muetre las localidades de cada partido
        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }

        string filtroActual = "";
        private void FiltrarUsuarios()
        {
            string texto = txtInput.Text.ToLower();

            var resultado = listaUsuariosCS.AsEnumerable();

            switch (filtroActual)
            {
                case "Nombre":
                    resultado = resultado.Where(u => u.Nombre.ToLower().Contains(texto));
                    break;
                case "Apellidos":
                    resultado = resultado.Where(u => u.Apellidos.ToLower().Contains(texto));
                    break;
                case "Localidad":
                    resultado = resultado.Where(u => u.Localidad.ToLower().Contains(texto));
                    break;
                case "Partido":
                    resultado = resultado.Where(u => u.Partido.ToLower().Contains(texto));
                    break;
                    /*  case "Activos":
                          resultado = resultado.Where(u => u.Estado && u.Nombre.ToLower().Contains(texto));
                          break;
                      case "Inactivos":
                          resultado = resultado.Where(u => !u.Activo && u.Nombre.ToLower().Contains(texto));*/
                    //  break;
            }

            // dgvDatosUsuario.DataSource = resultado.ToList();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            /*string filtrar = txtInput.Text;
            var usuarioFiltrado = listaUsuariosCS.Where(u =>
            string.IsNullOrEmpty(filtrar) || u.Nombre.Contains(filtrar)).ToList();*/

            filtroActual = "Nombre";
            FiltrarUsuarios();
            /*  dgvDatosUsuario.DataSource = null;
              dgvDatosUsuario.DataSource = usuarioFiltrado;*/
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmCambioContrasenia frm = new FrmCambioContrasenia();
            frm.ShowDialog();
        }

        private void btnApellido_Click(object sender, EventArgs e)
        {
            filtroActual = "Apellidos";
            var listaUsuarios = usuario.MostrarDatosDGV();
            var resultado = listaUsuarios.OrderBy(u => u.Apellidos).ToList();
            dgvDatosUsuario.DataSource = null;
            dgvDatosUsuario.DataSource = resultado;
            //  FiltrarUsuarios();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {

        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            var lista = listaUsuariosCS;
            var texto = txtInput.Text;
            var resultado = listaUsuariosCS.AsEnumerable();

            resultado = resultado.Where(u => u.Localidad.ToLower().Contains(texto));

            dgvDatosUsuario.DataSource = resultado;
            // filtroActual = "Localidad";
            FiltrarUsuarios();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvDatosUsuario.DataSource = usuario.MostrarDatosDGV();
        }

        private void dgvDatosUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = dgvDatosUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvDatosUsuario.CurrentRow.Cells[1].Value.ToString();
            txt_Apellido.Text = dgvDatosUsuario.CurrentRow.Cells[2].Value.ToString();
            txtTipoDocumento.Text = dgvDatosUsuario.CurrentRow.Cells[3].Value.ToString();
            txtNumeroDocumento.Text = dgvDatosUsuario.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvDatosUsuario.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dgvDatosUsuario.CurrentRow.Cells[6].Value.ToString();
            txtCelular.Text = dgvDatosUsuario.CurrentRow.Cells[7].Value.ToString();
            cmbProvincia.Text = dgvDatosUsuario.CurrentRow.Cells[8].Value.ToString();
            cmbPartido.Text = dgvDatosUsuario.CurrentRow.Cells[9].Value.ToString();
            txtCalle.Text = dgvDatosUsuario.CurrentRow.Cells[10].Value.ToString();
            txtNumeroCalle.Text = dgvDatosUsuario.CurrentRow.Cells[11].Value.ToString();
            //txtPartido.Text = dgvDatosUsuario.CurrentRow.Cells[12].Value.ToString();
            npdComision.Text = dgvDatosUsuario.CurrentRow.Cells[13].Value.ToString();
            cmbEstado.Text = dgvDatosUsuario.CurrentRow.Cells[14].Value.ToString();

        }


        // METODOS PARA CARGAR LOS COMBO BOX DEL FORMULARIO
        private void cmbEstado_TextChanged(object sender, EventArgs e)
        {
            string texto = cmbEstado.Text.ToLower();
            List<CS_EstadosUsuario> lista = new List<CS_EstadosUsuario>();
            lista = MostrarEstado.TraerEstadosCN();
            var filtrados = lista
                .Where(estado => estado.Nombre.ToLower().Contains(texto))
                .ToList();

            cmbEstado.DataSource = filtrados;
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "Id";
            cmbEstado.SelectionStart = cmbEstado.Text.Length;
            cmbEstado.SelectionLength = 0;
            cmbEstado.DroppedDown = true;
        }

        private void CargarEstadosEnComboBox()
        {
            try
            {
                CN_EstadosUsuario datos = new CN_EstadosUsuario();
                List<CS_EstadosUsuario> estados = new List<CS_EstadosUsuario>();
                CD_ObtenerEstadoUsuario traerDatos = new CD_ObtenerEstadoUsuario();

                estados = traerDatos.ObtenerEstadosCD();
                cmbEstado.DataSource = estados;
                cmbEstado.DisplayMember = "Nombre";
                cmbEstado.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el estado de usuario: " + ex.Message);
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        //Carga las localidades en el combo box
        public void CargarLocalidades()
        {
            try
            {
                listaLocalidadesCN = localidadesCN.TraerLocalidadesCN().ToList();
                cmbLocalidades.DataSource = listaLocalidadesCN;
                cmbLocalidades.DisplayMember = "Localidad";
                cmbLocalidades.ValueMember = "Id_Localidad";
                cmbLocalidades.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL CAGAR EL COMBO-BOX :CARGAR LOCALIDADES" + ex.Message.ToString());

            }

        }

        public void CargarCmbPartido()
        {
            Listapartidos = traerPartidos.TraerPartidosCN().ToList();
            cmbPartido.DataSource = Listapartidos.ToList();
            cmbPartido.DisplayMember = "Partido";
            cmbPartido.ValueMember = "Id_Partido";
            cmbPartido.SelectedIndex = -1;

        }
        private void cmbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPartido.SelectedItem is CS_Partidos partido)
            {
                var localidadesFiltradas = listaLocalidadesCN.ToList()
                    .Where(l => l.Id_Partido == partido.Id_Partido)
                    .ToList();

                cmbLocalidades.DataSource = localidadesFiltradas;
                cmbLocalidades.DisplayMember = "Localidad";
                //  cmbLocalidades.ValueMember = "Id_Localidad ";
            }
        }

        private void lblPartido_Click(object sender, EventArgs e)
        {

        }
    }
}
