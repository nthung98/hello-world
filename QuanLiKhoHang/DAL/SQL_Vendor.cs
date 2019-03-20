using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
namespace DAL
{
   public class SQL_Vendor
    {
        KetNoiDB cn = new KetNoiDB();
        public int KiemTra(String MaNCC)
        {
            return int.Parse(cn.GetValue("select count(*) from Vendor where MaNCC = '" + MaNCC));
        }
        public void ThemDuLieu(E_Vendor et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO Vendor (MaNCC,TenNCC,ADDRESS,SDT) " +
                "VALUES        (N'" + et.MaNCC + "',N'" + et.TenNCC + "',N'" + et.ADDRESS + "',N'" + et.SDT + "')");
        }

        public void SuaDuLieu(E_Vendor et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE Vendor (MaNCC, TenNCC, ADDRESS, SDT,Price, MaLoaiVendor,  SoLuong) " +
                "VALUES        (N'" + et.MaNCC + "',N'" + et.TenNCC + "',N'" + et.ADDRESS + "',N'" + et.SDT + "')");
        }

        public void XoaDuLieu(E_Vendor et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from Vendor Where MaNCC = N'" + et.MaNCC + "')");
        }
        //Ham lay du lieu
        //Taobang("where MaNCC = '1'")
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from Vendor" + DieuKien);
        }

        public DataTable LayTTVendor(string DieuKien)
        {
            return cn.GetDataTable("Select MaNCC,TenNCC,ADDRESS,SDT from Vendor" + DieuKien);


        }
    }
}
