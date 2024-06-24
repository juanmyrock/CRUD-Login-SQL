using System;
using System.Windows.Forms;
using CapaLogicaNegocio.Entidades;

namespace CapaVistas.Form_Menu
{
    public partial class frmEmpleados : Form
    {
        private cls_Empleados Logica;
        cls_Empleados empleado = new cls_Empleados();

        public frmEmpleados()
        {
            InitializeComponent();
            this.Logica = new cls_Empleados();
        }
        #region Método para validar todos los campos completos
        public bool ValidarCampos(out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrEmpty(Nombre))
            {
                mensaje = "El campo Nombre es obligatorio.";
                return false;
            }

            if (string.IsNullOrEmpty(Apellido))
            {
                mensaje = "El campo Apellido es obligatorio.";
                return false;
            }

            if (Id_Sexo <= 0)
            {
                mensaje = "Debe seleccionar un Sexo válido.";
                return false;
            }

            if (Id_Tipodni <= 0)
            {
                mensaje = "Debe seleccionar un Tipo de DNI válido.";
                return false;
            }

            if (Dni <= 0)
            {
                mensaje = "El campo DNI es obligatorio.";
                return false;
            }

            if (Fecha_Nac == default)
            {
                mensaje = "Debe seleccionar una Fecha de Nacimiento válida.";
                return false;
            }

            if (string.IsNullOrEmpty(Email))
            {
                mensaje = "El campo Email es obligatorio.";
                return false;
            }

            if (Id_Localidad <= 0)
            {
                mensaje = "Debe seleccionar una Localidad válida.";
                return false;
            }

            if (string.IsNullOrEmpty(Calle))
            {
                mensaje = "El campo Calle es obligatorio.";
                return false;
            }

            if (Numero_Calle <= 0)
            {
                mensaje = "El campo Número de Calle es obligatorio.";
                return false;
            }

            if (Id_Cargo <= 0)
            {
                mensaje = "Debe seleccionar un Cargo válido.";
                return false;
            }

            return true;
        }
        #endregion


        #region Tab Ver Empleados        
        private void TraerTodos(string datos = null)
        {
            dgvVerEmp.DataSource = null;
            dgvVerEmp.DataSource = empleado.VerEmpleados(datos);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            TraerTodos();
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
                TraerTodos();
            }
        }
        #endregion

        #region Tab Alta Empleados

        private void btnAgregar_Click(object sender, EventArgs e)
        {
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
                TraerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        #endregion




    }
}