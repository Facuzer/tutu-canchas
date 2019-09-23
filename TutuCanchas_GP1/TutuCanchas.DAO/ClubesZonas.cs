using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TutuCanchas.DAO
{
    public static class ClubesZonas
    {
        public static Dictionary<Int32, string> GetAllZonas()
        {
            var Zonas = new Dictionary<Int32, string>();
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM ClubesZonas",
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }
            Zonas.Add(0, "");
            foreach (DataRow dr in dt.Rows)
            {
                Zonas.Add(Convert.ToInt32(dr["Id"]), Convert.ToString(dr["Nombre"]));
            }
            return Zonas;
        }
    }
}
