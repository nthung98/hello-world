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
    public class BUS_LoaiSP
    {
        SQL_LoaiSP sql = new SQL_LoaiSP();

        public void ThemDuLieu(E_LoaiSP et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_LoaiSP et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_LoaiSP et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
