using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Querys_Login
{
    public class cls_BloquearUserQ : cls_EjecutarQ
    {
        public void BloquearUsuario(int idUser)
        {
            string sSql = "UPDATE Usuarios SET estado = @estado WHERE id_usuario = @idUser";
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@estado", false),  // Asumiendo que "false" representa un usuario bloqueado
                new SqlParameter("@idUser", idUser)
            };

            try
            {
                ConsultaWrite(sSql, parametros);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al bloquear el usuario: " + ex.Message);
                throw;
            }
        }
    }
}
