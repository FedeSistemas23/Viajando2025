namespace interfazPpal
{
    partial class FrmIngresarEditarPaquetes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid_bus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid_hotel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid_destino = new System.Windows.Forms.TextBox();
            this.cmbTipodeBus = new System.Windows.Forms.ComboBox();
            this.cmbRegimen = new System.Windows.Forms.ComboBox();
            this.lblHabitacionesCuadruples = new System.Windows.Forms.Label();
            this.lblHabitacionesTriples = new System.Windows.Forms.Label();
            this.lblDobles = new System.Windows.Forms.Label();
            this.lblHabitacionesSingles = new System.Windows.Forms.Label();
            this.lblCantidadDeHabitaciones = new System.Windows.Forms.Label();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGastosAdministrativos = new System.Windows.Forms.TextBox();
            this.txtCoste = new System.Windows.Forms.TextBox();
            this.nrodepaquete = new System.Windows.Forms.Label();
            this.lblnrodepaquete = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.btnAgregarDestino = new System.Windows.Forms.Button();
            this.btnBuscarHotel = new System.Windows.Forms.Button();
            this.btnBuscarBus = new System.Windows.Forms.Button();
            this.lblSingle = new System.Windows.Forms.Label();
            this.npdCantidadNoches = new System.Windows.Forms.NumericUpDown();
            this.npdCantidasDias = new System.Windows.Forms.NumericUpDown();
            this.lblCuadruples = new System.Windows.Forms.Label();
            this.lblTriples = new System.Windows.Forms.Label();
            this.lblDoble = new System.Windows.Forms.Label();
            this.lblCantidadHabitaciones = new System.Windows.Forms.Label();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.npdAsientosCama = new System.Windows.Forms.NumericUpDown();
            this.lbbAsientosSemicama = new System.Windows.Forms.Label();
            this.npdAsientosSemicama = new System.Windows.Forms.NumericUpDown();
            this.lblNombreBus = new System.Windows.Forms.Label();
            this.lblAsientosCama = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.txtPrecioEfectivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioLista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegreso = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.tableLayoutPanelBotones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.PaqueteNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnafechadesalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnafechadeRegreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDisponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecioenefectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gastosadministrativos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costoporpaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regimen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidaddehabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Single = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Triple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuadruple = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipodebus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asientocama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asientosemicama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdisponibilidad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadNoches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidasDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosCama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosSemicama)).BeginInit();
            this.tableLayoutPanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(415, 21);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 38);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(808, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(149, 38);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(219, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 38);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdisponibilidad);
            this.groupBox1.Controls.Add(this.txtid_bus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtid_hotel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtid_destino);
            this.groupBox1.Controls.Add(this.cmbTipodeBus);
            this.groupBox1.Controls.Add(this.cmbRegimen);
            this.groupBox1.Controls.Add(this.lblHabitacionesCuadruples);
            this.groupBox1.Controls.Add(this.lblHabitacionesTriples);
            this.groupBox1.Controls.Add(this.lblDobles);
            this.groupBox1.Controls.Add(this.lblHabitacionesSingles);
            this.groupBox1.Controls.Add(this.lblCantidadDeHabitaciones);
            this.groupBox1.Controls.Add(this.lblRegimen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGastosAdministrativos);
            this.groupBox1.Controls.Add(this.txtCoste);
            this.groupBox1.Controls.Add(this.nrodepaquete);
            this.groupBox1.Controls.Add(this.lblnrodepaquete);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.cmbBus);
            this.groupBox1.Controls.Add(this.cmbHotel);
            this.groupBox1.Controls.Add(this.btnAgregarDestino);
            this.groupBox1.Controls.Add(this.btnBuscarHotel);
            this.groupBox1.Controls.Add(this.btnBuscarBus);
            this.groupBox1.Controls.Add(this.lblSingle);
            this.groupBox1.Controls.Add(this.npdCantidadNoches);
            this.groupBox1.Controls.Add(this.npdCantidasDias);
            this.groupBox1.Controls.Add(this.lblCuadruples);
            this.groupBox1.Controls.Add(this.lblTriples);
            this.groupBox1.Controls.Add(this.lblDoble);
            this.groupBox1.Controls.Add(this.lblCantidadHabitaciones);
            this.groupBox1.Controls.Add(this.lblDisponibilidad);
            this.groupBox1.Controls.Add(this.npdAsientosCama);
            this.groupBox1.Controls.Add(this.lbbAsientosSemicama);
            this.groupBox1.Controls.Add(this.npdAsientosSemicama);
            this.groupBox1.Controls.Add(this.lblNombreBus);
            this.groupBox1.Controls.Add(this.lblAsientosCama);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.lblFechaSalida);
            this.groupBox1.Controls.Add(this.txtPrecioEfectivo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPrecioLista);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTransporte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaRegreso);
            this.groupBox1.Controls.Add(this.lblFechaRegreso);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 254);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Nuevo Paquete";
            // 
            // txtid_bus
            // 
            this.txtid_bus.Location = new System.Drawing.Point(616, 23);
            this.txtid_bus.Name = "txtid_bus";
            this.txtid_bus.Size = new System.Drawing.Size(79, 20);
            this.txtid_bus.TabIndex = 145;
            this.txtid_bus.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 144;
            this.label10.Text = "Id_Bus :";
            this.label10.Visible = false;
            // 
            // txtid_hotel
            // 
            this.txtid_hotel.Location = new System.Drawing.Point(344, 23);
            this.txtid_hotel.Name = "txtid_hotel";
            this.txtid_hotel.Size = new System.Drawing.Size(79, 20);
            this.txtid_hotel.TabIndex = 143;
            this.txtid_hotel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 142;
            this.label7.Text = "Id_Hotel :";
            this.label7.Visible = false;
            // 
            // txtid_destino
            // 
            this.txtid_destino.Location = new System.Drawing.Point(23, 125);
            this.txtid_destino.Name = "txtid_destino";
            this.txtid_destino.Size = new System.Drawing.Size(79, 20);
            this.txtid_destino.TabIndex = 141;
            this.txtid_destino.Visible = false;
            // 
            // cmbTipodeBus
            // 
            this.cmbTipodeBus.FormattingEnabled = true;
            this.cmbTipodeBus.Location = new System.Drawing.Point(616, 111);
            this.cmbTipodeBus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipodeBus.Name = "cmbTipodeBus";
            this.cmbTipodeBus.Size = new System.Drawing.Size(149, 21);
            this.cmbTipodeBus.TabIndex = 140;
            // 
            // cmbRegimen
            // 
            this.cmbRegimen.FormattingEnabled = true;
            this.cmbRegimen.Location = new System.Drawing.Point(344, 111);
            this.cmbRegimen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRegimen.Name = "cmbRegimen";
            this.cmbRegimen.Size = new System.Drawing.Size(149, 21);
            this.cmbRegimen.TabIndex = 139;
            // 
            // lblHabitacionesCuadruples
            // 
            this.lblHabitacionesCuadruples.AutoSize = true;
            this.lblHabitacionesCuadruples.Location = new System.Drawing.Point(471, 202);
            this.lblHabitacionesCuadruples.Name = "lblHabitacionesCuadruples";
            this.lblHabitacionesCuadruples.Size = new System.Drawing.Size(0, 13);
            this.lblHabitacionesCuadruples.TabIndex = 138;
            // 
            // lblHabitacionesTriples
            // 
            this.lblHabitacionesTriples.AutoSize = true;
            this.lblHabitacionesTriples.Location = new System.Drawing.Point(368, 195);
            this.lblHabitacionesTriples.Name = "lblHabitacionesTriples";
            this.lblHabitacionesTriples.Size = new System.Drawing.Size(0, 13);
            this.lblHabitacionesTriples.TabIndex = 137;
            // 
            // lblDobles
            // 
            this.lblDobles.AutoSize = true;
            this.lblDobles.Location = new System.Drawing.Point(453, 168);
            this.lblDobles.Name = "lblDobles";
            this.lblDobles.Size = new System.Drawing.Size(0, 13);
            this.lblDobles.TabIndex = 136;
            // 
            // lblHabitacionesSingles
            // 
            this.lblHabitacionesSingles.AutoSize = true;
            this.lblHabitacionesSingles.Location = new System.Drawing.Point(386, 168);
            this.lblHabitacionesSingles.Name = "lblHabitacionesSingles";
            this.lblHabitacionesSingles.Size = new System.Drawing.Size(0, 13);
            this.lblHabitacionesSingles.TabIndex = 135;
            // 
            // lblCantidadDeHabitaciones
            // 
            this.lblCantidadDeHabitaciones.AutoSize = true;
            this.lblCantidadDeHabitaciones.Location = new System.Drawing.Point(453, 142);
            this.lblCantidadDeHabitaciones.Name = "lblCantidadDeHabitaciones";
            this.lblCantidadDeHabitaciones.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadDeHabitaciones.TabIndex = 134;
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Location = new System.Drawing.Point(342, 108);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(0, 13);
            this.lblRegimen.TabIndex = 132;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(821, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 131;
            this.label6.Text = "Gastos Administrativos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(828, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 130;
            this.label5.Text = "Costo por paquete :";
            // 
            // txtGastosAdministrativos
            // 
            this.txtGastosAdministrativos.Location = new System.Drawing.Point(808, 49);
            this.txtGastosAdministrativos.Name = "txtGastosAdministrativos";
            this.txtGastosAdministrativos.Size = new System.Drawing.Size(149, 20);
            this.txtGastosAdministrativos.TabIndex = 129;
            // 
            // txtCoste
            // 
            this.txtCoste.Location = new System.Drawing.Point(808, 88);
            this.txtCoste.Name = "txtCoste";
            this.txtCoste.Size = new System.Drawing.Size(149, 20);
            this.txtCoste.TabIndex = 128;
            // 
            // nrodepaquete
            // 
            this.nrodepaquete.AutoSize = true;
            this.nrodepaquete.Location = new System.Drawing.Point(109, 30);
            this.nrodepaquete.Name = "nrodepaquete";
            this.nrodepaquete.Size = new System.Drawing.Size(0, 13);
            this.nrodepaquete.TabIndex = 127;
            // 
            // lblnrodepaquete
            // 
            this.lblnrodepaquete.AutoSize = true;
            this.lblnrodepaquete.Location = new System.Drawing.Point(12, 30);
            this.lblnrodepaquete.Name = "lblnrodepaquete";
            this.lblnrodepaquete.Size = new System.Drawing.Size(91, 13);
            this.lblnrodepaquete.TabIndex = 126;
            this.lblnrodepaquete.Text = "Nro. de Paquete :";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(112, 97);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(149, 21);
            this.cmbDestino.TabIndex = 125;
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(616, 49);
            this.cmbBus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(149, 21);
            this.cmbBus.TabIndex = 16;
            this.cmbBus.SelectedIndexChanged += new System.EventHandler(this.cmbBus_SelectedIndexChanged);
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(344, 48);
            this.cmbHotel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(149, 21);
            this.cmbHotel.TabIndex = 8;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            // 
            // btnAgregarDestino
            // 
            this.btnAgregarDestino.AutoSize = true;
            this.btnAgregarDestino.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDestino.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDestino.Location = new System.Drawing.Point(112, 125);
            this.btnAgregarDestino.Name = "btnAgregarDestino";
            this.btnAgregarDestino.Size = new System.Drawing.Size(149, 37);
            this.btnAgregarDestino.TabIndex = 4;
            this.btnAgregarDestino.Text = "Destino";
            this.btnAgregarDestino.UseVisualStyleBackColor = false;
            this.btnAgregarDestino.Click += new System.EventHandler(this.btnAgregarDestino_Click);
            // 
            // btnBuscarHotel
            // 
            this.btnBuscarHotel.AutoSize = true;
            this.btnBuscarHotel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHotel.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHotel.Location = new System.Drawing.Point(344, 74);
            this.btnBuscarHotel.Name = "btnBuscarHotel";
            this.btnBuscarHotel.Size = new System.Drawing.Size(149, 32);
            this.btnBuscarHotel.TabIndex = 9;
            this.btnBuscarHotel.Text = "Hotel";
            this.btnBuscarHotel.UseVisualStyleBackColor = false;
            this.btnBuscarHotel.Click += new System.EventHandler(this.btnBuscarHotel_Click);
            // 
            // btnBuscarBus
            // 
            this.btnBuscarBus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBus.ForeColor = System.Drawing.Color.White;
            this.btnBuscarBus.Location = new System.Drawing.Point(616, 75);
            this.btnBuscarBus.Name = "btnBuscarBus";
            this.btnBuscarBus.Size = new System.Drawing.Size(149, 31);
            this.btnBuscarBus.TabIndex = 17;
            this.btnBuscarBus.Text = "Transporte";
            this.btnBuscarBus.UseVisualStyleBackColor = false;
            this.btnBuscarBus.Click += new System.EventHandler(this.btnBuscarBus_Click);
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Location = new System.Drawing.Point(312, 167);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(39, 13);
            this.lblSingle.TabIndex = 124;
            this.lblSingle.Text = "Single:";
            // 
            // npdCantidadNoches
            // 
            this.npdCantidadNoches.Location = new System.Drawing.Point(228, 202);
            this.npdCantidadNoches.Margin = new System.Windows.Forms.Padding(2);
            this.npdCantidadNoches.Name = "npdCantidadNoches";
            this.npdCantidadNoches.Size = new System.Drawing.Size(33, 20);
            this.npdCantidadNoches.TabIndex = 6;
            // 
            // npdCantidasDias
            // 
            this.npdCantidasDias.Location = new System.Drawing.Point(121, 202);
            this.npdCantidasDias.Margin = new System.Windows.Forms.Padding(2);
            this.npdCantidasDias.Name = "npdCantidasDias";
            this.npdCantidasDias.Size = new System.Drawing.Size(33, 20);
            this.npdCantidasDias.TabIndex = 5;
            // 
            // lblCuadruples
            // 
            this.lblCuadruples.AutoSize = true;
            this.lblCuadruples.Location = new System.Drawing.Point(404, 195);
            this.lblCuadruples.Name = "lblCuadruples";
            this.lblCuadruples.Size = new System.Drawing.Size(66, 13);
            this.lblCuadruples.TabIndex = 116;
            this.lblCuadruples.Text = "Cuadruples :";
            this.lblCuadruples.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTriples
            // 
            this.lblTriples.AutoSize = true;
            this.lblTriples.Location = new System.Drawing.Point(308, 195);
            this.lblTriples.Name = "lblTriples";
            this.lblTriples.Size = new System.Drawing.Size(44, 13);
            this.lblTriples.TabIndex = 114;
            this.lblTriples.Text = "Triples :";
            // 
            // lblDoble
            // 
            this.lblDoble.AutoSize = true;
            this.lblDoble.Location = new System.Drawing.Point(404, 167);
            this.lblDoble.Name = "lblDoble";
            this.lblDoble.Size = new System.Drawing.Size(46, 13);
            this.lblDoble.TabIndex = 112;
            this.lblDoble.Text = "Dobles :";
            // 
            // lblCantidadHabitaciones
            // 
            this.lblCantidadHabitaciones.AutoSize = true;
            this.lblCantidadHabitaciones.Location = new System.Drawing.Point(296, 140);
            this.lblCantidadHabitaciones.Name = "lblCantidadHabitaciones";
            this.lblCantidadHabitaciones.Size = new System.Drawing.Size(135, 26);
            this.lblCantidadHabitaciones.TabIndex = 110;
            this.lblCantidadHabitaciones.Text = "Cantidad de Habitaciones :\r\n\r\n";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(117, 173);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(78, 13);
            this.lblDisponibilidad.TabIndex = 106;
            this.lblDisponibilidad.Text = "Disponibilidad :";
            // 
            // npdAsientosCama
            // 
            this.npdAsientosCama.Location = new System.Drawing.Point(616, 138);
            this.npdAsientosCama.Margin = new System.Windows.Forms.Padding(2);
            this.npdAsientosCama.Name = "npdAsientosCama";
            this.npdAsientosCama.ReadOnly = true;
            this.npdAsientosCama.Size = new System.Drawing.Size(149, 20);
            this.npdAsientosCama.TabIndex = 20;
            // 
            // lbbAsientosSemicama
            // 
            this.lbbAsientosSemicama.AutoSize = true;
            this.lbbAsientosSemicama.Location = new System.Drawing.Point(508, 167);
            this.lbbAsientosSemicama.Name = "lbbAsientosSemicama";
            this.lbbAsientosSemicama.Size = new System.Drawing.Size(103, 13);
            this.lbbAsientosSemicama.TabIndex = 104;
            this.lbbAsientosSemicama.Text = "Asientos SemiCama:";
            // 
            // npdAsientosSemicama
            // 
            this.npdAsientosSemicama.Location = new System.Drawing.Point(616, 165);
            this.npdAsientosSemicama.Margin = new System.Windows.Forms.Padding(2);
            this.npdAsientosSemicama.Name = "npdAsientosSemicama";
            this.npdAsientosSemicama.ReadOnly = true;
            this.npdAsientosSemicama.Size = new System.Drawing.Size(149, 20);
            this.npdAsientosSemicama.TabIndex = 21;
            // 
            // lblNombreBus
            // 
            this.lblNombreBus.AutoSize = true;
            this.lblNombreBus.Location = new System.Drawing.Point(537, 56);
            this.lblNombreBus.Name = "lblNombreBus";
            this.lblNombreBus.Size = new System.Drawing.Size(74, 13);
            this.lblNombreBus.TabIndex = 101;
            this.lblNombreBus.Text = "Transportista :";
            // 
            // lblAsientosCama
            // 
            this.lblAsientosCama.AutoSize = true;
            this.lblAsientosCama.Location = new System.Drawing.Point(528, 140);
            this.lblAsientosCama.Name = "lblAsientosCama";
            this.lblAsientosCama.Size = new System.Drawing.Size(83, 13);
            this.lblAsientosCama.TabIndex = 100;
            this.lblAsientosCama.Text = "Asientos Cama :";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(112, 48);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(149, 20);
            this.dtpFechaSalida.TabIndex = 1;
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(13, 54);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(90, 13);
            this.lblFechaSalida.TabIndex = 97;
            this.lblFechaSalida.Text = "Fecha de Salida :";
            // 
            // txtPrecioEfectivo
            // 
            this.txtPrecioEfectivo.Location = new System.Drawing.Point(808, 166);
            this.txtPrecioEfectivo.Name = "txtPrecioEfectivo";
            this.txtPrecioEfectivo.Size = new System.Drawing.Size(149, 20);
            this.txtPrecioEfectivo.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(849, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Precio Efectivo";
            // 
            // txtPrecioLista
            // 
            this.txtPrecioLista.Location = new System.Drawing.Point(808, 127);
            this.txtPrecioLista.Name = "txtPrecioLista";
            this.txtPrecioLista.Size = new System.Drawing.Size(149, 20);
            this.txtPrecioLista.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(849, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Precio Lista";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Location = new System.Drawing.Point(541, 113);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(70, 13);
            this.lblTransporte.TabIndex = 79;
            this.lblTransporte.Text = "Tipo de Bus :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Régimen :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Hotel :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Noches :";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(54, 100);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(49, 13);
            this.lblDestino.TabIndex = 71;
            this.lblDestino.Text = "Destino :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Días :";
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Location = new System.Drawing.Point(112, 72);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(149, 20);
            this.dtpFechaRegreso.TabIndex = 2;
            // 
            // lblFechaRegreso
            // 
            this.lblFechaRegreso.AutoSize = true;
            this.lblFechaRegreso.Location = new System.Drawing.Point(5, 79);
            this.lblFechaRegreso.Name = "lblFechaRegreso";
            this.lblFechaRegreso.Size = new System.Drawing.Size(98, 13);
            this.lblFechaRegreso.TabIndex = 67;
            this.lblFechaRegreso.Text = "Fecha de Regreso:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(23, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 38);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(611, 21);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(149, 38);
            this.btnVer.TabIndex = 29;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // tableLayoutPanelBotones
            // 
            this.tableLayoutPanelBotones.ColumnCount = 5;
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBotones.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.btnCancelar, 4, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.btnVer, 3, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.btnEditar, 1, 0);
            this.tableLayoutPanelBotones.Controls.Add(this.btnEliminar, 2, 0);
            this.tableLayoutPanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBotones.Location = new System.Drawing.Point(0, 580);
            this.tableLayoutPanelBotones.Name = "tableLayoutPanelBotones";
            this.tableLayoutPanelBotones.RowCount = 1;
            this.tableLayoutPanelBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBotones.Size = new System.Drawing.Size(981, 81);
            this.tableLayoutPanelBotones.TabIndex = 0;
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AllowUserToAddRows = false;
            this.dgvPaquetes.AllowUserToDeleteRows = false;
            this.dgvPaquetes.AllowUserToResizeRows = false;
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaqueteNro,
            this.columnaDestino,
            this.columnafechadesalida,
            this.columnafechadeRegreso,
            this.columnaDisponibilidad,
            this.columnaPrecio,
            this.columnaPrecioenefectivo,
            this.Gastosadministrativos,
            this.Costoporpaquete,
            this.Nombre_Hotel,
            this.Regimen,
            this.Cantidaddehabitaciones,
            this.Single,
            this.Doble,
            this.Triple,
            this.Cuadruple,
            this.Nombre_bus,
            this.Tipodebus,
            this.Asientocama,
            this.Asientosemicama});
            this.dgvPaquetes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaquetes.Location = new System.Drawing.Point(0, 254);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPaquetes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPaquetes.Size = new System.Drawing.Size(981, 326);
            this.dgvPaquetes.TabIndex = 95;
            // 
            // PaqueteNro
            // 
            this.PaqueteNro.HeaderText = "Nro. de Paquete";
            this.PaqueteNro.MinimumWidth = 6;
            this.PaqueteNro.Name = "PaqueteNro";
            this.PaqueteNro.ReadOnly = true;
            // 
            // columnaDestino
            // 
            this.columnaDestino.HeaderText = "Destino";
            this.columnaDestino.MinimumWidth = 6;
            this.columnaDestino.Name = "columnaDestino";
            this.columnaDestino.ReadOnly = true;
            // 
            // columnafechadesalida
            // 
            this.columnafechadesalida.HeaderText = "Fecha de Salida";
            this.columnafechadesalida.MinimumWidth = 6;
            this.columnafechadesalida.Name = "columnafechadesalida";
            this.columnafechadesalida.ReadOnly = true;
            // 
            // columnafechadeRegreso
            // 
            this.columnafechadeRegreso.HeaderText = "Fecha de Regreso";
            this.columnafechadeRegreso.MinimumWidth = 6;
            this.columnafechadeRegreso.Name = "columnafechadeRegreso";
            this.columnafechadeRegreso.ReadOnly = true;
            // 
            // columnaDisponibilidad
            // 
            this.columnaDisponibilidad.HeaderText = "Disponibilidad";
            this.columnaDisponibilidad.MinimumWidth = 6;
            this.columnaDisponibilidad.Name = "columnaDisponibilidad";
            this.columnaDisponibilidad.ReadOnly = true;
            // 
            // columnaPrecio
            // 
            this.columnaPrecio.HeaderText = "Precio";
            this.columnaPrecio.MinimumWidth = 6;
            this.columnaPrecio.Name = "columnaPrecio";
            this.columnaPrecio.ReadOnly = true;
            // 
            // columnaPrecioenefectivo
            // 
            this.columnaPrecioenefectivo.HeaderText = "Precio en Efectivo";
            this.columnaPrecioenefectivo.MinimumWidth = 6;
            this.columnaPrecioenefectivo.Name = "columnaPrecioenefectivo";
            this.columnaPrecioenefectivo.ReadOnly = true;
            // 
            // Gastosadministrativos
            // 
            this.Gastosadministrativos.HeaderText = "Gastos Administrativos";
            this.Gastosadministrativos.MinimumWidth = 6;
            this.Gastosadministrativos.Name = "Gastosadministrativos";
            this.Gastosadministrativos.ReadOnly = true;
            this.Gastosadministrativos.Visible = false;
            // 
            // Costoporpaquete
            // 
            this.Costoporpaquete.HeaderText = "Costo por Paquete";
            this.Costoporpaquete.MinimumWidth = 6;
            this.Costoporpaquete.Name = "Costoporpaquete";
            this.Costoporpaquete.ReadOnly = true;
            this.Costoporpaquete.Visible = false;
            // 
            // Nombre_Hotel
            // 
            this.Nombre_Hotel.HeaderText = "Nombre de Hotel";
            this.Nombre_Hotel.MinimumWidth = 6;
            this.Nombre_Hotel.Name = "Nombre_Hotel";
            this.Nombre_Hotel.ReadOnly = true;
            this.Nombre_Hotel.Visible = false;
            // 
            // Regimen
            // 
            this.Regimen.HeaderText = "Regimen";
            this.Regimen.MinimumWidth = 6;
            this.Regimen.Name = "Regimen";
            this.Regimen.ReadOnly = true;
            this.Regimen.Visible = false;
            // 
            // Cantidaddehabitaciones
            // 
            this.Cantidaddehabitaciones.HeaderText = "Cantidad de Habitaciones";
            this.Cantidaddehabitaciones.MinimumWidth = 6;
            this.Cantidaddehabitaciones.Name = "Cantidaddehabitaciones";
            this.Cantidaddehabitaciones.ReadOnly = true;
            this.Cantidaddehabitaciones.Visible = false;
            // 
            // Single
            // 
            this.Single.HeaderText = "Single";
            this.Single.MinimumWidth = 6;
            this.Single.Name = "Single";
            this.Single.ReadOnly = true;
            this.Single.Visible = false;
            // 
            // Doble
            // 
            this.Doble.HeaderText = "Doble";
            this.Doble.MinimumWidth = 6;
            this.Doble.Name = "Doble";
            this.Doble.ReadOnly = true;
            this.Doble.Visible = false;
            // 
            // Triple
            // 
            this.Triple.HeaderText = "Triple";
            this.Triple.MinimumWidth = 6;
            this.Triple.Name = "Triple";
            this.Triple.ReadOnly = true;
            this.Triple.Visible = false;
            // 
            // Cuadruple
            // 
            this.Cuadruple.HeaderText = "Cuadruple";
            this.Cuadruple.MinimumWidth = 6;
            this.Cuadruple.Name = "Cuadruple";
            this.Cuadruple.ReadOnly = true;
            this.Cuadruple.Visible = false;
            // 
            // Nombre_bus
            // 
            this.Nombre_bus.HeaderText = "Nombre de Bus";
            this.Nombre_bus.MinimumWidth = 6;
            this.Nombre_bus.Name = "Nombre_bus";
            this.Nombre_bus.ReadOnly = true;
            this.Nombre_bus.Visible = false;
            // 
            // Tipodebus
            // 
            this.Tipodebus.HeaderText = "Tipo de Bus";
            this.Tipodebus.MinimumWidth = 6;
            this.Tipodebus.Name = "Tipodebus";
            this.Tipodebus.ReadOnly = true;
            this.Tipodebus.Visible = false;
            // 
            // Asientocama
            // 
            this.Asientocama.HeaderText = "Asientos Cama";
            this.Asientocama.MinimumWidth = 6;
            this.Asientocama.Name = "Asientocama";
            this.Asientocama.ReadOnly = true;
            this.Asientocama.Visible = false;
            // 
            // Asientosemicama
            // 
            this.Asientosemicama.HeaderText = "Asientosemicama";
            this.Asientosemicama.MinimumWidth = 6;
            this.Asientosemicama.Name = "Asientosemicama";
            this.Asientosemicama.ReadOnly = true;
            this.Asientosemicama.Visible = false;
            // 
            // txtdisponibilidad
            // 
            this.txtdisponibilidad.Location = new System.Drawing.Point(201, 168);
            this.txtdisponibilidad.Name = "txtdisponibilidad";
            this.txtdisponibilidad.Size = new System.Drawing.Size(33, 20);
            this.txtdisponibilidad.TabIndex = 146;
            this.txtdisponibilidad.Visible = false;
            // 
            // FrmIngresarEditarPaquetes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 661);
            this.Controls.Add(this.dgvPaquetes);
            this.Controls.Add(this.tableLayoutPanelBotones);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmIngresarEditarPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIngresarEditarPaquetes";
            this.Load += new System.EventHandler(this.FrmIngresarEditarPaquetes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadNoches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidasDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosCama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosSemicama)).EndInit();
            this.tableLayoutPanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.NumericUpDown npdCantidadNoches;
        private System.Windows.Forms.NumericUpDown npdCantidasDias;
        private System.Windows.Forms.Label lblCuadruples;
        private System.Windows.Forms.Label lblTriples;
        private System.Windows.Forms.Label lblDoble;
        private System.Windows.Forms.Label lblCantidadHabitaciones;
        private System.Windows.Forms.NumericUpDown npdAsientosCama;
        private System.Windows.Forms.Label lbbAsientosSemicama;
        private System.Windows.Forms.NumericUpDown npdAsientosSemicama;
        private System.Windows.Forms.Label lblNombreBus;
        private System.Windows.Forms.Label lblAsientosCama;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.TextBox txtPrecioEfectivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioLista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.Label lblFechaRegreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarHotel;
        private System.Windows.Forms.Button btnBuscarBus;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAgregarDestino;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotones;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblnrodepaquete;
        private System.Windows.Forms.Label nrodepaquete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGastosAdministrativos;
        private System.Windows.Forms.TextBox txtCoste;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeRegreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dsiponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioEnEfectivo;
        private System.Windows.Forms.Label lblCantidadDeHabitaciones;
        private System.Windows.Forms.Label lblHabitacionesCuadruples;
        private System.Windows.Forms.Label lblHabitacionesTriples;
        private System.Windows.Forms.Label lblDobles;
        private System.Windows.Forms.Label lblHabitacionesSingles;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.ComboBox cmbRegimen;
        private System.Windows.Forms.ComboBox cmbTipodeBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaqueteNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnafechadesalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnafechadeRegreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDisponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecioenefectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gastosadministrativos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costoporpaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidaddehabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Single;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Triple;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuadruple;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_bus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipodebus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asientocama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asientosemicama;
        private System.Windows.Forms.TextBox txtid_destino;
        private System.Windows.Forms.TextBox txtid_hotel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid_bus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdisponibilidad;
    }
}