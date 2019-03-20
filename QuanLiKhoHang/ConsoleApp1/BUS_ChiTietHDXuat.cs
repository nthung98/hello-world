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
  public  class BUS_ChiTietHDXuat
    {
        SQL_ChiTietHDXuat sql = new SQL_ChiTietHDXuat();

        public void ThemDuLieu(E_ChiTietHDXuat et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_ChiTietHDXuat et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_ChiTietHDXuat et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
