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
  public  class BUS_KhachHang
    {
        SQL_KhachHang sql = new SQL_KhachHang();

        public void ThemDuLieu(E_KhachHang et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_KhachHang et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_KhachHang et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}

