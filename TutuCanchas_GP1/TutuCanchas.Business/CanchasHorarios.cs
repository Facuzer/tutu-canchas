using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.Business
{
    public static class CanchasHorarios
    {
        public static List<DTO.Horarios> GetAllHorariosDesde()
        {
            return DAO.CanchasHorariosDAO.GetAllHorariosDesde();
        }

        public static List<DTO.CanchasHorariosDTO> Filtrar(DTO.CanchasHorariosDTO busqueda)
        {
            return DAO.CanchasHorariosDAO.Filtrar(busqueda);
        }

        public static DTO.CanchasHorariosDTO GetCanchaHorarioByID(int id)
        {
            return DAO.CanchasHorariosDAO.GetHorariosById(id);
        }
    }
}
