using CapaDatos.Servicios;
using System.Windows.Forms;

namespace CapaServicios
{
    public class cls_LlenarCombos
    {
        private cls_LlenarCombosQ llenar = new cls_LlenarCombosQ();

        public cls_LlenarCombos(ComboBox CMB, string NombreTabla, string CampoID, string CampoDescrip, string Condicion = "")
        {
            llenar.Tabla = NombreTabla;
            llenar.CampoId = CampoID;
            llenar.CampoDescrip = CampoDescrip;
            llenar.Condicion = Condicion;

            CMB.DataSource = llenar.CargarCMB();
            CMB.DisplayMember = CampoDescrip;
            CMB.ValueMember = CampoID;
            CMB.SelectedIndex = -1;
        }
    }
}