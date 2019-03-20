using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class SQL_SP
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaSP)
        {
            return int.Parse(cn.GetValue("select count(*) from SP where MaSP = '" + MaSP));
        }
        public void ThemDuLieu(E_SP et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO SP (MaSP,TenSP,HinhDang,Color,Price,MaLoaiSP,SoLuong) " +
                "VALUES        (N'" + et.MaSP + "',N'" + et.TenSP + "',N'" + et.HinhDang + "',N'" + et.Color + "',N'" + et.Price + "',N'" + et.MaLoaiSP + "',N'" + et.MaLoaiSP + "',N'" + et.SoLuong +  "')");
        }

        public void SuaDuLieu(E_SP et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE SP (MaSP, TenSP, HinhDang, Color,Price, MaLoaiSP,  SoLuong) " +
                "VALUES        (N'" + et.MaSP + "',N'" + et.TenSP + "',N'" + et.HinhDang + "',N'" + et.Color + "',N'" + et.Price + "',N'" + et.MaLoaiSP  + "',N'" + et.SoLuong +   "')");
        }

        public void XoaDuLieu(E_SP et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from SP Where MaSP = N'" + et.MaSP + "')");
        }
        //Ham lay du lieu
        //Taobang("where MaSP = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from SP" + DieuKien);
        }

        public DataTable LayTTSP(string DieuKien)
        {
            return cn.GetDataTable("Select MaSP,TenSP,HinhDang,Color,Price,MaLoaiSP,SoLuong from SP" + DieuKien);


        }
    }
}
