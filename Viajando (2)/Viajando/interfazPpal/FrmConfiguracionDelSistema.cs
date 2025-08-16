using CapaNegocio;
using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmConfiguracionDelSistema : Form
    {
        private TabControl tabControl1;
        private TabPage Reserva;
        private TabPage tabPage2;
        private TextBox txtNumeroReserva;
        private Label label6;
        private DateTimePicker dtpFechaRegreso;
        private Label label5;
        private DateTimePicker dtpFechaSalida;
        private Label label3;
        private TextBox txtDestino;
        private Label label18;
        private Button btnBuscarDestino;
        private TextBox txtVendedor;
        private Label label4;
        private Button btnBuscarVendedor;
        private DataGridView dgvReservas;
        private TabPage tabPage1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private CheckBox ckbAdicionalCama;
        private NumericUpDown npdSingle;
        private NumericUpDown npdDoble;
        private NumericUpDown npdTriple;
        private Label label26;
        private Label label25;
        private Label lblDoble;
        private NumericUpDown npdCuadruple;
        private NumericUpDown npdAsientosSemiCama;
        private Label label23;
        private NumericUpDown npdAsientosCama;
        private NumericUpDown npdCamaMatrimonial;
        private Label label15;
        private NumericUpDown npdCamaSimple;
        private NumericUpDown npdCantHabitaciones;
        private Label label20;
        private Label label13;
        private Label lblSingle;
        private Label lblCamaIndividual;
        private Label label16;
        private TextBox txtAscenso;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox txtApellido;
        private Label label9;
        private TextBox txtNombre;
        private Label label10;
        private Label label14;
        private TextBox txtObservaciones;
        private Label label11;
        private TextBox txtNacionalidad;
        private ComboBox cmbTipoDoc;
        private TextBox txtNumDoc;
        private DateTimePicker FechaNacimiento;
        private Label label19;
        private TextBox txtTelefono;
        private Label label21;
        private Label label22;
        private Label label24;
        private TextBox txtEmail;
        private Label label27;
        private ComboBox cmbObraSocial;
        private Label lblSeguro;
        private CheckBox ckbTieneObraSocial;
        private CheckBox ckbCotizar;
        private Label label17;
        private TextBox txtSeña;
        private Button button1;
        private Button button2;
        private Button btnGuardar;
        private Button button3;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnEditar;
     /*   public FrmConfiguracionDelSistema()
        {
            InitializeComponent();
        }*/

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Backup (*.bak)|*.bak";
            saveFileDialog.Title = "Guardar Backup de la Base de Datos";
            saveFileDialog.FileName = "Backup.bak";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaDestino = saveFileDialog.FileName;

                try
                {
                    //backup.RealizarBackup(rutaDestino);

                    MessageBox.Show("Backup realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar el backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void lblCamaIndividual_Click(object sender, EventArgs e)
        {

        }

        private void npdCamaMatrimonial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void npdCamaSimple_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckbAdicionalCama_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSingle_Click(object sender, EventArgs e)
        {

        }

        private void npdSingle_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDoble_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txtAscenso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void npdCantMenores_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaRegreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reserva = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNumeroReserva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnBuscarDestino = new System.Windows.Forms.Button();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarVendedor = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbAdicionalCama = new System.Windows.Forms.CheckBox();
            this.npdSingle = new System.Windows.Forms.NumericUpDown();
            this.npdDoble = new System.Windows.Forms.NumericUpDown();
            this.npdTriple = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblDoble = new System.Windows.Forms.Label();
            this.npdCuadruple = new System.Windows.Forms.NumericUpDown();
            this.npdAsientosSemiCama = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.npdAsientosCama = new System.Windows.Forms.NumericUpDown();
            this.npdCamaMatrimonial = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.npdCamaSimple = new System.Windows.Forms.NumericUpDown();
            this.npdCantHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSingle = new System.Windows.Forms.Label();
            this.lblCamaIndividual = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAscenso = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.ckbTieneObraSocial = new System.Windows.Forms.CheckBox();
            this.ckbCotizar = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSeña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdDoble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTriple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCuadruple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosSemiCama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosCama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCamaMatrimonial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCamaSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Reserva);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 255);
            this.tabControl1.TabIndex = 252;
            // 
            // RESERVA
            // 
            this.tabControl1.Controls.Add(this.btnEliminar);
            this.tabControl1.Controls.Add(this.btnBuscar);
            this.tabControl1.Controls.Add(this.btnCancelar);
            this.Reserva.Controls.Add(this.btnEditar);
            this.Reserva.Controls.Add(this.numericUpDown1);
            this.Reserva.Controls.Add(this.label1);
            this.Reserva.Controls.Add(this.numericUpDown2);
            this.Reserva.Controls.Add(this.label2);
            this.Reserva.Controls.Add(this.txtVendedor);
            this.Reserva.Controls.Add(this.label4);
            this.Reserva.Controls.Add(this.btnBuscarVendedor);
            this.Reserva.Controls.Add(this.txtNumeroReserva);
            this.Reserva.Controls.Add(this.label6);
            this.Reserva.Controls.Add(this.dtpFechaRegreso);
            this.Reserva.Controls.Add(this.label5);
            this.Reserva.Controls.Add(this.dtpFechaSalida);
            this.Reserva.Controls.Add(this.label3);
            this.Reserva.Controls.Add(this.txtDestino);
            this.Reserva.Controls.Add(this.label18);
            this.Reserva.Controls.Add(this.btnBuscarDestino);
            this.Reserva.Location = new System.Drawing.Point(4, 22);
            this.Reserva.Name = "RESERVA";
            this.Reserva.Padding = new System.Windows.Forms.Padding(3);
            this.Reserva.Size = new System.Drawing.Size(855, 229);
            this.Reserva.TabIndex = 0;
            this.Reserva.Text = "RESERVA";
            this.Reserva.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.numericUpDown3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.ckbAdicionalCama);
            this.tabPage2.Controls.Add(this.npdSingle);
            this.tabPage2.Controls.Add(this.npdDoble);
            this.tabPage2.Controls.Add(this.npdTriple);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.lblDoble);
            this.tabPage2.Controls.Add(this.npdCuadruple);
            this.tabPage2.Controls.Add(this.npdAsientosSemiCama);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.npdAsientosCama);
            this.tabPage2.Controls.Add(this.npdCamaMatrimonial);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.npdCamaSimple);
            this.tabPage2.Controls.Add(this.npdCantHabitaciones);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.lblSingle);
            this.tabPage2.Controls.Add(this.lblCamaIndividual);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtAscenso);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(855, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SERVICIOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNumeroReserva
            // 
            this.txtNumeroReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroReserva.Location = new System.Drawing.Point(9, 27);
            this.txtNumeroReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroReserva.Name = "txtNumeroReserva";
            this.txtNumeroReserva.Size = new System.Drawing.Size(190, 22);
            this.txtNumeroReserva.TabIndex = 263;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 264;
            this.label6.Text = "Nro Reserva";
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegreso.Location = new System.Drawing.Point(412, 78);
            this.dtpFechaRegreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(175, 22);
            this.dtpFechaRegreso.TabIndex = 261;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 262;
            this.label5.Text = "Fecha Regreso";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Location = new System.Drawing.Point(412, 27);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(184, 22);
            this.dtpFechaSalida.TabIndex = 259;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 260;
            this.label3.Text = "Fecha Salida *";
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(9, 78);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(190, 22);
            this.txtDestino.TabIndex = 257;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 58);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 15);
            this.label18.TabIndex = 258;
            this.label18.Text = "Destino";
            // 
            // btnBuscarDestino
            // 
            this.btnBuscarDestino.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDestino.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDestino.Location = new System.Drawing.Point(108, 103);
            this.btnBuscarDestino.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarDestino.Name = "btnBuscarDestino";
            this.btnBuscarDestino.Size = new System.Drawing.Size(87, 29);
            this.btnBuscarDestino.TabIndex = 256;
            this.btnBuscarDestino.Text = "Buscar ";
            this.btnBuscarDestino.UseVisualStyleBackColor = false;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(667, 28);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(175, 22);
            this.txtVendedor.TabIndex = 267;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 266;
            this.label4.Text = "Vendedor";
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVendedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVendedor.Location = new System.Drawing.Point(756, 52);
            this.btnBuscarVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(87, 29);
            this.btnBuscarVendedor.TabIndex = 265;
            this.btnBuscarVendedor.Text = "Buscar ";
            this.btnBuscarVendedor.UseVisualStyleBackColor = false;
            // 
            // dgvReservas
            // 
            this.dgvReservas.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvReservas.Location = new System.Drawing.Point(9, 274);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(862, 91);
            this.dgvReservas.TabIndex = 253;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtSeña);
            this.tabPage1.Controls.Add(this.ckbCotizar);
            this.tabPage1.Controls.Add(this.cmbObraSocial);
            this.tabPage1.Controls.Add(this.lblSeguro);
            this.tabPage1.Controls.Add(this.ckbTieneObraSocial);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtNacionalidad);
            this.tabPage1.Controls.Add(this.cmbTipoDoc);
            this.tabPage1.Controls.Add(this.txtNumDoc);
            this.tabPage1.Controls.Add(this.FechaNacimiento);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtObservaciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(855, 229);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "PASAJEROS";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(261, 78);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 22);
            this.numericUpDown1.TabIndex = 272;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 273;
            this.label1.Text = "Menor 3 años";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(261, 25);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(72, 22);
            this.numericUpDown2.TabIndex = 270;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 271;
            this.label2.Text = "Cantidad Pax *";
            // 
            // ckbAdicionalCama
            // 
            this.ckbAdicionalCama.AutoSize = true;
            this.ckbAdicionalCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAdicionalCama.Location = new System.Drawing.Point(980, 82);
            this.ckbAdicionalCama.Margin = new System.Windows.Forms.Padding(4);
            this.ckbAdicionalCama.Name = "ckbAdicionalCama";
            this.ckbAdicionalCama.Size = new System.Drawing.Size(118, 20);
            this.ckbAdicionalCama.TabIndex = 258;
            this.ckbAdicionalCama.Text = "AdicionalCama";
            this.ckbAdicionalCama.UseVisualStyleBackColor = true;
            // 
            // npdSingle
            // 
            this.npdSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdSingle.Location = new System.Drawing.Point(226, 80);
            this.npdSingle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdSingle.Name = "npdSingle";
            this.npdSingle.Size = new System.Drawing.Size(72, 22);
            this.npdSingle.TabIndex = 242;
            // 
            // npdDoble
            // 
            this.npdDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdDoble.Location = new System.Drawing.Point(315, 80);
            this.npdDoble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdDoble.Name = "npdDoble";
            this.npdDoble.Size = new System.Drawing.Size(72, 22);
            this.npdDoble.TabIndex = 243;
            // 
            // npdTriple
            // 
            this.npdTriple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdTriple.Location = new System.Drawing.Point(227, 136);
            this.npdTriple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdTriple.Name = "npdTriple";
            this.npdTriple.Size = new System.Drawing.Size(72, 22);
            this.npdTriple.TabIndex = 244;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(317, 116);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(104, 16);
            this.label26.TabIndex = 257;
            this.label26.Text = "Hab. Cuadruple:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(229, 115);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 16);
            this.label25.TabIndex = 256;
            this.label25.Text = "Hab. Triple:";
            // 
            // lblDoble
            // 
            this.lblDoble.AutoSize = true;
            this.lblDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoble.Location = new System.Drawing.Point(316, 59);
            this.lblDoble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoble.Name = "lblDoble";
            this.lblDoble.Size = new System.Drawing.Size(50, 16);
            this.lblDoble.TabIndex = 255;
            this.lblDoble.Text = " Doble:";
            // 
            // npdCuadruple
            // 
            this.npdCuadruple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdCuadruple.Location = new System.Drawing.Point(315, 136);
            this.npdCuadruple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdCuadruple.Name = "npdCuadruple";
            this.npdCuadruple.Size = new System.Drawing.Size(72, 22);
            this.npdCuadruple.TabIndex = 245;
            // 
            // npdAsientosSemiCama
            // 
            this.npdAsientosSemiCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdAsientosSemiCama.Location = new System.Drawing.Point(4, 80);
            this.npdAsientosSemiCama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdAsientosSemiCama.Name = "npdAsientosSemiCama";
            this.npdAsientosSemiCama.Size = new System.Drawing.Size(74, 22);
            this.npdAsientosSemiCama.TabIndex = 240;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 60);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 16);
            this.label23.TabIndex = 254;
            this.label23.Text = " Semicama:";
            // 
            // npdAsientosCama
            // 
            this.npdAsientosCama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdAsientosCama.Location = new System.Drawing.Point(4, 28);
            this.npdAsientosCama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdAsientosCama.Name = "npdAsientosCama";
            this.npdAsientosCama.Size = new System.Drawing.Size(72, 22);
            this.npdAsientosCama.TabIndex = 239;
            // 
            // npdCamaMatrimonial
            // 
            this.npdCamaMatrimonial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdCamaMatrimonial.Location = new System.Drawing.Point(858, 80);
            this.npdCamaMatrimonial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdCamaMatrimonial.Name = "npdCamaMatrimonial";
            this.npdCamaMatrimonial.Size = new System.Drawing.Size(72, 22);
            this.npdCamaMatrimonial.TabIndex = 247;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(861, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 16);
            this.label15.TabIndex = 253;
            this.label15.Text = "Cama Matrimonial:";
            // 
            // npdCamaSimple
            // 
            this.npdCamaSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdCamaSimple.Location = new System.Drawing.Point(475, 28);
            this.npdCamaSimple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdCamaSimple.Name = "npdCamaSimple";
            this.npdCamaSimple.Size = new System.Drawing.Size(72, 22);
            this.npdCamaSimple.TabIndex = 246;
            // 
            // npdCantHabitaciones
            // 
            this.npdCantHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdCantHabitaciones.Location = new System.Drawing.Point(227, 28);
            this.npdCantHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.npdCantHabitaciones.Name = "npdCantHabitaciones";
            this.npdCantHabitaciones.Size = new System.Drawing.Size(72, 22);
            this.npdCantHabitaciones.TabIndex = 241;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(222, 8);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 16);
            this.label20.TabIndex = 250;
            this.label20.Text = " Habitaciones";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 248;
            this.label13.Text = "Asientos Cama:";
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingle.Location = new System.Drawing.Point(228, 60);
            this.lblSingle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(51, 16);
            this.lblSingle.TabIndex = 249;
            this.lblSingle.Text = " Single:";
            // 
            // lblCamaIndividual
            // 
            this.lblCamaIndividual.AutoSize = true;
            this.lblCamaIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamaIndividual.Location = new System.Drawing.Point(472, 8);
            this.lblCamaIndividual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCamaIndividual.Name = "lblCamaIndividual";
            this.lblCamaIndividual.Size = new System.Drawing.Size(106, 16);
            this.lblCamaIndividual.TabIndex = 251;
            this.lblCamaIndividual.Text = "Cama Individual:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(936, -17);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 252;
            this.label16.Text = "Ascenso Micro";
            // 
            // txtAscenso
            // 
            this.txtAscenso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAscenso.Location = new System.Drawing.Point(933, 3);
            this.txtAscenso.Margin = new System.Windows.Forms.Padding(4);
            this.txtAscenso.Name = "txtAscenso";
            this.txtAscenso.Size = new System.Drawing.Size(175, 22);
            this.txtAscenso.TabIndex = 238;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(478, 136);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 20);
            this.checkBox1.TabIndex = 263;
            this.checkBox1.Text = "AdicionalCama";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(475, 80);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(72, 22);
            this.numericUpDown3.TabIndex = 260;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 262;
            this.label7.Text = "Cama Matrimonial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 261;
            this.label8.Text = "Ascenso Micro";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 146);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 259;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(239, 28);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(193, 22);
            this.txtApellido.TabIndex = 269;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(237, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 270;
            this.label9.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(4, 27);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 22);
            this.txtNombre.TabIndex = 267;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 268;
            this.label10.Text = "Nombre titular";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(512, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 15);
            this.label14.TabIndex = 266;
            this.label14.Text = "Observación";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(515, 155);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(312, 22);
            this.txtObservaciones.TabIndex = 265;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 283;
            this.label11.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(5, 175);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(175, 20);
            this.txtNacionalidad.TabIndex = 276;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "Seleccione Tipo",
            "D.N.I",
            "Pasaporte",
            "Cuil",
            "Cuit",
            "Cedula Identidad"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(3, 76);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(158, 21);
            this.cmbTipoDoc.TabIndex = 272;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(3, 123);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(175, 20);
            this.txtNumDoc.TabIndex = 273;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Location = new System.Drawing.Point(239, 76);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(175, 20);
            this.FechaNacimiento.TabIndex = 274;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 15);
            this.label19.TabIndex = 280;
            this.label19.Text = "Número Documento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(239, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 20);
            this.txtTelefono.TabIndex = 275;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(236, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 15);
            this.label21.TabIndex = 282;
            this.label21.Text = "Télefono";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(236, 155);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 15);
            this.label22.TabIndex = 278;
            this.label22.Text = "email";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(5, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 15);
            this.label24.TabIndex = 279;
            this.label24.Text = "Tipo documento";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(239, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 20);
            this.txtEmail.TabIndex = 277;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(236, 57);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(107, 15);
            this.label27.TabIndex = 281;
            this.label27.Text = "Fecha Nacimiento";
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Items.AddRange(new object[] {
            "Seleccione Tipo",
            "D.N.I",
            "Pasaporte",
            "Cuil",
            "Cuit",
            "Cedula Identidad"});
            this.cmbObraSocial.Location = new System.Drawing.Point(623, 30);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(200, 21);
            this.cmbObraSocial.TabIndex = 285;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(626, 11);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(119, 15);
            this.lblSeguro.TabIndex = 286;
            this.lblSeguro.Text = "Nombre Obra Social";
            // 
            // ckbTieneObraSocial
            // 
            this.ckbTieneObraSocial.AutoSize = true;
            this.ckbTieneObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTieneObraSocial.Location = new System.Drawing.Point(515, 32);
            this.ckbTieneObraSocial.Name = "ckbTieneObraSocial";
            this.ckbTieneObraSocial.Size = new System.Drawing.Size(90, 19);
            this.ckbTieneObraSocial.TabIndex = 284;
            this.ckbTieneObraSocial.Text = "Obra Social";
            this.ckbTieneObraSocial.UseVisualStyleBackColor = true;
            // 
            // ckbCotizar
            // 
            this.ckbCotizar.AutoSize = true;
            this.ckbCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCotizar.Location = new System.Drawing.Point(756, 90);
            this.ckbCotizar.Margin = new System.Windows.Forms.Padding(4);
            this.ckbCotizar.Name = "ckbCotizar";
            this.ckbCotizar.Size = new System.Drawing.Size(67, 20);
            this.ckbCotizar.TabIndex = 288;
            this.ckbCotizar.Text = "Cotizar";
            this.ckbCotizar.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(512, 74);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 15);
            this.label17.TabIndex = 290;
            this.label17.Text = "Seña";
            // 
            // txtSeña
            // 
            this.txtSeña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeña.Location = new System.Drawing.Point(515, 91);
            this.txtSeña.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeña.Name = "txtSeña";
            this.txtSeña.Size = new System.Drawing.Size(177, 22);
            this.txtSeña.TabIndex = 289;
            this.txtSeña.Text = "          ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(660, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 293;
            this.button1.Text = "Pasajeros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(571, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 292;
            this.button2.Text = "Pagar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(482, 191);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 32);
            this.btnGuardar.TabIndex = 291;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(748, 191);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 294;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(303, 187);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 35);
            this.btnEliminar.TabIndex = 277;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(9, 188);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 35);
            this.btnBuscar.TabIndex = 274;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(197, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 276;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(103, 187);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 35);
            this.btnEditar.TabIndex = 275;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // FrmConfiguracionDelSistema
            // 
            this.ClientSize = new System.Drawing.Size(883, 369);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmConfiguracionDelSistema";
            this.Load += new System.EventHandler(this.FrmConfiguracionDelSistema_Load);
            this.tabControl1.ResumeLayout(false);
            this.Reserva.ResumeLayout(false);
            this.Reserva.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdDoble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdTriple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCuadruple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosSemiCama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosCama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCamaMatrimonial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCamaSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnBuscarDestino_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfiguracionDelSistema_Load(object sender, EventArgs e)
        {

        }
    }
}
