using CapaServicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaVistas.Forms_Login
{
    public partial class frmRecuperarContraseña : Form
    {
        //private UsuarioService usuarioService;

        // Constructor que inicializa el formulario y la capa de servicios
        public frmRecuperarContraseña()
        {
            InitializeComponent();
            //usuarioService = new UsuarioService();
        }

        // Evento para el botón Cancelar que cierra el formulario actual y abre el formulario de login
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();
        }

        // Evento para el botón Cerrar que cierra el formulario actual y abre el formulario de login
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.ShowDialog();
        }

        // Evento de carga del formulario
        private void frmRecuperarContraseña_Load(object sender, EventArgs e)
        {
        }

        // Evento para el botón Aceptar que verifica si el usuario existe y muestra las preguntas de seguridad

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //string nombreUsuario = txtUsuario.Text;

            // Verifica si el usuario existe
            //if (usuarioService.VerificarUsuario(nombreUsuario) == 1)
            //{
            //    // Obtiene las preguntas de seguridad del usuario
            //    List<string> preguntas = usuarioService.ObtenerPreguntasUsuario(nombreUsuario);

            //    if (preguntas.Count > 0)
            //    {
            //        // Si el usuario tiene preguntas cargadas, se muestra el formulario de preguntas
            //        frmPreguntas frmPreguntas = new frmPreguntas();
            //        // Establece las preguntas en el formulario de preguntas
            //        frmPreguntas.SetPreguntas(preguntas);
            //        frmPreguntas.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        // Si el usuario no tiene preguntas cargadas, muestra un mensaje
            //        MessageBox.Show("El usuario no tiene preguntas cargadas.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("El usuario no existe en la base de datos.");
            //}
        }
    }
}
