using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class E_ChiTietHDXuat
    {

        private string _MaHDX;
        private string _MaSP;
        private string _SoLuong;
        private string _DonGiaX;

        public string MaHDX { get => _MaHDX; set => _MaHDX = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string DonGiaX { get => _DonGiaX; set => _DonGiaX = value; }
    }
}
