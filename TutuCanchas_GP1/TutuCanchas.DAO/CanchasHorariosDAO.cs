using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;
using System.Data;
using System.Data.SqlClient;

namespace TutuCanchas.DAO
{
    public static class CanchasHorariosDAO
    {
        internal static List<CanchasHorariosDTO> ReadAll(string where)
        {
            List<CanchasHorariosDTO> canchas = new List<CanchasHorariosDTO>();
            DataTable dt = new DataTable();

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM CanchasHorarios" + where,
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }
            foreach(DataRow dr in dt.Rows)
            {
                var canchaHorario = new CanchasHorariosDTO();
                canchaHorario.Id = Convert.ToInt32(dr["Id"]);
                canchaHorario.IdCancha = Convert.ToInt32(dr["IdCancha"]);
                canchaHorario.HoraDesde = Convert.ToInt32(dr["HoraDesde"]);
                canchaHorario.HoraHasta = Convert.ToInt32(dr["HoraHasta"]);
                canchaHorario.Dia = Convert.ToDateTime(dr["Dia"]);
                canchaHorario.Precio = Convert.ToInt32(dr["Precio"]);
                canchas.Add(canchaHorario);
            }



            return canchas;
        }

        public static List<CanchasHorariosDTO> GetHorariosByPrecioFijo(int precio)
        {
            return ReadAll("WHERE Precio=" + precio);
        }

        public static List<CanchasHorariosDTO> GetHorariosByPrecio(int precioDesde, int precioHasta)
        {
            return ReadAll("WHERE Precio >= "+ precioDesde +" and Precio <= " + precioHasta);
        }

        public static List<CanchasHorariosDTO> GetHorariosByHora(int Horainicio)
        {
            return ReadAll("WHERE HoraDesde=" + Horainicio);
        }

    }


}
