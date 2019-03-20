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
  public  class BUS_NhanhKho
    {
        SQL_NhanhKho sql = new SQL_NhanhKho();

        public void ThemDuLieu(E_NhanhKho et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_NhanhKho et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_NhanhKho et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
