using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class SQL_NhanVien
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaNV)
        {
            return int.Parse(cn.GetValue("select count(*) from NhanVien where MaNV = '" + MaNV));
        }
        public void ThemDuLieu(E_NhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO NhanVien  (MaNV, TenNV, Sex, NgaySinh, ADDRESS, SDT, ChucVu, Email, NgayLam, MaKho, Luong, Tongtien) " +
                "VALUES        (N'" + et.MaNV + "',N'" + et.TenNV + "',N'" + et.Sex + "',N'" + et.NgaySinh + "',N'" + et.ADDRESS + "',N'" + et.SDT + "',N'" + et.SDT + "',N'" + et.ChucVu + "',N'" + et.Email + "',N'" + et.NgayLam + "',N'" + et.MaKho + "',N'" + et.Luong + "',N'" + et.Tongtien + "')");
        }

        public void SuaDuLieu(E_NhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE NhanVien  (MaNV, TenNV, Sex, NgaySinh, ADDRESS, SDT, ChucVu, Email, NgayLam, MaKho, Luong, Tongtien) " +
                "VALUES        (N'" + et.MaNV + "',N'" + et.TenNV + "',N'" + et.Sex + "',N'" + et.NgaySinh + "',N'" + et.ADDRESS + "',N'" + et.SDT + "',N'" + et.SDT + "',N'" + et.ChucVu + "',N'" + et.Email + "',N'" + et.NgayLam + "',N'" + et.MaKho + "',N'" + et.Luong + "',N'" + et.Tongtien + "')");
        }

        public void XoaDuLieu(E_NhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from NhanVien Where MaNV = N'" + et.MaNV + "')");
        }
        //Ham lay du lieu
        //Taobang("where ManV = '1'")
        public DataTable TaoBang(string DieuKien)
        { 
            return cn.GetDataTable("Select * from NhanVien" + DieuKien);
        }

        public DataTable LayTTNV(string DieuKien)
        {
            return cn.GetDataTable("Select MaNV,TenNV,NgaySinh,ADDRESS,SDT from NhanVien" + DieuKien);


        }
    }
}
