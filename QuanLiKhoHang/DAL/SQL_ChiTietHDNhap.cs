using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
   public class SQL_ChiTietHDNhap
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaHDN)
        {
            return int.Parse(cn.GetValue("select count(*) from ChiTietHDNhap where MaHDN = '" + MaHDN));
        }
        public void ThemDuLieu(E_ChiTietHDNhap et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO ChiTietHDNhap  (MaHDN, MaSP, SoLuong, DonGiaN, ADDRESS, SDT, ChucVu, Email, NgayLam, MaKho, Luong, Tongtien) " +
                "VALUES        (N'" + et.MaHDN + "',N'" + et.MaSP + "',N'" + et.SoLuong + "',N'" + et.DonGiaN + "',N'" +  "')");
        }

        public void SuaDuLieu(E_ChiTietHDNhap et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE ChiTietHDNhap  (MaHDN, MaSP, SoLuong, DonGiaN, ADDRESS, SDT, ChucVu, Email, NgayLam, MaKho, Luong, Tongtien) " +
                "VALUES        (N'" + et.MaHDN + "',N'" + et.MaSP + "',N'" + et.SoLuong + "',N'" + et.DonGiaN +  "')");
        }

        public void XoaDuLieu(E_ChiTietHDNhap et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from ChiTietHDNhap Where MaHDN = N'" + et.MaHDN + "'");
        }
        //Ham lay du lieu
        //Taobang("where MaHDN = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from ChiTietHDNhap" + DieuKien);
        }

        public DataTable LayTTCTHDN(string DieuKien)
        {
            return cn.GetDataTable("Select MaHDN,MaSP,DonGiaN,ADDRESS,SDT from ChiTietHDNhap" + DieuKien);


        }
    }
}
