using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class SQL_ChiTietHDXuat
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaHDX)
        {
            return int.Parse(cn.GetValue("select count(*) from ChiTietHDXuat where MaHDX = '" + MaHDX));
        }
        public void ThemDuLieu(E_ChiTietHDXuat et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO ChiTietHDXuat  (MaHDX, MaSP, SoLuong, DonGiaX) " +
                "VALUES        (N'" + et.MaHDX + "',N'" + et.MaSP + "',N'" + et.SoLuong + "',N'" + et.DonGiaX + "',N'" + "')");
        }

        public void SuaDuLieu(E_ChiTietHDXuat et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE ChiTietHDXuat  (MaHDX, MaSP, SoLuong, DonGiaX) " +
                "VALUES        (N'" + et.MaHDX + "',N'" + et.MaSP + "',N'" + et.SoLuong + "',N'" + et.DonGiaX + "')");
        }

        public void XoaDuLieu(E_ChiTietHDXuat et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from ChiTietHDXuat Where MaHDX = N'" + et.MaHDX + "'");
        }
        //Ham lay du lieu
        //Taobang("where MaHDX = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from ChiTietHDXuat" + DieuKien);
        }

        public DataTable LayTTCTHDN(string DieuKien)
        {
            return cn.GetDataTable("Select MaHDX,MaSP,DonGiaX,SoLuong from ChiTietHDXuat" + DieuKien);


        }
    }
}
