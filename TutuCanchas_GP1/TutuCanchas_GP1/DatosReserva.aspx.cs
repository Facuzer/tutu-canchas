﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutuCanchas_GP1
{
    public partial class DatosReserva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["DatosReserva"] == null) Response.Redirect("buscador.aspx");
            else
            {
                TutuCanchas.DTO.ReservasDTO reserva = Session["DatosReserva"];
            }
        }
    }
}