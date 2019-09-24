using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.DTO
{
    public class CanchasHorariosDTO
    {
        public int Id { get; set; }
        public int IdCancha { get; set; }
        public int HoraDesde { get; set; }
        public int HoraHasta { get; set; }
        public DateTime Dia{ get; set; }
        public int Precio { get; set; }
        public int IdCanchasTipos { get; set; }
        public int IdClubesZonas { get; set; }
        // hice esto por si el chabon elije un rango de precios, pero sé que no está en la BDD
        public int PrecioDesde { get; set; }
        public int PrecioHasta { get; set; }
        // Esto de aca es para mostrar al usuario
        public string NombreCancha { get; set; }
        public string NombreClub { get; set; }
        public string Direccion { get; set; }
        public string Zona { get; set; }
        public string CanchaTipo { get; set; }
        public string displayHoraDesde { get; set; }

        public string displayHoraHasta { get; set; }
    }
}
