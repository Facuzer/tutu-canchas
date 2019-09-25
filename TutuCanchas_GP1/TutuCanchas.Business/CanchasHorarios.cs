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

        public static string GetDireccionById(int id)
        {
            return DAO.CanchasHorariosDAO.GetHorariosById(id).Direccion;
        }

        public static string GetTipoCanchaById(int id)
        {
            return DAO.CanchasHorariosDAO.GetHorariosById(id).CanchaTipo;
        }

        public static List<string> GetHorariosById(int id)
        {
            List<string> horarios = new List<string>();
            var canchahorarios = DAO.CanchasHorariosDAO.GetHorariosById(id);
            string horadesde = canchahorarios.displayHoraDesde, horahasta = canchahorarios.displayHoraHasta;
            horarios.Add(horadesde);
            horarios.Add(horahasta);
            return horarios;
        }
    }
}
