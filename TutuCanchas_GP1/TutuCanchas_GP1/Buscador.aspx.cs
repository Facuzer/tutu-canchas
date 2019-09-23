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
                // Lleno el horario
                ddHorario.Items.Clear();
                ddHorario.DataSource = TutuCanchas.Business.CanchasHorarios.GetAllHorariosDesde();
                ddHorario.DataTextField = "Display";
                ddHorario.DataValueField = "Value";
                ddHorario.DataBind();
                // Lleno el tipo canchas
                ddTipoCancha.Items.Clear();
                ddTipoCancha.DataSource = TutuCanchas.Business.TipoCanchas.GetAllTipoCanchas();
                ddTipoCancha.DataTextField = "Value";
                ddTipoCancha.DataValueField = "Key";
                ddTipoCancha.DataBind();
                // Lleno las zonas
                ddZonas.Items.Clear();
                ddZonas.DataSource = TutuCanchas.Business.ClubesZonas.GetAllZonas();
                ddZonas.DataTextField = "Value";
                ddZonas.DataValueField = "Key";
                ddZonas.DataBind();
            }
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {

            // Response.Write("<script LANGUAGE='JavaScript' >alert('" + Calendar1.SelectedDate.Date.ToString("dd/MM/yyyy") +"')</script>");
            // Session.Add("Busqueda", );
            Response.Redirect("Canchas.aspx");
        }
    }
}