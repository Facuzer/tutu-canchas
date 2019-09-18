using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;

namespace TutuCanchas.Business
{
    public static class Usuarios
    {
        public static UsuariosDTO IniciarSesion(string usuario, string contraseña)
        {
            var usuarios = DAO.UsuariosDAO.ReadAll(
                "WHERE Nombre='[usuario]' AND Contraseña='[contraseña]'"
                .Replace("[usuario]", usuario)
                .Replace("[contraseña]", contraseña));

            if (usuarios.Count > 0)
                return usuarios[0];

            return null;
        }
        /// <summary>
        /// Función que da de alta un usuario
        /// </summary>
        /// <param name="user">Un dto de usuario lleno</param>
        /// <returns>Devuelve true si se pudo hacer y false si hubo errores de validación.</returns>
        public static bool RegistrarUsuario(UsuariosDTO user)
        {
            // Validaciones
            if (user.Nombre.Length > 50) return false;
            if (user.Contraseña.Length > 50) return false;
            if (user.Email.Length > 50) return false;
            if (user.Perfil.Length > 50) return false;
            if (user.Telefono.Length > 50) return false;
            // Todo ok
            try
            {
                DAO.UsuariosDAO.Alta(user);
                return true;
            }
            catch
            {
                // Hubo error
                return false;
            }
        }
    }
}
