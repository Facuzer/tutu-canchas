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
                "select CanchasHorarios.Id, CanchasHorarios.IdCancha, CanchasHorarios.HoraDesde, CanchasHorarios.HoraHasta, CanchasHorarios.Dia, CanchasHorarios.Precio, Canchas.IdCanchasTipos, Clubes.IdClubesZonas, Canchas.Nombre AS CanchaNombre, Clubes.Nombre AS ClubNombre, Clubes.Direccion AS ClubDireccion, Clubes.Zona AS ClubZona, CanchasTipos.Nombre AS TipoCancha  from CanchasHorarios inner join Canchas ON CanchasHorarios.Id = Canchas.Id inner join CanchasTipos ON Canchas.IdCanchasTipos = CanchasTipos.Id inner join Clubes ON Canchas.IdClub = Clubes.Id " + where,
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
                canchaHorario.IdCanchasTipos = Convert.ToInt32(dr["IdCanchasTipos"]);
                canchaHorario.IdClubesZonas = Convert.ToInt32(dr["IdClubesZonas"]);
                // Todo lo visible 
                canchaHorario.NombreCancha = Convert.ToString(dr["CanchaNombre"]);
                canchaHorario.NombreClub = Convert.ToString(dr["ClubNombre"]);
                canchaHorario.Direccion = Convert.ToString(dr["ClubDireccion"]);
                canchaHorario.Zona = Convert.ToString(dr["ClubZona"]);
                canchaHorario.CanchaTipo = Convert.ToString(dr["TipoCancha"]);
                string displayHoraDesde;
                if (canchaHorario.HoraDesde.ToString().Length == 3) displayHoraDesde = "0" + canchaHorario.HoraDesde.ToString().Substring(0, 1) + ":" + canchaHorario.HoraDesde.ToString().Substring(1, 2);
                else displayHoraDesde = canchaHorario.HoraDesde.ToString().Substring(0, 2) + ":" + canchaHorario.HoraDesde.ToString().Substring(2, 2);
                canchaHorario.displayHoraDesde = displayHoraDesde;
                string displayHoraHasta;
                if (canchaHorario.HoraHasta.ToString().Length == 3) displayHoraHasta = "0" + canchaHorario.HoraHasta.ToString().Substring(0, 1) + ":" + canchaHorario.HoraHasta.ToString().Substring(1, 2);
                else displayHoraHasta = canchaHorario.HoraHasta.ToString().Substring(0, 2) + ":" + canchaHorario.HoraHasta.ToString().Substring(2, 2);
                canchaHorario.displayHoraHasta = displayHoraHasta;
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

        public static List<Horarios> GetAllHorariosDesde()
        {
            var horarios = new List<Horarios>();
            var canchas = ReadAll("");

            horarios.Add(new Horarios
            {
                Value = 0,
                Display = ""
            });
            foreach(CanchasHorariosDTO item in canchas)
            {
                string vistahora = "";
                if (item.HoraDesde.ToString().Length == 3)
                {
                    vistahora = "0" + item.HoraDesde.ToString();
                }
                else if (item.HoraDesde.ToString().Length == 4)
                {
                    vistahora = item.HoraDesde.ToString();
                }
                if (item.HoraHasta.ToString().Length == 3)
                {
                    vistahora += "0" + item.HoraHasta.ToString();
                }
                else if (item.HoraHasta.ToString().Length == 4)
                {
                    vistahora += item.HoraHasta.ToString();
                }
                vistahora = vistahora.Substring(0, 2) + ":" + vistahora.Substring(2,2) + "hs. - " + vistahora.Substring(4, 2) + ":" + vistahora.Substring(4, 2) + "hs.";
                horarios.Add(new Horarios
                {
                    Value = item.HoraDesde,
                    Display = vistahora
                });
            }
            return horarios;
        }

        public static List<CanchasHorariosDTO> Filtrar(CanchasHorariosDTO busqueda)
        {
            var result = new List<CanchasHorariosDTO>();
            bool first = true;
            string where = "WHERE ";
            // Horarios
            if (busqueda.HoraDesde != 0)
            {
                where += "Horadesde=" + busqueda.HoraDesde;
                first = false;
            }
            // Tipo de cancha
            if (busqueda.IdCanchasTipos != 0)
            {
                if (!first) where = where + " AND ";
                where += "IdCanchasTipos=" +busqueda.IdCanchasTipos;
                first = false;
            }
            // Precio
            // Desde
            if (busqueda.PrecioDesde != 0)
            {
                if (!first) where = where + " AND ";
                where += "Precio>=" + busqueda.PrecioDesde;
                first = false;
            }
            
            // Hasta
            if (busqueda.PrecioHasta != 0)
            {
                if (!first) where = where + " AND ";
                where += "Precio<=" + busqueda.PrecioHasta;
                first = false;
            }
            // Zonas
            
            if (busqueda.IdClubesZonas != 0)
            {
                if (!first) where = where + " AND ";
                where += "IdClubesZonas=" + busqueda.IdClubesZonas;
                first = false;
            }
            // Fecha
            
            if (busqueda.Dia.Date.ToString("dd/MM/yyyy") != "01/01/0001")
            {
                if (!first) where = where + " AND ";
                where += "Dia=" + busqueda.Dia.Date.ToString("dd/MM/yyyy");
                first = false;
            }
            if (first) where = "";
            result = ReadAll(where);
            return result;
        }

    }


}
