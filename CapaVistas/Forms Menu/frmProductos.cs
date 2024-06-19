using System;
using System.Windows.Forms;
using CapaSistema;

namespace CapaVistas
{
    public partial class frmProductos : Form
    {
        private cls_ProdLogica prodLog;
        cls_ProdLogica logica_prod = new cls_ProdLogica();

        public frmProductos()
        {
            InitializeComponent();
            this.prodLog = new cls_ProdLogica();
        }


        private void FormProductos_Load(object sender, EventArgs e)
        {
            traerTodos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardarProd_Click(object sender, EventArgs e)
        {
            try
            {
                guardarProducto();
                //Limpiar.LimpiarControles(this);
                traerTodos();
                this.Refresh();

                textBoxNombreProd.Select();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message,
                                    "ERROR",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

            }
        }

        private void btnEditarProd_Click(object sender, EventArgs e)
        {
            try
            {
                int idProductoAEditar = ObtenerValoresProductoFila();

                // Obtén los nuevos valores desde los TextBox
                string nuevoNombre = textBoxNombreProd.Text;
                string nuevaDescripcion = textBoxDescProd.Text;
                string nuevaMarca = textBoxMarca.Text;
                double nuevoPrecio = Convert.ToDouble(textBoxPrecio.Text);
                int nuevoStock = Convert.ToInt32(textBoxStock.Text);

                // Llamada al método de la capa de lógica para editar el producto
                //prodLog.ActualizarProductoEnLogica(idProductoAEditar, nuevoNombre, nuevaDescripcion, nuevaMarca, nuevoPrecio, nuevoStock);

                // Luego, actualiza tu DataGridView o realiza cualquier acción adicional necesaria
                btnEliminarProd_Click(idProductoAEditar - 1, e);
                this.Refresh();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            try
            {
                int idProductoAEliminar = ObtenerIdProductoSeleccionado();

                // Llamada al método de la capa de lógica para eliminar el producto
                //prodLog.EliminarProductoEnLogica(idProductoAEliminar);

                // Luego, actualiza tu DataGridView o realiza cualquier acción adicional necesaria
                this.Refresh();
                traerTodos();
                this.Refresh();

                textBoxNombreProd.Select();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Metodos
        private void guardarProducto()
        {
            //logica_prod.Nombre_Prod = textBoxNombreProd.Text;
            //logica_prod.Descripcion_prod = textBoxDescProd.Text;
            //logica_prod.Marca_prod = textBoxMarca.Text;
            //logica_prod.Precio_prod = textBoxPrecio.Text;
            //logica_prod.Stock_prod = textBoxStock.Text;
            //logica_prod.Guardar();
        }

        private void traerTodos(string datos = null)
        {
            dGVProd.DataSource = null;
            //dGVProd.DataSource = logica_prod.LN_TraerTodos(datos);
        }
        #endregion



        private int ObtenerIdProductoSeleccionado()
        {
            if (dGVProd.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dGVProd.SelectedRows[0];

                // Accede a la celda que contiene el ID 
                DataGridViewCell cellId = selectedRow.Cells["Id"];

                // Convierte el valor de la celda a entero
                if (cellId.Value != null && int.TryParse(cellId.Value.ToString(), out int idProducto))
                {
                    return idProducto;
                }
            }
            // Lanza una excepción si no se selecciona ninguna fila
            throw new InvalidOperationException("No se ha seleccionado ningún producto.");
        }


        private int ObtenerValoresProductoFila()
        {
            if (dGVProd.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGVProd.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                int idProducto = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nombreProducto = Convert.ToString(selectedRow.Cells["nombre"].Value);
                string descripcionProducto = Convert.ToString(selectedRow.Cells["descripcion"].Value);
                string marcaProducto = Convert.ToString(selectedRow.Cells["marca"].Value);
                double precioProducto = Convert.ToDouble(selectedRow.Cells["precio"].Value);
                int stockProducto = Convert.ToInt32(selectedRow.Cells["stock"].Value);

                // Llenar los TextBox con los valores obtenidos
                textBoxNombreProd.Text = nombreProducto;
                textBoxDescProd.Text = descripcionProducto;
                textBoxMarca.Text = marcaProducto;
                textBoxPrecio.Text = precioProducto.ToString();
                textBoxStock.Text = stockProducto.ToString();
                
                return idProducto;
            }
            else
            {
                throw new InvalidOperationException("Selecciona una fila antes de editar.");
            }
        }


    }
}
