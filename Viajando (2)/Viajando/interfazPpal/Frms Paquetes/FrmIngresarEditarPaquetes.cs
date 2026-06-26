using CapaNegocio;
using CapaServicios;
using CapaSesion;
using Loggin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarPaquetes : Form
    {
        CS_ValidarFormulario Validar;
        CS_LimpiarFormularios Limpiador;
        CN_Bitacora bitacora;

        int IdProveedorHotel;
        string NombreHotel;
        int Id_Destino;
        string destino;
        bool editar = false;
        int Id_Paquete;

        public FrmIngresarEditarPaquetes()
        {
            InitializeComponent();
            Validar = new CS_ValidarFormulario();
            Limpiador = new CS_LimpiarFormularios();
            bitacora = new CN_Bitacora();
        }
        private void FrmIngresarEditarPaquetes_Load(object sender, EventArgs e)
        {
            CargarComboDestino();
            List<Paquete> Paquetes = new List<Paquete>(new CN_MostrarPaquetes().MostrarPaquetes());
            dgvPaquetes.DataSource = Paquetes;
        }
        
        private void MostrarPaquetes()
        {
            dgvPaquetes.Rows.Add(new object[]
            {
                lblnrodepaquete.Text,
                cmbDestino.Items.Add(cmbDestino.Text),
                dtpFechaSalida.Value,
                dtpFechaRegreso.Value,
                npdDisponibilidad.Value,
                txtPrecioLista.Text,
                txtPrecioEfectivo.Text,
            });
        }


        public void btnAgregarDestino_Click(object sender, EventArgs e)
        {
            FrmAgregarDestino NuevoDestino = new FrmAgregarDestino(this);
            NuevoDestino.ShowDialog();
        }

        public void AgregarDestinoAlCombo(int id_destino, string destino)
        {
            Id_Destino = id_destino;
            if (destino != "")
            {
                cmbDestino.Items.Add(destino);
            }
        }
        public void AgregarHotelAlCombo(string nombreHotel)
        {
            NombreHotel = nombreHotel;
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string mensaje = string.Empty;

            if (editar == false)
            {
                try
                {
                    Paquete NuevoPaquete = new Paquete()
                    {
                        FechaSalida = Convert.ToDateTime(dtpFechaSalida.Value),
                        FechaRegreso = Convert.ToDateTime(dtpFechaRegreso.Value),
                        Destino = new Destino() { Id_Destino = Convert.ToInt32(txtid_destino.Text)},
                        Disponibilidad = Convert.ToInt32(npdDisponibilidad.Value),
                        CantidadDias = Convert.ToInt32(npdCantidasDias.Value),
                        CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                        ProveedorHotel = new Hotel() { Id_ProvedorHotel = Convert.ToInt32(txtid_hotel.Text)},
                        ProveedorBus = new Bus() { Id_ProvedorBus = Convert.ToInt32(txtid_bus.Text) },
                        GastosAdministrativos = Convert.ToDecimal(txtGastosAdministrativos.Text),
                        PrecioLista = Convert.ToDecimal(txtPrecioLista.Text),
                        PrecioEfectivo = Convert.ToDecimal(txtPrecioEfectivo.Text),
                        Coste = Convert.ToDecimal(txtCoste.Text), 
                    };

                    int IdNuevoPaquete = new CN_GuardarPaquete().GuardarNuevoPaquete(NuevoPaquete, out mensaje);
                    if (IdNuevoPaquete != 0)
                    {
                        MessageBox.Show(mensaje);
                        //bitacora.GuardarBitacora(CS_Usuario.Id_Usuario, "Creacion de paquete", "Se ha creado un paquete nuevo.");
                       MostrarPaquetes();
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

                  
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CN_EliminarPaquete EliminarPaquete = new CN_EliminarPaquete();
            if (dgvPaquetes.SelectedRows.Count > 0)
            {
                if (dgvPaquetes.CurrentRow != null && dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value != null)
                {
                    Id_Paquete = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value.ToString());
                    EliminarPaquete.EliminarPaqueteL(Id_Paquete);
                    MessageBox.Show("Eliminado correctamente");
                    MostrarPaquetes();
                }
                else
                {
                    MessageBox.Show("No existen paquetes para eliminar");
                    cmbDestino.Focus();
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiador.Limpiar(this);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count == 1)
            {
                DataGridViewRow DestinoParaVer = dgvPaquetes.SelectedRows[0];
                if (DestinoParaVer != null)
                {
                    FrmFolletoPaquete Folleto = new FrmFolletoPaquete(DestinoParaVer);
                    Folleto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No hay paquetes para ver");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar solo un destino");
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)  
        {
            try
            {
                editar = true;
                if (dgvPaquetes.SelectedRows.Count > 0)
                {
                    if (dgvPaquetes.CurrentRow != null && dgvPaquetes.CurrentRow.Cells["Nrodepaquete"].Value != null)
                    {
                        int Id_Paquete = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Nrodepaquete"].Value);
                        cmbDestino.Text = dgvPaquetes.CurrentRow.Cells["Destino"].Value.ToString();
                        npdDisponibilidad.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Disponibilidad"].Value);                       
                        dtpFechaRegreso.Value = Convert.ToDateTime(dgvPaquetes.CurrentRow.Cells["FechaRegreso"].Value);
                        npdCantidasDias.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadDias"].Value);
                        npdCantidadNoches.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadNoches"].Value);
                        cmbHotel.Text = dgvPaquetes.CurrentRow.Cells["ProveedorHotel"].Value.ToString();
                        cmbBus.Text = dgvPaquetes.CurrentRow.Cells["ProveedorBus"].Value.ToString(); 
                        txtGastosAdministrativos.Text = dgvPaquetes.CurrentRow.Cells["GastosAdministrativos"].Value.ToString();
                        txtPrecioEfectivo.Text = dgvPaquetes.CurrentRow.Cells["PrecioEfectivo"].Value.ToString();
                        txtPrecioLista.Text = dgvPaquetes.CurrentRow.Cells["PrecioLista"].Value.ToString();
                        txtCoste.Text = dgvPaquetes.CurrentRow.Cells["Coste"].Value.ToString();
                        dtpFechaSalida.Value = Convert.ToDateTime(dgvPaquetes.CurrentRow.Cells["FechaSalida"].Value);
                    }
                    else
                    {
                        MessageBox.Show("No hay paquetes para editar.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
        }
        private void btnBuscarHotel_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedorHotel NuevoHotel = new FrmIngresarEditarProveedorHotel(this);
            NuevoHotel.ShowDialog();
        }
        public void CargarComboDestino()
        {
            string mensaje = string.Empty;
            List<Destino> listaDestinos = new CN_CargarComboDestino().CargarComboDestinosL(out mensaje);
            cmbDestino.Items.Clear();

            listaDestinos.Insert(0, new Destino
            {
                Id_Destino = 0,
                Nombre = "Seleccione un destino"
            });


            cmbDestino.DisplayMember = "Nombre";
            cmbDestino.ValueMember = "Id_Destino";
            cmbDestino.DataSource = listaDestinos;
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cmbBus.Enabled = false;
            cmbHotel.Enabled = false;
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            try
            {
                if (cmbHotel.SelectedIndex > 0)
                {

                    int Id_Hotel = Convert.ToInt32(cmbHotel.ValueMember);
                    
                    List<Hotel> listaHoteles = new CN_CargaComboHotel().CargaComboHotelL(Id_Hotel, out mensaje);
                    

                    if (listaHoteles != null)
                    {
                        foreach (Hotel hotel in listaHoteles)
                        {

                            txtid_hotel.Text = Convert.ToString(hotel.Id_ProvedorHotel);
                            cmbRegimen.Items.Add(hotel.Desayuno ? "Desayuno" : "");
                            cmbRegimen.Items.Add(hotel.MediaPension ? "Media Pension" : "");
                            cmbRegimen.Items.Add(hotel.PensionCompleta ? "Pension Completa" : "");
                            lblCantidadDeHabitaciones.Text=hotel.CantidadDeHabitaciones.ToString();
                            lblHabitacionesSingles.Text = Convert.ToString(hotel.HabitacionesSingle);
                            lblDobles.Text= Convert.ToString(hotel.HabitacionesDoble);
                            lblHabitacionesTriples.Text= Convert.ToString(hotel.HabitacionesTriple); 
                            lblHabitacionesCuadruples.Text= Convert.ToString(hotel.HabitacionesCuadruple);
                        }
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un hotel para mostrar su información.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            try
            {  
                if (cmbBus.SelectedIndex > 0)
                {
                    int id_bus = Convert.ToInt32(txtid_bus.Text);
                    List<Bus>listaBuses = new CN_CargaComboBus().CargaComboBusL(id_bus, out mensaje);
                    if (listaBuses != null)
                    {
                        foreach (Bus bus in listaBuses)
                        {
                            txtid_bus.Text = Convert.ToString(bus.Id_ProvedorBus);
                            cmbBus.Items.Add(bus.Semicama);
                            cmbBus.Items.Add(bus.Cama);
                            cmbBus.Items.Add(bus.Suite);
                            npdAsientosCama.Value = bus.AsientosCama;
                            npdAsientosSemicama.Value = bus.AsientosSemicama;
                        }
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    Limpiador.Limpiar(this);
                }
        }catch (Exception ex)
            {
                throw new Exception ("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
        }

        private void btnBuscarBus_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedorBus bus = new FrmIngresarEditarProveedorBus();
            bus.ShowDialog();
        }

        private void dgvPaquetes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPaquetes.SelectedRows[0].Cells["PaqueteNro"].Value);
                string destino = dgvPaquetes.SelectedRows[0].Cells["columnaDestino"].Value.ToString();
                DateTime fechaSalida = Convert.ToDateTime(dgvPaquetes.SelectedRows[0].Cells["FechaSalida"].Value);
                DateTime Regreso = Convert.ToDateTime(dgvPaquetes.SelectedRows[0].Cells["FechaRegreso"].Value);
                int Disponibilidad = Convert.ToInt32(dgvPaquetes.SelectedRows[0].Cells["Disponibilidad"].Value);
                if (Disponibilidad > 0)
                {
                    CrearReserva frm = new CrearReserva(id, destino, fechaSalida, Regreso, Disponibilidad);
                    frm.ShowDialog();
                }
            }
        }

        private void cmbDestino_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            try
            {
                if (cmbDestino.SelectedIndex > 0)
                {
                    txtid_destino.Text = cmbDestino.SelectedValue.ToString();
                    int id_destino = Convert.ToInt32(cmbDestino.SelectedValue);
                   
                    List<Hotel> listaHoteles = new List<Hotel>(new CN_CargaComboHotel().CargaComboHotelL(id_destino, out mensaje));
                    
                    if (listaHoteles.Count > 0)
                    {
                        Hotel hotelpordefecto = new Hotel();
                        hotelpordefecto.Id_ProvedorHotel = 0;
                        hotelpordefecto.NombreDelHotel = "Seleccione el Hotel";

                        // 3. Insertar el elemento por defecto en la primera posición (índice 0)
                        listaHoteles.Insert(0, hotelpordefecto);

                        // 4. Configurar las propiedades del ComboBox
                        cmbHotel.ValueMember = "Id_ProvedorHotel"; // Nombre exacto de la propiedad ID en tu clase Hotel
                        cmbHotel.DisplayMember = "NombreDelHotel";    // Nombre exacto de la propiedad Nombre en tu clase Hotelo

                        // 5. Asignar la lista como origen de datos (esto limpia automáticamente los ítems previos)
                        cmbHotel.DataSource = listaHoteles;

                        // 6. Seleccionar el primer elemento por defecto
                        cmbHotel.SelectedIndex = 0;
                        /*foreach (Hotel hotel in listaHoteles)
                        {
                            cmbHotel.Items.Add(hotel.NombreDelHotel);
                        }*/
                    }
                    else
                     {
                         MessageBox.Show("Ese destino no tiene hoteles, debe cargarlos.");
                     }

                    List<Bus> listaBuses = new List<Bus>(new CN_CargaComboBus().CargaComboBusL(id_destino, out mensaje));
                    if (listaBuses.Count > 0)
                    {

                        Bus buspordefecto = new Bus();
                        buspordefecto.Id_ProvedorBus = 0;
                        buspordefecto.NombreBus = "Seleccione el Destino";


                        // 3. Insertar el elemento por defecto en la primera posición (índice 0)
                        listaBuses.Insert(0, buspordefecto);

                        // 4. Configurar las propiedades del ComboBox
                        cmbBus.ValueMember = "Id_ProvedorBus"; // Nombre exacto de la propiedad ID en tu clase Destino
                        cmbBus.DisplayMember = "NombreBus";    // Nombre exacto de la propiedad Nombre en tu clase Destino

                        // 5. Asignar la lista como origen de datos (esto limpia automáticamente los ítems previos)
                        cmbBus.DataSource = listaBuses;

                        // 6. Seleccionar el primer elemento por defecto
                        cmbBus.SelectedIndex = 0;
                       
                        
                        /*foreach (Bus bus in listaBuses)
                        {
                            cmbBus.Items.Add(bus.NombreBus);
                        }*/
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un destino para mostrar su información.");
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   
    }
}
