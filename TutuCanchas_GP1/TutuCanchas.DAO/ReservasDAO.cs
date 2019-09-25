using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.DAO
{
    public static class ReservasDAO
    {
        internal static List<DTO.ReservasDTO> ReadAll(string where)
        {
            var reservas = new List<DTO.ReservasDTO>();
            System.Data.DataTable dt = new System.Data.DataTable();
            //Leo los registros de la DB.
            using (System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(
                "SELECT * FROM Reservas " + where,
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }
            //Itero entre los registros para armar la Lista de DTO.
            foreach (System.Data.DataRow dr in dt.Rows)
            {
                var dto = new DTO.ReservasDTO();

                if (!dr.IsNull("Id")) dto.Id = (int)dr["Id"];
                if (!dr.IsNull("Estado")) dto.Estado = (string)dr["Estado"];
                if (!dr.IsNull("IdCancha")) dto.IdCancha = (int)dr["IdCancha"];
                if (!dr.IsNull("IdCanchasHorarios")) dto.IdCanchaHorarios = (int)dr["IdCanchasHorarios"];
                if (!dr.IsNull("IdUsuario")) dto.IdUsuario = (int)dr["IdUsuario"];
                if (!dr.IsNull("Precio")) dto.Precio = Convert.ToInt32(dr["Precio"]);

                reservas.Add(dto);
            }

            return reservas;
        }

        public static bool CanchaHorarioDisponible(int idCanchaHorario)
        {
            var reservas = ReadAll("WHERE IdCanchasHorarios="+idCanchaHorario + " AND Estado='Reservado'");
            if (reservas.Count != 0) return false;
            else return true;
        }

        public static List<DTO.ReservasDTO> GetAllReservas(int idUsuario)
        {
            return ReadAll("WHERE IdUsuario=" + idUsuario + " AND Estado='Reservada'");
        }

        public static void AltaReserva(DTO.ReservasDTO reserva)
        {
            reserva.IdCancha = DAO.CanchasHorariosDAO.GetHorariosById(reserva.IdCanchaHorarios).IdCancha;
            DAOHelper.EjecutarComando("INSERT INTO Reservas(Id,IdCancha,FechaHora,IdUsuario,Precio,Estado,IdCanchasHorarios) VALUES("+ DAOHelper.GetNextId("Reservas") + "," + reserva.IdCancha + ", '" + reserva.FechaHora.ToString("yyyy-MM-dd HH:mm:ss") + "'," + reserva.IdUsuario + "," +  reserva.Precio + ", '" + reserva.Estado + "', " + reserva.IdCanchaHorarios+")");
        }
    }
}
