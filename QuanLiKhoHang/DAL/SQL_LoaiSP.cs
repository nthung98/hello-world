using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
namespace DAL
{
   public class SQL_LoaiSP
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaLoaiSP)
        {
            return int.Parse(cn.GetValue("select count(*) from LoaiSP where MaLoaiSP = '" + MaLoaiSP));
        }
        public void ThemDuLieu(E_LoaiSP et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO LoaiSP (MaLoaiSP,TenLoaiSP,DVT,GhiChu,MaKho) " +
                "VALUES        (N'" + et.MaLoaiSP + "',N'" + et.TenLoaiSP + "',N'" + et.DVT + "',N'" + et.GhiChu + "')");
        }

        public void SuaDuLieu(E_LoaiSP et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE LoaiSP (MaLoaiSP, TenLoaiSP, DVT, GhiChu,MaKho, MaLoaiLoaiSP,  SoLuong) " +
                "VALUES        (N'" + et.MaLoaiSP + "',N'" + et.TenLoaiSP + "',N'" + et.DVT + "',N'" + et.GhiChu + "',N'" + et.MaKho +  "')");
        }

        public void XoaDuLieu(E_LoaiSP et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from LoaiSP Where MaLoaiSP = N'" + et.MaLoaiSP + "')");
        }
        //Ham lay du lieu
        //Taobang("where MaLoaiSP = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from LoaiSP" + DieuKien);
        }

        public DataTable LayTTLoaiSP(string DieuKien)
        {
            return cn.GetDataTable("Select MaLoaiSP,TenLoaiSP,DVT,GhiChu,MaKho from LoaiSP" + DieuKien);


        }
    }
}

  