using CapaNegocio;
using CapaServicios;
using CapaSesion;
using Loggin;
using System;
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
                        Destino = new Destino() { Nombre = cmbHotel.SelectedItem.ToString() },
                        Disponibilidad = Convert.ToInt32(npdDisponibilidad.Value),
                        CantidadDias = Convert.ToInt32(npdCantidasDias.Value),
                        CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                        ProveedorHotel = new Hotel() { NombreDelHotel = cmbHotel.SelectedItem.ToString(), Id_ProvedorHotel = IdProveedorHotel, 
                                                       Regimen = cmbRegimen.SelectedItem.ToString(),
                                                       CantidadDeHabitaciones = Convert.ToInt32(lblCantidadHabitaciones.Text), 
                                                       HabitacionesSingle = Convert.ToInt32(lblSingle.Text),
                                                       HabitacionesDoble = Convert.ToInt32(lblDobles.Text), 
                                                       HabitacionesTriple = Convert.ToInt32(lblHabitacionesTriples.Text),
                                                       HabitacionesCuadruple = Convert.ToInt32(lblHabitacionesTriples.Text),
                                                      },
                        ProveedorBus = new Bus() { NombreBus = cmbBus.Text.ToString(), TipoBus=cmbTipodeBus.SelectedItem.ToString(), 
                                                   AsientosCama = Convert.ToInt32(npdAsientosCama.Value), 
                                                   AsientosSemicama = Convert.ToInt32(npdAsientosSemicama.Value)
                                                 },
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
            else
            {   
                if (!editar == false)
                {
                    CN_EditarPaquetes EditarPaquete = new CN_EditarPaquetes();

                    try
                    {
                        EditarPaquete.EditarPaqueteL(NuevoPaquete);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                    }

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
            List<Destino> listaDestinos = new List<Destino>(new CN_CargarComboDestino().CargarComboDestinosL());
            cmbDestino.Items.Clear(); 
            
            // Limpia el ComboBox
            // Agrega la frase en la primera posición
            cmbDestino.Items.Add("Seleccione el Destino");

            // Luego, agrega los elementos de la lista
            foreach (Destino destino in listaDestinos)
            {
                cmbDestino.Items.Add(destino.Nombre);
            }

            // Opcional: Establece "Seleccione el Destino" como el elemento seleccionado predeterminado
            cmbDestino.SelectedIndex = 0;
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            try
            {
                if (cmbHotel.SelectedIndex > 0)
                {
                    string nombreHotel = cmbHotel.SelectedItem.ToString();
                    List<Hotel> listaHoteles = new CN_CargaComboHotel.CargaComboHotelL(nombreHotel, out mensaje);
                    if (listaHoteles != null)
                    {
                        foreach (Hotel hotel in listaHoteles)
                        {
                            IdProveedorHotel = hotel.Id_ProvedorHotel;
                            cmbRegimen.Items.Add(hotel.Desayuno ? "Desayuno" : "");
                            cmbRegimen.Items.Add(hotel.MediaPension ? "Media Pension" : "");
                            cmbRegimen.Items.Add(hotel.PensionCompleta ? "Pension Completa" : "");
                            lblCantidadDeHabitaciones.Text=hotel.CantidadDeHabitaciones.ToString();
                            lblHabitacionesSingles.Text=hotel.Single.ToString();
                            lblDobles.Text=hotel.Doble.ToString();  
                            lblHabitacionesTriples.Text=hotel.Triple.ToString();
                            lblHabitacionesCuadruples.Text=hotel.Cuadruple.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("");
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
                    string nombreBus = cmbBus.SelectedItem.ToString();
                    List<Bus>listaBuses = new CN_CargaAsientosBuses().CargaAsientosBusL(nombreBus, out mensaje);
                    if (listaBuses != null)
                    {
                        foreach (Bus bus in listaBuses)
                        {
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
                    Destino destino = (Destino)cmbDestino.SelectedItem;
                    List<Bus> listaBuses = new List<Bus>(new CN_CargaComboBus().CargadorComboBusL(destino));
                    List<Hotel> listaHoteles = new List<Hotel>(new CN_CargaComboHotel().CargaComboHotel(destino, out mensaje));
                    
                    if (listaHoteles.Count > 0)
                    {
                        foreach (Hotel hotel in listaHoteles)
                        {
                            cmbHotel.Items.Add(hotel.NombreDelHotel);
                            int Id_ProvedorHotel = hotel.Id_ProvedorHotel;
                        }
                    }
                    else
                     {
                         MessageBox.Show("Ese destino no tiene hoteles, debe cargarlos.");
                     }
                    if(listaBuses.Count > 0)
                    {
                        foreach(Bus bus in listaBuses)
                        {
                            cmbBus.Items.Add(bus.NombreBus);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ese destino no tiene buses, debe cargarlos.");
                    }
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
    }
}
