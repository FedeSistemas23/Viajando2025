using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarProveedorBus : Form
    {
        CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
        CS_ValidarFormulario Validar = new CS_ValidarFormulario();
        CN_Buses obj;

        bool editar = false;
        public FrmIngresarEditarProveedorBus()
        {
            InitializeComponent();
            obj = new CN_Buses();
        }

        private void FrmIngresarEditarProveedorBus_Load(object sender, EventArgs e)
        {
            MostrarBuses();
        }

        public void MostrarBuses()
        {
            List<Bus> lista= obj.MostrarBusesL();

            foreach (Bus item in lista)
            {
                dgvDatos.Rows.Add(new object[] { item.Id_ProvedorBus, item.NombreBus,item.Destino,
                item.Celular,item.Telefono, item.Email, item.CantidadDeAsientos, item.Cama,item.Semicama });
            }
            dgvDatos.DataSource = lista;
        }

        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                editar = true;
                int Id_Provedor = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdBus"].Value);
                txtNombreProveedor.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDestino.Text = dgvDatos.CurrentRow.Cells["Destino"].Value.ToString();
                txtNombre.Text = dgvDatos.CurrentRow.Cells["NombreDelTitular"].Value.ToString();
                txtApellido.Text = dgvDatos.CurrentRow.Cells["ApellidoDelTitular"].Value.ToString();
                txtCuit.Text = dgvDatos.CurrentRow.Cells["Cuit"].Value.ToString();
                txtCalle.Text = dgvDatos.CurrentRow.Cells["Calle"].Value.ToString();
                txtNumero.Text = dgvDatos.CurrentRow.Cells["Numero"].Value.ToString();
                txtLocalidad.Text = dgvDatos.CurrentRow.Cells["Localidad"].Value.ToString();
                txtPartido.Text = dgvDatos.CurrentRow.Cells["Partido"].Value.ToString();
                txtProvincia.Text = dgvDatos.CurrentRow.Cells["Provincia"].Value.ToString();
                txtEmail.Text = dgvDatos.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                txtTelefono.Text = dgvDatos.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCelular.Text = dgvDatos.CurrentRow.Cells["Celular"].Value.ToString();
                txtTipoBus.Text = dgvDatos.CurrentRow.Cells["TipoDeBus"].Value.ToString();
                npdCantidadAsientos.Value = Convert.ToInt32(dgvDatos.CurrentRow.Cells["TotalDeAsientos"].Value);
                txtCantidadAsientosCama.Text = dgvDatos.CurrentRow.Cells["AsientosCama"].Value.ToString();
                txtCantidadAsientosSemicama.Text = dgvDatos.CurrentRow.Cells["AsientosSemincama"].Value.ToString();    
            }
        }

        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Bus nuevoBus;

            if (editar == false)
            {
                nuevoBus = new Bus()
                {
                    NombreBus = txtNombreProveedor.Text,
                    Destino = txtDestino.Text,
                    NombreTitularBus = txtNombre.Text,
                    ApellidoTitularBus = txtApellido.Text,
                    Cuit = Convert.ToString(txtCuit.Text),
                    Calle = txtCalle.Text,
                    Numero = Convert.ToInt32(txtNumero.Text),
                    Localidad = txtLocalidad.Text,
                    Provincia = txtProvincia.Text,
                    Email = txtEmail.Text,
                    Telefono = Convert.ToString(txtTelefono.Text),
                    Celular = Convert.ToString(txtCelular.Text),
                    TipoBus = txtTipoBus.Text,
                    CantidadDeAsientos = Convert.ToInt32(npdCantidadAsientos.Value),
                    Cama = txtCantidadAsientosCama.ToString(),
                    Semicama = txtCantidadAsientosSemicama.ToString(),
                };

                int IdBus = obj.Guardar(nuevoBus, out mensaje);

                if (IdBus != 0)
                {
                    dgvDatos.Rows.Add(new object[] { IdBus, txtNombreProveedor.Text, txtDestino.Text,
                        txtCantidadAsientosCama.Text, txtCantidadAsientosSemicama.Text, txtTelefono.Text,
                        txtDestino.Text,txtCelular.Text});
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + mensaje);
                }
            }
            limpiar.Limpiar(this);


            if (editar == true)
            {

                nuevoBus = new Bus()
                {
                    Id_ProvedorBus = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdBus"].Value),
                    NombreBus = txtNombreProveedor.Text,
                    Destino = txtDestino.Text,
                    NombreTitularBus = txtNombre.Text,
                    ApellidoTitularBus = txtApellido.Text,
                    Cuit = Convert.ToString(txtCuit.Text),
                    Calle = txtCalle.Text,
                    Numero = Convert.ToInt32(txtNumero.Text),
                    Localidad = txtLocalidad.Text,
                    Provincia = txtProvincia.Text,
                    Email = txtEmail.Text,
                    Telefono = Convert.ToString(txtTelefono.Text),
                    Celular = Convert.ToString(txtCelular.Text),
                    TipoBus = txtTipoBus.Text,
                    CantidadDeAsientos = Convert.ToInt32(npdCantidadAsientos.Value),
                    Cama = txtCantidadAsientosCama.ToString(),
                    Semicama = txtCantidadAsientosSemicama.ToString(),

                };

                bool resultado = obj.Editar(nuevoBus, out mensaje);

                if (!resultado)
                {
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Los datos se han modificado con exito");
                    dgvDatos.Rows.Add(new object[] { txtNombreProveedor.Text, txtDestino.Text,
                    txtCantidadAsientosCama.Text, txtCantidadAsientosSemicama.Text, txtTelefono.Text,
                    txtDestino.Text,txtCelular.Text});
                }

                limpiar.Limpiar(this);
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count > 0)
            {
                int Id_ProvedorBus = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id Bus"].Value.ToString());
                bool resultado = obj.Eliminar(Id_ProvedorBus, out string mensaje);
                if (resultado)
                {
                    MessageBox.Show("Eliminado correctamente");
                    MostrarBuses();
                }
                else
                {
                    MessageBox.Show("Error al eliminar: " + mensaje);
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }
    }

    /*private void BtnCancelar_Click_1(object sender, EventArgs e)
    {
        limpiar.Limpiar(this);
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {
        string filtro = txtBuscar.Text.ToLower();

        // Filtra la lista de objetos
        var listaFiltrada = listaBuses
            .Where(bus =>
                          bus.Destino.ToLower().Contains(filtro)
                         )
            .ToList();
        if (listaFiltrada.Count > 0)
        {
            // Actualiza el DataGridView con los resultados filtrados
            dgvBus =null;
            dgvBus.DataSource = new BindingList<CS_AtributosBus>(listaFiltrada);
        }
        else
        {
            MessageBox.Show("No hay provedores ingresesado. Debe ingresar provedores");
        }
    }*/

}

    

