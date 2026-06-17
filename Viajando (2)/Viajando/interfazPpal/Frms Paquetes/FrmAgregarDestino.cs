using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmAgregarDestino : Form
    {


        FrmIngresarEditarPaquetes nuevoDestino;
        CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
        CS_ValidarFormulario Validar = new CS_ValidarFormulario();
        
        int Id_Destino;
        string Nombre;
        bool editar = false;
        
        public FrmAgregarDestino(FrmIngresarEditarPaquetes nuevoDestino)
        {
            InitializeComponent();
            this.nuevoDestino = nuevoDestino;
            
        }
        private void FrmAgregarDestino_Load(object sender, EventArgs e)
        {
            CargarDgvDestinos();
            dgvDestinos.RowHeadersVisible = false;
            dgvDestinos.Columns[0].Visible = false;
            dgvDestinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void CargarDgvDestinos()
        {
            List<Destino> Destinos = new CN_Destino().MostrarD();
            dgvDestinos.DataSource = Destinos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {    
            try
            {
                if (editar == false)
                {
                    if (!Validar.Validar(this))
                    {
                        MessageBox.Show("Debe completar todos los campos.");
                    }
                    else
                    {
                        Destino NuevoDestino = new Destino
                        {
                            Nombre = txtDestino.Text,
                            Localidad = txtLocalidad.Text,
                            Partido = txtPartido.Text,
                            Provincia = txtProvincia.Text,
                        };
                        int IdNuevoDestino = new CN_Destino().AgregarDestinoL(NuevoDestino, out mensaje);
                        if (IdNuevoDestino != 0)
                        {
                            MessageBox.Show(mensaje);
                            //bitacora.GuardarBitacora(CS_Usuario.Id_Usuario, "Creacion de paquete", "Se ha creado un paquete nuevo.");
                            CargarDgvDestinos();
                        }
                        else
                        {
                            MessageBox.Show(mensaje);
                        }
                    }         
                }
                else
                {         
                    if (editar == true)
                    {
                        Id_Destino = Convert.ToInt32(dgvDestinos.CurrentRow.Cells["Id_Destino"].Value);
                        destino.EditarDestinoL(NuevoDestino);
                        editar = false;
                        CargarDgvDestinos();
                        limpiar.Limpiar(this);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);


            finally
            {
                limpiar.Limpiar(this);

            }
             
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDestinos.SelectedRows.Count > 0)
                {
                    editar = true;
                    txtDestino.Text = dgvDestinos.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtLocalidad.Text = dgvDestinos.CurrentRow.Cells["Localidad"].Value.ToString();
                    txtPartido.Text = dgvDestinos.CurrentRow.Cells["Partido"].Value.ToString();
                    txtProvincia.Text = dgvDestinos.CurrentRow.Cells["Provincia"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("seleccione una fila por favor");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar.Limpiar(this);
        }

        private void dgvDestinos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Destino= Convert.ToInt32(dgvDestinos.CurrentRow.Cells["Id_Destino"].Value.ToString());
            Nombre = dgvDestinos.CurrentRow.Cells["Nombre"].Value.ToString();
            nuevoDestino.AgregarDestinoAlTextBox(Id_Destino, Nombre);
            this.Close();   
        }
    }
}
