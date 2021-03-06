using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TutuCanchas.DAO
{
    public static class TipoCanchasDAO
    {
        public static Dictionary<Int32, String> GetAllTipoCanchas()
        {
            Dictionary<Int32,String> TipoCanchas = new Dictionary<Int32, string>();

            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM CanchasTipos",
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }
            TipoCanchas.Add(0, "");
            foreach (DataRow dr in dt.Rows)
            {
                TipoCanchas.Add(Convert.ToInt32(dr["Id"]), Convert.ToString(dr["Nombre"]));
            }
            return TipoCanchas;
        }
    }
}
