using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity;
using System.Data;
using DAL;

namespace BUS
{
   public class BUS_HDXuat
    {
        SQL_HDXuat sql = new SQL_HDXuat();

        public void ThemDuLieu(E_HDXuat et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_HDXuat et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_HDXuat et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
