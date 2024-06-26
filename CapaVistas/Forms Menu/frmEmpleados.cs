using System;
using System.Data;
using System.Windows.Forms;
using CapaLogicaNegocio.Entidades;
using CapaLogicaNegocio.Llenar_Combos;

namespace CapaVistas.Form_Menu
{
    public partial class frmEmpleados : Form
    {

        private cls_Empleados empleado = new cls_Empleados();

        public frmEmpleados()
        {
            InitializeComponent();
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            // Llenar ComboBox de Sexos
            cls_LlenarCombos CMBSexo = new cls_LlenarCombos(cmbSexo, "Sexos", "id_sexos", "sexo");

            // Llenar ComboBox de Tipos de DNI
            cls_LlenarCombos CMBTipoDNI = new cls_LlenarCombos(cmbTipoDNI, "TiposDocumentos", "id_tipodni", "tipodni");

            // Llenar ComboBox de Localidades
            cls_LlenarCombos CMBLocalidad = new cls_LlenarCombos(cmbLocalidad, "Localidades", "id_localidad", "localidad");

            // Llenar ComboBox de Cargos
            cls_LlenarCombos CMBCargo = new cls_LlenarCombos(cmbCargo, "Cargos", "id_cargos", "cargos");
        }


        #region Método para validar todos los campos completos
        public bool ValidarCampos(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                mensaje = "El campo Nombre es obligatorio.";
                return false;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                mensaje = "El campo Apellido es obligatorio.";
                return false;
            }

            if (cmbSexo.SelectedIndex == -1 )
            {
                mensaje = "Debe seleccionar un Sexo válido.";
                return false;
            }

            if (cmbTipoDNI.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar un Tipo de DNI válido.";
                return false;
            }

            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                mensaje = "El campo DNI es obligatorio.";
                return false;
            }

            if (dateNacimiento.Value == default)
            {
                mensaje = "Debe seleccionar una Fecha de Nacimiento válida.";
                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                mensaje = "El campo Email es obligatorio.";
                return false;
            }

            if (cmbLocalidad.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar una Localidad válida.";
                return false;
            }

            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                mensaje = "El campo Calle es obligatorio.";
                return false;
            }

            if (string.IsNullOrEmpty(txtNumCalle.Text))
            {
                mensaje = "El campo Número de Calle es obligatorio.";
                return false;
            }

            if (cmbCargo.SelectedIndex == -1)
            {
                mensaje = "Debe seleccionar un Cargo válido.";
                return false;
            }

            return true;
        }
        #endregion


        #region Tab Ver Empleados        
        private void TraerTodos(DataGridView dgv, string datos = null)
        {
            dgv.DataSource = null;
            dgv.DataSource = empleado.VerEmpleados(datos);
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            TraerTodos(dgvVerEmp);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvVerEmp.DataSource = null;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            if (dgvVerEmp.DataSource != null)
            {
                dgvVerEmp.DataSource = null;
                TraerTodos(dgvVerEmp);
            }
        }
        #endregion

        #region Tab Alta Empleados
        private void btnVerAlta_Click(object sender, EventArgs e)
        {
            TraerTodos(dgvVerEmpAlta);
        }
        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            string mensaje;

            // Llamar a ValidarCampos y verificar si la validación es exitosa
            if (!ValidarCampos(out mensaje))
            {
                // Si la validación falla, mostrar el mensaje de error y salir del método
                MessageBox.Show(mensaje);
                return;
            }

            try
            {
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Id_Sexo = Convert.ToInt32(cmbSexo.SelectedValue);
                empleado.Id_Tipodni = Convert.ToInt32(cmbTipoDNI.SelectedValue);
                empleado.Dni = Convert.ToInt32(txtDNI.Text);
                empleado.Fecha_Nac = dateNacimiento.Value;
                empleado.Email = txtEmail.Text;
                empleado.Id_Localidad = Convert.ToInt32(cmbLocalidad.SelectedValue);
                empleado.Calle = txtCalle.Text;
                empleado.Numero_Calle = Convert.ToInt32(txtNumCalle.Text);
                empleado.Id_Cargo = Convert.ToInt32(cmbCargo.SelectedValue);
                empleado.AgregarEmpleado();
                MessageBox.Show("Empleado agregado correctamente");
                TraerTodos(dgvVerEmpAlta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }



        #endregion
    }
}