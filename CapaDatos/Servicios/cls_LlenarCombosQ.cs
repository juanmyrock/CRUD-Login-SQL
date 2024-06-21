using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Servicios
{
    public class cls_LlenarCombosQ : cls_EjecutarQ
    {
        #region ATRIBUTOS
        private string tabla;
        private string campoid;
        private string campodescrip;
        private string condicion;
        #endregion

        #region PROPERTIES
        public string Tabla
        {
            set { tabla = value; }
        }
        public string CampoId
        {
            set { campoid = value; }
        }
        public string CampoDescrip
        {
            set { campodescrip = value; }
        }
        public string Condicion
        {
            set { condicion = value; }
        }
        #endregion

        public DataTable CargarCMB()
        {
            string sSql;
            if (string.IsNullOrEmpty(condicion))
            {
                sSql = $"SELECT {campoid}, {campodescrip} FROM {tabla} ORDER BY {campodescrip}";
            }
            else
            {
                sSql = $"SELECT {campoid}, {campodescrip} FROM {tabla} WHERE {condicion} ORDER BY {campodescrip}";
            }

            return ConsultaRead(sSql);
        }
    }
}
