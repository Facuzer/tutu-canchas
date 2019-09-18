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
        public static string RegistrarUsuario(UsuariosDTO user)
        {
            // Validaciones
            //lenght
            if (user.Nombre.Length > 50) return "El usuario es demasiado largo(50 caracteres max)";
            if (user.Contraseña.Length > 50) return "La contraseña es demasiado largo(50 caracteres max)";
            if (user.Email.Length > 50) return "El email es demasiado largo(50 caracteres max)";
            if (user.Perfil.Length > 50) return "El perfil es demasiado largo(50 caracteres max)";
            if (user.Telefono.Length > 50) return "El telefono es demasiado largo(50 caracteres max)";
            //repeticion
            if (DAO.UsuariosDAO.UserExist(user.Nombre)) return "El nombre de usuario ya existe.";
            if (DAO.UsuariosDAO.EmailExist(user.Email)) return "El email ya esta en uso.";
            // Todo ok
            try
            {
                DAO.UsuariosDAO.Alta(user);
                return "";
            }
            catch
            {
                // Hubo error
                return "No se que paso";
            }
        }
    }
}
