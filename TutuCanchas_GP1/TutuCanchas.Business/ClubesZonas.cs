using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.Business
{
    public static class ClubesZonas
    {
        public static Dictionary<Int32, string> GetAllZonas()
        {
            return DAO.ClubesZonas.GetAllZonas();
        }
    }
}
