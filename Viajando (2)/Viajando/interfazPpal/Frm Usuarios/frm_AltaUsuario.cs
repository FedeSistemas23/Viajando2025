using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
using CapaNegocio.CN_Localidades;
using CapaNegocio.CN_Usuario;
using CapaServicios;
using CapaSesion;



namespace interfazPpal
{
    public partial class frm_AltaUsuario : Form
    {
        bool editarUsuario = false;

        List<Usuario> listaUsuariosCS = new List<Usuario>();
        CS_EstadosUsuario usuario = new CS_EstadosUsuario();
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

            //MostrarEstado.TraerEstadosCN();
            DGV_datosUsuario.RowHeadersVisible = false;
            // listaUsuariosCS = usuario.MostrarDatosDGV(); // ERROR: CS_EstadosUsuario no tiene MostrarDatosDGV
            listaUsuariosCS = new List<Usuario>(); // TODO: Reemplazar por la obtención real de usuarios desde la capa de negocio
            DGV_datosUsuario.DataSource = null;

            CargarEstadosEnComboBox();
            CargarLocalidades();
            cargarProvincias();
            CargarCmbPartido();

            var listaFiltrada = listaUsuariosCS.Select(u => new
            {
                u.Username,
                Nombre = u.Persona != null ? u.Persona.Nombre : "",
                Apellido = u.Persona != null ? u.Persona.Apellido : "",
                Email = u.Persona != null ? u.Persona.Email : "",
                DNI = u.Persona != null ? u.Persona.DNI : "",
                Telefono = u.Persona != null ? u.Persona.Telefono : "",
                Celular = u.Persona != null ? u.Persona.Celular : "",
                Provincia = u.Persona != null ? u.Persona.Provincia : "",
                Partido = u.Persona != null ? u.Persona.Partido : "",
                Localidad = u.Persona != null ? u.Persona.Localidad : "",
                Calle = u.Persona != null ? u.Persona.Calle : "",
                Numero = u.Persona != null ? u.Persona.Numero : "",
                u.Estado         // Si no existe, revisar si está en Persona
            }).ToList();

            DGV_datosUsuario.DataSource = listaFiltrada;

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
                        txt_Apellido.Text = DGV_datosUsuario.CurrentRow.Cells["Apellido"].Value.ToString();
                        txtEmail.Text = DGV_datosUsuario.CurrentRow.Cells["Email"].Value.ToString();
                        // txtTipoDocumento.Text = DGV_datosUsuario.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                        //txtNumeroDocumento.Text = DGV_datosUsuario.CurrentRow.Cells["NumDocumento"].Value.ToString();
                        //txtTelefono.Text = DGV_datosUsuario.CurrentRow.Cells["Telefono"].Value.ToString();
                        txtCelular.Text = DGV_datosUsuario.CurrentRow.Cells["Celular"].Value.ToString();
                        /* cmbProvincia.Text = DGV_datosUsuario.CurrentRow.Cells["Provincia"].Value.ToString();
                         cmbPartido.Text = DGV_datosUsuario.CurrentRow.Cells["Partido"].Value.ToString();
                         cmbLocalidades.Text = DGV_datosUsuario.CurrentRow.Cells["Localidad"].Value.ToString();
                         txtCalle.Text = DGV_datosUsuario.CurrentRow.Cells["Calle"].Value.ToString();
                         txtNumeroCalle.Text = DGV_datosUsuarios.CurrentRow.Cells["NumCalle"].Value.ToString();

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

        // METODOS PARA CARGAR LOS COMBO BOX DEL FORMULARIO

        private void CargarEstadosEnComboBox()
        {
            try
            {
                CS_EstadosUsuario datos = new CS_EstadosUsuario();
                List<CS_EstadosUsuario> estados = new List<CS_EstadosUsuario>();
                //CD_ObtenerEstadoUsuario traerDatos = new CD_ObtenerEstadoUsuario();

                //estados = traerDatos.ObtenerEstadosCD();
                cmbEstado.DataSource = estados;
                cmbEstado.DisplayMember = "Nombre";
                cmbEstado.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el estado de usuario: " + ex.Message);
            }
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


        private void DGV_datosUsuario_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            editarUsuario = true;
            CN_CargarControles(editarUsuario);
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (editarUsuario == false)
            {
                try
                {
                    Usuario Usuario = new Usuario()
                    {
                        Username = txtUsuario.Text,
                        Persona = new Persona
                        {
                            Nombre = txtNombre.Text,
                            Apellido = txt_Apellido.Text,
                            Email = txtEmail.Text,
                            TipoDocumento = txtTipoDocumento.Text,
                            DNI = txtNumeroDocumento.Text,
                            Telefono = txtTelefono.Text,
                            Celular = txtCelular.Text,
                            Provincia = cmbProvincia.DisplayMember,
                            Partido = cmbPartido.DisplayMember,
                            Localidad = cmbLocalidades.DisplayMember,
                            Calle = txtCalle.Text,
                            Numero = txtNumeroCalle.Text, 
                        },
                        
                        Id_Familia = Convert.ToInt32(cmbFamilias.SelectedValue),
                        PrimeraPassword = true,
                        DebeCambiarPassword = true,
                        PasswordVence = true,
                        DiasVencimiento = 90,
                        FechaUltimoCambio = DateTime.Now,
                        UsuarioTemporal = false,
                        FechaCaducidad = DateTime.Now.AddDays(90),
                        IntentosFallidos = 3,
                        FechaIntento = DateTime.Now,
                        Bloqueado = false,
                        BloqueadoHasta = DateTime.Now.AddDays(1),
                        //Estado = cmbEstado.DisplayMember,
                    };

                    bool IdNuevoUsuario = new CN_AltaUsuario().AltaUsuario(Usuario, out mensaje);
                    if (IdNuevoUsuario == false)
                    {
                        MessageBox.Show(mensaje);
                        //bitacora.GuardarBitacora(CS_Usuario.Id_Usuario, "Creacion de paquete", "Se ha creado un paquete nuevo.");
                        //MostrarUsuario();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btguardarconfiguracionesseguridad_Click(object sender, EventArgs e)
        {
            try
            {
                ConfiguracionSeguridad config = new ConfiguracionSeguridad
                {
                    MinCaracteres =
                    Convert.ToInt32(ckbMinimo.Text),

                    RequiereMay =
                    ckbMayuscula.Checked,

                    RequiereMin =
                    ckbMinuscula.Checked,

                    RequiereNumeros =
                    ckbNumero.Checked,

                    RequiereEspecial =
                    ckbEspecial.Checked,

                    Usa2FA =
                    ckbAutenticacion2FA.Checked,

                    IntentosFallidos =
                    Convert.ToInt32(npdIntentos.Text),

                    TiempoDesbloqueoDias =
                    Convert.ToInt32(npdBloqueadoPorDias.Text),

                    TiempoDesbloqueoHoras =
                    Convert.ToInt32(npdHorasDeBloqueo.Text),

                    DesbloqueoAutomatico =
                    ckbDesbloqueoAuto.Checked,

                    AvisarVencimiento =
                    ckbAvisarVencimiento.Checked,

                    UsaPreguntasSeguridad =
                    ckbRealizarPreguntasSeguridad.Checked,

                    UsuarioBloqueado =
                    ckbBloqueado.Checked,

                    DiasAviso = Convert.ToInt32(npdVenceCada.Text),
                };

                new CN_ConfiguracionesSeguridad().GuardarConfiguracionSeguridad(config);

                MessageBox.Show(
                    "Configuración guardada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
