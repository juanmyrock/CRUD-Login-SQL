using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaSistema;

namespace CapaVistas
{
    public partial class frmMenu : Form
    {
        cls_ProdLogica logica_prod = new cls_ProdLogica(); //Instancio objeto para clase Logica Login

        public frmMenu()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region MoverVentana  | Métodos para poder mover la ventana |
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void MoverForm() //Método para mover la ventana del formulario por la pantalla libremente
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelBarraClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnMinimize.Visible = false;
            btnMaximize.Visible = true;
            MoverForm();
        }
        #endregion

        #region Botones de la Barra
        private void btnCerrar_Click(object sender, EventArgs e) //para cerrar la aplicación
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void btnMinimize_Click(object sender, EventArgs e) //para minimizar a modo ventana
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimize.Visible = false;
            btnMaximize.Visible = true;
            picLogOut.Location = new Point(192, 640);
        }

        private void btnOcultar_Click(object sender, EventArgs e) //para ocultar/minimizar la aplicación
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e) //para maximizar la ventana a pantalla completa
        {
            this.WindowState = FormWindowState.Maximized;
            btnMinimize.Visible = true;
            btnMaximize.Visible = false;
            picLogOut.Location = new Point(192, 800);
        }
        #endregion

        public void AbrirForms(object formHijo) //método para abrir otros formularios dentro del panel contenedor principal
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0); //si hay algún panel abierto lo cierra
            }
            Form fh = formHijo as Form; //crea objeto como tipo form
            fh.TopLevel = false; //panel secundario no principal
            fh.Dock = DockStyle.Fill; //que se acople en el centro
            this.panelContenedor.Controls.Add(fh); //agrego el formulario hijo al panel
            this.panelContenedor.Tag = formHijo; //instancio el contenedor de datos
            fh.Show(); //muestro el formulario
        }
 

        #region Config Botones Menú
        private void btnSlide_Click(object sender, EventArgs e) //para minimizar el panel de menú y acomodar los íconos
        {
            if (panelMenu.Width == 240)
            {
                panelMenu.Width = 72;
                picProductos.Location = new Point(25, 301);
                picVentas.Location = new Point(25, 363);
                picClientes.Location = new Point(25, 425);
                picFacturas.Location = new Point(25, 486);
                picReportes.Location = new Point(25, 549);
                picLogOut.Size = new Size(40, 40);
                picLogOut.Location = new Point(14, 595);

            }
            else
            {
                panelMenu.Width = 240;
                picProductos.Location = new Point(25, 301);
                picVentas.Location = new Point(25, 363);
                picClientes.Location = new Point(25, 425);
                picFacturas.Location = new Point(25, 486);
                picReportes.Location = new Point(25, 549);
                picLogOut.Size = new Size(45, 45);
                picLogOut.Location = new Point(192, 640);
            }
        }

        private void picLogOut_Click(object sender, EventArgs e) //Botón de deslogueo
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                CapaVistas.frmLogin frm = new CapaVistas.frmLogin();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.Show();
                }
                
            }
        }
        #endregion
    }




}