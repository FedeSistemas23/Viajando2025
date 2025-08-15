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
        bool editarUsuario = false;

        List<CN_Nuevo_Usuario> listaUsuariosCS = new List<CN_Nuevo_Usuario>();
        CN_MostrarDatosUsuario usuario = new CN_MostrarDatosUsuario();
        CN_ObtenerEstadosUsuario MostrarEstado = new CN_ObtenerEstadosUsuario();
        CN_EditarDatosUsuario editarUsuarioCN = new CN_EditarDatosUsuario();

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
            DGV_datosUsuario.RowHeadersVisible = false;
            listaUsuariosCS = usuario.MostrarDatosDGV();
            DGV_datosUsuario.DataSource = null;

            CargarEstadosEnComboBox();
            CargarLocalidades();
            cargarProvincias();
            CargarCmbPartido();

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

            DGV_datosUsuario.DataSource = listaFiltrada;

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

            DGV_datosUsuario.DataSource = listaFiltrada;
        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
          /*  CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();

            editarUsuario = false;
           if(editarUsuario)
                try
                { //     ALTA DE USUARIO
                    if (editarUsuario == false)
                    {

                        CN_Alta_Usuario AltaUsuario = new CN_Alta_Usuario();
                        string pass = Aleatorios.Armar();
                        string concatenados = pass + txtUsuario.Text;

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

                        NuevoUsuario.Provincia = cmbProvincia.DisplayMember;
                        NuevoUsuario.Localidad = cmbLocalidades.DisplayMember;

                        AltaUsuario.AñadirAtributos(NuevoUsuario);
                        listaUsuariosCS.Add(NuevoUsuario);
                        muestraDatos();
                        limpiar.Limpiar(panelForm);

                        MessageBox.Show("Se ha enviado la 1° contraseña al E-mail.");
                        txtUsuario.Focus();
                    }//  EDITAR USUARIO
                    else if (editarUsuario == true)
                    {
                        CN_Nuevo_Usuario UsuarioEditar = new CN_Nuevo_Usuario
                        {
                            Username = txtUsuario.Text,
                            Nombre = txtNombre.Text,
                            Apellidos = txt_Apellido.Text,
                            Email = txtEmail.Text,
                            Telefono = txtTelefono.Text,
                            Celular = txtCelular.Text
                        };
                        editarUsuarioCN.editarDatosUsuarioCN(UsuarioEditar);
                        listaUsuariosCS.Add(UsuarioEditar);
                        DGV_datosUsuario.DataSource = null;
                        muestraDatos();
                        MessageBox.Show("Usuario editado con exito");
                        limpiar.Limpiar(panelForm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: "  +ex.Message);
                }
          */
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
            cmbProvincia.ValueMember = "Id_Provincia";
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincia.SelectedItem is CS_Provincias provincia)
            {

                var provinciasFiltradas = Listapartidos.ToList()
                    .Where(l => l.Id_Provincia == provincia.Id_Provincia)
                    .ToList();

                cmbPartido.DataSource = provinciasFiltradas;
                cmbPartido.DisplayMember = "Partido";
                // cmbLocalidades.ValueMember = "Id_Localidad ";
            }
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

            }

        }

        private void button13_Click_1(object sender, EventArgs e)
        {


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

        private void DGV_datosUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGV_datosUsuario.DataSource = null;
            DGV_datosUsuario.Rows.Clear();
        }

        public void CN_CargarControles(bool editarUsuario)
        {
            if (editarUsuario)
            {

                try
                {
                    if (DGV_datosUsuario.CurrentRow != null)
                    {
                        txtUsuario.Text = DGV_datosUsuario.CurrentRow.Cells["Username"].Value.ToString();
                        txtNombre.Text = DGV_datosUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
                        txt_Apellido.Text = DGV_datosUsuario.CurrentRow.Cells["Apellidos"].Value.ToString();
                        txtEmail.Text = DGV_datosUsuario.CurrentRow.Cells["Email"].Value.ToString();
                        // txtTipoDocumento.Text = DGV_datosUsuario.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                        //txtNumeroDocumento.Text = DGV_datosUsuario.CurrentRow.Cells["NumDocumento"].Value.ToString();
                        //txtTelefono.Text = DGV_datosUsuario.CurrentRow.Cells["Telefono"].Value.ToString();
                        txtCelular.Text = DGV_datosUsuario.CurrentRow.Cells["Celular"].Value.ToString();
                        /* cmbProvincia.Text = DGV_datosUsuario.CurrentRow.Cells["Provincia"].Value.ToString();
                         cmbPartido.Text = DGV_datosUsuario.CurrentRow.Cells["Partido"].Value.ToString();
                         cmbLocalidades.Text = DGV_datosUsuario.CurrentRow.Cells["Localidad"].Value.ToString();
                         txtCalle.Text = DGV_datosUsuario.CurrentRow.Cells["Calle"].Value.ToString();
                         txtNumeroCalle.Text = DGV_datosUsuario.CurrentRow.Cells["NumCalle"].Value.ToString();

                         npdComision.Value = Convert.ToDecimal(DGV_datosUsuario.CurrentRow.Cells["Comision"].Value);// DGV_datosUsuario.CurrentRow.Cells["Comision"].Value.ToString();
                         cmbEstado.Text = DGV_datosUsuario.CurrentRow.Cells["Estado"].Value.ToString();*/
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("!ERROR ALCARGAR DATOS DEL DVG-USUARIO " + ex.Message.ToString());
                }
            }
        }
        /* cmbProvincia.SelectedItem = listaDeProvincias
     .FirstOrDefault(p => p.Nombre == fila.Cells["Provincia"].Value.ToString());
     */

        private void button3_Click(object sender, EventArgs e)
        {
            editarUsuario = true;
            CN_CargarControles(editarUsuario);

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
            DGV_datosUsuario.DataSource = null;
            DGV_datosUsuario.DataSource = resultado;

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

            DGV_datosUsuario.DataSource = resultado;
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
            DGV_datosUsuario.DataSource = usuario.MostrarDatosDGV();
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

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblComision_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void DGV_datosUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //   public void CN_CargarControles()
            //{
            try
            {
                if (DGV_datosUsuario.CurrentRow != null)
                {
                    txtUsuario.Text = DGV_datosUsuario.CurrentRow.Cells["Username"].Value.ToString();
                    txtNombre.Text = DGV_datosUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
                    txt_Apellido.Text = DGV_datosUsuario.CurrentRow.Cells["Apellidos"].Value.ToString();
                    txtEmail.Text = DGV_datosUsuario.CurrentRow.Cells["Email"].Value.ToString();
                    txtTipoDocumento.Text = DGV_datosUsuario.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                    txtNumeroDocumento.Text = DGV_datosUsuario.CurrentRow.Cells["NumDocumento"].Value.ToString();
                    txtTelefono.Text = DGV_datosUsuario.CurrentRow.Cells["Telefono"].Value.ToString();
                    txtCelular.Text = DGV_datosUsuario.CurrentRow.Cells["Celular"].Value.ToString();
                    cmbProvincia.Text = DGV_datosUsuario.CurrentRow.Cells["Provincia"].Value.ToString();
                    cmbPartido.Text = DGV_datosUsuario.CurrentRow.Cells["Partido"].Value.ToString();
                    cmbLocalidades.Text = DGV_datosUsuario.CurrentRow.Cells["Localidad"].Value.ToString();
                    txtCalle.Text = DGV_datosUsuario.CurrentRow.Cells["Calle"].Value.ToString();
                    txtNumeroCalle.Text = DGV_datosUsuario.CurrentRow.Cells["NumCalle"].Value.ToString();

                    npdComision.Value = Convert.ToDecimal(DGV_datosUsuario.CurrentRow.Cells["Comision"].Value);// DGV_datosUsuario.CurrentRow.Cells["Comision"].Value.ToString();
                    cmbEstado.Text = DGV_datosUsuario.CurrentRow.Cells["Estado"].Value.ToString();
                }

                Console.WriteLine("sE CARGARON LOS COTROLES CON LA INFORMACIN");

            }
            catch (Exception ex)
            {
                Console.WriteLine("!ERROR ALCARGAR DATOS DEL DVG-USUARIO " + ex.Message.ToString());
            }
        }

        //CN_CargarControles();
        /*txtUsuario.Text = DGV_datosUsuario.CurrentRow.Cells[0].Value.ToString();
        txtNombre.Text = DGV_datosUsuario.CurrentRow.Cells[1].Value.ToString();
        txt_Apellido.Text = DGV_datosUsuario.CurrentRow.Cells[2].Value.ToString();
        /*  txtTipoDocumento.Text = DGV_datosUsuario.CurrentRow.Cells[3].Value.ToString();
          txtNumeroDocumento.Text =DGV_datosUsuario.CurrentRow.Cells[4].Value.ToString();
          txtEmail.Text = DGV_datosUsuario.CurrentRow.Cells[5].Value.ToString();
          txtTelefono.Text = DGV_datosUsuario.CurrentRow.Cells[6].Value.ToString();
          txtCelular.Text = DGV_datosUsuario.CurrentRow.Cells[7].Value.ToString();
          cmbProvincia.Text = DGV_datosUsuario.CurrentRow.Cells[8].Value.ToString();
          cmbPartido.Text = DGV_datosUsuario.CurrentRow.Cells[9].Value.ToString();
          txtCalle.Text = DGV_datosUsuario.CurrentRow.Cells[10].Value.ToString();
          txtNumeroCalle.Text = DGV_datosUsuario.CurrentRow.Cells[11].Value.ToString();
          //txtPartido.Text = DGV_datosUsuario.CurrentRow.Cells[12].Value.ToString();
          npdComision.Text = DGV_datosUsuario.CurrentRow.Cells[13].Value.ToString();
          cmbEstado.Text = DGV_datosUsuario.CurrentRow.Cells[14].Value.ToString();*/



        private void DGV_datosUsuario_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            editarUsuario = true;
            CN_CargarControles(editarUsuario);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_datosUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();

            editarUsuario = false;
            if (!editarUsuario)
                try
                { //     ALTA DE USUARIO
                    if (editarUsuario == false)
                    {

                        CN_Alta_Usuario AltaUsuario = new CN_Alta_Usuario();
                        string pass = Aleatorios.Armar();
                        string concatenados = pass + txtUsuario.Text;

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

                        NuevoUsuario.Provincia = cmbProvincia.DisplayMember;
                        NuevoUsuario.Localidad = cmbLocalidades.DisplayMember;

                        AltaUsuario.AñadirAtributos(NuevoUsuario);
                        listaUsuariosCS.Add(NuevoUsuario);
                        muestraDatos();
                        limpiar.Limpiar(panelForm);

                        MessageBox.Show("Se ha enviado la 1° contraseña al E-mail.");
                        txtUsuario.Focus();
                    }//  EDITAR USUARIO
                    else if (editarUsuario == true)
                    {
                        CN_Nuevo_Usuario UsuarioEditar = new CN_Nuevo_Usuario
                        {
                            Username = txtUsuario.Text,
                            Nombre = txtNombre.Text,
                            Apellidos = txt_Apellido.Text,
                            Email = txtEmail.Text,
                            Telefono = txtTelefono.Text,
                            Celular = txtCelular.Text
                        };
                        editarUsuarioCN.editarDatosUsuarioCN(UsuarioEditar);
                        listaUsuariosCS.Add(UsuarioEditar);
                        DGV_datosUsuario.DataSource = null;
                        muestraDatos();
                        MessageBox.Show("Usuario editado con exito");
                        limpiar.Limpiar(panelForm);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
        }
    }
}
