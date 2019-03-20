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
    public class BUS_HDNhap
    {
        SQL_HDNhap sql = new SQL_HDNhap();

        public void ThemDuLieu(E_HDNhap et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_HDNhap et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_HDNhap et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable LayTTHD(string DieuKien)
        {
            return sql.LayTTHDNhap(DieuKien);
        }
    }
}
