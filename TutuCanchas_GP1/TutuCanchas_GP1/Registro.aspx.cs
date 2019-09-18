using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutuCanchas.Business;
using TutuCanchas.DTO;

namespace TutuCanchas_GP1
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UsuariosDTO user = new UsuariosDTO();
            user.Nombre = txtUsuario.Text;
            user.Perfil = txtPerfil.Text;
            user.Telefono = txtTelefono.Text;
            user.Email = txtEmail.Text;
            user.Contraseña = txtContraseña.Text;
            string error = Usuarios.RegistrarUsuario(user);
            if ( error == "")
            {
                // Registro correcto
                Response.Write("<script LANGUAGE='JavaScript' >alert('Registro exitoso')</script>");
            }
            else
            {
                // Registro incorrecto
                Response.Write("<script LANGUAGE='JavaScript' >alert('" + error + "')</script>");
            }
        }
    }
}