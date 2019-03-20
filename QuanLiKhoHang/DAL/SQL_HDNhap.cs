using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class SQL_HDNhap
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaHDN)
        {
            return int.Parse(cn.GetValue("select count(*) from HDNhap where MaHDN = '" + MaHDN));
        }
        public void ThemDuLieu(E_HDNhap et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO HDNhap (MaHDN,NgayNhap,TongTienNhap,MaNCC,MaNV) " +
                "VALUES        (N'" + et.MaHDN + "',N'" + et.NgayNhap + "',N'" + et.TongTienNhap + "',N'" + et.MaNCC + "',N'" + et.MaNV + "')");
        }

        public void SuaDuLieu(E_HDNhap et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE HDNhap (MaHDN, NgayNhap, TongTienNhap, MaNCC,MaNV, MaLoaiHDNhap,  SoLuong) " +
                "VALUES        (N'" + et.MaHDN + "',N'" + et.NgayNhap + "',N'" + et.TongTienNhap + "',N'" + et.MaNCC + "')");
        }

        public void XoaDuLieu(E_HDNhap et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from HDNhap Where MaHDN = N'" + et.MaHDN + "')");
        }
        //Ham lay du lieu
        //Taobang("where MaHDN = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from HDNhap" + DieuKien);
        }

        public DataTable LayTTHDNhap(string DieuKien)
        {
            return cn.GetDataTable("select hdn.MaHDN,NgayNhap,TongTienNhap,vd.MaNCC,TenNCC,nv.MaNV,sp.MaSP,TenSP,SP.SoLuong,DonGiaN from HDNhap hdn , ChiTietHDNhap ct, Vendor vd, Sp, NhanVien nv where sp.MaSP = ct.MaSP and ct.MaHDN = hdn.MaHDN and hdn.MaNCC = vd.MaNCC and nv.MaNV = hdn.MaNV" + DieuKien);


        }
        //public DataTable LayTTNV(string DieuKien)
        //{
        //    return cn.GetDataTable("select MaNV ,TenNV from NhanVien " + DieuKien);
        //}
        //public DataTable LayTTNCC(string DieuKien)
        //{
        //    return cn.GetDataTable("select MaNCC,Te    }
    }

}