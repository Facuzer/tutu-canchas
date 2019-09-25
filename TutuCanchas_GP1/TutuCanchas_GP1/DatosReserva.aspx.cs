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
        protected void Page_Load(object sender, EventArgs e)
        {
            TutuCanchas.DTO.ReservasDTO reservas = (TutuCanchas.DTO.ReservasDTO)Session["DatosReserva"];
            lblFecha.Text = reservas.FechaHora.Date.ToString("dd/MM/yyyy");
            lblPrecio.Text = reservas.Precio.ToString();
        }
        
        protected global::System.Web.UI.WebControls.Label Label1;

       
        protected global::System.Web.UI.WebControls.Label lblFecha;

        
        protected global::System.Web.UI.WebControls.Label Label2;

        
        protected global::System.Web.UI.WebControls.Label lblHorario;

        
        protected global::System.Web.UI.WebControls.Label Label3;

       
        protected global::System.Web.UI.WebControls.Label lblDir;

      
        protected global::System.Web.UI.WebControls.Label Label4;

        protected global::System.Web.UI.WebControls.Label lblTipo;

        
        protected global::System.Web.UI.WebControls.Label Label5;

        
        protected global::System.Web.UI.WebControls.Label lblPrecio;

        protected global::System.Web.UI.WebControls.Button btnConfirm;

     
        protected global::System.Web.UI.WebControls.Button btnBack;
    }
}
