using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;

namespace TutuCanchas.DAO
{
    public static class UsuariosDAO
    {
        public static List<UsuariosDTO> ReadAll(string where)
        {
            DataTable dt = new DataTable();

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Usuarios " + where,
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            UsuariosDTO dto;
            List<UsuariosDTO> lista = new List<UsuariosDTO>();

            //Itero entre los registros para armar la Lista de DTO.
            foreach (DataRow dr in dt.Rows)
            {
                dto = new UsuariosDTO();

                if (!dr.IsNull("Id")) dto.Id = (int)dr["Id"];
                if (!dr.IsNull("Nombre")) dto.Nombre = (string)dr["Nombre"];
                if (!dr.IsNull("Contraseña")) dto.Contraseña = (string)dr["Contraseña"];
                if (!dr.IsNull("Perfil")) dto.Perfil = (string)dr["Perfil"];
                if (!dr.IsNull("Email")) dto.Email = (string)dr["Email"];
                if (!dr.IsNull("Telefono")) dto.Telefono = (string)dr["Telefono"];

                lista.Add(dto);
            }

            return lista;
        }

        public static void Alta(UsuariosDTO user)
        {
            string cmdText = "INSERT INTO (Id, Nombre, Contraseña, Perfil, Email, Telefono) " +
                             "VALUES([Id], '[Nombre]', '[Contraseña]', '[Perfil]', '[Email]', '[Telefono]')";
            cmdText.Replace("[Id]", DAOHelper.GetNextId("Usuarios").ToString());
            cmdText.Replace("[Nombre]", user.Nombre);
            cmdText.Replace("[Contraseña]", user.Contraseña);
            cmdText.Replace("[Prefil]", user.Perfil);
            cmdText.Replace("[Email]", user.Email);
            cmdText.Replace("[Telefono]", user.Telefono);

            DAOHelper.EjecutarComando(cmdText);
        }
    }
}
