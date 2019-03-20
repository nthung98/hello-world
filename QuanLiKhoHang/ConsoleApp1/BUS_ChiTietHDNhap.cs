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
   public class BUS_ChiTietHDNhap
    {
        SQL_ChiTietHDNhap sql = new SQL_ChiTietHDNhap();

        public void ThemDuLieu(E_ChiTietHDNhap et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_ChiTietHDNhap et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_ChiTietHDNhap et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
