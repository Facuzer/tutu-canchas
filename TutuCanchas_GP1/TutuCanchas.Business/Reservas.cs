using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.Business
{
    public static class Reservas
    {
        public static List<DTO.ReservasDTO> GetAllReservas(int idUsuario)
        {
            return DAO.ReservasDAO.GetAllReservas(idUsuario);
        }
    }
}
