using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
namespace DAL
{
   public class SQL_HDXuat
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaHDX)
        {
            return int.Parse(cn.GetValue("select count(*) from HDXuat where MaHDX = '" + MaHDX));
        }
        public void ThemDuLieu(E_HDXuat et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO HDXuat (MaHDX,NgayXuat,TongTienXuat,MaKH,MaNV) " +
                "VALUES        (N'" + et.MaHDX + "',N'" + et.NgayXuat + "',N'" + et.TongTienXuat + "',N'" + et.MaKH + "',N'" + et.MaNV + "')");
        }

        public void SuaDuLieu(E_HDXuat et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE HDXuat (MaHDX, NgayXuat, TongTienXuat, MaKH,MaNV, MaLoaiHDXuat,  SoLuong) " +
                "VALUES        (N'" + et.MaHDX + "',N'" + et.NgayXuat + "',N'" + et.TongTienXuat + "',N'" + et.MaKH + "')");
        }

        public void XoaDuLieu(E_HDXuat et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from HDXuat Where MaHDX = N'" + et.MaHDX + "')");
        }
        //Ham lay du lieu
        //Taobang("where MaHDX = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from HDXuat" + DieuKien);
        }

        public DataTable LayTTHDXuat(string DieuKien)
        {
            return cn.GetDataTable("Select MaHDX,NgayXuathap,TongTienXuat,MaKH,MaNV" + DieuKien);


        }
    }
}

