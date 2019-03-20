using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class E_ChiTietHDNhap
    {

        private string _MaHDN;
        private string _MaSP;
        private string _SoLuong;
        private string _DonGiaN;

        public string MaHDN { get => _MaHDN; set => _MaHDN = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string DonGiaN { get => _DonGiaN; set => _DonGiaN = value; }
    }
}
