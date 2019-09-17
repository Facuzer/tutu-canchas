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

            System.Data.DataTable dt = new System.Data.DataTable("dt");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Direccion");
            dt.Columns.Add("Cancha");
            dt.Columns.Add("Horario");
            dt.Columns.Add("Precio", typeof(decimal));

            dt.Rows.Add("Club San Telmo", "Calle 234", "Futbol 5", "19:00", 1200);
            dt.Rows.Add("Club San Telmo", "Calle 234", "Futbol 5", "19:00", 1200);
            dt.Rows.Add("Club San Telmo", "Calle 234", "Futbol 5", "19:00", 1200);
            dt.Rows.Add("Club San Telmo", "Calle 234", "Futbol 5", "19:00", 1200);
            dt.Rows.Add("Club San Telmo", "Calle 234", "Futbol 5", "19:00", 1200);
            
            gvCanchas.DataSource = dt;
            gvCanchas.DataBind();
        }

        protected void gvCanchas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}