using System;
using CapaDatos.Query_Login;
using CapaSesion;

namespace CapaLogicaNegocio.Logica_Login
{
    public class cls_LogicaLogin
    {
        public bool LoginUser(string user, string pass)
        {
            try
            {
                cls_ConectarUser conexionUsuario = new cls_ConectarUser();
                cls_Permisos permisos = new cls_Permisos();

                if (conexionUsuario.ValidarUsuario(user, pass))
                {
                    permisos.ObtenerPermisos(cls_UserCache.IdUsuario);
                    return conexionUsuario.CargarUsuario(user, pass);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false; // O retorna false para indicar que hubo un problema en el proceso de login
            }
        }
    }
}
