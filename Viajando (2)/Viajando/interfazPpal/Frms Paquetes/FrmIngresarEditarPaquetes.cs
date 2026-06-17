using CapaNegocio;
using CapaServicios;
using CapaSesion;
using Loggin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarPaquetes : Form
    {
        CS_ValidarFormulario Validar;
        CS_LimpiarFormularios Limpiador;
        CN_Bitacora bitacora;

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
            MostrarPaquetes();
            /*CargarComboDestino();
            dgvPaquetes.RowHeadersVisible = false;
            dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaquetes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dgvPaquetes.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            
            int[] columnasParaOcultar = { 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            foreach (int indice in columnasParaOcultar)
            {
                if (indice < dgvPaquetes.Columns.Count)
                {
                    dgvPaquetes.Columns[indice].Visible = false;
                }
            }*/
        }
        private void MostrarPaquetes()
        {

            List<Paquete> Paquetes = new List<Paquete>(new CN_MostrarPaquetes().MostrarPaquetes());   
            dgvPaquetes.DataSource = Paquetes;
        }


        public void btnAgregarDestino_Click(object sender, EventArgs e)
        {
            FrmAgregarDestino NuevoDestino = new FrmAgregarDestino(this);
            NuevoDestino.ShowDialog();
        }

        public void AgregarDestinoAlTextBox(int id_destino, string destino)
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
                    Paquete nuevoPaquete = new Paquete()
                    {
<<<<<<< HEAD
                        MessageBox.Show("Debe completar todos los campos");
                    }
                    else
                    {
                        Paquete nuevoPaquete = new Paquete()
                        {
                            FechaSalida = Convert.ToDateTime(dtpFechaSalida.Value),
                            FechaRegreso = Convert.ToDateTime(dtpFechaRegreso.Value),
                            Destino = new Destino() { Nombre = cmbHotel.SelectedItem.ToString() },
                            CantidadDias = Convert.ToInt32(npdCantidasDias.Value),
                            CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                            ProveedorHotel = new Hotel() { NombreDelHotel = cmbHotel.SelectedItem.ToString() },
                            ProveedorBus = new Bus() { NombreBus = cmbBus.Text.ToString() },
                            GastosAdministrativos = Convert.ToDecimal(txtGastosAdministrativos.Text),
                            PrecioLista = Convert.ToDecimal(txtPrecioLista.Text),
                            PrecioEfectivo = Convert.ToDecimal(txtPrecioEfectivo.Text),
                            Coste = Convert.ToDecimal(txtCoste.Text),
                            Disponibilidad = Convert.ToInt32(npdDisponibilidad.Value),
                        };

                        int IdNuevoPaquete = new CN_GuardarPaquete().GuardarNuevoPaquete(nuevoPaquete, out mensaje);
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
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Limpiador.Limpiar(this);
                }
            }
            else
            {
                CN_EditarPaquetes EditarPaquete = new CN_EditarPaquetes();

                try
                {
                    EditarPaquete.EditarPaqueteL(nuevoPaquete);
=======
                        FechaSalida = Convert.ToDateTime(dtpFechaSalida.Value),
                        FechaRegreso = Convert.ToDateTime(dtpFechaRegreso.Value),
                        Destino = new Destino() { Nombre = cmbHotel.SelectedItem.ToString() },
                        CantidadDias = Convert.ToInt32(npdCantidasDias.Value),
                        CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                        ProveedorHotel = new Hotel() { NombreDelHotel = cmbHotel.SelectedItem.ToString() },
                        ProveedorBus = new Bus() { NombreBus = cmbBus.Text.ToString() },
                        GastosAdministrativos = Convert.ToDecimal(txtGastosAdministrativos.Text),
                        PrecioLista = Convert.ToDecimal(txtPrecioLista.Text),
                        PrecioEfectivo = Convert.ToDecimal(txtPrecioEfectivo.Text),
                        Coste = Convert.ToDecimal(txtCoste.Text),
                        Disponibilidad = Convert.ToInt32(npdDisponibilidad.Value),
                    };

                    int IdNuevoPaquete = new CN_GuardarPaquete().GuardarNuevoPaquete(nuevoPaquete, out mensaje);
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

                    if (!editar == false)
                    {
                        CN_EditarPaquetes EditarPaquete = new CN_EditarPaquetes();

                        try
                        {
                            EditarPaquete.EditarPaqueteL(nuevoPaquete);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                        }
                        
                    }
>>>>>>> ef00c54 (.)
                }
                catch (Exception ex)    
                {
<<<<<<< HEAD
                    MessageBox.Show("Los campos se han modificado con exito";
=======
                    MessageBox.Show(ex.Message);    

>>>>>>> ef00c54 (.)
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
                    if (dgvPaquetes.CurrentRow != null && dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value != null)
                    {
                        int Id_Paquete = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value);
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
            CN_CargarHabitacionesHotel CargadorHabitacionesyRegimen = new CN_CargarHabitacionesHotel();

            if (cmbHotel.SelectedIndex > 0)
            {
                string nombreHotel = cmbHotel.SelectedItem.ToString();
                if (nombreHotel != null)
                {
                    CS_HabitacionesYRegimen habitacionesYRegimen = new CS_HabitacionesYRegimen();
                    habitacionesYRegimen = CargadorHabitacionesyRegimen.CargarHabitacionesL(nombreHotel);
                    if (habitacionesYRegimen != null)
                    {
                        cmbRegimen.Items.Add("Desayuno");
                        cmbRegimen.Items.Add("Media Pension");
                        cmbRegimen.Items.Add("Pension Completa");
                        npdCantidadHabitaciones.Value = habitacionesYRegimen.CantidadHabitaciones;
                        npdSIngle.Value = habitacionesYRegimen.Single;
                        npdDobles.Value = habitacionesYRegimen.Doble;
                        npdTriple.Value = habitacionesYRegimen.Triple;
                        npdCuadruple.Value = habitacionesYRegimen.Cuadruple;
                    }
                }
                else
                {
                    MessageBox.Show("Este hotel no tiene las habitaciones cargadas");
                }
            }
            else
            {
                cmbRegimen.Items.Clear();
                cmbRegimen.Items.Insert(0, "Selecione el regimen");
                cmbRegimen.SelectedIndex = 0;
                npdCantidadHabitaciones.Value = 0;
                npdSIngle.Value = 0;
                npdDobles.Value = 0;
                npdTriple.Value = 0;
                npdCuadruple.Value = 0;
            }
        }

        private void cmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> asientos = new List<int>();
            CN_CargaAsientosBuses CargadorDeAsientos = new CN_CargaAsientosBuses();
            if (cmbBus.SelectedIndex > 0)
            {
                string nombreBus = cmbBus.SelectedItem.ToString();
                asientos = CargadorDeAsientos.CargaAsientosBusL(nombreBus);
                if (asientos != null)
                {
                    cmbTipoBus.Items.Add("Suite");
                    cmbTipoBus.Items.Add("Cama");
                    cmbTipoBus.Items.Add("SemiCama");
                    npdCantidadAsientos.Value = asientos[0];
                    npdAsientosCama.Value = asientos[1];
                    npdAsientosSemicama.Value = asientos[2];
                }
                else
                {
                    MessageBox.Show("Este bus no tiene la cantidad de asientos cargadas");
                }
            }
            else
            {
                cmbTipoBus.Items.Clear();
                cmbTipoBus.Items.Insert(0, "Tipo de Bus");
                cmbTipoBus.SelectedIndex = 0;
                npdCantidadAsientos.Value = 0;
                npdAsientosCama.Value = 0;
                npdAsientosSemicama.Value = 0;
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
                int id = Convert.ToInt32(dgvPaquetes.SelectedRows[0].Cells["Id_Paquete"].Value);
                string destino = dgvPaquetes.SelectedRows[0].Cells["Destino"].Value.ToString();
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
            try
            {
                if (cmbDestino.SelectedIndex > 0)
                {
                    Destino destino = (Destino)cmbDestino.SelectedItem;
                    List<Bus> listaBuses = new List<Bus>(new CN_CargaComboBus().CargadorComboBusL(destino));
                    List<Hotel> listaHoteles = new List<Hotel>(new CN_CargaComboHotel().cargaComboHotel(destino));
                    if (listaHoteles.Count > 0)
                    {
                        foreach (Hotel hotel in listaHoteles)
                        {
                            cmbHotel.Items.Add(hotel.NombreDelHotel);
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
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
        }  
    }
}
