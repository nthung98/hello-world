using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
  public  class SQL_KhachHang
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaKH)
        {
            return int.Parse(cn.GetValue("select count(*) from KhachHang where MaKH = '" + MaKH));
        }
        public void ThemDuLieu(E_KhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO KhachHang (MaKH,TenKH,ADDRESS,SDT,CCCD) " +
                "VALUES        (N'" + et.MaKH + "',N'" + et.TenKH + "',N'" + et.ADDRESS + "',N'" + et.SDT + "',N'" + et.CCCD  + "')");
        }

        public void SuaDuLieu(E_KhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE KhachHang (MaKH, TenKH, ADDRESS, SDT,CCCD, MaLoaiKhachHang,  SoLuong) " +
                "VALUES        (N'" + et.MaKH + "',N'" + et.TenKH + "',N'" + et.ADDRESS + "',N'" + et.SDT + "',N'" + et.CCCD + "')");
        }

        public void XoaDuLieu(E_KhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from KhachHang Where MaKH = N'" + et.MaKH + "')");
        }
        //Ham lay du lieu
        //Taobang("where MaKH = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from KhachHang" + DieuKien);
        }

        public DataTable LayTTKhachHang(string DieuKien)
        {
            return cn.GetDataTable("Select MaKH,TenKH,ADDRESS,SDT,CCCD from KhachHang" + DieuKien);


        }
    }
}
