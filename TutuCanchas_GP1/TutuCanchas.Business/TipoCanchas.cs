using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DAO;

namespace TutuCanchas.Business
{
    public static class TipoCanchas
    {
        public static Dictionary<Int32, String> GetAllTipoCanchas()
        {
            return DAO.TipoCanchasDAO.GetAllTipoCanchas();
        }
    }
}
