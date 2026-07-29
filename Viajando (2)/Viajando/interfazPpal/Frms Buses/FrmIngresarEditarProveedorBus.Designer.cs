namespace interfazPpal
{
    partial class FrmIngresarEditarProveedorBus
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
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pnlBus = new System.Windows.Forms.Panel();
            this.txtCantidadAsientosSemicama = new System.Windows.Forms.TextBox();
            this.txtCantidadAsientosCama = new System.Windows.Forms.TextBox();
            this.npdCantidadAsientos = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadAsientos = new System.Windows.Forms.Label();
            this.lbbAsientosSemicama = new System.Windows.Forms.Label();
            this.lblAsientosCama = new System.Windows.Forms.Label();
            this.lblSuite = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
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
            this.lblProvincia = new System.Windows.Forms.Label();
            this.chbSuite = new System.Windows.Forms.CheckBox();
            this.lblCama = new System.Windows.Forms.Label();
            this.lblSemicama = new System.Windows.Forms.Label();
            this.chbCama = new System.Windows.Forms.CheckBox();
            this.chbSemicama = new System.Windows.Forms.CheckBox();
            this.IdBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDeAsientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsientosCama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsientosSemincama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDelTitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoDelTitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semicama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.ItemHeight = 13;
            this.cmbProveedores.Location = new System.Drawing.Point(747, 102);
            this.cmbProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(92, 21);
            this.cmbProveedores.TabIndex = 104;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(747, 81);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(92, 13);
            this.lblBuscar.TabIndex = 121;
            this.lblBuscar.Text = "Buscar Proveedor";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBus,
            this.Nombre,
            this.Destino,
            this.Celular,
            this.Telefono,
            this.CorreoElectronico,
            this.TotalDeAsientos,
            this.AsientosCama,
            this.AsientosSemincama,
            this.NombreDelTitular,
            this.ApellidoDelTitular,
            this.Calle,
            this.Numero,
            this.Localidad,
            this.Provincia,
            this.Partido,
            this.Suite,
            this.Cama,
            this.Semicama});
            this.dgvDatos.Location = new System.Drawing.Point(11, 336);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(918, 285);
            this.dgvDatos.TabIndex = 105;
            // 
            // pnlBus
            // 
            this.pnlBus.Controls.Add(this.chbSemicama);
            this.pnlBus.Controls.Add(this.chbCama);
            this.pnlBus.Controls.Add(this.lblSemicama);
            this.pnlBus.Controls.Add(this.lblCama);
            this.pnlBus.Controls.Add(this.chbSuite);
            this.pnlBus.Controls.Add(this.txtCantidadAsientosSemicama);
            this.pnlBus.Controls.Add(this.txtCantidadAsientosCama);
            this.pnlBus.Controls.Add(this.npdCantidadAsientos);
            this.pnlBus.Controls.Add(this.lblCantidadAsientos);
            this.pnlBus.Controls.Add(this.lbbAsientosSemicama);
            this.pnlBus.Controls.Add(this.lblAsientosCama);
            this.pnlBus.Controls.Add(this.lblSuite);
            this.pnlBus.Location = new System.Drawing.Point(219, 190);
            this.pnlBus.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBus.Name = "pnlBus";
            this.pnlBus.Size = new System.Drawing.Size(456, 72);
            this.pnlBus.TabIndex = 120;
            // 
            // txtCantidadAsientosSemicama
            // 
            this.txtCantidadAsientosSemicama.Location = new System.Drawing.Point(383, 15);
            this.txtCantidadAsientosSemicama.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadAsientosSemicama.Name = "txtCantidadAsientosSemicama";
            this.txtCantidadAsientosSemicama.Size = new System.Drawing.Size(34, 20);
            this.txtCantidadAsientosSemicama.TabIndex = 140;
            // 
            // txtCantidadAsientosCama
            // 
            this.txtCantidadAsientosCama.Location = new System.Drawing.Point(236, 15);
            this.txtCantidadAsientosCama.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadAsientosCama.Name = "txtCantidadAsientosCama";
            this.txtCantidadAsientosCama.Size = new System.Drawing.Size(34, 20);
            this.txtCantidadAsientosCama.TabIndex = 139;
            // 
            // npdCantidadAsientos
            // 
            this.npdCantidadAsientos.Location = new System.Drawing.Point(110, 16);
            this.npdCantidadAsientos.Margin = new System.Windows.Forms.Padding(2);
            this.npdCantidadAsientos.Name = "npdCantidadAsientos";
            this.npdCantidadAsientos.Size = new System.Drawing.Size(33, 20);
            this.npdCantidadAsientos.TabIndex = 23;
            // 
            // lblCantidadAsientos
            // 
            this.lblCantidadAsientos.AutoSize = true;
            this.lblCantidadAsientos.Location = new System.Drawing.Point(20, 18);
            this.lblCantidadAsientos.Name = "lblCantidadAsientos";
            this.lblCantidadAsientos.Size = new System.Drawing.Size(80, 13);
            this.lblCantidadAsientos.TabIndex = 138;
            this.lblCantidadAsientos.Text = "Asientos Total :";
            // 
            // lbbAsientosSemicama
            // 
            this.lbbAsientosSemicama.AutoSize = true;
            this.lbbAsientosSemicama.Location = new System.Drawing.Point(275, 18);
            this.lbbAsientosSemicama.Name = "lbbAsientosSemicama";
            this.lbbAsientosSemicama.Size = new System.Drawing.Size(103, 13);
            this.lbbAsientosSemicama.TabIndex = 137;
            this.lbbAsientosSemicama.Text = "Asientos SemiCama:";
            // 
            // lblAsientosCama
            // 
            this.lblAsientosCama.AutoSize = true;
            this.lblAsientosCama.Location = new System.Drawing.Point(148, 18);
            this.lblAsientosCama.Name = "lblAsientosCama";
            this.lblAsientosCama.Size = new System.Drawing.Size(83, 13);
            this.lblAsientosCama.TabIndex = 135;
            this.lblAsientosCama.Text = "Asientos Cama :";
            // 
            // lblSuite
            // 
            this.lblSuite.AutoSize = true;
            this.lblSuite.Location = new System.Drawing.Point(60, 52);
            this.lblSuite.Name = "lblSuite";
            this.lblSuite.Size = new System.Drawing.Size(40, 13);
            this.lblSuite.TabIndex = 133;
            this.lblSuite.Text = "Suite : ";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(140, 11);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(205, 20);
            this.txtNombreProveedor.TabIndex = 87;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(48, 14);
            this.lblNombreProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(87, 13);
            this.lblNombreProveedor.TabIndex = 118;
            this.lblNombreProveedor.Text = "Nombre Del Bus:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(448, 155);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(205, 20);
            this.txtCelular.TabIndex = 99;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(405, 160);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 117;
            this.lblCelular.Text = "Celular:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(448, 83);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(205, 20);
            this.txtProvincia.TabIndex = 96;
            // 
            // txtPartido
            // 
            this.txtPartido.Location = new System.Drawing.Point(448, 59);
            this.txtPartido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(205, 20);
            this.txtPartido.TabIndex = 95;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(397, 62);
            this.lblPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(46, 13);
            this.lblPartido.TabIndex = 115;
            this.lblPartido.Text = "Partido :\r\n";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(448, 35);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(205, 20);
            this.txtLocalidad.TabIndex = 94;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(392, 40);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 114;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(612, 11);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(42, 20);
            this.txtNumero.TabIndex = 93;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(587, 11);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(25, 13);
            this.lblNumero.TabIndex = 113;
            this.lblNumero.Text = "N° :";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(140, 35);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(205, 20);
            this.txtDestino.TabIndex = 88;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(92, 38);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(49, 13);
            this.lblDestino.TabIndex = 112;
            this.lblDestino.Text = "Destino :";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(343, 284);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 34);
            this.btnEditar.TabIndex = 101;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(475, 284);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 34);
            this.btnEliminar.TabIndex = 102;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(609, 284);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(94, 34);
            this.BtnCancelar.TabIndex = 103;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(200, 284);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 34);
            this.btnGuardar.TabIndex = 100;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(140, 83);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(205, 20);
            this.txtApellido.TabIndex = 90;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(140, 107);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(205, 20);
            this.txtCuit.TabIndex = 91;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(448, 11);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(138, 20);
            this.txtCalle.TabIndex = 92;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(448, 131);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(205, 20);
            this.txtTelefono.TabIndex = 98;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(448, 107);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 20);
            this.txtEmail.TabIndex = 97;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 59);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 20);
            this.txtNombre.TabIndex = 89;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(404, 110);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 13);
            this.lblEmail.TabIndex = 111;
            this.lblEmail.Text = "E-mail : ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(396, 135);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 110;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(413, 14);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 109;
            this.lblCalle.Text = "Calle:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(110, 112);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(31, 13);
            this.lblCuit.TabIndex = 108;
            this.lblCuit.Text = "Cuit :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(38, 85);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(104, 13);
            this.lblApellido.TabIndex = 107;
            this.lblApellido.Text = "Apellido Del Titular : ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 61);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 106;
            this.lblNombre.Text = "Nombre Del Titular:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(394, 88);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 116;
            this.lblProvincia.Text = "Provincia:";
            // 
            // chbSuite
            // 
            this.chbSuite.AutoSize = true;
            this.chbSuite.Location = new System.Drawing.Point(110, 51);
            this.chbSuite.Name = "chbSuite";
            this.chbSuite.Size = new System.Drawing.Size(15, 14);
            this.chbSuite.TabIndex = 141;
            this.chbSuite.UseVisualStyleBackColor = true;
            // 
            // lblCama
            // 
            this.lblCama.AutoSize = true;
            this.lblCama.Location = new System.Drawing.Point(187, 50);
            this.lblCama.Name = "lblCama";
            this.lblCama.Size = new System.Drawing.Size(43, 13);
            this.lblCama.TabIndex = 142;
            this.lblCama.Text = "Cama : ";
            // 
            // lblSemicama
            // 
            this.lblSemicama.AutoSize = true;
            this.lblSemicama.Location = new System.Drawing.Point(313, 50);
            this.lblSemicama.Name = "lblSemicama";
            this.lblSemicama.Size = new System.Drawing.Size(65, 13);
            this.lblSemicama.TabIndex = 143;
            this.lblSemicama.Text = "Semicama : ";
            // 
            // chbCama
            // 
            this.chbCama.AutoSize = true;
            this.chbCama.Location = new System.Drawing.Point(236, 51);
            this.chbCama.Name = "chbCama";
            this.chbCama.Size = new System.Drawing.Size(15, 14);
            this.chbCama.TabIndex = 144;
            this.chbCama.UseVisualStyleBackColor = true;
            // 
            // chbSemicama
            // 
            this.chbSemicama.AutoSize = true;
            this.chbSemicama.Location = new System.Drawing.Point(383, 50);
            this.chbSemicama.Name = "chbSemicama";
            this.chbSemicama.Size = new System.Drawing.Size(15, 14);
            this.chbSemicama.TabIndex = 145;
            this.chbSemicama.UseVisualStyleBackColor = true;
            // 
            // IdBus
            // 
            this.IdBus.HeaderText = "Id Bus";
            this.IdBus.Name = "IdBus";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.HeaderText = "Correo Electronico";
            this.CorreoElectronico.Name = "CorreoElectronico";
            // 
            // TotalDeAsientos
            // 
            this.TotalDeAsientos.HeaderText = "Total de Asientos";
            this.TotalDeAsientos.Name = "TotalDeAsientos";
            // 
            // AsientosCama
            // 
            this.AsientosCama.HeaderText = "Asientos Cama";
            this.AsientosCama.Name = "AsientosCama";
            // 
            // AsientosSemincama
            // 
            this.AsientosSemincama.HeaderText = "Asientos Semicama";
            this.AsientosSemincama.Name = "AsientosSemincama";
            // 
            // NombreDelTitular
            // 
            this.NombreDelTitular.HeaderText = "Nombre del Titular";
            this.NombreDelTitular.Name = "NombreDelTitular";
            this.NombreDelTitular.Visible = false;
            // 
            // ApellidoDelTitular
            // 
            this.ApellidoDelTitular.HeaderText = "Apellido del Titular";
            this.ApellidoDelTitular.Name = "ApellidoDelTitular";
            this.ApellidoDelTitular.Visible = false;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.Visible = false;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.Visible = false;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.Visible = false;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.Visible = false;
            // 
            // Partido
            // 
            this.Partido.HeaderText = "Partido";
            this.Partido.Name = "Partido";
            this.Partido.Visible = false;
            // 
            // Suite
            // 
            this.Suite.HeaderText = "Suite";
            this.Suite.Name = "Suite";
            this.Suite.Visible = false;
            // 
            // Cama
            // 
            this.Cama.HeaderText = "Cama";
            this.Cama.Name = "Cama";
            this.Cama.Visible = false;
            // 
            // Semicama
            // 
            this.Semicama.HeaderText = "Semicama";
            this.Semicama.Name = "Semicama";
            this.Semicama.Visible = false;
            // 
            // FrmIngresarEditarProveedorBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 632);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.pnlBus);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmIngresarEditarProveedorBus";
            this.Text = "FrmIngresarEditarProveedorBus";
            this.Load += new System.EventHandler(this.FrmIngresarEditarProveedorBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlBus.ResumeLayout(false);
            this.pnlBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel pnlBus;
        private System.Windows.Forms.NumericUpDown npdCantidadAsientos;
        private System.Windows.Forms.Label lblCantidadAsientos;
        private System.Windows.Forms.Label lbbAsientosSemicama;
        private System.Windows.Forms.Label lblAsientosCama;
        private System.Windows.Forms.Label lblSuite;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
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
        private System.Windows.Forms.TextBox txtCantidadAsientosSemicama;
        private System.Windows.Forms.TextBox txtCantidadAsientosCama;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.CheckBox chbSuite;
        private System.Windows.Forms.Label lblSemicama;
        private System.Windows.Forms.Label lblCama;
        private System.Windows.Forms.CheckBox chbSemicama;
        private System.Windows.Forms.CheckBox chbCama;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDeAsientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsientosCama;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsientosSemincama;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDelTitular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoDelTitular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semicama;
    }
}