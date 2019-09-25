using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutuCanchas_GP1
{
    public partial class DatosReserva : System.Web.UI.Page
    {
        TutuCanchas.DTO.ReservasDTO reservas = new TutuCanchas.DTO.ReservasDTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            reservas = (TutuCanchas.DTO.ReservasDTO)Session["DatosReserva"];
            lblFecha.Text = reservas.FechaHora.Date.ToString("dd/MM/yyyy");
            lblPrecio.Text = reservas.Precio.ToString();
            lblDir.Text = TutuCanchas.Business.CanchasHorarios.GetDireccionById(reservas.IdCanchaHorarios);
            lblTipo.Text = TutuCanchas.Business.CanchasHorarios.GetTipoCanchaById(reservas.IdCanchaHorarios);
            lblHorario.Text = TutuCanchas.Business.CanchasHorarios.GetHorariosById(reservas.IdCanchaHorarios)[0] + "-" + TutuCanchas.Business.CanchasHorarios.GetHorariosById(reservas.IdCanchaHorarios)[1];
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            TutuCanchas.Business.Reservas.AltaReservas(reservas);
            Response.Write("<script LANGUAGE='JavaScript' >alert('Cancha reservada con exito :).')</script>");
            Response.Redirect("Buscador.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}