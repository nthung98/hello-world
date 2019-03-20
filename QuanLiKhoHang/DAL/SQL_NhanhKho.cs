using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
   public class SQL_NhanhKho
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String Makho)
        {
            return int.Parse(cn.GetValue("select count(*) from NhanhKho where Makho = '" + Makho));
        }
        public void ThemDuLieu(E_NhanhKho et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO NhanhKho (Makho,TenKho,DiaChi,SDT) " +
                "VALUES        (N'" + et.Makho + "',N'" + et.TenKho + "',N'" + et.DiaChi + "',N'" + et.SDT +  "')");
        }

        public void SuaDuLieu(E_NhanhKho et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE NhanhKho (Makho, TenKho, DiaChi, SDT,Price, MaLoaiNhanhKho,  SoLuong) " +
                "VALUES        (N'" + et.Makho + "',N'" + et.TenKho + "',N'" + et.DiaChi + "',N'" + et.SDT + "')");
        }

        public void XoaDuLieu(E_NhanhKho et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from NhanhKho Where Makho = N'" + et.Makho + "')");
        }
        //Ham lay du lieu
        //Taobang("where Makho = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from NhanhKho" + DieuKien);
        }

        public DataTable LayTTNhanhKho(string DieuKien)
        {
            return cn.GetDataTable("Select Makho,TenKho,DiaChi,SDT from NhanhKho" + DieuKien);


        }
    }
}
