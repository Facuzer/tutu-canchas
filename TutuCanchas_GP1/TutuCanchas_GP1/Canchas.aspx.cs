using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutuCanchas_GP1
{
    public partial class Canchas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Busqueda"] == null) Response.Redirect("Buscador.aspx");
            else
            {
                gvCanchas.AutoGenerateColumns = false;
                gvCanchas.DataSource = Session["Busqueda"];
                gvCanchas.DataBind();
            }
        }

        protected void gvCanchas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gvCanchas_Rowcommand(object sender, EventArgs e)
        {

        }

        protected void gvCanchas_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument);

            int IdCanchaHorario = Convert.ToInt32(gvCanchas.Rows[fila].Cells[0].Text);
        }
    }
}