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
   public class BUS_NhanVien
    {
        SQL_NhanVien sql = new SQL_NhanVien();

        public void ThemDuLieu(E_NhanVien et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_NhanVien et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_NhanVien et)
        {
            sql.XoaDuLieu(et);
        }
        public  DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
            }
}
