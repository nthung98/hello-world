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
    public class BUS_SP
    {
        SQL_SP sql = new SQL_SP();

        public void ThemDuLieu(E_SP et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_SP et)
        {
            sql.SuaDuLieu(et);
        }
        public void XoaDuLieu(E_SP et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
