using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutuCanchas_GP1
{
    public partial class Reserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TutuCanchas.DTO.ReservasDTO reserva = (TutuCanchas.DTO.ReservasDTO)Session["DatosReserva"];
        }
    }
}