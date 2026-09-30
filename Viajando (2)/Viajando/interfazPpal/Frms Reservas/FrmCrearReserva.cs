using CapaNegocio;
using CapaServicios;
using CapaSesion;
using interfazPpal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Loggin
{
    public partial class CrearReserva : Form
    {
        ConversionesDeTipo convertir = new ConversionesDeTipo();
        CN_MostrarReserva mostrar = new CN_MostrarReserva();

        //actualiza el combobox con los destinos disponibles
        CN_TraerDestinos CV_TraerDestinos = new CN_TraerDestinos();

        // actualiza el label con el id del destino seleccionado
        CN_TraerIdDestino CV_TraerIdDestino = new CN_TraerIdDestino();

        //actualiza la disponibilidad
        CN_CheckDisponibilidad CV_CheckDisponibilidad = new CN_CheckDisponibilidad();

        // para poder hacer las conversiones de booleano a bit en la carga y edicion de pasajeros
        int bitCotizar;
        int bitCamaAdicional;



        bool editar = false;

        public CrearReserva()
        {
            InitializeComponent();
        }
        public CrearReserva(int id , string nombre , DateTime FechaSalida , DateTime fechaRegreso, int Disponibilidad )
        {
            InitializeComponent();
                  cbxDestino.Items.Clear();
                  cbxDestino.Items.Add( nombre);
           
            lbl_IdPaquete.Text = Convert.ToString(id);
            dtpFechaSalida.Value = FechaSalida ;
            dtpFechaRegreso.Value = fechaRegreso;
        }

        private bool ValidarControles()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(cbxDestino.Text))
            {
                MessageBox.Show("El campo 'Destino' no puede estar vacío.");
                cbxDestino.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIDVendedor.Text))
            {
                MessageBox.Show("El campo 'Número de Reserva' no puede estar vacío.");
                txtIDVendedor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVendedor.Text))
            {
                MessageBox.Show("El campo 'Vendedor' no puede estar vacío.");
                txtVendedor.Focus();
                return false;
            }

            // Verificar si el valor de NumericUpDown es mayor que 0
            if (npdCantidadPax.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida de pasajeros.");
                npdCantidadPax.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' no puede estar vacío.");
                cbxDestino.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacío.");
                cbxDestino.Focus();
                return false;
            }

            // Si todos los controles están correctos, se retorna true
            return true;
        }
        private void CrearReserva_Load(object sender, EventArgs e)
        {
            MuestraNumReserva Nreserva = new MuestraNumReserva();
            CN_MostrarReserva mostrar = new CN_MostrarReserva();

            txtIDVendedor.Text = Convert.ToString(Nreserva.MostrarNumReservaCN());
            mostrar.MostrarReservaCN();

            dgvReservas.DataSource = mostrar.MostrarReservaCN();

            //establece los valores de la lista con los destinos disponibles.
            // ahora se utiliza la funcion del formulario paquete para traer el destino
            
           // cbxDestino.Items.Clear();
          //  cbxDestino.DataSource= CV_TraerDestinos.TraeDestinos();

            //establece la fecha de la reserva del dia actual
            lblFechaReserva.Text = Convert.ToString(DateTime.Now);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCargaPasajeros frm = new FrmCargaPasajeros();
            frm.ShowDialog();

        }
        public void muestraDatosEnTextbox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvReservas.Rows[e.RowIndex];
                txtIDVendedor.Text = filaSeleccionada.Cells["NroReserva"].Value.ToString();
                cbxDestino.Text = filaSeleccionada.Cells["Destino"].Value.ToString();
                dtpFechaSalida.Text = filaSeleccionada.Cells["FechaSalida"].Value.ToString();
                dtpFechaRegreso.Text = filaSeleccionada.Cells["FechaRegreso"].Value.ToString();
                npdCantidadPax.Text = filaSeleccionada.Cells["CantidadPax"].Value.ToString();
                npdCamaMatrimonial.Text = filaSeleccionada.Cells["CamaMatrimonialx"].Value.ToString();
                npdDoble.Text = filaSeleccionada.Cells["CAntMenores"].Value.ToString();
                npdAsientosSemiCama.Text = filaSeleccionada.Cells["SemiCama"].Value.ToString();
                npdAsientosCama.Text = filaSeleccionada.Cells["AsientosCama"].Value.ToString();
                npdCantHabitaciones.Text = filaSeleccionada.Cells["CantidadHabitaciones"].Value.ToString();
                npdSingle.Text = filaSeleccionada.Cells["Single"].Value.ToString();
                npdDoble.Text = filaSeleccionada.Cells["Doble"].Value.ToString(); cbxDestino.Text = filaSeleccionada.Cells["Destino"].Value.ToString();
                npdTriple.Text = filaSeleccionada.Cells["Triple"].Value.ToString();
                npdCuadruple.Text = filaSeleccionada.Cells["Cuadruple"].Value.ToString();
                txtAscenso.Text = filaSeleccionada.Cells["AscensoMicro"].Value.ToString();
                npdCamaSimple.Text = filaSeleccionada.Cells["CamaSimple"].Value.ToString();
                npdCamaMatrimonial.Text = filaSeleccionada.Cells["CamaMatrimonial"].Value.ToString();
                ckbCotizar.Text = filaSeleccionada.Cells["Cotizar"].Value.ToString();
                txtSeña.Text = filaSeleccionada.Cells["Senia"].Value.ToString();
                txtObservaciones.Text = filaSeleccionada.Cells["Observacion"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                ckbAdicionalCama.Text = filaSeleccionada.Cells["AdicionalCama"].Value.ToString();
                txtVendedor.Text = filaSeleccionada.Cells["Vendedor"].Value.ToString();
                txtAscenso.Text = filaSeleccionada.Cells["AscensMicro"].Value.ToString();
            }
        }

        

        private void btnVer_Click(object sender, EventArgs e)
        {
            frm_MostrarReserva frm = new frm_MostrarReserva();
            frm.ShowDialog();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            CN_MostrarReserva mostrar = new CN_MostrarReserva();
            CN_GuardarReserva reservaNueva = new CN_GuardarReserva();
            
            if (editar == false)
            {
                if (this.ValidarControles())
                {
                    try
                    {   if (ckbCotizar.Checked) { bitCotizar = 1; } else{bitCotizar = 0;}
                        if (ckbAdicionalCama.Checked) { bitCamaAdicional = 1; } else {bitCamaAdicional=0;}

                        CS_Reserva reserva = new CS_Reserva()

                        {
                            
                           
                             Id_Paquete = Convert.ToInt32(lbl_IdPaquete.Text),
                            CantidadPasajeros = Convert.ToInt32(npdCantidadPax.Value),
                            Id_Vendedor= Convert.ToInt32(txtIDVendedor.Text),
                            CantMenorTres = Convert.ToInt32(npdDoble.Value),
                            AsientosCama = Convert.ToInt32(npdAsientosCama.Value),
                            AsientosSemiCama = Convert.ToInt32(npdAsientosSemiCama.Value),
                            Single = Convert.ToInt32(npdSingle.Value),
                            Doble = Convert.ToInt32(npdDoble.Value),
                            Triple = Convert.ToInt32(npdTriple.Value),
                            Cuadruple = Convert.ToInt32(npdCuadruple.Value),
                            AscensoMicro = txtAscenso.Text,
                            CamaSimple = Convert.ToInt32(npdCamaSimple.Value),
                            CamaMatrimonial = Convert.ToInt32(npdCamaMatrimonial.Value),
                            
                            Cotizar = bitCotizar,
                            Senia = convertir.ConvertirTextoADouble(txtSeña.Text),
                            Observacion = txtObservaciones.Text,
                            FechaSalida = dtpFechaSalida.Value,
                            FechaRegreso = dtpFechaRegreso.Value,
                            FechaReserva = DateTime.Now,
                            NombreTitular = txtNombre.Text,
                            ApellidoTitular = txtApellido.Text,
                            
                            AdicionalCama = bitCamaAdicional,
                            Habitaciones = Convert.ToInt32(npdCantHabitaciones.Value),
                            NombreVendedor = txtVendedor.Text,
                            Destino = cbxDestino.Text,
                        };
                        //estos son las variables que permiten que se chequee la disponibilidad y se sepa
                        // si la reserva se guardo en la bd.
                        int idpaquete = Convert.ToInt32(lbl_IdPaquete.Text);
                        int nropasajeros = Convert.ToInt32(npdCantidadPax.Value);
                        int single = Convert.ToInt32(npdSingle.Value);
                        int doble= Convert.ToInt32(npdDoble.Value); 
                        int triple= Convert.ToInt32(npdTriple.Value);   
                        int cuadruple= Convert.ToInt32(npdCuadruple.Value);
                        int asientocama = Convert.ToInt32(npdAsientosCama.Value);
                        int semicama = Convert.ToInt32(npdAsientosSemiCama.Value);
                        int habitaciones = Convert.ToInt32(npdCantHabitaciones.Value);
                        int CamaSimple = Convert.ToInt32(npdCamaSimple.Value);
                        int CamaMatrimonial=Convert.ToInt32(npdCamaMatrimonial.Value);

                        List<int> ListaDisponibilidad = new List<int>();
                        ListaDisponibilidad.Add(idpaquete);
                        ListaDisponibilidad.Add(nropasajeros);
                        ListaDisponibilidad.Add(single);
                        ListaDisponibilidad.Add(doble);
                        ListaDisponibilidad.Add(triple);
                        ListaDisponibilidad.Add(cuadruple);
                        ListaDisponibilidad.Add(asientocama);
                        ListaDisponibilidad.Add(semicama);
                        ListaDisponibilidad.Add(habitaciones);
                        ListaDisponibilidad.Add(CamaSimple);
                        ListaDisponibilidad.Add(CamaMatrimonial);


                        //considero cambiar guarddada por un numero para poder integrar un switch que permita saber cual es el problema exacto
                        bool guardada;
                        // crear un condicional que evalue si hay esapcio para la reserva. trae 
                        // el espacio disponible y hace el calculo en la capa logica
                        //stored procedure que modifique la disponibilidad del paquete en base a lo
                        //que puso la reserva
                        // si hay disponibilidad se cambia la disponibilidad actual y se confirma que esta
                        //guardada
                        //si esta guardada se agrega a la lista y se hace visible
                        //se manda un mensaje de confirmacion al usuario y se limpia el formulario
                        if (CV_CheckDisponibilidad.chkDisponibilidad(ListaDisponibilidad))
                        { guardada = reservaNueva.GuardarReservaCN(reserva); }

                        else { guardada = false; }
                        //stored procedure que modifique la disponibilidad del paquete en base a lo
                        //que puso la reserva
                        //CV_Reservas.ModificarDisponibilidad()
                        reserva.AgregarLista(reserva);
                        if (guardada == true)
                        {
                            reserva.AgregarLista(reserva);

                            panelMsg.Visible = true;
                            lblMsgOk.Visible = true;
                            lblMsgOk.Text = "Reserva guardada con exito";
                            CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
                            dgvReservas.DataSource = null;
                            lblDestino.Text = "";
                            dgvReservas.DataSource = null;
                            dgvReservas.DataSource = mostrar.MostrarReservaCN();
                            limpiar.Limpiar(this);
                            int reservacionN = reserva.NroReserva;

                        }
                        else
                        {
                            panelMsg.Visible = true;
                            lblMsgOk.Visible = true;
                            lblMsgOk.Text = "Ha ocurrido un error al cargar la reserva";
                        }
                        dgvReservas.DataSource = mostrar.MostrarReservaCN();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la reserva, intente de nuevo: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar los campos obligatorios ");
                }
            }
            if (editar == true)
            {
                CN_EditarReserva reservaEditar = new CN_EditarReserva();
                CS_Reserva reserva = new CS_Reserva()

                {
                    NroReserva = Convert.ToInt32(txtIDVendedor.Text),
                    Id_Paquete = Convert.ToInt32(lblDestino.Text),
                    CantidadPasajeros = Convert.ToInt32(npdCantidadPax.Value),
                    CantMenorTres = Convert.ToInt32(npdDoble.Value),
                    AsientosCama = Convert.ToInt32(npdAsientosCama.Value),
                    AsientosSemiCama = Convert.ToInt32(npdAsientosSemiCama.Value),
                    Single = Convert.ToInt32(npdSingle.Value),
                    Doble = Convert.ToInt32(npdDoble.Value),
                    Triple = Convert.ToInt32(npdTriple.Value),
                    Cuadruple = Convert.ToInt32(npdCuadruple.Value),
                    AscensoMicro = txtAscenso.Text,
                    CamaSimple = Convert.ToInt32(npdCamaSimple.Value),
                    CamaMatrimonial = Convert.ToInt32(npdCamaMatrimonial.Value),
                    Cotizar = bitCotizar,
                    Senia = convertir.ConvertirTextoADouble(txtSeña.Text),
                    Observacion = txtObservaciones.Text,
                    FechaSalida = dtpFechaSalida.Value,
                    FechaRegreso = dtpFechaRegreso.Value,
                    FechaReserva = DateTime.Now,
                    NombreTitular = txtNombre.Text,
                    ApellidoTitular = txtApellido.Text,
                    AdicionalCama = bitCamaAdicional,
                    Habitaciones = Convert.ToInt32(npdCantHabitaciones.Value),
                    NombreVendedor = txtVendedor.Text,
                    Destino = cbxDestino.Text,
                };

                if (reservaEditar.EditarReservaCN(reserva))
                {
                    panelMsg.Visible = true;
                    lblMsgOk.Visible = true;
                    lblMsgOk.Text = "Reserva editada con exito";
                    CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
                    dgvReservas.DataSource = null;
                    lblDestino.Text = "";
                    dgvReservas.DataSource = null;
                    dgvReservas.DataSource = mostrar.MostrarReservaCN();
                    limpiar.Limpiar(this);
                }
                editar=false;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
                     // btnEditar 
        {
            editar = true;

            if (dgvReservas.SelectedRows.Count > 0)
            {

                // DataGridViewRow filaSeleccionada = dgvReservas.Rows[e.RowIndex];

                
                lbl_IdPaquete.Text = dgvReservas.CurrentRow.Cells["Id_Paquete"].Value.ToString();
                txtIDVendedor.Text = dgvReservas.CurrentRow.Cells["NroReserva"].Value.ToString();
                cbxDestino.Text = dgvReservas.CurrentRow.Cells["Destino"].Value.ToString();
                dtpFechaSalida.Text = dgvReservas.CurrentRow.Cells["FechaSalida"].Value.ToString();
                dtpFechaRegreso.Text = dgvReservas.CurrentRow.Cells["FechaRegreso"].Value.ToString();
                npdCantidadPax.Text = dgvReservas.CurrentRow.Cells["CantidadPasajeros"].Value.ToString();
                npdCamaMatrimonial.Text = dgvReservas.CurrentRow.Cells["CamaMatrimonial"].Value.ToString();
                npdCantMenores.Text = dgvReservas.CurrentRow.Cells["PasajerosMenores"].Value.ToString();
                npdAsientosSemiCama.Text = dgvReservas.CurrentRow.Cells["AsientosSemiCama"].Value.ToString();
                var valorAsientosCama = dgvReservas.CurrentRow.Cells["AsientosCama"].Value;
                if (valorAsientosCama != DBNull.Value)
                {
                    npdAsientosCama.Value = Convert.ToInt32(valorAsientosCama);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdAsientosCama.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                var CantHabitaciones = dgvReservas.CurrentRow.Cells["Habitaciones"].Value;

                if (CantHabitaciones != DBNull.Value)
                {
                    npdCantHabitaciones.Value = Convert.ToInt32(CantHabitaciones);
                }
                else
                {

                    npdCantHabitaciones.Value = 0;
                }
                var Single = dgvReservas.CurrentRow.Cells["Single"].Value;

                if (Single != DBNull.Value)
                {
                    npdSingle.Value = Convert.ToInt32(Single);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdSingle.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }


                var Doble = dgvReservas.CurrentRow.Cells["Doble"].Value;
                if (Doble != DBNull.Value)
                {
                    npdDoble.Value = Convert.ToInt32(Doble);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdDoble.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }

                var Triple = dgvReservas.CurrentRow.Cells["Triple"].Value;
                if (Triple != DBNull.Value)
                {
                    npdTriple.Value = Convert.ToInt32(Triple);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdTriple.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                var Cuadruple = dgvReservas.CurrentRow.Cells["Cuadruple"].Value;

                if (Cuadruple != DBNull.Value)
                {
                    npdCuadruple.Value = Convert.ToInt32(Cuadruple);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdCuadruple.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                txtAscenso.Text = dgvReservas.CurrentRow.Cells["Ascenso"].Value.ToString();
                var CamaSimple = dgvReservas.CurrentRow.Cells["CamaSimple"].Value;

                if (CamaSimple != DBNull.Value)
                {
                    npdCamaSimple.Value = Convert.ToInt32(CamaSimple);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdCamaSimple.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                var CamaMatrimonial = dgvReservas.CurrentRow.Cells["CamaMatrimonial"].Value;
                if (CamaMatrimonial != DBNull.Value)
                {
                    npdCamaMatrimonial.Value = Convert.ToInt32(CamaMatrimonial);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdCamaMatrimonial.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                
                /*ckbCotizar.Text*/ 
                bitCotizar = Convert.ToInt32( dgvReservas.CurrentRow.Cells["Cotizar"].Value);
                if (bitCotizar==1) { ckbCotizar.Checked = true; } else { ckbCotizar.Checked= false; }
                
                txtSeña.Text = dgvReservas.CurrentRow.Cells["Seña"].Value.ToString();
                txtObservaciones.Text = dgvReservas.CurrentRow.Cells["Observacion"].Value.ToString();
                txtNombre.Text = dgvReservas.CurrentRow.Cells["NombreTitular"].Value.ToString();
                txtApellido.Text = dgvReservas.CurrentRow.Cells["ApellidoTitular"].Value.ToString();

                //ckbAdicionalCama
                bitCamaAdicional = Convert.ToInt32(dgvReservas.CurrentRow.Cells["AdicionalCama"].Value);
                if (bitCamaAdicional==1) { ckbAdicionalCama.Checked = true; }else { ckbAdicionalCama.Checked= false; }
                txtVendedor.Text = dgvReservas.CurrentRow.Cells["NombreVendedor"].Value.ToString();
                
                txtAscenso.Text = dgvReservas.CurrentRow.Cells["Ascenso"].Value.ToString();
                lblFechaReserva.Text = dgvReservas.CurrentRow.Cells["fecha"].Value.ToString();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CN_MostrarReserva mostrar = new CN_MostrarReserva();
            CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = mostrar.MostrarReservaCN();
            lblDestino.Text = "";
            limpiar.Limpiar(this);
        }
        private void button5_Click(object sender, EventArgs e)
        {         // btnEliminar
            CN_ElimnarReserva eliminar = new CN_ElimnarReserva();
            CS_Reserva reserva = new CS_Reserva();
            CN_MostrarReserva mostrar = new CN_MostrarReserva();
            if (dgvReservas.SelectedRows.Count > 0)
            {
                reserva.NroReserva = Convert.ToInt32(dgvReservas.CurrentRow.Cells["NroReserva"].Value);
                if (eliminar.EliminarReservaCN(reserva.NroReserva))
                {
                    panelMsg.Visible = true;
                    lblMsgOk.Visible = true;
                    lblMsgOk.Text = "Reserva Eliminada con exito";
                    dgvReservas.DataSource = null;
                    dgvReservas.DataSource = mostrar.MostrarReservaCN();
                }
                else
                {
                    lblMsgOk.Text = "No se pudo editar la reserva";
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FrmBuscarReserva frm = new FrmBuscarReserva();
            frm.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void npdCantHabitaciones_ValueChanged(object sender, EventArgs e)
        {

        }

        private void npdCantidadPax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ckbDestino_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            FrmBuscarPaquete frm = new FrmBuscarPaquete();
            frm.ShowDialog();
        }

        private void ckbNumRerva_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbFechaRegreso_CheckedChanged(object sender, EventArgs e)
        {
            FrmCargaPasajeros frm = new FrmCargaPasajeros();
            frm.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void cbxDestino_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
           
        }

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //trae el id del destino usando el nombre del destino
            // deberia traer el id del paquete, no del destino. 
           // lbl_IdDestino.Text = CV_TraerIdDestino.TraerIdDestino(cbxDestino.Text).ToString();
        }
    }
}



























