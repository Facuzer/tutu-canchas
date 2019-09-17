using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutuCanchas_GP1
{
    public partial class Buscador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si la sesion no esta iniciada, volvemos al Login.
            if (Session["usuario"] == null)
                Response.Redirect("Login.aspx");


            //Inicializo los controles.
            if (!Page.IsPostBack)
            {
                ddHorario.Items.Clear();
                for (int i = 10; i < 20; i++)
                {
                    ddHorario.Items.Add("Horario: " + i.ToString());
                }

                ddTipoCancha.Items.Add("Futbol 5 - Sintetico");
                ddTipoCancha.Items.Add("Futbol 5 - Cemento");
                ddTipoCancha.Items.Add("Futbol 11 - Pasto");

                ddZonas.Items.Clear();
                ddZonas.Items.Add("Zona 1");
                ddZonas.Items.Add("Zona 2");
            }
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Canchas.aspx");
        }
    }
}