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
   public class BUS_Vendor
    {
        SQL_Vendor sql = new SQL_Vendor();

        public void ThemDuLieu(E_Vendor et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_Vendor et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_Vendor et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
