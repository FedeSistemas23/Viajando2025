namespace interfazPpal
{
    partial class FrmIngresarEditarProveedorHotel
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidadHabitaciones = new System.Windows.Forms.Label();
            this.npdCantidadHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.lblDoble = new System.Windows.Forms.Label();
            this.lblTriple = new System.Windows.Forms.Label();
            this.lblCuadruple = new System.Windows.Forms.Label();
            this.npdCuadruple = new System.Windows.Forms.NumericUpDown();
            this.npdTriple = new System.Windows.Forms.NumericUpDown();
            this.npdDoble = new System.Windows.Forms.NumericUpDown();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblRegimen = new System.Windows.Forms.Label();
            this.chbDesayuno = new System.Windows.Forms.CheckBox();
            this.chbMediaPension = new System.Windows.Forms.CheckBox();
            this.chbPensionCompleta = new System.Windows.Forms.CheckBox();
            this.lblSingle = new System.Windows.Forms.Label();
            this.npdSingle = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.pnlHotel = new System.Windows.Forms.Panel();
            this.dgvHotel = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCuadruple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTriple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdDoble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdSingle)).BeginInit();
            this.pnlHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(497, 586);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 42);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(591, 586);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 42);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(741, 586);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(93, 42);
            this.BtnCancelar.TabIndex = 29;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(389, 586);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 42);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(327, 98);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(272, 22);
            this.txtApellido.TabIndex = 4;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(327, 124);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(272, 22);
            this.txtCuit.TabIndex = 5;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(723, 20);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(183, 22);
            this.txtCalle.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(327, 150);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(272, 22);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(724, 124);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(327, 72);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(664, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 16);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "E-mail : ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(249, 153);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 16);
            this.lblTelefono.TabIndex = 39;
            this.lblTelefono.Text = "*Telefono :";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(673, 23);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(44, 16);
            this.lblCalle.TabIndex = 37;
            this.lblCalle.Text = "Calle :";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(286, 127);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(35, 16);
            this.lblCuit.TabIndex = 35;
            this.lblCuit.Text = "Cuit :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(186, 101);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(135, 16);
            this.lblApellido.TabIndex = 34;
            this.lblApellido.Text = "*Apellido Del Titular : ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(190, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(131, 16);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "*Nombre Del Titular :";
            // 
            // lblCantidadHabitaciones
            // 
            this.lblCantidadHabitaciones.AutoSize = true;
            this.lblCantidadHabitaciones.Location = new System.Drawing.Point(3, 23);
            this.lblCantidadHabitaciones.Name = "lblCantidadHabitaciones";
            this.lblCantidadHabitaciones.Size = new System.Drawing.Size(174, 16);
            this.lblCantidadHabitaciones.TabIndex = 49;
            this.lblCantidadHabitaciones.Text = "*Cantidad de Habitaciones :";
            // 
            // npdCantidadHabitaciones
            // 
            this.npdCantidadHabitaciones.Location = new System.Drawing.Point(177, 21);
            this.npdCantidadHabitaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdCantidadHabitaciones.Name = "npdCantidadHabitaciones";
            this.npdCantidadHabitaciones.Size = new System.Drawing.Size(53, 22);
            this.npdCantidadHabitaciones.TabIndex = 14;
            // 
            // lblDoble
            // 
            this.lblDoble.AutoSize = true;
            this.lblDoble.Location = new System.Drawing.Point(353, 23);
            this.lblDoble.Name = "lblDoble";
            this.lblDoble.Size = new System.Drawing.Size(47, 16);
            this.lblDoble.TabIndex = 52;
            this.lblDoble.Text = "Doble:";
            // 
            // lblTriple
            // 
            this.lblTriple.AutoSize = true;
            this.lblTriple.Location = new System.Drawing.Point(464, 23);
            this.lblTriple.Name = "lblTriple";
            this.lblTriple.Size = new System.Drawing.Size(48, 16);
            this.lblTriple.TabIndex = 53;
            this.lblTriple.Text = "Triple :";
            // 
            // lblCuadruple
            // 
            this.lblCuadruple.AutoSize = true;
            this.lblCuadruple.Location = new System.Drawing.Point(583, 23);
            this.lblCuadruple.Name = "lblCuadruple";
            this.lblCuadruple.Size = new System.Drawing.Size(75, 16);
            this.lblCuadruple.TabIndex = 54;
            this.lblCuadruple.Text = "Cuadruple :";
            // 
            // npdCuadruple
            // 
            this.npdCuadruple.Location = new System.Drawing.Point(664, 21);
            this.npdCuadruple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdCuadruple.Name = "npdCuadruple";
            this.npdCuadruple.Size = new System.Drawing.Size(51, 22);
            this.npdCuadruple.TabIndex = 18;
            // 
            // npdTriple
            // 
            this.npdTriple.Location = new System.Drawing.Point(518, 21);
            this.npdTriple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdTriple.Name = "npdTriple";
            this.npdTriple.Size = new System.Drawing.Size(59, 22);
            this.npdTriple.TabIndex = 17;
            // 
            // npdDoble
            // 
            this.npdDoble.Location = new System.Drawing.Point(406, 23);
            this.npdDoble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdDoble.Name = "npdDoble";
            this.npdDoble.Size = new System.Drawing.Size(49, 22);
            this.npdDoble.TabIndex = 16;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(257, 48);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(64, 16);
            this.lblDestino.TabIndex = 58;
            this.lblDestino.Text = "*Destino :";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(327, 46);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(272, 22);
            this.txtDestino.TabIndex = 2;
            // 
            // lblRegimen
            // 
            this.lblRegimen.AutoSize = true;
            this.lblRegimen.Location = new System.Drawing.Point(745, 19);
            this.lblRegimen.Name = "lblRegimen";
            this.lblRegimen.Size = new System.Drawing.Size(68, 16);
            this.lblRegimen.TabIndex = 60;
            this.lblRegimen.Text = "Regimen :";
            // 
            // chbDesayuno
            // 
            this.chbDesayuno.AutoSize = true;
            this.chbDesayuno.Location = new System.Drawing.Point(819, 18);
            this.chbDesayuno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbDesayuno.Name = "chbDesayuno";
            this.chbDesayuno.Size = new System.Drawing.Size(91, 20);
            this.chbDesayuno.TabIndex = 19;
            this.chbDesayuno.Text = "Desayuno";
            this.chbDesayuno.UseVisualStyleBackColor = true;
            // 
            // chbMediaPension
            // 
            this.chbMediaPension.AutoSize = true;
            this.chbMediaPension.Location = new System.Drawing.Point(916, 19);
            this.chbMediaPension.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMediaPension.Name = "chbMediaPension";
            this.chbMediaPension.Size = new System.Drawing.Size(119, 20);
            this.chbMediaPension.TabIndex = 20;
            this.chbMediaPension.Text = "Media Pension";
            this.chbMediaPension.UseVisualStyleBackColor = true;
            // 
            // chbPensionCompleta
            // 
            this.chbPensionCompleta.AutoSize = true;
            this.chbPensionCompleta.Location = new System.Drawing.Point(1041, 19);
            this.chbPensionCompleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbPensionCompleta.Name = "chbPensionCompleta";
            this.chbPensionCompleta.Size = new System.Drawing.Size(139, 20);
            this.chbPensionCompleta.TabIndex = 21;
            this.chbPensionCompleta.Text = "Pension Completa";
            this.chbPensionCompleta.UseVisualStyleBackColor = true;
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Location = new System.Drawing.Point(237, 23);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(48, 16);
            this.lblSingle.TabIndex = 67;
            this.lblSingle.Text = "Single:";
            // 
            // npdSingle
            // 
            this.npdSingle.Location = new System.Drawing.Point(291, 21);
            this.npdSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdSingle.Name = "npdSingle";
            this.npdSingle.Size = new System.Drawing.Size(49, 22);
            this.npdSingle.TabIndex = 15;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(912, 23);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(27, 16);
            this.lblNumero.TabIndex = 69;
            this.lblNumero.Text = "N° :";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(941, 20);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(54, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(645, 49);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(73, 16);
            this.lblLocalidad.TabIndex = 71;
            this.lblLocalidad.Text = "Localidad :";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(724, 46);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(272, 22);
            this.txtLocalidad.TabIndex = 8;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(662, 75);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(56, 16);
            this.lblPartido.TabIndex = 73;
            this.lblPartido.Text = "Partido :";
            // 
            // txtPartido
            // 
            this.txtPartido.Location = new System.Drawing.Point(724, 72);
            this.txtPartido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(272, 22);
            this.txtPartido.TabIndex = 9;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(647, 101);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(69, 16);
            this.lblProvincia.TabIndex = 75;
            this.lblProvincia.Text = "Provincia :";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(723, 98);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(272, 22);
            this.txtProvincia.TabIndex = 10;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(657, 153);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(60, 16);
            this.lblCelular.TabIndex = 78;
            this.lblCelular.Text = "*Celular :";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(723, 150);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(272, 22);
            this.txtCelular.TabIndex = 13;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(195, 23);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(126, 16);
            this.lblNombreProveedor.TabIndex = 80;
            this.lblNombreProveedor.Text = "*Nombre Del Hotel :";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(327, 20);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(272, 22);
            this.txtNombreProveedor.TabIndex = 1;
            // 
            // pnlHotel
            // 
            this.pnlHotel.Controls.Add(this.lblCantidadHabitaciones);
            this.pnlHotel.Controls.Add(this.npdCantidadHabitaciones);
            this.pnlHotel.Controls.Add(this.lblSingle);
            this.pnlHotel.Controls.Add(this.npdSingle);
            this.pnlHotel.Controls.Add(this.lblDoble);
            this.pnlHotel.Controls.Add(this.npdDoble);
            this.pnlHotel.Controls.Add(this.lblTriple);
            this.pnlHotel.Controls.Add(this.npdTriple);
            this.pnlHotel.Controls.Add(this.lblCuadruple);
            this.pnlHotel.Controls.Add(this.npdCuadruple);
            this.pnlHotel.Controls.Add(this.lblRegimen);
            this.pnlHotel.Controls.Add(this.chbDesayuno);
            this.pnlHotel.Controls.Add(this.chbMediaPension);
            this.pnlHotel.Controls.Add(this.chbPensionCompleta);
            this.pnlHotel.Location = new System.Drawing.Point(12, 177);
            this.pnlHotel.Name = "pnlHotel";
            this.pnlHotel.Size = new System.Drawing.Size(1217, 59);
            this.pnlHotel.TabIndex = 82;
            // 
            // dgvHotel
            // 
            this.dgvHotel.AllowUserToAddRows = false;
            this.dgvHotel.AllowUserToDeleteRows = false;
            this.dgvHotel.AllowUserToResizeColumns = false;
            this.dgvHotel.AllowUserToResizeRows = false;
            this.dgvHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotel.Location = new System.Drawing.Point(12, 242);
            this.dgvHotel.MultiSelect = false;
            this.dgvHotel.Name = "dgvHotel";
            this.dgvHotel.ReadOnly = true;
            this.dgvHotel.RowHeadersWidth = 51;
            this.dgvHotel.RowTemplate.Height = 24;
            this.dgvHotel.Size = new System.Drawing.Size(1217, 317);
            this.dgvHotel.TabIndex = 31;
            this.dgvHotel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotel_CellContentDoubleClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(1058, 39);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(116, 16);
            this.lblBuscar.TabIndex = 86;
            this.lblBuscar.Text = "Buscar Proveedor";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.ItemHeight = 16;
            this.cmbProveedores.Location = new System.Drawing.Point(1053, 62);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(121, 24);
            this.cmbProveedores.TabIndex = 30;
            this.cmbProveedores.TextChanged += new System.EventHandler(this.cmbProveedores_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(1053, 101);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(121, 32);
            this.btnbuscar.TabIndex = 87;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // FrmIngresarEditarProveedorHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 650);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvHotel);
            this.Controls.Add(this.pnlHotel);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.lblNombreProveedor);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmIngresarEditarProveedorHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmIngresarEditarProveedor";
            this.Load += new System.EventHandler(this.FrmIngresarEditarProveedorHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCuadruple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTriple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdDoble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdSingle)).EndInit();
            this.pnlHotel.ResumeLayout(false);
            this.pnlHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidadHabitaciones;
        private System.Windows.Forms.NumericUpDown npdCantidadHabitaciones;
        private System.Windows.Forms.Label lblDoble;
        private System.Windows.Forms.Label lblTriple;
        private System.Windows.Forms.Label lblCuadruple;
        private System.Windows.Forms.NumericUpDown npdCuadruple;
        private System.Windows.Forms.NumericUpDown npdTriple;
        private System.Windows.Forms.NumericUpDown npdDoble;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblRegimen;
        private System.Windows.Forms.CheckBox chbDesayuno;
        private System.Windows.Forms.CheckBox chbMediaPension;
        private System.Windows.Forms.CheckBox chbPensionCompleta;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.NumericUpDown npdSingle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Panel pnlHotel;
        private System.Windows.Forms.DataGridView dgvHotel;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Button btnbuscar;
    }
}